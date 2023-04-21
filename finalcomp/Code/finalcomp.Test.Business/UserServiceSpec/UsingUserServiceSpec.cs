using NSubstitute;
using finalcomp.Test.Framework;
using finalcomp.BusinessServices.Services;
using finalcomp.Data.Interfaces;

namespace finalcomp.Test.Business.UserServiceSpec
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