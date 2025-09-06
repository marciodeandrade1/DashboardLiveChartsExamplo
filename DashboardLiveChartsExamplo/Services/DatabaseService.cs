using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DashboardLiveChartsExample
{
    public class VendaMensal
    {
        public string Mes { get; set; }
        public decimal Valor { get; set; }
    }

    public class ParticipacaoMercado
    {
        public string Empresa { get; set; }
        public decimal Percentual { get; set; }
    }

    public class KPI
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Unidade { get; set; }
    }

    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string server, string database, string userId, string password)
        {
            _connectionString = $"Server={server};Database={database};Uid={userId};Pwd={password};";
        }

        public List<VendaMensal> ObterVendasMensais()
        {
            var vendas = new List<VendaMensal>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT Mes, Valor FROM VendasMensais ORDER BY FIELD(Mes, 'Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez')", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vendas.Add(new VendaMensal
                        {
                            Mes = reader.GetString("Mes"),
                            Valor = reader.GetDecimal("Valor")
                        });
                    }
                }
            }

            return vendas;
        }

        public List<ParticipacaoMercado> ObterMarketShare()
        {
            var marketShare = new List<ParticipacaoMercado>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT Empresa, Percentual FROM MarketShare", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marketShare.Add(new ParticipacaoMercado
                        {
                            Empresa = reader.GetString("Empresa"),
                            Percentual = reader.GetDecimal("Percentual")
                        });
                    }
                }
            }

            return marketShare;
        }

        public List<KPI> ObterKPIs()
        {
            var kpis = new List<KPI>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT Nome, Valor, Unidade FROM KPIs", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kpis.Add(new KPI
                        {
                            Nome = reader.GetString("Nome"),
                            Valor = reader.GetDecimal("Valor"),
                            Unidade = reader.GetString("Unidade")
                        });
                    }
                }
            }

            return kpis;
        }
    }
}