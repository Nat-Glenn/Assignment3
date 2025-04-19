using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Assignment3
{
    [DataContract]
    public class User : IEquatable<User>
    {
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public string Email { get; private set; }
        [DataMember]
        public string Password { get; private set; }

        /// <summary>
        /// Initializes a User object.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="email">Email</param>
        /// <param name="password">Plain-text password</param>
        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        /// <summary>
        /// Checks if the passed password is correct.
        /// </summary>
        /// <param name="input">Inputted password</param>
        /// <returns>True if password is correct</returns>
        public bool IsCorrectPassword(string input)
        {
            if (string.IsNullOrEmpty(Password) == string.IsNullOrEmpty(input))
                return true;
            else if (string.IsNullOrEmpty(Password) != string.IsNullOrEmpty(input))
                return false;
            else
                return Password.Equals(input);
        }

        public override bool Equals(object other)
        {
            if (!(other is User otherUser))
                return false;

            return Id == otherUser.Id && Name.Equals(otherUser.Name) && Email.Equals(otherUser.Email);
        }

        public bool Equals(User other)
        {
            return !(other is null) &&
                   Id == other.Id &&
                   Name == other.Name &&
                   Email == other.Email &&
                   Password == other.Password;
        }

        public override int GetHashCode()
        {
            int hashCode = 825453597;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            return hashCode;
        }
    }
}