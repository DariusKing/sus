using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "archivo";
            saveFileDialog.SupportMultiDottedExtensions = true;
            saveFileDialog.ValidateNames = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Title = "Guardar Como";
            saveFileDialog.InitialDirectory = @"c:\";
            saveFileDialog.ShowDialog();
            try
            {
                string[] texto = { textBox1.Text, "Hola ", "Mundo" };
                File.WriteAllLines(saveFileDialog.FileName, texto);
                MessageBox.Show("Archivo guardado correctamente");
            }
            catch (IOException error )
            {

                MessageBox.Show(error.Message.ToString());
            }
            
        }
        public string Path()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string path = saveFileDialog.CustomPlaces.ToString() ;

            return path;
        }

        private void AbrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var archivo = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = archivo.ReadToEnd();
                }
                catch (Exception a)
                {

                    MessageBox.Show(a.Message.ToString());
                }
            }
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar los cambios?", "info", MessageBoxButtons.YesNoCancel);
            if (result==DialogResult.Yes)
            {
                GuardarToolStripButton_Click(sender, e);
                textBox1.Clear();
            }
            else if(result == DialogResult.Cancel)
            {
                  
            }
            else if(result==DialogResult.No)
            {
                textBox1.Clear();
            }
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
