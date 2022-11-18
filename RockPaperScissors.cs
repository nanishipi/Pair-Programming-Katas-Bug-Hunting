using NUnit.Framework;
namespace RockPapperScissors
{
    [TestFixture]
    public class RockPapperSciorsTest
    {

        [TestCase("Rock", "Paper", "Player2 Wins")]
        [TestCase("Rock", "Scissors", "Player1 Wins")]
        [TestCase("Paper", "Rock", "Player1 Wins")]
        [TestCase("Paper", "Scissors", "Player2 Wins")]
        [TestCase("Scissors", "Rock", "Player2 Wins")]
        [TestCase("Scissors", "Paper", "Player1 Wins")]

        [TestCase("Rock", "Rock", "Draw")]
        [TestCase("Paper", "Paper", "Draw")]
        [TestCase("Scissors", "Scissors", "Draw")]
        public void GetOutput_WhenCalled(string player1, string player2, string res)
        {
            Assert.AreEqual(res, RPC(player1, player2));
        }

        public static string RPC(string player1, string player2)
        {
            if (player1 == "Rock" && player2 == "Paper")
                return "Player2 Wins";
            if (player1 == "Rock" && player2 == "Scissors")
                return "Player1 Wins";
            if (player1 == "Paper" && player2 == "Rock")
                return "Player1 Wins";
            if (player1 == "Paper" && player2 == "Scissors")
                return "Player2 Wins";
            if (player1 == "Scissors" && player2 == "Rock")
                return "Player2 Wins";
            if (player1 == "Scissors" && player2 == "Paper")
                return "Player1 Wins";
            if (player1 == player2)
                return "Draw";

            return "";
        }
    }
}
