﻿using System;

public class IRepositoryBase<TEntity> where TEntity : class
{
    void Add(TEntity entity);

    void AddAll(List<TEntity> entity);

    void Edit(TEntity entity);

    void Delete(TEntity entity);

    void DeleteAll(Expression<Func<TEntity, bool>> filter = null);

    List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
}
