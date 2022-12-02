namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie a.");
            ProgramistHelper.HowManyDaysBetweenToDate("15.09.1992", "12.08.1992");
            Console.WriteLine();
            Console.WriteLine("Zadanie b.");
            ProgramistHelper.ConcectTwoStringSentencesToOne("gdy niemożliwe staje się możliwe,", "a hałas przysłania cisza.");
            ProgramistHelper.ConcectTwoStringSentencesToOne("lubie dobre książkI", "i starą muzykę zwłaszcza lata 60'");
            Console.WriteLine();
            Console.WriteLine("Zadanie c.");
            ProgramistHelper.ChangeEveryWordWhoEndOnAEOToDupa();
            Console.WriteLine();
            Console.WriteLine("Zadanie c.");
            ProgramistHelper.ChangeEveryDupaWordInTextInRandomWord();
        }
    }
}