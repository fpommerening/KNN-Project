using System;
using System.IO;

namespace FP.Study.KNN.FaceApi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bitte geben Sie den Face-API Key ein:");
                var key = Console.ReadLine();
                Console.WriteLine("Bitte geben Sie den Pfad zum Analysebild ein oder leer für Beispielbild.");
                var path = Console.ReadLine();
                if (string.IsNullOrEmpty(path))
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "sample.jpeg");
                }
                var detectFaces = new DetectFaces(path, key);
                detectFaces.Run().Wait();
                Console.WriteLine($"Analyseergebnis für Datei {Path.GetFileName(path)}");
                Console.WriteLine(detectFaces.ResultFormated);

            }
            catch (Exception e)
            {
                Console.WriteLine("Fehler bei der Ausführung der Analyse");
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
