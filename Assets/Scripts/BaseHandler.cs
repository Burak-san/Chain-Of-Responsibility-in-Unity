using UnityEngine;
public abstract class BaseHandler : MonoBehaviour, IBaseHandler
{
    private IBaseHandler _nextConcreteHandler;

    public IBaseHandler SetNext(IBaseHandler nextConcreteHandler)
    {
        this._nextConcreteHandler = nextConcreteHandler;
        return nextConcreteHandler;
    }
    public virtual object Handle(object request)
    {
        if (this._nextConcreteHandler != null)
        {
            return this._nextConcreteHandler.Handle(request);
        }
        else
        {
            return null;
        }
    }
}

