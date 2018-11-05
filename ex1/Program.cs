using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] PWLista1 = { "C#", "Aprender C#","ASP.NET MVC com C#",
"Entity Framework","Bootstrap","Identity",
"Lambda","Delegates","Linq","POO com C# "
};
            string[] PWLista2 = { "C#", "ASP.NET MVC", "Linq", "Lambda e C#" };

            int[] PWNum = { 10, 23, 54, 77, 85, 12, 1, 4, 53 };

            Console.Write($"exercicio 1:)\n");

            var Lista = new List<string>();
            foreach (string x in PWLista1)
                if (x.Contains("C#")) Lista.Add(x);

            var PWListaB = from s in PWLista2
                           where s.Contains("C#")
                           select s;

            var PWListC = PWLista1.Where(l => l.Contains("C#"));

            foreach (string x in PWListC)
                Console.WriteLine($"Elemento: {x} ");

            // a)
            Console.Write($"\nalinea a)\n");
            // QUery syntax
            var ordenados_ = from x in PWLista1 orderby x select x;

            // Extension Methods
            var _ordenados = PWLista1.OrderBy(s => s);

            foreach (string x in ordenados_) Console.Write($" {x} "); Console.Write($"\n");
            foreach (string x in _ordenados) Console.Write($" {x} "); Console.Write($"\n");

            // b)
            Console.Write($"\nalinea b)\n");

            var _b = from x in PWLista1 where x.Length < 6 select x; // query syntax
            var b_ = PWLista1.Where(x => x.Length < 6); // Extension methods

            foreach (string x in _b) Console.Write($" {x} "); Console.Write($"\n");
            foreach (string x in b_) Console.Write($" {x} "); Console.Write($"\n");

            // c)
            Console.Write($"\nalinea c)\n");

            var _c = (from x in PWLista1 where x.Contains("C#") select x).Count(); // query syntax
            var c_ = PWLista1.Count(x => x.Contains("C#")); // Extension methods

            Console.Write($" {_c} "); Console.Write($"\n");
            Console.Write($" {c_} "); Console.Write($"\n");

            // d)
            Console.Write($"\nalinea d)\n");

            var _d = from x in PWLista1 select x.Trim().Split(' ').Count(); // query syntax
            var d_ = PWLista1.Select(x => x.Trim().Split(' ').Count()); // Extension methods

            foreach (int x in _d) Console.Write($" {x} "); Console.Write($"\n");
            foreach (int x in d_) Console.Write($" {x} "); Console.Write($"\n");

            // e)
            Console.Write($"\nalinea e)\n");

            var _e = (from x in PWNum select x).Average(); // query syntax
            var e_ = PWNum.Average(); // Extension methods

            Console.Write($" {_e.ToString("F2")}"); Console.Write($"\n");
            Console.Write($" {e_.ToString("F2")}"); Console.Write($"\n");

            // f)
            Console.Write($"\nalinea f)\n");

            var f_ = PWNum.Max();

            Console.Write($" {f_.ToString("F2")}"); Console.Write($"\n");

            // g)
            Console.Write($"\nalinea g)\n");

            var _g = from x in PWNum where (x >= 1 && x <= 25) orderby x descending select x; // query syntax
            var g_ = PWNum.Where(x => x >= 1 && x <= 25).OrderByDescending(y => y); // Extension methods

            foreach (var x in _g) Console.Write($" {x} "); Console.Write($"\n");
            foreach (var x in g_) Console.Write($" {x} "); Console.Write($"\n");

        }
    }
}
