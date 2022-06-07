using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using System.IO;

public class TestSender : ISender
{
    public bool TrySendMessage(string serverUrl,ISendable messageData)
    {
        if (Random.value>0.5f)
        {
            return true;
        }
        return false;
    }
}
