using UnityEngine;

internal class TestStorage : IStorage
{
    public void AddNode(IStorable newNode)
    {
    }

    public void ClearInterval(StorageNodeInterval interval)
    {

    }

    public bool TryGetNodePack(out IStorablePack nodePack)
    {
        if (Random.value >0.5f)
        {
            nodePack = new TestStorablePack();
            return true;
        }
        nodePack = default;
        return false;
    }
}