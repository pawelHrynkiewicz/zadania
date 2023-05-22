using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_WindowsForms
{
    public partial class GetFilePathWindow : Form
    {
        public string FilePath { get; set; }
        private readonly MainWidow _mainWidow;
        public GetFilePathWindow(MainWidow mainWidow)
        {
            InitializeComponent();
            _mainWidow = mainWidow;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Text files (*.txt)|*.txt",
            };
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;

                //MessageBox.Show(FilePath,"",MessageBoxButtons.OK, MessageBoxIcon.Information);
                var textBox = Controls.Find("textBox1", true).FirstOrDefault() as TextBox;
                textBox.Text = FilePath;

                if (string.IsNullOrEmpty(FilePath))
                {

                }
            }
            else
            {
                //var errorWindow = new ErrorWindow("YOU NEED TO SELECT FILE");
                //errorWindow.ShowDialog(); 
                ShowError();
            }

        }
        private void ShowError(string message = "select a file")
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(FilePath))
            {
                ShowError();
                return;
            }
            _mainWidow.LoadData(FilePath);
            Close();
        }
    }
}
