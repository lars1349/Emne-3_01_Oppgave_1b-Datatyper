namespace Oppgave_1_b_Datatyper
{
    internal class Datatyper
    {
        int tall = 12;

        float desimalTall = 7.59F;
        double desimalTall2 = 3,41;
        decimal desimalTall3 = 79,23M; 

        char bokstav = 'R';
        string tekst = "wohoo";

        bool santUsant = true; // eller false

        int[] tallArray = { 4, 29, 77 };
        string[] tekstArray = { "Dette", "er", "en", "tekst" };

        List<int> listeMedTall = new List<int>(); // Lager en ny liste med tall.

        public int BlaBlahBlaah()
        {
            return 666;
        }
    }
}
