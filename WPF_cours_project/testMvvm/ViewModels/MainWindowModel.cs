using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using testMvvm.ViewModels.Base;
using testMvvm.View.Windows;
using testMvvm.Infrastructure.Commands;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using testMvvm.Model;
using System.Windows;
using testMvvm.View;
using testMvvm.View.UserControllers;
using System.Reflection;
using System.Diagnostics;

namespace testMvvm.ViewModels
{
    internal class MainWindowModel : ViewModel
    {
        #region Властивості
        
        private static string connectString = $"Host=localhost;Database=MyTestBase;Username=postgres;Password=123";
        Gareg cars = new Gareg(connectString);
        Office drivers = new Office(connectString); 
        Storage SparePart = new Storage(connectString);
       


        private UserControl _ShowControler = new EmptyControl();

        public UserControl ShowControler
        {
            get => _ShowControler;
            set => Set(ref _ShowControler, value);
        }

        #endregion

        #region Команди
        #region showCarController 
        public ICommand showCarController { get; set; }

        private bool CanshowCarControllerCommandExecute(object o) => true;

        private void OnshowCarControllerCommandExecute(object o)
        {
            ShowControler = new ListCarController(cars);
            

        }
        #endregion

        #region showSpController 
        public ICommand showSpController { get; set; }

        private bool CanshowSpControllerCommandExecute(object o) => true;

        private void OnshowSpControllerCommandExecute(object o)
        {
            ShowControler = new SPControler(SparePart);


        }
        #endregion

        #region showDriverController 
        public ICommand showDriverController { get; set; }

        private bool CanshowDriverControllerCommandExecute(object o) => true;

        private void OnshowDriverControllerCommandExecute(object o)
        {
            ShowControler = new DriverControler(drivers);

        }
        #endregion



        #region addCars 
        public ICommand CreatAddWindowCommand { get; set; }

        private bool CanCreatAddWindowCommandExecute(object o) => true;

        private void OnCreatAddWindowCommandExecute(object o)
        {

            AddWindow addWindow = new AddWindow(cars,drivers);
            addWindow.Show();

        }
        #endregion

        #region delCar 
        public ICommand delCarCommand { get; set; }

        private bool CandelCarCommandExecute(object o) => true;

        private void OndelCarCommandExecute(object o)
        {
            string content = o.ToString();
            Debug.WriteLine(content.Substring(content.IndexOf('№') + 1).Trim());
            cars.del(content.Substring(content.IndexOf('№') + 1).Trim());
            cars.GetAll();

        }
        #endregion

        #region upgradeCar 
        public ICommand upgradeCarCommand { get; set; }

        private bool CanupgradeCarCommandExecute(object o) => true;

        private void OnupgradeCarCommandExecute(object o)
        {
            string content = o.ToString();
            string numberCar = content.Substring(content.IndexOf('№') + 1).Trim();
            UpdateCarWindow window = new UpdateCarWindow(cars.GetCar(numberCar), cars, drivers);
            window.Show();

        }
        #endregion

        #region addDrivers
        public ICommand CreatAddWindowDriversCommand { get; set; }

        private bool CanCreatAddWindowDriversCommandExecute(object o) => true;

        private void OnCreatAddWindowDriversCommandExecute(object o)
        {

            AddWindowDrivers Window = new AddWindowDrivers(drivers);
            Window.Show();

        }
        #endregion

        #region addSP
        public ICommand CreatAddWindowSPCommand { get; set; }

        private bool CanCreatAddWindowSPCommandExecute(object o) => true;

        private void OnCreatAddWindowSPCommandExecute(object o)
        {

            AddWindowStorage addWindow = new AddWindowStorage(SparePart);
            addWindow.Show();
           
            

        }
        #endregion


        

        #region InfoCarWindow
        public ICommand CreatInfoCarWindow { get; set; }

        private bool CanCreatInfoCarWindowExecute(object o) => true;

        private void OnCreatInfoCarWindowExecute(object o)
        {
            if (o is string textButton)
            {
                Car car = cars.GetCar(textButton); 
                SparePart.GetPartsByCarId(car.Id);
                InfoCarWindow carWindow = new InfoCarWindow(car, SparePart);
                carWindow.Show();
            }

        }
        #endregion

        public ICommand LoadDbCommand { get; set; }

        private bool CanLoadDbCommandExecute(object o) => true;

        private void OnLoadDbCommandExecute(object o)
        {

           
             

        }



        #endregion
        public MainWindowModel()
        {
            
            CreatAddWindowCommand = new LambdaCommand(OnCreatAddWindowCommandExecute, CanCreatAddWindowCommandExecute);
            CreatAddWindowDriversCommand = new LambdaCommand(OnCreatAddWindowDriversCommandExecute, CanCreatAddWindowDriversCommandExecute);
            CreatAddWindowSPCommand = new LambdaCommand(OnCreatAddWindowSPCommandExecute, CanCreatAddWindowSPCommandExecute);
            CreatInfoCarWindow = new LambdaCommand(OnCreatInfoCarWindowExecute, CanCreatInfoCarWindowExecute);

            LoadDbCommand = new LambdaCommand(OnLoadDbCommandExecute, CanLoadDbCommandExecute);

            showCarController = new LambdaCommand(OnshowCarControllerCommandExecute,CanshowCarControllerCommandExecute);
            showSpController = new LambdaCommand(OnshowSpControllerCommandExecute, CanshowSpControllerCommandExecute);
            showDriverController = new LambdaCommand(OnshowDriverControllerCommandExecute, CanshowDriverControllerCommandExecute);

            delCarCommand = new LambdaCommand(OndelCarCommandExecute, CandelCarCommandExecute);
            upgradeCarCommand = new LambdaCommand(OnupgradeCarCommandExecute,CanupgradeCarCommandExecute);
        }
        



        
    }
}
