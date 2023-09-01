﻿using AnimeNotificationsBot.BLL.Interfaces.Repositories;
using AnimeNotificationsBot.Common.Interfaces;
using AnimeNotificationsBot.DAL;
using Microsoft.EntityFrameworkCore;

namespace AnimeNotificationsBot.BLL.Repositories.Base
{
    public class RemoveRepository<T> : Repository<T>, IRemoveRepository<T> where T :class, IRemoveEntity
    {
        public RemoveRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<T>> GetRangeWhereAsync(Func<IQueryable<T>, Task<List<T>>> selector, bool includingDeleted = false)
        {
            return await selector(Entity.Where(x => !includingDeleted || !x.IsRemoved));
        }

        public async Task<T?> GetFirstOrDefaultAsync(Func<IQueryable<T>, Task<T?>> selector, bool includingDeleted = false)
        {
            return await selector(Entity.Where(x => !includingDeleted || !x.IsRemoved));
        }

        public async Task<T> GetById(int id, bool includingDeleted = false)
        {
            var entity = await Entity.Where(x => !includingDeleted || !x.IsRemoved).FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null)
                throw CreateNotFoundEntityException(id);

            return entity;
        }

        public async Task<List<T>> GetAll(bool includingDeleted = false)
        {
            return await Entity.Where(x => !includingDeleted || !x.IsRemoved).ToListAsync();
        }

        public async Task RemoveById(int id, bool permanently = false)
        {
            var entity = await GetById(id);

            if (permanently)
                Entity.Remove(entity);
            else
                entity.IsRemoved = true;

        }
    }
}