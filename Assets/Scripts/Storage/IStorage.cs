internal interface IStorage
{
    void AddNode(IStorable newNode);
    bool TryGetNodePack(out IStorablePack nodePack);
    void ClearInterval(StorageNodeInterval interval);
}