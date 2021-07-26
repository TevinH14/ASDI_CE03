using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_CE03
{

    class Main
    {
        private Menu _menu = new Menu();
        private Car _currentCar=null;
        private static Logger _logger = null;

        public Main()
        {
            _menu = new Menu("Disable Logging", "Enable Logging", "create car", "Drive The Car", "Destroy car", "Exit");
            _menu.Title = "Looging";
            Display();
        }
        public static Logger GetLogger()
        {
            return _logger;
        }
        private void Display()
        {
            Console.Clear();
            _menu.Display();
            SelectOption();
        }
        private void SelectOption()
        {
            switch (Utility.IntValidate("\nPlease make a selection"))
            {
                case 1:
                    DisableLogging();
                    break;
                case 2:
                    EnableLogging();
                    break;
                case 3:
                    if ( _logger == null) { Console.WriteLine("please create a car."); Console.ReadKey(); Display(); }
                    else { CreateCar(); }
                    break;
                case 4:
                    if (_currentCar == null) { Console.WriteLine("please create a car."); Console.ReadKey(); Display(); }
                    else { DriveCar(); }
                    break;
                case 5:
                    if (_currentCar == null) { Console.WriteLine("please create a car."); Console.ReadKey(); Display(); }
                    else { DestroyCar(); }
                    break;
                case 6:
                    Exit();
                    break;
                default:
                    SelectOption();
                    break;
            }


        }
        private void DisableLogging()
        {
            Console.Clear();
            _logger = new DoNotLog();
            Console.WriteLine("Logger disable");
            Console.WriteLine("\r\nPress enter to main menu.\r\n");
            Console.ReadKey();
            Display();
        }
        private void EnableLogging()
        {
            Console.Clear();
            _logger = new LogToConsole();
            Console.WriteLine("Logger enable");
            Console.WriteLine("\r\nPress enter to main menu.\r\n");
            Console.ReadKey();
            Display();
        }
        private void CreateCar()
        {
            Console.Clear();
            string make = Utility.StringValidate("Enter car make");
            GetLogger().LogD($"\r\n{make}");
            string model = Utility.StringValidate("\r\nEnter car model");
            GetLogger().LogD($"\r\n{model}");
            string color = Utility.StringValidate("\r\nEnter car color");
            GetLogger().LogD($"\r\n{color}");
            float mileage = Utility.FloatValidate("\r\nEnter car mileage");
            GetLogger().LogD($"\r\n{ mileage}");
            int year = Utility.IntValidate("\r\nEnter car year\r\n");
            GetLogger().LogD($"\r\n{ year}");
            _currentCar = new Car(make, model, color, mileage, year);
            GetLogger().LogD("\r\nCar have been created");
            GetLogger().LogD("\r\n_currentCar = myCar");
            //test
            //Console.WriteLine(_currentCar.Mileage);
            Console.ReadKey();
            Display();
        }
        private void DriveCar()
        {
            Console.Clear();
            float mileageUpdate = Utility.FloatValidate("Please enter the miles you will drive\r\n");
            GetLogger().LogD($"\r\n typed respones {mileageUpdate}\r\n");
            _currentCar.Drive(mileageUpdate);
            GetLogger().LogD("The current car method Drive have have been ran and Mileage have been update");
            Console.WriteLine($"your current mileage is {_currentCar.Mileage}");
            GetLogger().LogW($"\r\n Mileage have been update {_currentCar.Mileage}");
            Console.ReadKey();
            Display();
        }
        private void DestroyCar()
        {
            Console.Clear();
            _currentCar = null;
            Console.WriteLine("car destroyed\r\n");
            Console.WriteLine("press enter to return to main menu\r\n");
            Console.ReadKey();
            Display();
        }      
        private void Exit()
        {
            Console.Clear();
            Console.WriteLine("GOODBYE!!!!");
            Environment.Exit(0);
            Console.ReadKey();
        }
    }
}
