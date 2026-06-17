using Microsoft.Data.SqlClient;
using Dapper; 

namespace tp3.Models; 

public class BD 
{
    public string _connectionString = @"Server=localhost; DataBase = Ahorcado; Integrated Security=True; TrustServerCertificate=True;"; 

    public List<string> hacerLista()
    {
        List <string> palabras = new List<string>();
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Texto FROM Palabras";
            palabras = connection.Query<string>(query).ToList();
        }
        return palabras; 
    }

    public void agregarPalabra(string palabra){
        string query = "INSERT INTO Palabras (Texto) VALUES (@palabra)";
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Execute(query , new {palabra}); 
        }
    }
}


