using APISmartControl.Tools;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APISmartControl.Dados
{
    public class Equipamento
    {
        public string Listar()
        {
            string Retorno = string.Empty;
            try
            {
                DataSet DtsEquipamento = new DataSet();
                ConnectDB oConnect = new ConnectDB();

                using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
                {
                    dbConnection.Open();
                    try
                    {
                        // 1. inicia o SqlDataAdapter passando o comando SQL para selecionar codigo e nome
                        // do produto e a conexão com o banco de dados
                        SqlDataAdapter SqlEquipamento = new SqlDataAdapter("SELECT * from Equipamento", dbConnection);
                        // 2. preenche o dataset
                        SqlEquipamento.Fill(DtsEquipamento);
                        Retorno = JsonConvert.SerializeObject(DtsEquipamento, Formatting.Indented).ToString();
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
        public string Insert_Equipamento(
             DateTime Data_Inicio,
             DateTime Data_fechamento,
             DateTime Data_Edicao,
             string device,
             string manufacturer,
             string deviceName,
             string Version,
             string platform,
             string idiom,
             string deviceType,
             string Imei)
        {

            ConnectDB oConnect = new ConnectDB();

            String Retorno = string.Empty;

            using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
            {
                dbConnection.Open();
                try
                {
                    /// Ajusta o Insert para seu projeto
                    String CommandoInsert = $"INSERT INTO Equipamento" +
                        $"( " + 
                        $"Data_Inicio," +
                        $"Data_Fechamento," +
                        $"Data_Edicao," +
                        $"device," +
                        $"manufacturer," +
                        $"deviceName," +
                        $"version," +
                        $"platform," +
                        $"idiom," +
                        $"deviceType," +
                        $"Imei) " +
                        $" VALUES " +
                        $"( " +
                        $"'{Data_Inicio}'," +
                        $"'{Data_fechamento}'," +
                        $"'{Data_Edicao}'," +
                        $"'{device}'," +
                        $"'{manufacturer}'," +
                        $"'{deviceName}'," +
                        $"'{Version}'," +
                        $"'{platform}'," +
                        $"'{idiom}'," +
                        $"'{deviceType}'," +
                        $"'{Imei}')";
                    /////////////////////////////////////

                    SqlCommand command_tmp =
                    new
                    SqlCommand(CommandoInsert, dbConnection);

                    command_tmp.ExecuteNonQuery();

                    Retorno = "OK"; 
                }
                catch (Exception ex) 
                {
                    Retorno = ex.Message.ToString();
                }
                dbConnection.Close();
            }
            return Retorno;

        }
    }
}
