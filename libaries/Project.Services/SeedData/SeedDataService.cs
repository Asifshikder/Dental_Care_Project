using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Project.Core.Constants.Authentication;
using Project.Core.Domain.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.SeedData
{
    public class SeedDataService : ISeedDataService
    {
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public SeedDataService(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public async Task<bool> SeedCoreData()
        {
            try
            {
                bool already_configured = true;
                var roles = roleManager.Roles;
                if (!roles.Any())
                {
                    already_configured = false;
                    var roleconstants = new RoleConstants();
                    var roletiems = roleconstants.GetType().GetFields();
                    foreach (var item in roletiems)
                    {
                        string name = item.GetRawConstantValue().ToString();
                        ApplicationRole applicationRole = new ApplicationRole()
                        {
                            Name = name,
                        };
                        await roleManager.CreateAsync(applicationRole);
                    }
                }
                var users = userManager.Users.Any();
                if (!users)
                {
                    already_configured = false;
                    ApplicationUser applicationUser = new ApplicationUser()
                    {
                        Email = UserConstants.SysAdmin_Email,
                        UserName = UserConstants.SysAdmin_Email,
                        DisplayName = "System Admin",
                        DisplayImage = "",
                        PhoneNumber = ""
                    };
                    await userManager.CreateAsync(applicationUser, UserConstants.SysAdmin_Password);
                }
                return already_configured;
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
    }
}
