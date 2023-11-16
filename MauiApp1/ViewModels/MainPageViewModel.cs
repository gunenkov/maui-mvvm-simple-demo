using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace MauiApp1.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            ((Command)AddCommand).ChangeCanExecute();
        }

        private ObservableCollection<Person> _persons = new ObservableCollection<Person>();

        private string name;
        private int age;

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Person> Persons
        {
            get => _persons;
            set
            {
                if (_persons != value)
                {
                    _persons = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainPageViewModel() 
        {
            AddCommand = new Command(() =>
            {
                this._persons.Add(new Person
                {
                    Name = name,
                    Age = age
                });
            }, () => Person.Validate(age));

            DeleteCommand = new Command((object parameter) =>
            {
                var person = (Person)parameter;
                this._persons.Remove(person);
            });
        }
    }
}
