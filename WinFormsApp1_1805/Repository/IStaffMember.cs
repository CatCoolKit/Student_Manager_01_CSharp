﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IStaffMember
    {
        StaffMember Login(string email, string password);
        StaffMember GetById(int id);
    }
}