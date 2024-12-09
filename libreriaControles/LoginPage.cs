using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreriaControles
{
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        // Propiedades personalizadas para obtener los valores del usuario y contraseña
        public string Usuario
        {
            get => txtUsuario.Text;
            set => txtUsuario.Text = value;
        }

        public string Password
        {
            get => txtPassword.Text;
            set => txtPassword.Text = value;
        }
        public bool Recordarme
        {
            get => chkRecordarme.Checked;
            set => chkRecordarme.Checked = value;
        }

        // Evento personalizado para el botón de inicio de sesión
        public event EventHandler LoginClicked;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Llamar al evento personalizado
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }

        // Método para establecer mensajes
        public void SetMensaje(string mensaje, bool esError = false)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.ForeColor = esError ? System.Drawing.Color.Red : System.Drawing.Color.Green;
        }
    }
}
