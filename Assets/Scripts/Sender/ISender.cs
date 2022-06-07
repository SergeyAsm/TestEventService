internal interface ISender
{
    bool TrySendMessage(string serverUrl, ISendable messageData);
}