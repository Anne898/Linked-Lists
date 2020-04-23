using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linked_Lists
{
    class Menu
    {
        private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;

        List<int> mainMenuOptions = new List<int>(new int[] { 1, 2, 3, 9 }); //opciones del menu

        List<int> OptionsPiso1 = new List<int>(new int[] { 2, 3, 9 });

        List<int> OptionsPiso2 = new List<int>(new int[] { 1, 3, 9 });

        List<int> OptionsPiso3 = new List<int>(new int[] { 1, 2, 9 });


        LinkedList<string> elevador = new LinkedList<string>(new string[] { "Piso 1", "Piso 2", "Piso 3" });


        private void DisplayWelcomeMessage()
        { //mensaje de bienvenida
            System.Console.WriteLine("Elevador");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions()
        { //menu
            System.Console.WriteLine("2) Piso 1");
            System.Console.WriteLine("3) Piso 2");
            System.Console.WriteLine("4) Piso 3");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplayByeMessage()
        { //mensaje de despedida
            System.Console.WriteLine("¡Hasta luego!");
        }

        private int RequestOption(List<int> validOptions)
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida...
            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        private void DisplayMessage()
        {
            System.Console.WriteLine("¿En qué piso esta?");
            System.Console.WriteLine();
        }

        private void DisplayMessagePisos()
        {
            System.Console.WriteLine("Seleccione un piso");
            System.Console.WriteLine();
        }

        private void Pisos1()
        {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION)
            {
                DisplayMessagePisos();
                selectedOption = RequestOption(OptionsPiso1);

                switch (selectedOption)
                {

                    case 2:

                        elevador.Remove(elevador.Last);

                        foreach (string i in elevador)
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine("LLegaste al piso 3");


                        break;

                    case 3:

                        foreach (string i in elevador)
                        {
                            Console.WriteLine(i);
                        }


                        Console.WriteLine("LLegaste al piso 3");


                        break;

                    case 9:
                        selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                        // default:
                }
            }

            DisplayByeMessage();

        }




        private void Pisos2()
        {

            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION)
            {
                DisplayMessagePisos();
                selectedOption = RequestOption(OptionsPiso2);

                switch (selectedOption)
                {

                    case 1:
                         elevador.Remove(elevador.Last);
                         elevador.Reverse();

                        foreach (string i in  elevador.Reverse())
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine("LLegaste al piso 1");


                        break;

                    case 3:

                        elevador.Remove(elevador.First);


                        foreach (string i in elevador)
                        {
                            Console.WriteLine(i);
                        }


                        Console.WriteLine("LLegaste al piso 3");


                        break;

                    case 9:
                        selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                        // default:
                }
            }

            DisplayByeMessage();

        }


        private void Pisos3()
        {

            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION)
            {
                DisplayMessagePisos();
                selectedOption = RequestOption(OptionsPiso3);

                switch (selectedOption)
                {

                    case 1:

                        elevador.Reverse();

                        foreach (string i in elevador.Reverse())
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine("LLegaste al piso 1");

                        break;



                    case 2:

                        elevador.Remove(elevador.First);
                        elevador.Reverse();

                        foreach (string i in elevador.Reverse())
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine("LLegaste al piso 2");

                        break;

                    case 9:
                        selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                        // default:
                }
            }

            DisplayByeMessage();

        }


        public void Display()
        {
            int selectedOption = 0;

            DisplayMessage();


            while (selectedOption != MAIN_MENU_EXIT_OPTION)
            {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1: //Tipo de cono
                        Pisos1();
                        break;

                    case 2:
                        Pisos2();
                        break;

                    case 3:
                        Pisos3();
                        break;

                    case 9:
                        selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                        // default:
                }
            }

            DisplayByeMessage();

        }

    }
}
