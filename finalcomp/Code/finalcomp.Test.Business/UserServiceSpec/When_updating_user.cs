using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using finalcomp.BusinessEntities.Entities;


namespace finalcomp.Test.Business.UserServiceSpec
{
    public class When_updating_user : UsingUserServiceSpec
    {
        private User _result;
        private User _user;

        public override void Context()
        {
            base.Context();

            _user = new User
            {
                UserId = 16,
                UserName = "UserName",
                UserAge = 10,
                UserPresent = "UserPresent"
            };

            _userRepository.Update(_user.Id, _user).Returns(_user);
            
        }
        public override void Because()
        {
            _result = subject.Update(_user.Id, _user);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _userRepository.Received(1).Update(_user.Id, _user);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<User>();

            _result.ShouldBe(_user);
        }
    }
}