using Airlines_Kylosov.Model;
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

namespace Airlines_Kylosov.Element
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(Classes.TicketContext x)
        {
            InitializeComponent();

            lprice.Content = x.Price + " P";

            fromTime.Content = x.StartTime.ToString("HH:mm");
            fromDate.Content = x.StartTime.ToString("MM.dd.yyyy");
            from.Content = x.From;

            toTime.Content = x.EndTime.ToString("HH:mm");
            toDate.Content = x.EndTime.ToString("MM.dd.yyyy");
            to.Content = x.To;

            int[] time = new int[] { (x.EndTime.Subtract(x.StartTime)).Days, (x.EndTime.Subtract(x.StartTime)).Hours, (x.EndTime.Subtract(x.StartTime)).Minutes};

            TimeFly.Content = $"В пути: {(time[0] < 10 ? $"0{time[0]}" : $"{time[0]}")}:{(time[1] < 10 ? $"0{time[1]}" : $"{time[1]}")}:{(time[1] < 10 ? $"0{time[1]}" : $"{time[1]}")}";
/*            TimeFly.Content = $"В пути: {(x.EndTime.Subtract(x.StartTime)).Hours}:{(x.EndTime.Subtract(x.StartTime)).Minutes}";*/
        }
    }
}
