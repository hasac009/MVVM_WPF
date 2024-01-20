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

namespace testMvvm.ViewModels
{
    internal class MainWindowModel : ViewModel
    {
        #region Свойства
        DbTools dbTools = new DbTools("localhost", "MyTestBase", "postgres", "123");


        #region Заголовок окна

        private string _Title = "Мой заголовок";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion

        

        #endregion

        #region Команды


        #region addCars 
        public ICommand CreatAddWindowCommand { get; set; }

        private bool CanCreatAddWindowCommandExecute(object o) => true;

        private void OnCreatAddWindowCommandExecute(object o)
        {

            AddWindow addWindow = new AddWindow(dbTools);
            addWindow.Show();

        }
        #endregion

        #region addDrivers
        public ICommand CreatAddWindowDriversCommand { get; set; }

        private bool CanCreatAddWindowDriversCommandExecute(object o) => true;

        private void OnCreatAddWindowDriversCommandExecute(object o)
        {

            AddWindowDrivers Window = new AddWindowDrivers(dbTools);
            Window.Show();

        }
        #endregion

        #region addSP
        public ICommand CreatAddWindowSPCommand { get; set; }

        private bool CanCreatAddWindowSPCommandExecute(object o) => true;

        private void OnCreatAddWindowSPCommandExecute(object o)
        {

            AddWindowStorage addWindow = new AddWindowStorage(dbTools);
            addWindow.Show();

        }
        #endregion




        #region InfoCarWindow
        public ICommand CreatInfoCarWindow { get; set; }

        private bool CanCreatInfoCarWindowExecute(object o) => true;

        private void OnCreatInfoCarWindowExecute(object o)
        {

            AddWindowStorage addWindow = new AddWindowStorage(dbTools);
            addWindow.Show();

        }
        #endregion

        public ICommand LoadDbCommand { get; set; }

        private bool CanLoadDbCommandExecute(object o) => true;

        private void OnLoadDbCommandExecute(object o)
        {

           dbTools = new DbTools("localhost", "MyTestBase", "postgres", "123");
            

        }

        #endregion
        public MainWindowModel()
        {
            
            CreatAddWindowCommand = new LambdaCommand(OnCreatAddWindowCommandExecute, CanCreatAddWindowCommandExecute);
            CreatAddWindowDriversCommand = new LambdaCommand(OnCreatAddWindowDriversCommandExecute, CanCreatAddWindowDriversCommandExecute);
            CreatAddWindowSPCommand = new LambdaCommand(OnCreatAddWindowSPCommandExecute, CanCreatAddWindowSPCommandExecute);
            CreatInfoCarWindow = new LambdaCommand(OnCreatInfoCarWindowExecute, CanCreatInfoCarWindowExecute);

            LoadDbCommand = new LambdaCommand(OnLoadDbCommandExecute, CanLoadDbCommandExecute);
            

        }
        



        
    }
}
