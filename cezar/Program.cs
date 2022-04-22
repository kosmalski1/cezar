// See https://aka.ms/new-console-template for more information
namespace cezar

{
    class Program
    {
        static void Main(string[] args)
        {
            bool aa;
            Console.WriteLine("podaj klucz przesunięcia");
            int przesuniecie = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj fraze");
            string fraza = Console.ReadLine();
            char[] tablica = fraza.ToCharArray();
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = (char)((char)tablica[i] + przesuniecie);
                aa = Char.IsUpper(tablica[i]);
                if (tablica[i] >= 91)
                {
                    tablica[i] = (char)((char)tablica[i] - 26); }
                if (aa == true)
                {



                }
                else
                {
                    tablica[i] = (char)((char)tablica[i] + przesuniecie - 2);
                }







            }
            string charsStr = new string(tablica);
            Console.WriteLine(charsStr);
        }
    }
}
