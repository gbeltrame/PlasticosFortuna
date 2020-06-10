using PlasticosFortuna.Shared;

namespace PlasticosFortuna.Data.Repositories
{
    public interface IUserRepository
    {
        UserModel GetLoginUser(UserModel user);
    }
}