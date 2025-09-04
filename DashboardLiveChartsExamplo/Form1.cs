

using LiveCharts;
using LiveCharts.Wpf;

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
           // SetupPieChart();
        }

        private void SetupLineChart()
        {
            // Cria uma nova s�rie do tipo Line (Linha)
            var lineSeries = new LineSeries
            {
                Title = "Vendas Mensais",
                // Usaremos valores num�ricos (double) para o eixo Y
                Values = new ChartValues<double> { 42321, 53211, 48975, 65234, 71230, 55321, 82345, 93412, 101200, 88123, 75321, 112450 },
                // Preenche a �rea sob a linha
                Fill = System.Windows.Media.Brushes.Transparent,
                // Espessura da linha
                StrokeThickness = 3,
                // Desenha pontos em cada valor
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 10,
                PointForeground = System.Windows.Media.Brushes.White
            };

            // Adiciona a s�rie ao gr�fico
            cartesianChart1.Series = new SeriesCollection { lineSeries };

            // Define os r�tulos (labels) para o eixo X (Meses)
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "M�s",
                Labels = new[] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" }
            });

            // Define o eixo Y
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Vendas (R$)",
                LabelFormatter = value => value.ToString("C0") // Formata como moeda
            });

            // Adiciona uma legenda
            cartesianChart1.LegendLocation = LegendLocation.Top;
        }
        }

        private void SetupKPIs()
        {
            // Vamos apenas definir textos e valores fict�cios nos Labels que colocamos no design.
            // Suponha que voc� tenha Labels chamados labelKpi1, labelKpi2, etc.
            // Na pr�tica, voc� buscaria esses valores de um banco de dados ou servi�o.

            labelKpi1.Text = "R$ 152.304,00";
            labelKpi1Desc.Text = "Receita Total (M�s)";

            labelKpi2.Text = "1.284";
            labelKpi2Desc.Text = "Total de Vendas";

            labelKpi3.Text = "R$ 118,57";
            labelKpi3Desc.Text = "Ticket M�dio";

            labelKpi4.Text = "12.4%";
            labelKpi4Desc.Text = "Crescimento Anual";
        }
    }
}
