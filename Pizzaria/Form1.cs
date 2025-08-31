
namespace Pizzaria
{
    public enum NivelAcesso
    {
        Visualizador,
        Funcionario,
        Administrador
    }
    public partial class Form1 : Form
    {
        public NivelAcesso NivelUsuario { get; private set; }
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(NivelAcesso.Visualizador);
            comboBox1.Items.Add(NivelAcesso.Funcionario);
            comboBox1.Items.Add(NivelAcesso.Administrador);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)            // Login
        {
            if (comboBox1.SelectedItem is NivelAcesso nivelSelecionado)
            {

                NivelUsuario = nivelSelecionado;

                if (textBox1.Text == "admin" && textBox2.Text == "password")
                {
                    Gerenciamento sistema = new Gerenciamento(NivelUsuario); 
                    sistema.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login ou senha estão incorretas");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selecione um nível de acesso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}