// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserRepository.cs" company="Exit Games GmbH">
//   Copyright (c) Exit Games GmbH.  All rights reserved.
// </copyright>
// <summary>
//   Defines the UserRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ExitGames.Web.Sample.Services
{
    public class UserRepository : IUserRepository
    {
        public bool CheckUserID(string ID)
        {
            throw new System.NotImplementedException();
        }

        public bool VerifyUser(string ID, string token)
        {
            throw new System.NotImplementedException();
        }
    }
}