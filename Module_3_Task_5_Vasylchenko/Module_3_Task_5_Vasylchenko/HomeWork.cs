using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Module_3_Task_5_Vasylchenko
{
    public class HomeWork
    {
        private readonly string _world;
        private readonly string _path;

        public HomeWork()
        {
            _world = "World";
            _path = "TextFile1.txt";
        }

        public Task<string> HomeWorkAsync()
        {
            List<Task<string>> list = new List<Task<string>>();
            list.Add(Task.FromResult(_world));
            list.Add(Task.Run(() => File.ReadAllTextAsync(_path)));
            var k = Task.WhenAll(list);
            return Task.Run(() => $"{k.Result[1]} {k.Result[0]}");
        }
    }
}
