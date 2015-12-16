

namespace Ticket.Interfaces.Data
{
    using System.Linq.Expressions;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IRepository<T> where T : class
        {
            /// <summary>
            /// The delete.
            /// </summary>
            /// <param name="entity">
            /// The entity.
            /// </param>
            void Delete(T entity);

            /// <summary>
            /// The delete.
            /// </summary>
            /// <param name="id">
            /// The id.
            /// </param>
            void Delete(int id);

            /// <summary>
            /// The get.
            /// </summary>
            /// <param name="filter">
            /// The filter.
            /// </param>
            /// <param name="orderBy">
            /// The order by.
            /// </param>
            /// <returns>
            /// The <see cref="IEnumerable{T}">List of Objects
            /// </returns>
            IEnumerable<T> Get(
                Expression<Func<T, bool>> filter = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

            /// <summary>
            /// The get by id.
            /// </summary>
            /// <param name="id">
            /// The id.
            /// </param>
            /// <returns>
            /// The <see cref="T"/>.
            /// </returns>
            T GetById(int id);

            /// <summary>
            /// The insert.
            /// </summary>
            /// <param name="entity">
            /// The entity.
            /// </param>
            void Insert(T entity);

            /// <summary>
            /// The update.
            /// </summary>
            /// <param name="entity">
            /// The entity.
            /// </param>
            void Update(T entity);
    }
}
