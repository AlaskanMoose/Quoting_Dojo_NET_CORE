using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using quoting_dojo2.Models;
using quoting_dojo2.Connectors;

namespace quoting_dojo2.Factories {

    public class QuoteFactory : IFactory<Quote> {
        public List<Dictionary<string, object>> FindAll(){
            string Query = "SELECT * FROM Quote ORDER BY CreatedAt DESC";
            var allQuotes = DbConnector.Query(Query);
            return allQuotes;

        }
        public void Add(Quote quote){
            string Query = $"INSERT INTO Quote (Name, Content, CreatedAt) VALUES ('{quote.Name}', '{quote.Content}', NOW())";
            DbConnector.Execute(Query);
        }
    }
}