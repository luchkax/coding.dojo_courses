// using System.Collections.Generic;
// using System.Linq;
// using Dapper;
// using System.Data;
// using MySql.Data.MySqlClient;
// using lostInTheWoods.Models;
 
// namespace lostInTheWoods.Factory
// {
//     public class TrailFactory : IFactory<Trail>
//     {
//         private string connectionString;
//         public TrailFactory()
//         {
//             connectionString = "server=localhost;userid=root;password=root;port=3306;database=wood;SslMode=None";
//         }
//         internal IDbConnection Connection
//         {
//             get {
//                 return new MySqlConnection(connectionString);
//             }
//         }

using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using lostInTheWoods.Models;
using Microsoft.Extensions.Options;
namespace lostInTheWoods.Factory
{
    public class TrailFactory : IFactory<Trail>
    {
        private readonly IOptions<MySqlOptions> MySqlConfig;
        public TrailFactory(IOptions<MySqlOptions> config)
        {
            MySqlConfig = config;
        }
        internal IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(MySqlConfig.Value.ConnectionString);
            }
        }

        public void Add(Trail trail)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO trails(name, description, trailLength, elevationChange, lat, lon, created_at) VALUES (@name, @description, @trailLength, @elevationChange, @lat, @lon, NOW());";
                System.Console.WriteLine(query);
                dbConnection.Open();
                dbConnection.Execute(query, trail);
            }
        }
        public List<Trail> FindAll()
        {
            using(IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();   
                return dbConnection.Query<Trail>("SELECT * FROM trails;").ToList();
            }
        }

        public Trail FindId(int id)
        {
            using(IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trails WHERE id = @Id", new {Id = id}).FirstOrDefault();
            }

        }




    }   
}
