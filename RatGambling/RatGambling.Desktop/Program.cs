using RatGambling.Desktop.src;
using RatGambling.Core.src.Card;
using RatGambling.Desktop.startingPage;

namespace RatGambling.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //CardDeck deck = new();                DO NOT DELETE
            //deck.CreateDeck();
            //deck.Shuffle();
            //string deckCards = string.Empty;
            //foreach(var Card in deck)
            //{
            //    deckCards += $"{Card}\n";
            //}
            //MessageBox.Show(deckCards);
            Application.Run(new MainForm());
        }
    }
}