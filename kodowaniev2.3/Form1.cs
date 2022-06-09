using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kodowaniev2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void loadFile_Click(object sender, EventArgs e)
        {
            var filePath = String.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"c:\";
                ofd.ShowDialog();
            }
        }

        private void codeType_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFile_Click(object sender, EventArgs e)
        {

        }
    }


    class Kodowanie
    {

        private List<string> _lista;

        public Kodowanie(List<string> lista)
        {
            _lista = lista;
        }

        public void openFile()
        {
 
        }
    }
}
