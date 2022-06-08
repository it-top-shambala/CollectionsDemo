namespace CollectionsDemo.ListApp
{
    internal class Program
    {
        static void Main()
        {
            var names = new List<string>();

            names.Add("a1");
            names.Add("a2");
            names.Add("a3");
            names.Add("a5");
            names.Add("a7");
            names.Add("a7");
            names.Add("a7");
            
            PrintCollection(names);
            
            Console.Write("Введите строку для поиска: ");
            var key = Console.ReadLine();

            var res = names.FindAll(str => str == key);
            PrintCollection(res);
            res[0] = "a17";
            res[res.Count - 1] = "a45";
            PrintCollection(res);

            var file = new StreamWriter("names.txt", false);
            file.WriteLine(res[0]);

            foreach (var name in names)
            {
                file.WriteLine(name);
            }
            
            names.ForEach(file.WriteLine);
        }

        static void PrintCollection(List<string> list)
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}