using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Sergioteacher.Csharp04.MensajeBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                OpenFileDialog fichero = new OpenFileDialog();
                if (fichero.ShowDialog() == true)
                {
                    txtEditor.Text = File.ReadAllText(fichero.FileName);
                }
                else
                {
                    MessageBox.Show(" No se ha selecionado NADA", "Nada de nada", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }
        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {{
            SaveFileDialog ficherito = new SaveFileDialog();
            ficherito.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs|All files (*.*)|*.*";
            ficherito.InitialDirectory = @"c:\";
            ficherito.AddExtension = true;
            if (ficherito.ShowDialog() == true)
            {
                File.WriteAllText(ficherito.FileName, txtEditor.Text);
            }
            else
            {
                MessageBox.Show(" Cancelado ", "Na de na", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        }
    }
}