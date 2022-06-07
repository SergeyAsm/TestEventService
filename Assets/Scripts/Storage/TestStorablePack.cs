using System.Collections.Generic;
internal class TestStorablePack: IStorablePack
{
    private StorageNodeInterval interval = new StorageNodeInterval(0, 0);
    public StorageNodeInterval GetInterval()
    {
        return interval;
    }

    public IEnumerator<IStorable> GetIterator()
    {
        yield return default(IStorable);
    }
}