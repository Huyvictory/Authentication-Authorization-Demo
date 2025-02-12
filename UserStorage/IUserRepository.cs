namespace UserStorage
{
    public interface IUserRepository
    {
        public Task<User?> FindByUserNameAsync(string userName);
        public Task SaveAsync(User user);
    }
}