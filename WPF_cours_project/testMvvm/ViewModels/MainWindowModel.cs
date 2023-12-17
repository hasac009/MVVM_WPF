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

        //#region Коллекция кнопок
        //private ObservableCollection<Button> buttons= new ObservableCollection<Button>();

        //public ObservableCollection<Button> Buttons
        //{
        //    get => buttons;
        //    set => Set(ref buttons, value);
        //}
        
        //#endregion

        #endregion
        
        #region Команды

        public ICommand CreatAddWindowCommand { get; set; }

        private bool CanCreatAddWindowCommandExecute(object o) => true;
        
        private void OnCreatAddWindowCommandExecute(object o)
        {
            
            AddWindow addWindow = new AddWindow(dbTools);
            addWindow.Show();
            
        }


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
            LoadDbCommand = new LambdaCommand(OnLoadDbCommandExecute, CanLoadDbCommandExecute);
            

        }
        



        
    }
}
