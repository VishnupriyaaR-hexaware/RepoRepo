using NSubstitute;
using DotnetSixApp.Test.Framework;
using DotnetSixApp.BusinessServices.Services;
using DotnetSixApp.Data.Interfaces;

namespace DotnetSixApp.Test.Business.UserServiceSpec
{
    public abstract class UsingUserServiceSpec : SpecFor<UserService>
    {
        protected IUserRepository _userRepository;

        public override void Context()
        {
            _userRepository = Substitute.For<IUserRepository>();
            subject = new UserService(_userRepository);

        }

    }
}