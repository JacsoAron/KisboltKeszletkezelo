using System;
using KisboltKeszletkezelo.Models;
using KisboltKeszletkezelo.Services;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KisboltKeszletkezelo.TermekHozzaadas
{
    /// <summary>
    /// Interaction logic for TermekUserControl.xaml
    /// </summary>
    public partial class TermekUserControl : UserControl
    {
        List<Termek> termekek;
        Termek kivalasztottTermek;
        public TermekUserControl()
        {
            InitializeComponent();
        }
        // megkell ezt írni

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
