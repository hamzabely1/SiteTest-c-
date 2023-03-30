using Api.FreeSide.Datas.Context.Contact;
using Api.FreeSide.Datas.Repository.Contact;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Api.FreeSide.Datas.Repository
{

    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected readonly IFreeSideContext _ifreeSideContext;

        private readonly DbSet<T> _table;

        public GenericRepository(IFreeSideContext _ifreeSideContext)
        {
            _ifreeSideContext = _ifreeSideContext;
            _table = _ifreeSideContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table.ToListAsync().ConfigureAwait(false);
        }


  
        public async Task<T> GetByKeyAsync(object id)
        {
            return await _table.FindAsync(id).ConfigureAwait(false);
        }

        public async Task<T> CreateElementAsync(T element)
        {
            var elementAdded = await _table.AddAsync(element).ConfigureAwait(false);
            await _ifreeSideContext.SaveChangesAsync().ConfigureAwait(false);

            return elementAdded.Entity;
        }
        public async Task<T> UpdateElementAsync(T element)
        {
            var elementUpdated = _table.Update(element);
            await _ifreeSideContext.SaveChangesAsync().ConfigureAwait(false);

            return elementUpdated.Entity;
        }


        public async Task<T> DeleteElementAsync(T element)
        {
            var elementDeleted = _table.Remove(element);
            await _ifreeSideContext.SaveChangesAsync().ConfigureAwait(false);

            return elementDeleted.Entity;
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }


        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }

   
}
