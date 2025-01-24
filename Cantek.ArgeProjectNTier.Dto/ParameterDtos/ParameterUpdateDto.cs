using Cantek.ArgeProjectNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Dtos
{
    public class ParameterUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
    }
}
