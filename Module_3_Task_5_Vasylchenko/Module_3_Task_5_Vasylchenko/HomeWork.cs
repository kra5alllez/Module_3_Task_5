using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            return await Task.Run(() => File.ReadAllTextAsync("TextFile1.txt"));
        }

        public async Task<string> ConcontenAsync()
        {
            var k = await Task.WhenAll(HelloAsync(), WorldAsync());
            foreach (var y in k)
            {
                Console.WriteLine(y);
            }

            return await Task.Run(() => " ");
        }

        public void RR()
        {
            Console.WriteLine(ConcontenAsync().GetAwaiter().GetResult());
        }
    }
}
