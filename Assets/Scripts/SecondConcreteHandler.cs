using System.Collections;
using UnityEngine;
public class SecondConcreteHandler : BaseHandler
{
    [SerializeField]
    float rotationSpeed = 10.0f;
    [SerializeField]
    float rotationDuration = 3.0f;
    private bool rotating;

    void Update()
    {
        if (rotating)
        {
            transform.Rotate(Vector3.forward * rotationSpeed*Time.deltaTime);
        }
    }
    IEnumerator StartRotating()
    {
        rotating = true;
        yield return new WaitForSeconds(rotationDuration);
        Debug.Log("The object has finished rotating its position");
        rotating = false;
        base.Handle(null);
    }
    public override object Handle(object request)
    {
        StartCoroutine(StartRotating());
        return null;
    }
}


