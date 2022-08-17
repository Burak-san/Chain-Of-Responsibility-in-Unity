using UnityEngine;
public class FirstConcreteHandler : BaseHandler
{
    public bool MoveToPosition = false;

    [SerializeField] private Vector2 positionToMove;
    void Update()
    {
        if (MoveToPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, positionToMove, Time.deltaTime * 3);
            if (Vector2.Distance(transform.position, positionToMove) == 0)
            {
                FinishedMoving();
            }
        }
    }
    void FinishedMoving()
    {
        Debug.Log("The object reached its position");
        MoveToPosition = false;
        base.Handle(null);
    }
    public override object Handle(object request)
    {
        MoveToPosition = true;
        return null;
    }
}


