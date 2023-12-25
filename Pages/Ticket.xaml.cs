using Airlines_Kylosov.Classes;
using Airlines_Kylosov.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airlines_Kylosov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Ticket.xaml
    /// </summary>
    public partial class Ticket : Page
    {
        public List<Classes.TicketContext> AllTickets;

        bool CheckTime(DateTime DateForm, DateTime DateAir)
        {
            return (DateForm.TimeOfDay != TimeSpan.Zero ? DateForm == DateAir : DateForm.Date == DateAir.Date);
        }


        public Ticket(string from, string to, DateTime? fromDateQ, DateTime? toDateQ)
        {
            from = from.ToLower();
            to = to.ToLower();

            InitializeComponent();
            if(fromDateQ.HasValue && toDateQ.HasValue)
            {

                //а вторая дата показывает есть ли на выбранное второе число билет обратно
                AllTickets = TicketContext.AllTickets().FindAll(item =>
                {
                    bool lag = fromDateQ.HasValue && (fromDateQ.Value.TimeOfDay != TimeSpan.Zero ? item.StartTime > fromDateQ.Value : item.StartTime.Date > fromDateQ.Value.Date);

                    // туда билет
                    bool isOutboundTicket = item.From == from && item.To == to && CheckTime(fromDateQ.Value, item.StartTime);

                    // обратно билет
                    bool isInboundTicket = item.From == to && item.To == from && CheckTime(toDateQ.Value, item.StartTime) && lag;

                    return isOutboundTicket || isInboundTicket;
                });

            }
            else if (fromDateQ.HasValue || toDateQ.HasValue)
            {
                //первая дата показывает есть ли рейсы на выбранное число
                DateTime FirstDate = fromDateQ.HasValue ? fromDateQ.Value : toDateQ.Value;


                AllTickets = TicketContext.AllTickets().FindAll(x =>
                    (x.From.ToLower() == from.ToLower() && to == "" && CheckTime(FirstDate, fromDateQ.HasValue ? x.StartTime : x.EndTime)) ||
                    (x.To.ToLower() == to.ToLower() && from == "" && CheckTime(FirstDate, fromDateQ.HasValue ? x.StartTime : x.EndTime)) ||
                    (x.From == from && x.To == to && CheckTime(FirstDate, fromDateQ.HasValue ? x.StartTime : x.EndTime)) ||
                    (x.From == to && x.To == from && fromDateQ.HasValue && (fromDateQ.Value.TimeOfDay != TimeSpan.Zero ? x.StartTime > fromDateQ.Value : x.StartTime.Date > fromDateQ.Value.Date))
                );

            }
            else
            {
                AllTickets = TicketContext.AllTickets().FindAll(x => (x.From.ToLower() == from.ToLower() && to == "") ||
                                                      (x.To.ToLower() == to.ToLower() && from == "") ||
                                                      (x.From == from && x.To == to));
            }

            CreateUI();
        }


        public void CreateUI()
        {
            foreach (Classes.TicketContext x in AllTickets)
                parent.Children.Add(new Element.Item(x));
        }
    }
}
