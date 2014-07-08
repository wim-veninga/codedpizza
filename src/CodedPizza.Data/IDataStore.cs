using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodedPizza.Data
{

	public class IDataStore<TEntity, TKey>
	{

		Task<TEntity> Get(TKey key);
		Task<TEntity> Add(TEntity entity);
		Task<TEntity> Delete(TEntity entity);
		Task<IEnumerable<TEntity>> Find(Func<TEntity, bool> predicate, int pageNumber, int pageSize);

	}

}
