using Assignment3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Tests
{
    public class Tests
    {
        private SLL linkedList;

        [SetUp]
        public void SetUp()
        {
            linkedList = new SLL();
        }

        [Test]
        public void TestIsEmpty()
        {
            Assert.That(linkedList.IsEmpty(), Is.True);
        }

        [Test]
        public void TestAddFirst()
        {
            var user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddFirst(user);
            Assert.That(linkedList.IsEmpty(), Is.False);
            Assert.That(linkedList.GetValue(0), Is.EqualTo(user));
        }

        [Test]
        public void TestAddLast()
        {
            var user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddLast(user);
            Assert.That(linkedList.IsEmpty(), Is.False);
            Assert.That(linkedList.GetValue(0), Is.EqualTo(user));
        }

        [Test]
        public void TestAddAtIndex()
        {
            var user1 = new User(1, "Alice", "alice@example.com", "password");
            var user2 = new User(2, "Bob", "bob@example.com", "password");
            linkedList.AddLast(user1);
            linkedList.Add(user2, 1);
            Assert.That(linkedList.GetValue(1), Is.EqualTo(user2));
        }

        [Test]
        public void TestReplace()
        {
            var user1 = new User(1, "Alice", "alice@example.com", "password");
            var user2 = new User(2, "Bob", "bob@example.com", "password");
            linkedList.AddLast(user1);
            linkedList.Replace(user2, 0);
            Assert.That(linkedList.GetValue(0), Is.EqualTo(user2));
        }

        [Test]
        public void TestRemoveFirst()
        {
            var user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddFirst(user);
            linkedList.RemoveFirst();
            Assert.That(linkedList.IsEmpty(), Is.True);
        }

        [Test]
        public void TestRemoveLast()
        {
            var user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddLast(user);
            linkedList.RemoveLast();
            Assert.That(linkedList.IsEmpty(), Is.True);
        }

        [Test]
        public void TestRemoveAtIndex()
        {
            var user1 = new User(1, "Alice", "alice@example.com", "password");
            var user2 = new User(2, "Bob", "bob@example.com", "password");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            linkedList.Remove(0);
            Assert.That(linkedList.GetValue(0), Is.EqualTo(user2));
        }

        [Test]
        public void TestGetValue()
        {
            var user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddLast(user);
            Assert.That(linkedList.GetValue(0), Is.EqualTo(user));
        }

        [Test]
        public void TestIndexOf()
        {
            var user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddLast(user);
            Assert.That(linkedList.IndexOf(user), Is.EqualTo(0));
        }

        [Test]
        public void TestContains()
        {
            var user = new User(1, "Alice", "alice@example.com", "password");
            linkedList.AddLast(user);
            Assert.That(linkedList.Contains(user), Is.True);
        }

        [Test]
        public void TestReverse()
        {
            var user1 = new User(1, "Alice", "alice@example.com", "password");
            var user2 = new User(2, "Bob", "bob@example.com", "password");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            linkedList.Reverse();
            Assert.That(linkedList.GetValue(0), Is.EqualTo(user2));
            Assert.That(linkedList.GetValue(1), Is.EqualTo(user1));
        }
    }
}
