using System;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using Csv;

namespace DataLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var file = new FileStream(ConfigurationManager.AppSettings["sourceFile"], FileMode.Open))
            using (var db = new DataContext.DataContext())
            {
                var data = CsvReader.ReadFromStream(file);

                foreach (var line in data)
                {
                    Console.WriteLine(@"Adding: {0}, {1}", line[0], line[1]);
                    db.Items.Add(new DataContext.Models.Entry { Title = line[0], Value = int.Parse(line[1]) });
                }

                db.SaveChanges();
            }
        }
    }
}
