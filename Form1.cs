using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_USB_Interface
{
    public partial class Form1 : Form
    {
        string message;
        int flag_save;

        public Form1()
        {
            InitializeComponent();
        }

        private void Forme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frequence_Scroll(object sender, EventArgs e)
        {

        }

        private void Amplitude_Scroll(object sender, EventArgs e)
        {

        }

        private void Offset_Scroll(object sender, EventArgs e)
        {

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
            message += Frequence.Value * 20 + "A=";

            // Ajout de l'amplitude dans la trame
            message += Amplitude.Value * 100 + "O=";

            // Ajout de l'offset dans la trame
            if (Offset.Value > 0)
            {
                message += "+" + Offset.Value * 100 + "W=";
            }
            else
            {
                message += Offset.Value * 100 + "W=";
            }

            // Ajout de la save dans la trame
            message += flag_save;

            // Afficheage de la trame
            textBox1.Text = message + "#";
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
