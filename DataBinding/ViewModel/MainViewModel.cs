using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace DataBinding.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Person> People { get; set; }
        public ICommand ShowPersonCommand { get; }

        public MainViewModel()
        {
            People = new ObservableCollection<Person>
            {
                new Person { Name = "Jan Kowalski" },
                new Person { Name = "Anna Nowak" },
                new Person { Name = "Julia Pomidor" },
                new Person { Name = "Tomasz Kaczyński" }
            };

            ShowPersonCommand = new Command<string>(ShowPerson);
        }

        private async void ShowPerson(string name)
        {
            if (Application.Current?.MainPage != null)
            {
                await Application.Current.MainPage.DisplayAlert("Wybrana osoba", $"Witaj, {name}!", "OK");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
