namespace Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox1.SelectedItem.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "PC";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "MAC";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Notebook";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)

                label6.Text = "Fax";

            else

                label6.Text = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)

                label7.Text = "Calculadora";

            else

                label7.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)

                label8.Text = "Copiadora";

            else

                label8.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = listBox1.SelectedItem.ToString();
        }
    }
}