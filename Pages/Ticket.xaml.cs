using Airlines_Kylosov.Classes;
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

        public Ticket(string from, string to)
        {
            InitializeComponent();                                                                                            
            AllTickets = TicketContext.AllTickets().FindAll(x => (x.From.ToLower() == from.ToLower() && to == "") || 
                                                                 (x.To.ToLower() == to.ToLower() && from.ToLower() == "") || (x.From == from && x.To == x.To));
            CreateUI();
        }

        public void CreateUI()
        {
            foreach (Classes.TicketContext x in AllTickets)
                parent.Children.Add(new Element.Item(x));
        }
    }
}
