﻿using Cantek.ArgeProjectNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Dtos
{
    public class GenderUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string GenderType { get; set; }
    }
}
