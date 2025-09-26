using System.Diagnostics;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Data.Repositories;
using Grocery.App.Views;
using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels
{
    public partial class RegisterViewModel : BaseViewModel
    {
        private readonly IAuthService _authService;
        private readonly GlobalViewModel _globalViewModel;
        private readonly ClientRepository _clientRepository;


        // private readonly IClientService _clientService;


        public RegisterViewModel(IAuthService authService, GlobalViewModel global, IClientRepository clientRepository)
        {
            _authService =  authService;
            _globalViewModel = global;
            _clientRepository = (ClientRepository?)clientRepository;
        }

        [ObservableProperty] private string name;
        [ObservableProperty] private string email;
        [ObservableProperty] private string password;

        [ObservableProperty]
        private string registerMessage;
        
        [RelayCommand]
        private async Task Register()
        {
            Trace.WriteLine("Register: Test 1");
            // Checks if all values are given
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Password))
            {
                RegisterMessage = "Please enter all the field";
                return;
            }
            Trace.WriteLine("Register: Test 2");
            // check if the email is correct 
            if (!Email.Contains("@"))
            {
                RegisterMessage = "Please enter a valid email address.";
                return;
            }
            Trace.WriteLine("Register: Test 3");

            // int Id = _clientService.CountClients();
            int Id = 4;
            Trace.WriteLine("Register: Test 4");
            
            Client newClient = new Client(Id, Name, Email, PasswordHelper.HashPassword(Password));
            Trace.WriteLine("Register: Test 5");
            
            Trace.WriteLine($"Name {Name}, Email {Email}, Password {Password}");
            // Client addedClient = _clientService.Add(newClient);
            _clientRepository.AddClientRepo(Name, Email, Password);
            Trace.WriteLine("Register: Test 6");

            GoToLogin();
            Trace.WriteLine("Register: Test 7");
        }
        
        [RelayCommand]
        private async Task GoToLogin()
        {
            
            var loginViewModel = new LoginViewModel(_authService, _globalViewModel, _clientRepository);
            Application.Current.MainPage = new LoginView(loginViewModel);
            
            
        }
        

    }
}