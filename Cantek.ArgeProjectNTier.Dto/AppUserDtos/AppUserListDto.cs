﻿using Cantek.ArgeProjectNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Dtos
{
    public class AppUserListDto : IDto
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int GenderId { get; set; }
    }
}
