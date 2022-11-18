using NUnit.Framework;
namespace Tamagotchi
{
    [TestFixture]
    public class TamagotchiTest
    {

        [TestCase("Feed", "Hungriness Increase and Fullness Increase")]
        [TestCase("Play", "Happiness Increase and Tiredness Increase")]
        [TestCase("PutBed", "Tiredness Decrease")]
        [TestCase("Poop", "Fullness Decrease")]
        [TestCase("TimePass", "Tiredness Increase, Hungriness Increase and Happiness Decrease")]
        public void GetOutput_WhenCalled(string command, string res)
        {
            Assert.AreEqual(res,Tamagotchi(command));
        }

        public static string Tamagotchi(string command)
        {
            if (command == "Feed")
                return "Hungriness Increase and Fullness Increase";
            if (command == "Play")
                return "Happiness Increase and Tiredness Increase";
            if (command == "PutBed")
                return "Tiredness Decrease";
            if (command == "Poop")
                return "Fullness Decrease";
            if (command == "TimePass")
                return "Tiredness Increase, Hungriness Increase and Happiness Decrease";



            return "";
        }
    }
}