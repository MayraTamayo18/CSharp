﻿using Entity.Dto;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUserRoleData
    {
        public Task Delete(int id);
        public Task<UserRole> GetById(int id);
        public Task<UserRole> Save(UserRole entity);
        public Task Update(UserRole entity);
        public Task<IEnumerable<UserRole>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect()
    }
}
