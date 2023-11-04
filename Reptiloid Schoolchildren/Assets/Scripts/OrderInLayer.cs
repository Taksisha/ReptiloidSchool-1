using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderInLayer : MonoBehaviour
{
    [SerializeField] private int OrderdBase = 400;
    [SerializeField] private int offset;

    private Renderer myrenderer;

    void Awake()
    {
        myrenderer = gameObject.GetComponent<Renderer>(); // обращаемся к объекту на котором находится
    }


    void LateUpdate()
    {
        myrenderer.sortingOrder = (int)(OrderdBase - transform.position.y - offset);
    }
}