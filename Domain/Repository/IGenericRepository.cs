﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        /// <summary>
        /// Asynchronously get and entity by id. Where TEntity is a class that represents the database domain entity.
        /// If the entity loaded on the entity framework context it will be returned, if the context does not contains it
        /// the entity will be loaded on the context.
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the entity, otherwise null if the entity was not found.
        /// </returns>
        Task<TEntity> GetByIdAsync(object id);

        /// <summary>
        /// Asynchronously get a list of entity. Where TEntity is a class that represents the database domain entity.
        /// If the entity loaded on the entity framework context it will be returned, if the context does not contains it
        /// the entity will be loaded on the context.
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>
        /// A task that represents the asynchronous operation. 
        /// The task result contains the IEnumerable of entities, otherwise null if nothing was found.
        /// </returns>
        Task<IEnumerable<TEntity>> GetAll();
    }
}
