using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WinForm_GeometricFigures
{
    class Figures
    {
        private List<Figure> figures = new List<Figure>();

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }

        public void Save(string filePath)
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.Create))
                {
                    var binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, figures);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                $"{ex.Message}",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        public void Clear()
        {
            figures.Clear();
        }

        public void Draw(Graphics paper)
        {
            foreach (var figure in figures)
            {
                figure.Draw(paper);
            }
        }

        public void Load(string filePath)
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    var binaryFormatter = new BinaryFormatter();
                    figures = (List<Figure>) binaryFormatter.Deserialize(stream);                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                $"{ex.Message}",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                Console.WriteLine($"Файл не найден");
            }
        }

        public List<Figure> GetFigures()
        {
            return figures;
        }
    }
}