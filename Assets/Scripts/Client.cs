using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public List<BaseHandler> ConcreteHandlers;

    void Start()
    {
        ConcreteHandlers[0].Handle(null);
        for (int i = 1; i < ConcreteHandlers.Count; i++)
        {
            ConcreteHandlers[i - 1].SetNext(ConcreteHandlers[i]);
        }
    }
}