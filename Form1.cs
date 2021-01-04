using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gerar_Senhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
          
            string chars = "0123456789";
            string chars1 = "qwertyuiopasdfghjklzxcvbnm";
            string chars2 = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string pass = "";
            string pass1 = "";
            string pass2 = "";
            Random random = new Random();
            for (int x = 0; x < 4; x++)
            {
                pass = pass + chars.Substring(random.Next(0, chars.Length - 1), 1);
            }
            for (int x = 0; x < 1; x++)
            {
                pass1 = pass1 + chars1.Substring(random.Next(0, chars1.Length - 1), 1);
            }
            for (int x = 0; x < 1; x++)
            {
                pass2 = pass2 + chars2.Substring(random.Next(0, chars2.Length - 1), 1);
            }
            txtSenha.Text = pass2 + pass1 + pass;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSenha.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
