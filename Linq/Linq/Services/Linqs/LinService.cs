using Linq.Interfaces.Service;

namespace Linq.Services.Linqs
{
    internal class LinService : ILinService
    {
        public void FirstOrDefault(IReadOnlyCollection<string> con)
        {
            var list = con.FirstOrDefault("a");
            foreach (var l in list)
            {
                Console.WriteLine($"FirstOrDefault {l}");
                break;
            }
        }

        public void SelectWhere(IReadOnlyCollection<string> con)
        {
            var list = con.Select(w => w.ToLower()).Where(x => x.StartsWith("b"));
            foreach (var l in list)
            {
                Console.WriteLine($"SelectWhere {l}");
            }
        }

        public void Distinct(IReadOnlyCollection<string> con)
        {
            Console.WriteLine($"Length before: {con.Count}");
            var list = con.Distinct();
            Console.WriteLine($"Length after: {list.Count()}");
        }

        public void Count(IReadOnlyCollection<string> con)
        {
            var list = con.Count(w => w.Contains("d"));
            Console.WriteLine($"Elements which containt 'd': {list}");
        }

        public void Reverse(IReadOnlyCollection<string> con)
        {
            var list = con.Reverse();
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }
        }
    }
}
