using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulaTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDestino.Text = string.Empty;
            if (txtOrigem.Lines.Length > 0)
            {
                var aspas = string.Format("\\{0}","\"");
                var abrechaves = string.Format("\"+\"{0}", "{");
                var fechachaves = string.Format("\"+\"{0}", "}");
                for (int i = 0; i < txtOrigem.Lines.Length; i++)
                {
                    var linha = "file.AppendLine($\"" + txtOrigem.Lines[i].Replace("\"", aspas).Replace("{", abrechaves).Replace("}", fechachaves) + "\");" + "\r\n";
                    
                    txtDestino.AppendText(linha);
                }

            }
        }
    }
}
