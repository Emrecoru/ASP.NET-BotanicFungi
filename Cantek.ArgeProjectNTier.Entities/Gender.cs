﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Entities
{
    public class Gender : BaseEntity
    {
        public string GenderType { get; set; }

        public List<AppUser> AppUsers { get; set; }
    }
}
