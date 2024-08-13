using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aluno_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CadastroAlunosControl();
        }

        private void avaliacoes_Click(object sender, RoutedEventArgs e)
        {
            // Substitua pelo UserControl correspondente para avaliações
            // MainContent.Content = new AvaliacoesControl();
        }

        private void instrutores_Click(object sender, RoutedEventArgs e)
        {
            // Substitua pelo UserControl correspondente para instrutores
            // MainContent.Content = new InstrutoresControl();
        }

        private void aulas_Click(object sender, RoutedEventArgs e)
        {
            // Substitua pelo UserControl correspondente para aulas
            // MainContent.Content = new AulasControl();
        }
    }
}
