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
using Wolverine.UI.ViewModel;

namespace Wolverine.UI.Control
{
    /// <summary>
    /// Interaction logic for CircleCardChooser.xaml
    /// </summary>
    public partial class CircleCardChooser : UserControl
    {
        public CircleCardChooser()
        {
            InitializeComponent();

            DataContext = new CircleCardChooserViewModel();
        }
    }
}
