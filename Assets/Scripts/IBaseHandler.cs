
public interface IBaseHandler
{
    object Handle(object request);
    IBaseHandler SetNext(IBaseHandler nextConcreteHandler);
}