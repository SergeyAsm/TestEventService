using System.Collections.Generic;

internal class TestSendableMaker : ISendableMaker
{
    public ISendable MakeSendableMessage(IEnumerator<IStorable> enumerator)
    {
        return new TestEventsMessage(enumerator);
    }
}