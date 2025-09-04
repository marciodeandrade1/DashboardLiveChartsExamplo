
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

        private void SetupKPIs()
        {
            // Vamos apenas definir textos e valores fict�cios nos Labels que colocamos no design.
            // Suponha que voc� tenha Labels chamados labelKpi1, labelKpi2, etc.
            // Na pr�tica, voc� buscaria esses valores de um banco de dados ou servi�o.

            labelKpi1.Text = "R$ 152.304,00";
            labelKpi1.Text = "Receita Total (M�s)";

            labelKpi2.Text = "1.284";
            labelKpi2Desc.Text = "Total de Vendas";

            labelKpi3.Text = "R$ 118,57";
            labelKpi3Desc.Text = "Ticket M�dio";

            labelKpi4.Text = "12.4%";
            labelKpi4Desc.Text = "Crescimento Anual";
        }
    }
}
