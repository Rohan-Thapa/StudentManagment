using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Domain.Interfaces;

public interface IHasLastUpdated
{
    DateTime LastUpdated { get; set; }
}
