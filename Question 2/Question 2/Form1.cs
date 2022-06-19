namespace Question_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "The pig Latin version is " + textBox1.Text.Substring(1) + textBox1.Text[0] + "ay";
            label2.Text = msg;
        }
    }
}