internal class TestStorableMaker : IStorableMaker
{
    public IStorable MakeStorableEvent(string type, string data)
    {
        return new TestGameEvent(type, data);
    }
}