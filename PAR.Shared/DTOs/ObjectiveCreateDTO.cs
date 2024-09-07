using PAR.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class ObjectiveCreateDTO
    {
        public string? Objective { get; set; }
        public int Status { get; set; } = (int)WorkplanStatus.Draft;
    }
}
