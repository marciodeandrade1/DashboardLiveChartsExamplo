namespace DashboardLiveChartsExamplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 1. Configurar os Indicadores (KPIs) Simulados
            SetupKPIs();

            // 2. Configurar o Gráfico de Linha (Vendas ao Longo do Tempo)
            SetupLineChart();

            // 3. Configurar o Gráfico de Pizza/Rosca (Participação de Market Share)
            SetupPieChart();
        }
    }
}
