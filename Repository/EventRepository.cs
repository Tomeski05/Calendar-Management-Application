using CalendarManagementApplication.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarManagementApplication.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly IConfiguration _configuration;

        public EventRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool CreateEvent(SchedulerEvent model)
        {
            try
            {
                string query = @"INSERT INTO Event
                                 (Description, Start, End)
                                 VALUES(@Description, @Start, @End)";

                using (IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("default")))
                {
                    dbConnection.Open();
                    var result = dbConnection.Execute(query, model);
                    return true;
                };
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateEvent(int id)
        {
            try
            {
                string query = @"UPDATE Event
                                 Set
                                 Description = @Description,
                                 Start = @Start,
                                 End = @End
                                 Where
                                 Email=@Email";

                using (IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("default")))
                {
                    dbConnection.Open();
                    var result = dbConnection.Execute(query, id);
                    return true;
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteEvent(int id)
        {
            try
            {
                string query = @"Delete 
                                 From Event   
                                 Where
                                 EventID = @EventID";

                using (IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("default")))
                {
                    dbConnection.Open();
                    var result = dbConnection.Execute(query, id);
                    return true;
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
