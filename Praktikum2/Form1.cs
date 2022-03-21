namespace Praktikum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_data_TextChanged(object sender, EventArgs e)
        {
            listBox1.Text = textBox_data.Text;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox_data.Text);
            textBox_data.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         label_output.Text = listBox1.Text;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label_output.Text = "";
            textBox_data.Text = "";
            checkBox_aktif.Checked = false;
            radioButton_biru.Checked = false;
            radioButton_merah.Checked = true;
            listBox1.Items.Clear();
        }

        private void checkBox_aktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_aktif.Checked)
            {
                radioButton_biru.Checked = false;
                radioButton_merah.Checked = false;
            }
            else
            {
                label_output.ForeColor = Color.Black;
            }
        }

        private void radioButton_merah_CheckedChanged(object sender, EventArgs e)
        {
            label_output.ForeColor = Color.Red;
        }

        private void radioButton_biru_CheckedChanged(object sender, EventArgs e)
        {
            label_output.ForeColor= Color.Blue;
        }
    }
}