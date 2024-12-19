using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using Syncfusion.Windows.PdfViewer;
using Syncfusion.UI.Xaml.Spreadsheet;

namespace SynfusionWpfApp241129
{
    public partial class FileLoadWindow : Window
    {
        public FileLoadWindow ()
        {
            InitializeComponent();
        }

        private void OpenFile_Click (object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "All Supported Files|*.xlsx;*.pdf;*.txt|Excel Files|*.xlsx|PDF Files|*.pdf|Text Files|*.txt",
                Title = "Select a File"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                string extension = Path.GetExtension(filePath).ToLower();

                switch (extension)
                {
                    case ".xlsx":
                        LoadExcel(filePath);
                        break;
                    case ".pdf":
                        LoadPDF(filePath);
                        break;
                    case ".txt":
                        LoadText(filePath);
                        break;
                    default:
                        MessageBox.Show("Unsupported file format.");
                        break;
                }
            }
        }

        private void LoadExcel (string filePath)
        {
            try
            {
                Spreadsheet.Open(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Excel: {ex.Message}");
            }
        }

        private void LoadPDF (string filePath)
        {
            try
            {
                PdfViewer.Load(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading PDF: {ex.Message}");
            }
        }

        private void LoadText (string filePath)
        {
            try
            {
                string textContent = File.ReadAllText(filePath);
                TextViewer.Document.Blocks.Clear();
                TextViewer.Document.Blocks.Add(new System.Windows.Documents.Paragraph(new System.Windows.Documents.Run(textContent)));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading text file: {ex.Message}");
            }
        }
    }
}
