using System;
using System.IO;
using System.Threading.Tasks;

namespace Module_3_Task_5_Vasylchenko
{
    public class HomeWork
    {
        public async Task<string> WorldAsync()
        {
           return await Task.Run(() => "World");
        }

        public async Task<string> HelloAsync()
        {
            return await File.ReadAllTextAsync("TextFile1.txt");
        }

        public async Task<string> ConcatenationAsync()
        {
            var k = await Task.WhenAll(HelloAsync(), WorldAsync());
            return await Task.Run(() => $"{k[0]} {k[1]}");
        }
    }
}
