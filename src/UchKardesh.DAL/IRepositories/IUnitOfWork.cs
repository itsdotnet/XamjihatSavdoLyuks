using UchKardesh.Domain.Entities;

namespace UchKardesh.DAL.IRepositories;

public interface IUnitOfWork : IDisposable
{
    IRepository<User> UserRepository { get; }
    IRepository<Product> ProductRepository { get; }
    IRepository<Category> CategoryRepository { get; }
    IRepository<Session> SessionRepository { get; }
    IRepository<Attachment> AttachmentRepository { get; }
    Task<bool> SaveAsync();
}