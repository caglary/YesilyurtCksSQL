using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class DatabaseToJson
    {
        public static void SaveAsJson(string connectionstring, string query, string fileName)
        {

            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                // SQL sorgusu
                string sqlQuery = query;

                // SQL komutunu oluştur
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Verileri oku
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // JSON için liste oluştur
                        List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

                        // Verileri oku ve liste oluştur
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader[i];
                            }

                            data.Add(row);
                        }

                        // Listeyi JSON'a dönüştür
                        string jsonData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);

                        // JSON'u dosyaya yaz
                        string filePath = fileName + ".json";

                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            sw.Write(jsonData);
                        }


                    }
                }
            }
        }
    }
}
