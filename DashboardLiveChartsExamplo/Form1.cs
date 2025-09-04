namespace DashboardLiveChartsExamplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 1. Configurar os Indicadores (KPIs) Simulados
            SetupKPIs();

            // 2. Configurar o Gr�fico de Linha (Vendas ao Longo do Tempo)
            SetupLineChart();

            // 3. Configurar o Gr�fico de Pizza/Rosca (Participa��o de Market Share)
            SetupPieChart();
        }
    }
}
