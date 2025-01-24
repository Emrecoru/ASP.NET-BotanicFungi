using Cantek.ArgeProjectNTier.DataAccess.Contexts;
using Cantek.ArgeProjectNTier.DataAccess.Interfaces;
using Cantek.ArgeProjectNTier.DataAccess.Repositories;
using Cantek.ArgeProjectNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly BotanicFungiContext _context;

        public Uow(BotanicFungiContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
