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
    public partial class botonCircular : Control
    {
        private Color _hoverColor = Color.LightBlue;
        private Color _defaultColor = Color.Blue;
        private bool _isHovered = false;
        public botonCircular()
        {
            this.Size = new Size(100, 100);
            InitializeComponent();
        }


        // Propiedades para personalizar colores
        public Color HoverColor
        {
            get => _hoverColor;
            set { _hoverColor = value; Invalidate(); }
        }

        public Color DefaultColor
        {
            get => _defaultColor;
            set { _defaultColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;

            // Dibujar círculo
            using (SolidBrush brush = new SolidBrush(_isHovered ? _hoverColor : _defaultColor))
            {
                g.FillEllipse(brush, 0, 0, Width - 1, Height - 1);
            }

            // Dibujar texto
            StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(Text, Font, Brushes.White, ClientRectangle, sf);
        }

        // Detectar el paso del ratón
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            Invalidate(); // Redibujar
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            Invalidate(); // Redibujar
        }

        // Detectar clics
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            MessageBox.Show("¡Botón circular presionado!");
        }
    }
}
