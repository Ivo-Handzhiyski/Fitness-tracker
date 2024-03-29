﻿using Fitness_Tracker.Models;

namespace Fitness_Tracker.Repository.IRepository
{
    public interface IBodyRepository : IRepository<Body>
    {
        void Update(Body obj);

        public Body GetUserBody(string userId);

        public void SaveChanges();
    }
}
