using NUnit.Framework;
using Comportamiento.Domain;

namespace Comportamiento.Domain.Tests
{
    public class NewsAgencyTests
    {
        [Test]
        public void GivenSubscribers_WhenNewsPublished_AllReceiveNotification()
        {
            var agency = new NewsAgency();
            var subscriber1 = new Subscriber("Camila");
            var subscriber2 = new Subscriber("Bianca");

            agency.Attach(subscriber1);
            agency.Attach(subscriber2);

            agency.PublishNews("Nueva conferencia de software anunciada.");

            Assert.AreEqual("Nueva conferencia de software anunciada.", subscriber1.LastNews);
            Assert.AreEqual("Nueva conferencia de software anunciada.", subscriber2.LastNews);
        }

        [Test]
        public void GivenUnsubscribedUser_WhenNewsPublished_DoesNotReceiveNotification()
        {
            var agency = new NewsAgency();
            var subscriber = new Subscriber("Luis");

            agency.Attach(subscriber);
            agency.Detach(subscriber);

            agency.PublishNews("Nueva actualización de .NET 9!");

            Assert.AreEqual("", subscriber.LastNews);
        }
    }
}
