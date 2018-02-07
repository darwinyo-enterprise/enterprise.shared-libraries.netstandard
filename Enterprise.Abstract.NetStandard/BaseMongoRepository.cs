using Enterprise.Interfaces.NetStandard;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Enterprise.Abstract.NetStandard
{
    public class BaseMongoRepository<TCollection> : IMongoRepository<TCollection> where TCollection : class
    {
        public virtual async Task AddAsync(IMongoCollection<TCollection> context, TCollection entity)
        {
            await context.InsertOneAsync(entity);
        }

        public virtual async Task<long> CountByAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query)
        {
            return await context.CountAsync(query);
        }

        public virtual async Task<IEnumerable<TCollection>> FindByAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query)
        {
            return await context.Find(query).ToListAsync();
        }

        public virtual async Task<IEnumerable<TCollection>> GetAllAsync(IMongoCollection<TCollection> context)
        {
            return await context.AsQueryable().ToListAsync();
        }

        public virtual async Task<TCollection> GetSingleAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query)
        {
            return await context.Find(query).FirstOrDefaultAsync();
        }

        public virtual async Task<UpdateResult> UpdateOneAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query, UpdateDefinition<TCollection> update)
        {
            return await context.UpdateOneAsync(query, update);
        }
        public virtual async Task<UpdateResult> UpdateManyAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query, UpdateDefinition<TCollection> update)
        {
            return await context.UpdateManyAsync(query, update);
        }

        public virtual async Task<ReplaceOneResult> ReplaceOrInsertOneAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query, TCollection entity)
        {
            return await context.ReplaceOneAsync(query, entity, new UpdateOptions
            {
                IsUpsert = true
            });
        }

        public virtual async Task<DeleteResult> DeleteOneAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query)
        {
            return await context.DeleteOneAsync(query);
        }

        public virtual async Task<DeleteResult> DeleteManyAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query)
        {
            return await context.DeleteManyAsync(query);
        }
    }
}
