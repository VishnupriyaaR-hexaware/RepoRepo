using NSubstitute;
using compsdotnet.Test.Framework;
using compsdotnet.BusinessServices.Services;
using compsdotnet.Data.Interfaces;

namespace compsdotnet.Test.Business.UserServiceSpec
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