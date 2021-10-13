using Newtonsoft.Json;
using System;

namespace Messenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Ilya", "Priv", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message desirializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(desirializedMsg);
            //{ "UserName":"Ilya","MessageText":"Priv","TimeStamp":"2021-10-13T13:02:59.9652169Z"}
            //Ilya < 13.10.2021 13:02:59 >: Priv

        }
    }
}
