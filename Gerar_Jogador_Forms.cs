namespace Training
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome, time;
            int idade, camisa;
            nome = name_jogador.Text;
            time = time_name.Text;
            idade = int.Parse(years_old.Text);
            camisa = int.Parse(shirt_number.Text);
            MessageBox.Show(nome + " que tem " + idade + " anos " + " vai jogar no " + time + " e adquiriu a camisa " + camisa);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}