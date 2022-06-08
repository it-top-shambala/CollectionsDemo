namespace CollectionsDemo.DictionaryApp
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("первый", "first");
            dict.Add("второй", "second");

            PrintDict(dict);

            Console.Write("Введите слово для поиска перевода: ");
            var key = Console.ReadLine();
            var val = dict[key];
            Console.WriteLine($"Перевод слова {key} - {val}");

            var res = dict.TryGetValue(key, out val);
            if (res)
            {
                Console.WriteLine($"Перевод слова {key} - {val}");
            }
            else
            {
                Console.WriteLine($"Перевод слова {key} не найден");
            }
        }

        private static void PrintDict(Dictionary<string, string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}