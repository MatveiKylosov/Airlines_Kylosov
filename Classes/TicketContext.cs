using Airlines_Kylosov.Model;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingBD;

namespace Airlines_Kylosov.Classes
{
    public class TicketContext : Ticket
    {
        public TicketContext(int price, string from, string to, DateTime startTime, DateTime endTime) : base(price, from.ToLower(), to.ToLower(), startTime, endTime)
        {

        }
        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();

            MySqlConnection connection = Connection.OpenConnection();

            MySqlDataReader ticketQuery = Connection.Query("SELECT * FROM `Airlines`.`tickets`", connection);

            while (ticketQuery.Read())
            {
                allTickets.Add(new TicketContext(
                    ticketQuery.GetInt32(3),
                    ticketQuery.GetString(1).ToLower(),
                    ticketQuery.GetString(2).ToLower(),
                    ticketQuery.GetDateTime(4),
                    ticketQuery.GetDateTime(5)
                    )) ;
            }

            Connection.CloseConnection(connection);

            return allTickets;
        }
    }
}
