using System;
using System.Collections.Generic;
using System.Text;
using ELibrary.Core.Entites;
using Microsoft.AspNetCore.Identity;

namespace ELibrary.Entities.Concrete
{
    public class ApplicationUser : IdentityUser, IEntity
    {
    }
}
