using System;

using SimpleCMenu.Menu;

namespace SimpleCMenu
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string headerText =
                Environment.NewLine + @" ____               " +
                Environment.NewLine + @"/\  _`\    " +
                Environment.NewLine + @"\ \,\L\_\      __   _ __    __       __   __  __    " +
                Environment.NewLine + @" \/_\__ \    /'__`\/\`'__\/'_ `\   /'__`\/\ \/\ \   " +
                Environment.NewLine + @"   /\ \L\ \ /\  __/\ \ \//\ \L\ \ /\  __/\ \ \_\ \ " +
                Environment.NewLine + @"   \ `\____\\ \____\\ \_\\ \____ \\ \____\\/`____ \ " +
                Environment.NewLine + @"    \/_____/ \/____/ \/_/ \/___L\ \\/____/ `/___/> \" +
                Environment.NewLine + @"                            /\____/           /\___/" +
                Environment.NewLine + @"                            \_/__/            \/__/ " +
               
                Environment.NewLine;



            

        

            // Setup the menu
            ConsoleMenu mainMenu = new ConsoleMenu("===");

            ConsoleMenu subMenu1 = new ConsoleMenu("==>");
            subMenu1.SubTitle = "---------------- Secret Menu -----------------";
            subMenu1.addMenuItem(0, "backToMain", subMenu1.hideMenu);
            subMenu1.ParentMenu = mainMenu;
            subMenu1.hideMenu();

            ConsoleMenu subMenu2 = new ConsoleMenu("++=>");
            subMenu2.SubTitle = "---------------- Secret Menu2 -----------------";
            subMenu2.addMenuItem(0, "backToMain", subMenu2.hideMenu);
            subMenu2.ParentMenu = mainMenu;
            subMenu2.hideMenu();

            ConsoleMenu subMenu3 = new ConsoleMenu("++=>");
            subMenu3.SubTitle = "---------------- Secret Menu3 -----------------";
            subMenu3.addMenuItem(0, "backToMain", subMenu3.hideMenu);
            subMenu3.addMenuItem(1, "324532", HelloWorld);
            subMenu3.ParentMenu = subMenu2;
            subMenu3.hideMenu();

            mainMenu.Header = headerText;
            subMenu1.Header = headerText;
            subMenu2.Header = headerText;

            mainMenu.SubTitle = "-------------------- Menu ----------------------";
            mainMenu.addMenuItem(0, "Hello World!", HelloWorld);
            mainMenu.addMenuItem(1, "Secret Menu", subMenu1.showMenu);
            mainMenu.addMenuItem(2, "Secret Menuuu", subMenu2.showMenu);
            mainMenu.addMenuItem(3, "Exit", Exit);

            subMenu2.addMenuItem(4, "ewtwtwt", subMenu3.showMenu);
            // Display the menu
            mainMenu.showMenu();

        }


        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void HelloWorld()
        {
            
            Console.WriteLine("Hello World!");
            Console.ReadLine(); 
        }
    }
}
