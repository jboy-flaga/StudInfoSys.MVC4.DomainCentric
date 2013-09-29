using StudInfoSys.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudInfoSys.Infrastructure.Data.RegistrationBoundedContext
{
    public interface IRegistrationsContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Registration> Registrations { get; set; }
    }
}
