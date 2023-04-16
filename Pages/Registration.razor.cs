using GameMaster.UI.Models;
using Microsoft.AspNetCore.Components;
using GameMaster.Data.Services;
using GameMaster.Data.Models;
using System;


namespace GameMaster.UI.Pages
{
    public partial class Registration : ComponentBase
    {
        private UserViewModel _newUser = new UserViewModel();
        [Inject] private IUserServices _services { get; init; }
        private async Task _handleRegister()
        {
            UserModel _user = new()
            {
                Username = _newUser.Username,
                Password = _newUser.Password,
            };

            await _services.InsertUser(_user); 
        }
    }
}
