using Microsoft.AspNetCore.Hosting;
using Services.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Services.Services
{
    public class DatabaseProductService
    {
        public IConfiguration _configuration { get; }

        public DatabaseProductService(IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            WebHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string ConnectionString
        {
            get { return _configuration.GetConnectionString("ServicesDB"); ; }
        }

        public IEnumerable<Product> GetProducts()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string sql = "" +
                "SELECT * " +
                "FROM Products ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Product> temp = new List<Product>();
            while (reader.Read())
            {
                Product tempP = new Product();
                tempP.Id = int.Parse(reader["Id"].ToString());
                tempP.Maker = reader["Maker"].ToString();
                tempP.Image = reader["Img"].ToString();
                tempP.Url = reader["Url"].ToString();
                tempP.Title = reader["Title"].ToString();
                tempP.Description = reader["Description"].ToString();
                temp.Add(tempP);
            }
            return temp;
        }
    }

}
