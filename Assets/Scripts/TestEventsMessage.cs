using System;
using System.Collections.Generic;

internal class TestEventsMessage : ISendable
{
    public TestEventsMessage(IEnumerator<IStorable> enumerator)
    {
    }

    public string GetJsonData()
    {
        return "";
    }
}