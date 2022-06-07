using System.Collections.Generic;

internal interface IStorablePack
{
    IEnumerator<IStorable> GetIterator();
    StorageNodeInterval GetInterval();
}