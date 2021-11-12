using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Files12112021
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User();
            //user.Name = "Martin";
            //user.Surname = "Heidegger";
            //user.Age = 77;

            //Serialize(user, "Martin");
            Console.WriteLine(DeSerialize("Martin"));
        }
        public static void Serialize(User user, string filename)
        {
            string path = @"C:\Users\tu201906115\Desktop\" + filename + ".txt";
            Stream stream = new FileStream(path,FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, user);
        }


        public static User DeSerialize(string filename)
        {
            string path = @"C:\Users\tu201906115\Desktop\" + filename + ".txt";
            Stream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            var data = (User)bf.Deserialize(stream);
            return data;
        }
        
    }
}
