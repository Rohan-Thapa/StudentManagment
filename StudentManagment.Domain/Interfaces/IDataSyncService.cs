using StudentManagment.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Domain.Interfaces;

public interface IDataSyncService
{
    /// <summary>
    /// Performs scheduled two-way synchronization for tables like Cart and Shop.
    /// </summary>
    Task SyncDatabasesAsync();

    /// <summary>
    /// Immediately synchronizes an updated User record.
    /// </summary>
    /// <param name="student">The student entity that was updated.</param>
    Task SyncUserAsync(Student student);
}

