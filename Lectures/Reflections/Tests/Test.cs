using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sample;
using Sample.Commands;

namespace Tests
{
    [TestFixture]
    public class Test
    {
        private CommandDispatcher dispatcher;

        [SetUp]
        public void SetUp()
        {
            this.dispatcher = new CommandDispatcher();
        }

        [Test]
        public void ShouldAdd()
        {
            var result = this.dispatcher.Execute(new AddTwoNumbers(2, 3));

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void ShouldRegisterUserAsAdminUser()
        {
            var result = this.dispatcher.Execute(new RegisterUser("admin", "newUser", "pass"));

            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldNotRegisterUserAsNormalUser()
        {
            Assert.That(() => this.dispatcher.Execute(new RegisterUser("normal", "newUser", "pass")), Throws.TypeOf<SecurityException>());
        }

        [Test]
        public void ShouldNotAllowToRegisterUserWithoutPassword()
        {
            Assert.That(() => this.dispatcher.Execute(new RegisterUser("admin", "newUser", "")),
                Throws.TypeOf<ValidationException>()
                .And.Matches<ValidationException>(x => x.InvalidProperties.Length == 1 && x.InvalidProperties[0] == "Password")
                );
        }
    }
}
