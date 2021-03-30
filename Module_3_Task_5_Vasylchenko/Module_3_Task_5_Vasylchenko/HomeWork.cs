using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Module_3_Task_5_Vasylchenko
{
    public class HomeWork
    {
        private const string Path = "TextFile1.txt";

        public async Task<string> HomeWorkAsync()
        {
            var list = new List<Task<string>>();
            list.Add(Task.FromResult("World"));
            list.Add(Task.Run(() => File.ReadAllTextAsync(Path)));
            var k = await Task.WhenAll(list);
            return $"{k[1]} {k[0]}";
        }
    }
}
