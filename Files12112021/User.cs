using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Files12112021
{
    [Serializable]
    class User:ISerializable
    {
        public User(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name, typeof(string));
            info.AddValue("Surname", Surname, typeof(string));
            info.AddValue("Age", Age, typeof(byte));
        }
        public User()
        {

        }

        public User(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Surname = (string)info.GetValue("Surname", typeof(string));
            Age = (byte)info.GetValue("Age", typeof(byte));
        }
        public override string ToString()
        {
            return $"{Name} {Surname} - {Age}";
        }
    }
   
}
