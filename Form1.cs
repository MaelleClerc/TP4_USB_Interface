using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TP4_USB_Interface
{
    public partial class Form1 : Form
    {
        string message;
        int flag_save;
        int valeur_frequence;
        int valeur_amplitude;
        int valeur_offset;

        public Form1()
        {
            InitializeComponent();
        }

        private void Forme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frequence_Scroll(object sender, EventArgs e)
        {
            // Lecture du scroll pour affichage direct de la valeur
            valeur_frequence = Frequence.Value * 20;
            ValeurFrequence.Text = valeur_frequence.ToString();
        }

        private void Amplitude_Scroll(object sender, EventArgs e)
        {
            // Lecture du scroll pour affichage direct de la valeur
            valeur_amplitude = Amplitude.Value * 100;
            ValeurAmplitude.Text = valeur_amplitude.ToString();
        }

        private void Offset_Scroll(object sender, EventArgs e)
        {
            // Lecture du scroll pour affichage direct de la valeur
            valeur_offset = Offset.Value * 100;
            ValeurOffset.Text = valeur_offset.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            message = "!S=";

            switch (Forme.SelectedIndex)
            {
                case 0:

                    message += "SF=";

                    break;

                case 1:

                    message += "CF=";

                    break;

                case 2:

                    message += "DF=";

                    break;

                case 3:

                    message += "TF=";

                    break;
            }

            // Ajout de la fréquence dans la trame
            if (valeur_frequence < 1000)
            {
                message += "0";

                if(valeur_frequence < 100)
                {
                    message += "0";

                    if (valeur_frequence < 10)
                    {
                        message += "0";

                        if (valeur_frequence == 0)
                        {
                            message += "0";
                        }
                    }
                }
            }
            message += Frequence.Value * 20 + "A=";

            // Ajout de l'amplitude dans la trame
            if (valeur_amplitude < 10000)
            {
                if (valeur_amplitude < 1000)
                {
                    message += "0";
                       
                    if (valeur_amplitude == 0)
                    {
                        message += "00";
                    }
                }
            }
            message += Amplitude.Value * 100 + "O=";

            // Ajout de l'offset dans la trame
            if (Offset.Value > 0)
            {
                message += "+";
            }
            else
            {
                message += "-";
            }

            if (Math.Abs(valeur_offset) < 1000)
            {
                message += "0";

                if (Math.Abs(valeur_offset) == 0)
                {
                    message += "00";
                }
            }
            message += Math.Abs(Offset.Value) * 100 + "W=";

            // Ajout de la save dans la trame
            message += flag_save;

            // Afficheage de la trame
            textBox1.Text = message + "#";

            // Envoi de la trame sur l'usb
            char[] chaine = message.ToCharArray();
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.Write(chaine, 0, 27);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            flag_save ^= 1;

            if (flag_save == 1)
            {
                Sauvegarde.Text = "Sauvegarde \r\n On";
            }
            else
            {
                Sauvegarde.Text = "Sauvegarde \r\n Off";
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
