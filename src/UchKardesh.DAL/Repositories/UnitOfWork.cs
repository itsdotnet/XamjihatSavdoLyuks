using UchKardesh.DAL.Constexts;
using UchKardesh.DAL.IRepositories;
using UchKardesh.DAL.Repositories;
using UchKardesh.Domain.Entities;

namespace UchKardesh.DAL.Repository;

public class UnitOfWork : IUnitOfWork
{

    private readonly AppDbContext dbContext;

    public UnitOfWork(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        UserRepository = new Repository<User>(dbContext);
        ProductRepository = new Repository<Product>(dbContext);
        AttachmentRepository = new Repository<Attachment>(dbContext);
        CategoryRepository = new Repository<Category>(dbContext);
        SessionRepository = new Repository<Session>(dbContext);
    }

    public IRepository<User> UserRepository { get; }

    public IRepository<Product> ProductRepository { get; }

    public IRepository<Attachment> AttachmentRepository { get; }

    public IRepository<Category> CategoryRepository { get; }

    public IRepository<Session> SessionRepository { get; }

    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }

    public async Task<bool> SaveAsync()
    {
        return await dbContext.SaveChangesAsync() > 0;
    }
}