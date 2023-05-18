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

namespace _43P_Podgot
{
    /// <summary>
    /// Логика взаимодействия для Agents.xaml
    /// </summary>
    public partial class Agents : Page
    {
        public Frame frame1;
        List<Газета> газета = new List<Газета>();
        public Agents(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            газета = Entities.GetContext().Газета.ToList();

        }
    }
}
