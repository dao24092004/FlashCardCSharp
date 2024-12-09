using FlashCard.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Model
{
    internal interface IUserProfileService
    {
        public ModelUserProfile GetAllById(int userId);
        public bool SaveProfile(ModelUserProfile modelUserProfile, int userId);
    }
}
