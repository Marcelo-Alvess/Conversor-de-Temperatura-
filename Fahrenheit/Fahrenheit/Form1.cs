using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Conversor conversor = new Conversor();
            
            if (rdbCelsiusparaf.Checked == true)
            {
                try
                {
                    conversor.TemperaturaC = Convert.ToDouble(txtCelsius.Text);
                    txtFahrenheit.Text = Convert.ToString(conversor.calcularCfahrenheit());
                }
                catch(Exception)
                {
                    MessageBox.Show("Ocorreu um erro, digite um valor válido");
                }
            }
            else
            {
                if (rdbCelsiusparak.Checked == true)
                {
                    try
                    {
                        conversor.TemperaturaC = Double.Parse(txtCelsius.Text);
                        txtKelvin.Text = Convert.ToString(conversor.calcularCkelvin());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocorreu um erro, digite um valor válido");
                    }
                }
                else
                {
                    if (rdbFahrenheitparac.Checked == true)
                    {
                        try
                        {
                            conversor.TemperaturaF = Double.Parse(txtFahrenheit.Text);
                            txtCelsius.Text = Convert.ToString(conversor.calcularFcelsius());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ocorreu um erro, digite um valor válido");
                        }
                    }
                    else
                    {
                        if (rdbFahrenheitparak.Checked == true)
                        {
                            try
                            {
                                conversor.TemperaturaF = Double.Parse(txtFahrenheit.Text);
                                txtKelvin.Text = Convert.ToString(conversor.calcularFkelvin());
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocorreu um erro, digite um valor válido");
                            }
                        }
                        else
                        {
                            if(rdbKelvinparac.Checked == true)
                            {
                                try
                                {
                                    conversor.TemperaturaK = Double.Parse(txtKelvin.Text);
                                    txtCelsius.Text = Convert.ToString(conversor.calcularKcelsius());
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Ocorreu um erro, digite um valor válido");
                                } 
                            }
                            else
                            {
                                try
                                {
                                    conversor.TemperaturaK = Double.Parse(txtKelvin.Text);
                                    txtFahrenheit.Text = Convert.ToString(conversor.calcularKfahrenheit());
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Ocorreu um erro, digite um valor válido");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void rdbCelsiusparaf_CheckedChanged(object sender, EventArgs e)
        {
            txtFahrenheit.Enabled = false;
            txtKelvin.Enabled = false;
            txtCelsius.Enabled = true;
        }

        private void rdbCelsiusparak_CheckedChanged(object sender, EventArgs e)
        {
            txtFahrenheit.Enabled = false;
            txtKelvin.Enabled = false;
            txtCelsius.Enabled = true;
        }

        private void rdbFahrenheitparac_CheckedChanged(object sender, EventArgs e)
        {
            txtCelsius.Enabled = false;
            txtKelvin.Enabled = false;
            txtFahrenheit.Enabled = true;
        }

        private void rdbFahrenheitparak_CheckedChanged(object sender, EventArgs e)
        {
            txtCelsius.Enabled = false;
            txtKelvin.Enabled = false;
            txtFahrenheit.Enabled = true;
        }

        private void rdbKelvintparac_CheckedChanged(object sender, EventArgs e)
        {
            txtCelsius.Enabled = false;
            txtFahrenheit.Enabled = false;
            txtKelvin.Enabled = true;
        }

        private void rdbKelvintparaf_CheckedChanged(object sender, EventArgs e)
        {
            txtCelsius.Enabled = false;
            txtFahrenheit.Enabled = false;
            txtKelvin.Enabled = true;
        }

        private void txtFahrenheit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConverter.Focus();
            }
        }

        private void txtCelsius_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConverter.Focus();
            }
        }

        private void txtKelvin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConverter.Focus();
            }
        }
    }
}
