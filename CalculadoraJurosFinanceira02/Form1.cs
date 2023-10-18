namespace CalculadoraJurosFinanceira02
{
    public partial class CalculadoraJuros : Form
    {
        public CalculadoraJuros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double principal = double.Parse(txtPrincipal.Text);
            double taxaDeJurosAnual = double.Parse(txtTaxaJuros.Text);
            int numeroDeParcelas = int.Parse(txtNumeroParcelas.Text);

            
            double taxaDeJurosMensal = (taxaDeJurosAnual / 100) / 12;

            
            double valorDaParcela = principal * (taxaDeJurosMensal / (1 - Math.Pow(1 + taxaDeJurosMensal, -numeroDeParcelas)));

          
            double totalJuros = (valorDaParcela * numeroDeParcelas) - principal;

            
            double totalPago = principal + totalJuros;

            
            lblValorParcela.Text = "Valor da Parcela: " + valorDaParcela.ToString("N2");
            lblTotalJuros.Text = "Total em Juros: " + totalJuros.ToString("N2");
            lblTotalPago.Text = "Total Pago: " + totalPago.ToString("N2");
        }
    }
}