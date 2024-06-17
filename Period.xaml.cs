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
using System.Windows.Shapes;

namespace WorkTimeLogger
{
    /// <summary>
    /// Interaction logic for Period.xaml
    /// </summary>
    public partial class Period : Window
    {
        public Period()
        {
            init();
            this.start = DateTime.Now;
            this.end = DateTime.Now;
        }

        public Period(DateTime start)
        {
            this.start = start;
            this.end = DateTime.Now;
            init();
        }

        public Period(DateTime start, DateTime end)
        {
            this.start = start;
            this.end = end;
            init();
        }

        private void init()
        {
            InitializeComponent();
            timeStart.time
        }

        DateTime start = new DateTime();
        DateTime end = new DateTime();




    }
}
