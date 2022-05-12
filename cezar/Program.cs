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
              
                if (aa == true)
                {
                   
 if (tablica[i] >= 91)
                {
                    tablica[i] = (char)((char)tablica[i] - 26);
}

                }
                else
                {
                    if (tablica[i] >= 123)
                    {
                        tablica[i] = (char)((char)tablica[i] - 26);
                    }
                }

 
                





            }
            string charsStr = new string(tablica);
            Console.WriteLine(charsStr);
        }
    }
}
