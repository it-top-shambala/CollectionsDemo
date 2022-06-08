namespace CollectionsDemo.ArrayApp
{
    internal class Program
    {
        static void Main()
        {
            Phone phone = new Phone()
            {
                Type = PhoneType.Types[0],
                Number = "+789067777"
            };

            Phone2 phone2 = new Phone2()
            {
                Type = PhoneType2.Relatives,
                Number = "+2345235"
            };
        }
    }

    public static class PhoneType
    {
        public static string[] Types = new[] { "родные", "друзья" };
    }

    public class Phone
    {
        public string Type { get; set; }
        public string Number { get; set; }
    }

    public enum PhoneType2 { Relatives, Friends }
    
    public class Phone2
    {
        public PhoneType2 Type { get; set; }
        public string Number { get; set; }
    }
}