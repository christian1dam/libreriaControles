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
    public partial class selectorFechaHora : UserControl
    {
        public selectorFechaHora()
        {
            InitializeComponent();
            chkHora.CheckedChanged += ChkHora_CheckedChanged;
            UpdateTimeEnabledState();
        }

        // Propiedad para obtener o establecer la fecha seleccionada
        public DateTime Fecha
        {
            get
            {
                var fecha = datePicker.Value.Date;
                if (chkHora.Checked)
                {
                    fecha = fecha.AddHours((double)numHora.Value);
                    fecha = fecha.AddMinutes((double)numMinutos.Value);
                }
                return fecha;
            }
            set
            {
                datePicker.Value = value.Date;
                numHora.Value = value.Hour;
                numMinutos.Value = value.Minute;
                chkHora.Checked = value.Hour != 0 || value.Minute != 0;
            }
        }

        // Evento que se dispara al cambiar la fecha o la hora
        public event EventHandler FechaHoraCambiada;

        private void OnFechaHoraCambiada()
        {
            FechaHoraCambiada?.Invoke(this, EventArgs.Empty);
        }

        private void ChkHora_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTimeEnabledState();
            OnFechaHoraCambiada();
        }

        private void UpdateTimeEnabledState()
        {
            numHora.Enabled = chkHora.Checked;
            numMinutos.Enabled = chkHora.Checked;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            OnFechaHoraCambiada();
        }

        private void numHora_ValueChanged(object sender, EventArgs e)
        {
            OnFechaHoraCambiada();
        }

        private void numMinutos_ValueChanged(object sender, EventArgs e)
        {
            OnFechaHoraCambiada();
        }
    }
}
