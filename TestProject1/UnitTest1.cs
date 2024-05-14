using static System.Net.Mime.MediaTypeNames;
using Практика;
using ClassLibrary1;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void LoginSuccessfullTest()
        {
                string login = "Darya";
               string password= "789";
            string res = "";
            var users = new Dictionary<string, string>()
            {
                { "first", "123"},
                { "second", "456"},
                { "Darya", "789"}
            };
            if (users.ContainsKey(login) && users[login] == password)
            {
                res= login;
            }
            Assert.AreEqual("Darya", res);
        }
        [Test]
        public void LoginFailTest()
        {
            string login = "";
            string password = "789";
            string res = "";
            var users = new Dictionary<string, string>()
            {
                { "first", "123"},
                { "second", "456"},
                { "Darya", "789"}
            };
            if (users.ContainsKey(login) && users[login] == password)
            {
                res = login;
            }
            Assert.AreEqual("Darya", res);
        }
        [Test]
        public void ConnectToCreatedConf()
        {
            ConferenceClass c1 = new ConferenceClass(1);
            ConferenceClass c2 = new ConferenceClass(2);
            List < ConferenceClass> confs = new List<ConferenceClass>() { c1, c2 };
            int idTest = 1;

            bool found = false;
            foreach (var conf in confs)
            {
                if (conf.Id == idTest)
                {
                    found = true;
                    break;
                }
            }
            Assert.AreEqual(true, found);
        }

        [Test]
        public void ConnectToNotCreatedConf()
        {
            ConferenceClass c1 = new ConferenceClass(1);
            ConferenceClass c2 = new ConferenceClass(2);
            List<ConferenceClass> confs = new List<ConferenceClass>() { c1, c2 };
            int idTest = 5;

            bool found = false;
            foreach (var conf in confs)
            {
                if (conf.Id == idTest)
                {
                    found = true;
                    break;
                }
            }
            Assert.AreEqual(true, found);
        }

        [Test]
        public void MessageIsSendedTest()
        {
            string msg = "null";
            bool sended = false;
            if (msg.Trim() != "")
                sended = true;

            Assert.AreEqual(true, sended);
        }

        [Test]
        public void MessageIsNotSendedTest()
        {
            string msg = null;
            bool sended = false;
            if (msg.Trim() != "")
                sended = true;

            Assert.AreEqual(true, sended);
        }
    }
}