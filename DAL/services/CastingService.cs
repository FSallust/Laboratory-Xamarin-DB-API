using DAL.interfaces;
using DAL.models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Database;

namespace DAL.services
{
    public class CastingService : ICastingService
    {
        private string _connectionString;
        private Connection _Connection;

        public CastingService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("default");

            _Connection = new Connection(SqlClientFactory.Instance, _connectionString);
        }

        private Casting Converter(IDataReader reader)
        {
            return new Casting
            {
                Id = (int)reader["Id"],
                MovieId = (int)reader["MovieId"],
                PersonId = (int)reader["PersonId"],
                Role = reader["Role"].ToString()
            };
        }

        public IEnumerable<Casting> GetAll()
        {
            Command command = new Command("SELECT * FROM Casting");

            _Connection.Open();
            IEnumerable<Casting> casting = _Connection.ExecuteReader(command, Converter).ToList();
            _Connection.Close();

            return casting;
        }

        public Casting GetByMovieId(int Id)
        {
            Command command = new Command("SELECT * FROM Casting WHERE MovieId = @Id");
            command.AddParameter("Id", Id);

            _Connection.Open();
            Casting casting = _Connection.ExecuteReader(command, Converter).FirstOrDefault();
            _Connection.Close();

            return casting;
        }
    }
}
