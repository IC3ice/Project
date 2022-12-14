using System;

class Program
    {
        static MainMenu mainMenu = new MainMenu();

        static void Main(string[] args) {
            Console.Clear();
            PrepareMainMenuControllerWhenProgramIsLoaded();

            ShowMainMenuScreen();
        }

        static void PrepareMainMenuControllerWhenProgramIsLoaded() {
            mainMenu.ShowMainMenuScreen();
        }

        static void ShowMainMenuScreen() {
            Program.mainMenu.ShowMainMenuScreen();
    }
}
