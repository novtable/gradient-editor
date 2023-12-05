using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradientedit
{
    public partial class gui : Form
    {
        public gui()
        {
            InitializeComponent();
        }

        public void UpdateBorderColors()
        {
            Guna2Panel[] panels = { guna2Panel1, guna2Panel2, guna2Panel3 };
            foreach (Guna2Panel pan in panels)
            {
                pan.BorderColor = Color.FromArgb((int)colorSlider8.Value, (int)colorSlider9.Value, (int)colorSlider7.Value);
            }

            borderColor.FillColor = Color.FromArgb((int)colorSlider8.Value, (int)colorSlider9.Value, (int)colorSlider7.Value);
            guna2Separator2.FillColor = Color.FromArgb((int)colorSlider8.Value, (int)colorSlider9.Value, (int)colorSlider7.Value);
        }
        
        public void UpdateBackgroundColors()
        {
            ColorSlider.ColorSlider[] colorSliders = { colorSlider1, colorSlider2, colorSlider3, colorSlider4, colorSlider5, colorSlider6, colorSlider10, colorSlider11, colorSlider12, colorSlider8, colorSlider9, colorSlider7 };
            foreach (ColorSlider.ColorSlider slider in colorSliders)
            {
                slider.BackColor = Color.FromArgb((int)colorSlider11.Value, (int)colorSlider12.Value, (int)colorSlider10.Value);
                slider.BarInnerColor = Color.FromArgb((int)colorSlider11.Value, (int)colorSlider12.Value, (int)colorSlider10.Value);
            }

            this.BackColor = Color.FromArgb((int)colorSlider11.Value, (int)colorSlider12.Value, (int)colorSlider10.Value);
            backColor.CheckedState.FillColor = Color.FromArgb((int)colorSlider11.Value, (int)colorSlider12.Value, (int)colorSlider10.Value);
            
        }

        public void UpdateColors()
        {
            mainPanel.GradientColor1 = Color.FromArgb((int)colorSlider1.Value, (int)colorSlider2.Value, (int)colorSlider3.Value);
            color1.FillColor = Color.FromArgb((int)colorSlider1.Value, (int)colorSlider2.Value, (int)colorSlider3.Value);
            color1.CheckedState.FillColor = Color.FromArgb((int)colorSlider1.Value, (int)colorSlider2.Value, (int)colorSlider3.Value);

            mainPanel.GradientColor2 = Color.FromArgb((int)colorSlider5.Value, (int)colorSlider6.Value, (int)colorSlider4.Value);
            color2.FillColor = Color.FromArgb((int)colorSlider5.Value, (int)colorSlider6.Value, (int)colorSlider4.Value);
            color2.CheckedState.FillColor = Color.FromArgb((int)colorSlider5.Value, (int)colorSlider6.Value, (int)colorSlider4.Value);

        }

        public void SwitchColorBorder(Guna2Button button)
        {
            Guna2Button[] buttons = { color1, color2 };
            foreach (Guna2Button btn in buttons ) { 
                btn.Checked = false;
                btn.BorderColor = Color.FromArgb(67, 66, 66);
                btn.BorderThickness = 1;
            }

            button.Checked = true;
            button.BorderColor = Color.WhiteSmoke;
            button.BorderThickness = 3;

        }

        private void gui_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.ShowIcon = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SwitchColorBorder(color1);
            color1Panel.Visible = true;
            color2Panel.Visible = false;
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SwitchColorBorder(color2);
            color1Panel.Visible = false;
            color2Panel.Visible = true;
        }

        private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColors();
            label5.Text = colorSlider1.Value.ToString();
        }

        private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColors();
            label6.Text = colorSlider2.Value.ToString();
        }

        private void colorSlider3_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColors();
            label7.Text = colorSlider3.Value.ToString();
        }
        private void colorSlider4_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColors();
            label8.Text = colorSlider4.Value.ToString();
        }

        private void colorSlider5_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColors();
            label12.Text = colorSlider5.Value.ToString();
        }

        private void colorSlider6_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColors();
            label10.Text = colorSlider6.Value.ToString();
        }

        private void colorSlider11_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateBackgroundColors();
            label24.Text = colorSlider11.Value.ToString();
        }

        private void colorSlider12_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateBackgroundColors();
            label22.Text = colorSlider12.Value.ToString();
        }

        private void colorSlider10_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateBackgroundColors();
            label20.Text = colorSlider10.Value.ToString();
        }

        private void colorSlider8_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateBorderColors();
        }

        private void colorSlider9_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateBorderColors();
        }

        private void colorSlider7_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateBorderColors();
        }
    }
}
