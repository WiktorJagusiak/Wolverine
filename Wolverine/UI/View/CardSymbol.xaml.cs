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

namespace Wolverine.UI.Control
{
    /// <summary>
    /// Interaction logic for CardSymbol.xaml
    /// </summary>
    public partial class CardSymbol : UserControl
    {
        public CardSymbolState CurrentState { get; set; }
        public enum CardSymbolState
        {
            Empty, Visible, Invisible
        }

        public CardSymbol()
        {
            InitializeComponent();
            CurrentState = CardSymbolState.Empty;
            DataContext = this;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            CircleCardChooser.Visibility = Visibility.Visible;
        }
    }
}
