namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sayHelloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"Hello {firstNameText.Text} {lastNameText.Text}");
        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}