﻿using ConnectedCamerasWeb.Models;
using ConnectedCamerasWeb.ViewModels.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ConnectedCamerasWeb.Infrastructure.Data
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}