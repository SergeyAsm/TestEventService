using System.Net;
using System.IO;
using System.Text;

public class SimpleHttpSender : ISender
{
    public bool TrySendMessage(string serverUrl,ISendable messageData)
    {
        WebRequest request = WebRequest.Create(serverUrl);

        request.Method = "POST";

        //в реальном проекте, для временных обьектов лучше использовать какой-то менеджер памяти/пул обьектов
        byte[] data = Encoding.UTF8.GetBytes(messageData.GetJsonData());

        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = data.Length;

        Stream dataStream = request.GetRequestStream();
        dataStream.Write(data, 0, data.Length);
        dataStream.Close();

        using HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        if (response.StatusCode == HttpStatusCode.OK)
        {
            return true;
        }
        return false;
    }
}
