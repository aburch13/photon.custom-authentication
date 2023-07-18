// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientAuthenticationService.cs" company="Exit Games GmbH">
//   Copyright (c) Exit Games GmbH.  All rights reserved.
// </copyright>
// <summary>
//   Defines the ClientAuthenticationService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ExitGames.Web.Sample.Services
{
    public class ClientAuthenticationService : IClientAuthenticationService
    {
        private readonly IUserRepository userRepository;

        public ClientAuthenticationService()
            : this(null)
        {
        }

        public ClientAuthenticationService(IUserRepository repository)
        {
            this.userRepository = repository ?? new UserRepository();
        }

        public int Authenticate(string userName, string token)
        {
            // TODO use repository to get user and authenticate
            if(userRepository.CheckUserID(userName))
            {
                if (userRepository.VerifyUser(userName, token))
                    return 0;
                else
                    return 1;
            }

            return 2;
        }
    }
}