namespace CleanArchitecture.Domain.Repositories;

public interface IUserRepository
{
    Task<int> AddAsync(User user);
    Task<int> UpdateAsync(User user);
    Task<IEnumerable<User>> GetAllAsync();
}