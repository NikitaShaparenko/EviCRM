using Microsoft.EntityFrameworkCore;

namespace EviCRM.Core.Db.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        void Create(List<TEntity> entities);
        TEntity? FindById(Guid id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Remove(List<TEntity> entities);
        void Update(TEntity item);
        void Update(List<TEntity> entities);
    }

    public class EntityFrameworkGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext _context;
        DbSet<TEntity> _dbSet;

        public EntityFrameworkGenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }
        public TEntity? FindById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public void Create(List<TEntity> entities)
        {
            foreach (var elem in entities)
                _dbSet.Add(elem);
            _context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            _context.Attach(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(List<TEntity> entities)
        {
            foreach (var elem in entities)
                _context.Attach(elem).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(TEntity item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public void Remove(List<TEntity> entities)
        {
            foreach (var elem in entities)
                _dbSet.Remove(elem);
            _context.SaveChanges();
        }
    }
}
