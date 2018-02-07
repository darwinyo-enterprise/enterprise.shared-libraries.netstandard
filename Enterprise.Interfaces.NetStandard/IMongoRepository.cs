using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Interfaces.NetStandard
{
    public interface IMongoRepository<TCollection> where TCollection : class
    {
        Task AddAsync(IMongoCollection<TCollection> context, TCollection entity);
        Task<long> CountByAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query);
        Task<IEnumerable<TCollection>> FindByAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query);
        Task<IEnumerable<TCollection>> GetAllAsync(IMongoCollection<TCollection> context);
        Task<TCollection> GetSingleAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query);
        Task<UpdateResult> UpdateOneAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query, UpdateDefinition<TCollection> update);
        Task<UpdateResult> UpdateManyAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query, UpdateDefinition<TCollection> update);
        Task<ReplaceOneResult> ReplaceOrInsertOneAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query, TCollection entity);
        Task<DeleteResult> DeleteOneAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query);
        Task<DeleteResult> DeleteManyAsync(IMongoCollection<TCollection> context, Expression<Func<TCollection, bool>> query);
    }
}
