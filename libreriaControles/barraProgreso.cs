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
    public partial class barraProgreso : Control
    {
        private int _minimum = 0; // Valor mínimo
        private int _maximum = 100; // Valor máximo
        private int _value = 0; // Valor actual
        private Color _barColor = Color.Blue; // Color de la barra de progreso

        public barraProgreso()
        {
            this.DoubleBuffered = true; // Para evitar parpadeos
            this.Size = new Size(300, 30); // Tamaño predeterminado
        }

        // Propiedad para el valor mínimo
        public int Minimum
        {
            get => _minimum;
            set
            {
                if (value >= _maximum)
                    throw new ArgumentOutOfRangeException(nameof(Minimum), "El valor mínimo debe ser menor que el máximo.");
                _minimum = value;
                if (_value < _minimum) _value = _minimum;
                Invalidate(); // Redibujar
            }
        }

        // Propiedad para el valor máximo
        public int Maximum
        {
            get => _maximum;
            set
            {
                if (value <= _minimum)
                    throw new ArgumentOutOfRangeException(nameof(Maximum), "El valor máximo debe ser mayor que el mínimo.");
                _maximum = value;
                if (_value > _maximum) _value = _maximum;
                Invalidate(); // Redibujar
            }
        }

        // Propiedad para el valor actual
        public int Value
        {
            get => _value;
            set
            {
                if (value < _minimum || value > _maximum)
                    throw new ArgumentOutOfRangeException(nameof(Value), "El valor debe estar entre el mínimo y el máximo.");
                _value = value;
                Invalidate(); // Redibujar
            }
        }

        // Propiedad para el color de la barra
        public Color BarColor
        {
            get => _barColor;
            set
            {
                _barColor = value;
                Invalidate(); // Redibujar
            }
        }

        // Dibujar el control
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Dibujar fondo
            using (SolidBrush backgroundBrush = new SolidBrush(Color.LightGray))
            {
                g.FillRectangle(backgroundBrush, ClientRectangle);
            }

            // Dibujar barra de progreso
            float percentage = (float)(_value - _minimum) / (_maximum - _minimum);
            int barWidth = (int)(ClientRectangle.Width * percentage);

            using (SolidBrush barBrush = new SolidBrush(_barColor))
            {
                g.FillRectangle(barBrush, 0, 0, barWidth, Height);
            }

            // Dibujar borde
            using (Pen borderPen = new Pen(Color.Black))
            {
                g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
            }
        }
    }
}
