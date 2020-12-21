using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    [Serializable]
    ///	<summary>
    ///	<para>Класс Сообщение</para>
    ///	</summary>
    public class message
    {
        public string username { get; set; }

        public string text { get; set; }
        public DateTime timestamp { get; set; }

        public message()

        {
            this.username = "Server";

            this.text = "Server is running...";

            this.timestamp = DateTime.UtcNow.AddHours(+3);

        }

        public message(string username, string text)

        {
            this.username = username;

            this.text = text;

            this.timestamp = DateTime.UtcNow;
        }

        ///	<summary>
        ///	<br>Ts - время отправки сообщения (по серверу)</br>

        ///	</summary>

        public int Ts { get; set; }

        ///	<summary>
        ///	<br>Name - имя клиента</br>
        ///	</summary>

        public string Name { get; set; }

        ///	<summary>
        ///	<br>Text - сообщение клиента</br>
        ///	</summary>

        public string Text { get; set; }

        ///	<summary>
        ///	<br>ToString - функция преобразования полей класса в строку для печати</br>

        ///	</summary>
        ///	<returns> [Time] Name: Text </returns>
        public override string ToString()

        {

            //TODO bad code hour +3, local tim was not realse

            return $"[{new DateTime(1970, 1, 1, 3, 0, 0, 0).AddSeconds(Ts)}] {Name}: { Text}";

        }

    }


[Serializable]
public class MessagesClass

{

    public List<message> messages = new List<message>();

    public void Add(message ms)

    {
        ms.timestamp = DateTime.UtcNow;

        messages.Add(ms);

        Console.WriteLine(messages.Count);
    }

    public void Add(string username, string text)

    {
        message msg = new message(username, text);

        messages.Add(msg);

        Console.WriteLine(messages.Count);
    }

    public message Get(int id)
    {

        return messages.ElementAt(id);

    }


    public int GetCountMessages()

    {
        return messages.Count;

    }


    public MessagesClass()

    {
        messages.Clear();

        message ms = new message();

        messages.Add(ms);

    }

}

}
