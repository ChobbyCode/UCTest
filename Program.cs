using Update_Checker;

namespace UCTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Updater();
            Console.ReadLine();
        }

        public static async void Updater()
        {
            UpdateChecker updateChecker = new UpdateChecker();

            updateChecker.OWNERNAME = "ChobbyCode";
            updateChecker.REPONAME = "Update-Checker";

            string currentVersion = "v0.1.0";

            bool isUpdate = await updateChecker.CheckForUpdates(currentVersion);

            if(isUpdate)
            {
                // Do update stuff here
                Console.WriteLine("There is an update");
            }
        }
    }
}