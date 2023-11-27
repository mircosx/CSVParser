using System.Diagnostics;
using System.IO;
using System.Text;

namespace ParserCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Apri file csv",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Percorso del file di controllo",
                CheckFileExists = false,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog2.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(textBox1.Text);

            string delimitatore = textBox4.Text;
            string testo = textBox3.Text;
            string linea = "";
            int contaRighe = 1;

            using (inputFile)
            {
                while ((linea = inputFile.ReadLine()) != null)
                {
                    string stringa = "";
                    int contaDelimitatori = 0;
                    int contaTesto = 0;

                    FileStream fs = new FileStream(textBox2.Text, FileMode.Append, FileAccess.Write);
                    StreamWriter outputFile = new StreamWriter(fs);

                    if (linea.Contains(delimitatore))
                    {
                        contaDelimitatori = linea.Count(f => f == char.Parse(delimitatore));
                    }

                    if (linea.Contains(testo))
                    {
                        contaTesto = linea.Count(g => g == char.Parse(testo));
                    }

                    stringa = "La riga " + contaRighe + " contiene " + contaDelimitatori + " colonne con " + contaTesto + " delimitatori di testo.";

                    using (outputFile)
                    {
                        outputFile.WriteLine(stringa);
                        outputFile.Close();
                    }
                    contaRighe++;
                }
                MessageBox.Show("File creato!");

                if (checkBox1.Checked == true)
                {
                    using Process apri = new Process();
                    apri.StartInfo.FileName = "explorer";
                    apri.StartInfo.Arguments = "\"" + textBox2.Text + "\"";
                    apri.Start();
                }
            }
        }
    }
}