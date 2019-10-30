using System.Windows;
using System.Windows.Documents;

namespace Demo
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MercuryZelle.Blocks.Add(new Paragraph(new Run("Mercury")));
            var tabel = new TableCell();
            tabel.Blocks.Add(new Paragraph(new Run("Vom Code erstellt")));
            TableRowTest.Cells.Add(tabel);
        }
    }
}
