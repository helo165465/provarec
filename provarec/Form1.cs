namespace provarec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verificarprofissao v = new Verificarprofissao();
            v.nome = tx_name.Text;
            v.profiss�o = cb_profissao.Text;
            v.genero = cb_genero.Text;
            v.cpf = Convert.ToInt32(tx_cpf.Text);
            v.datadenascimento = Convert.ToDateTime(tx_datadenasc.Text);
            v.iniciodaprofiss�o = Convert.ToDateTime(tx_inicioprof.Text);

            int resultado = v.Verificarprofissao() ;

            lb_confirm.Text = $"Quantidade de pontos � de " + resultado.ToString();

        }
    }
}