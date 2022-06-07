using System.Collections.Generic;

internal interface ISendableMaker
{
    ISendable MakeSendableMessage(IEnumerator<IStorable> enumerator);
}