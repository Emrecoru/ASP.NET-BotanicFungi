using AutoMapper;
using Cantek.ArgeProjectNTier.Business.Mappings.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.Helpers
{
    public class ProfileHelper
    {
        public static List<Profile> GetProfiles()
        {
            return new List<Profile>
            {
                new RoomProfile(),
                new ParameterProfile(),
                new RoomStatusProfile(),
                new AppUserProfile(),
                new GenderProfile(),
                new AppRoleProfile(),
            };
        }
    }
}
