using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using APISmartControl.Database;
using APISmartControl.Tools;
using Newtonsoft.Json;

namespace APISmartControl.Dados
{
    public class Aluguel
    {

        public string Listar()
        {
            string Retorno = string.Empty;
            try
            {
                DataSet DtsAluguel = new DataSet();
                ConnectDB oConnect = new ConnectDB();

                using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
                {
                    dbConnection.Open();
                    try
                    {
                        // 1. inicia o SqlDataAdapter passando o comando SQL para selecionar codigo e nome
                        // do produto e a conexão com o banco de dados
                        SqlDataAdapter SqlAluguel = new SqlDataAdapter("SELECT * from Aluguel", dbConnection);
                        // 2. preenche o dataset
                        SqlAluguel.Fill(DtsAluguel);
                        Retorno = JsonConvert.SerializeObject(DtsAluguel, Formatting.Indented).ToString();
                    }
                    catch (Exception) { }
                    dbConnection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Retorno;
        }
    }
}
