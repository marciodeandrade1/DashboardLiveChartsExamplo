using DashboardLiveChartsExample;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace DashboardLiveChartsExamplo
{
    public partial class Form1 : Form
    {
        private DatabaseService _databaseService;
        public Form1()
        {
            InitializeComponent();
            //// 1. Configurar os Indicadores (KPIs) Simulados
            //SetupKPIs();

            //// 2. Configurar o Gr�fico de Linha (Vendas ao Longo do Tempo)
            //SetupLineChart();

            //// 3. Configurar o Gr�fico de Pizza/Rosca (Participa��o de Market Share)
            //SetupPieChart();
            // Configurar a conex�o com o banco de dados
            // ALTERE ESTES VALORES PARA SUA CONEX�O MYSQL!
            _databaseService = new DatabaseService(
                server: "localhost",
                database: "DashboardDB",
                userId: "seu_usuario",
                password: "sua_senha"
            );

            // Carregar dados do banco
            LoadDashboardData();

        }

        private void LoadDashboardData()
        {
            try
            {
                // 1. Carregar e configurar KPIs
                SetupKPIs();

                // 2. Carregar e configurar Gr�fico de Linha
                SetupLineChart();

                // 3. Carregar e configurar Gr�fico de Pizza
                SetupPieChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupKPIs()
        {
            var kpis = _databaseService.ObterKPIs();

            // Supondo que temos pelo menos 4 KPIs na ordem correta
            if (kpis.Count >= 4)
            {
                labelKpi1.Text = $"{kpis[0].Valor.ToString("C2")}";
                labelKpi1Desc.Text = kpis[0].Nome;

                labelKpi2.Text = $"{kpis[1].Valor} {kpis[1].Unidade}";
                labelKpi2Desc.Text = kpis[1].Nome;

                labelKpi3.Text = $"{kpis[2].Valor.ToString("C2")}";
                labelKpi3Desc.Text = kpis[2].Nome;

                labelKpi4.Text = $"{kpis[3].Valor} {kpis[3].Unidade}";
                labelKpi4Desc.Text = kpis[3].Nome;
            }
        }

        private void SetupLineChart()
        {
            var vendas = _databaseService.ObterVendasMensais();

            var lineSeries = new LineSeries
            {
                Title = "Vendas Mensais",
                Values = new ChartValues<double>(vendas.Select(v => (double)v.Valor)),
                Fill = System.Windows.Media.Brushes.Transparent,
                StrokeThickness = 3,
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 10,
                PointForeground = System.Windows.Media.Brushes.White
            };

            cartesianChart1.Series = new SeriesCollection { lineSeries };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "M�s",
                Labels = vendas.Select(v => v.Mes).ToArray()
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Vendas (R$)",
                LabelFormatter = value => value.ToString("C0")
            });

            cartesianChart1.LegendLocation = LegendLocation.Top;
        }

        private void SetupPieChart()
        {
            var marketShare = _databaseService.ObterMarketShare();

            var pieSeriesCollection = new SeriesCollection();

            foreach (var item in marketShare)
            {
                pieSeriesCollection.Add(new PieSeries
                {
                    Title = item.Empresa,
                    Values = new ChartValues<ObservableValue> { new ObservableValue((double)item.Percentual) },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.Y}%"
                });
            }

            pieChart1.Series = pieSeriesCollection;
            pieChart1.InnerRadius = 50;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        // Bot�o para atualizar os dados
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            MessageBox.Show("Dados atualizados com sucesso!", "Atualiza��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

        //private void SetupPieChart()
        //{
        //    // Cria os dados para o gr�fico de pizza.
        //    // ObservableValue � uma classe do LiveCharts que notifica o gr�fico sobre mudan�as.
        //    var pieSeriesCollection = new SeriesCollection();

        //    pieSeriesCollection.Add(new PieSeries
        //    {
        //        Title = "Empresa A",
        //        Values = new ChartValues<ObservableValue> { new ObservableValue(40) },
        //        DataLabels = true, // Mostra os r�tulos de dados
        //        LabelPoint = chartPoint => $"{chartPoint.Y}%" // Formata o label para mostrar a porcentagem
        //    });
        //    pieSeriesCollection.Add(new PieSeries
        //    {
        //        Title = "Empresa B",
        //        Values = new ChartValues<ObservableValue> { new ObservableValue(25) },
        //        DataLabels = true,
        //        LabelPoint = chartPoint => $"{chartPoint.Y}%"
        //    });
        //    pieSeriesCollection.Add(new PieSeries
        //    {
        //        Title = "Nossa Empresa",
        //        Values = new ChartValues<ObservableValue> { new ObservableValue(20) },
        //        DataLabels = true,
        //        LabelPoint = chartPoint => $"{chartPoint.Y}%"
        //    });
        //    pieSeriesCollection.Add(new PieSeries
        //    {
        //        Title = "Empresa C",
        //        Values = new ChartValues<ObservableValue> { new ObservableValue(15) },
        //        DataLabels = true,
        //        LabelPoint = chartPoint => $"{chartPoint.Y}%"
        //    });

        //    // Atribui a cole��o de s�ries ao PieChart
        //    pieChart1.Series = pieSeriesCollection;

        //    // Opcional: For�a o gr�fico a ser desenhado como uma rosca (Donut)
        //    pieChart1.InnerRadius = 50; // 50 pixels de raio interno (buraco)

        //    // Opcional: Configura a legenda
        //    pieChart1.LegendLocation = LegendLocation.Bottom;
        //}
        //private void SetupLineChart()
        //{
        //    // Cria uma nova s�rie do tipo Line (Linha)
        //    var lineSeries = new LineSeries
        //    {
        //        Title = "Vendas Mensais",
        //        // Usaremos valores num�ricos (double) para o eixo Y
        //        Values = new ChartValues<double> { 42321, 53211, 48975, 65234, 71230, 55321, 82345, 93412, 101200, 88123, 75321, 112450 },
        //        // Preenche a �rea sob a linha
        //        Fill = System.Windows.Media.Brushes.Transparent,
        //        // Espessura da linha
        //        StrokeThickness = 3,
        //        // Desenha pontos em cada valor
        //        PointGeometry = DefaultGeometries.Circle,
        //        PointGeometrySize = 10,
        //        PointForeground = System.Windows.Media.Brushes.White
        //    };
        //    // Adiciona a s�rie ao gr�fico
        //    cartesianChart1.Series = new SeriesCollection { lineSeries };
        //    // Define os r�tulos (labels) para o eixo X (Meses)
        //    cartesianChart1.AxisX.Add(new Axis
        //    {
        //        Title = "M�s",
        //        Labels = new[] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" }
        //    });
        //    // Define o eixo Y
        //    cartesianChart1.AxisY.Add(new Axis
        //    {
        //        Title = "Vendas (R$)",
        //        LabelFormatter = value => value.ToString("C0") // Formata como moeda
        //    });
        //    // Adiciona uma legenda
        //    cartesianChart1.LegendLocation = LegendLocation.Top;
        //}
        //private void SetupKPIs()
        //{
        //    // Vamos apenas definir textos e valores fict�cios nos Labels que colocamos no design.
        //    // Suponha que voc� tenha Labels chamados labelKpi1, labelKpi2, etc.
        //    // Na pr�tica, voc� buscaria esses valores de um banco de dados ou servi�o.

        //    labelKpi1.Text = "R$ 152.304,00";
        //    labelKpi1Desc.Text = "Receita Total (M�s)";

        //    labelKpi2.Text = "1.284";
        //    labelKpi2Desc.Text = "Total de Vendas";

        //    labelKpi3.Text = "R$ 118,57";
        //    labelKpi3Desc.Text = "Ticket M�dio";

        //    labelKpi4.Text = "12.4%";
        //    labelKpi4Desc.Text = "Crescimento Anual";
        //}
//    }
//}