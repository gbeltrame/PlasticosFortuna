using Blazored.SessionStorage;
using PlasticosFortuna.Shared;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PlasticosFortuna.UI.Services
{
    public interface IUserService
    {
        Task<UserModel> LoginAsync(UserModel user);
    }
}