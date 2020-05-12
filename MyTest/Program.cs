using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyTest
{
    class Program
    {
        private static void Main(string[] args)
        {
            FileStream filestream = new FileStream(@"G:\课程\4\out.txt", FileMode.Create);
            var streamwriter = new StreamWriter(filestream);
            streamwriter.AutoFlush = true;
            Console.SetOut(streamwriter);
            Console.SetError(streamwriter);

            var root = @"G:\课程\4";
            var dictionary = new Dictionary<string, List<string>>();
            foreach (var path in Directory.GetDirectories(root))
            {
                var projectGuids = string.Join(" ", GetProjectGuids(path).Distinct().OrderBy(x => x));
                if (!dictionary.ContainsKey(projectGuids))
                    dictionary[projectGuids] = new List<string>();
                //dictionary[projectGuids].Add(Path.GetFileName(path).Split('_')[0]);
                dictionary[projectGuids].Add(Path.GetFileName(path));
            }
            foreach (var key in dictionary.Keys.OrderBy(x => x))
            {
                if (dictionary[key].Count == 1) continue;
                Console.Write(key);
                foreach (var q in dictionary[key])
                    Console.Write("\t{0}", q);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static IEnumerable<string> GetProjectGuids(string path)
        {
            var files = Directory.GetFiles(path, "*.csproj", SearchOption.AllDirectories);
            foreach (var file in files)
                foreach (var line in File.ReadAllLines(file))
                    if (line.Trim().StartsWith("<ProjectGuid>"))
                        yield return line.Trim().Replace("<ProjectGuid>", "").Replace("</ProjectGuid>", "");

            var sln_files = Directory.GetFiles(path, "*.sln", SearchOption.AllDirectories);
            foreach (var file in sln_files)
                foreach (var line in File.ReadAllLines(file))
                    if (line.Trim().StartsWith("Project(\""))
                        yield return line.Trim().Split(' ')[4].Trim('"');
        }
    }
}
