using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schrijventarief_inkomstenbelasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inkomen = Convert.ToDouble(textBox1.Text);

            double belastbaresom;
            double belastvrijesom;
            double tebetalenbelasting;

            double tariefgroep1 = 419;
            double tariefgroep2 = 8799;
            double tariefgroep3 = 17179;
            double tariefgroep4 = 15503;
            double tariefgroep5 = 15503;

            if (comboBox1.Items[Convert.ToInt32(comboBox1.SelectedIndex)].Equals(comboBox1.Items[0]))
            {
                belastvrijesom = tariefgroep1;
            }
            else if (comboBox1.Items[Convert.ToInt16(comboBox1.SelectedIndex)] == comboBox1.Items[1])
            {
                belastvrijesom = tariefgroep2;
            }
            else if (comboBox1.Items[Convert.ToInt16(comboBox1.SelectedIndex)] == comboBox1.Items[2])
            {
                belastvrijesom = tariefgroep3;
            }
            else if (comboBox1.Items[Convert.ToInt16(comboBox1.SelectedIndex)] == comboBox1.Items[3])
            {
                belastvrijesom = tariefgroep4;
            }
            else if (comboBox1.Items[Convert.ToInt16(comboBox1.SelectedIndex)] == comboBox1.Items[4])
            {
                belastvrijesom = tariefgroep5;
            }
            else if (comboBox1.Items[Convert.ToInt16(comboBox1.SelectedIndex)] == comboBox1.Items[5])
            {
                belastvrijesom = inkomen / 100 * 12;

                if (belastvrijesom >= 6704)
                {
                    belastvrijesom = 6704;
                }
            }
            else
            {
                belastvrijesom = 0;
            }

            belastbaresom = inkomen - belastvrijesom;

            if (belastbaresom <= 8000)
            {
                tebetalenbelasting = belastbaresom / 100 * 35.75;
            }
            else if(belastbaresom >= 8001 && belastbaresom <= 25000)
            {
                tebetalenbelasting = belastbaresom / 100 * 37.05;

            }
            else if (belastbaresom >= 25001 && belastbaresom <= 54000)
            {
                tebetalenbelasting = belastbaresom / 100 * 50;

            }
            else
            {
                tebetalenbelasting = belastbaresom / 100 * 60;

            }

            textBox2.Text = Convert.ToString(tebetalenbelasting);

        }
    }
}
