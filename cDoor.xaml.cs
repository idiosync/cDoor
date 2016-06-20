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

namespace jfetting
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class cDoor : UserControl
    {
        public cDoor()
        {
            InitializeComponent();
        }

        public string status
        {
            get { return lblStatus.Content as string; }
            set { lblStatus.Content=value; }
        }

        public string door
        {
            get { return lblDoor.Content as string; }
            set { lblDoor.Content = value; }
        }

        public string trailer
        {
            get { return lblTrailer.Content as string; }
            set { lblTrailer.Content = value; }
        }
    
    }
}
