internal interface IStorableMaker
{
    IStorable MakeStorableEvent(string type, string data);
}