using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Cube : MonoBehaviour
{
    public enum Element
    {
        BLUE,
        RED,
        NONE
    }

    public Element element
    {
        get; set;
    }

    void Start()
    {
        gameObject.transform.position = new Vector3(Random.Range(-3f, 3f), 6, Random.Range(-4f, -2f));
        gameObject.transform.rotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
    }

    void Update()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        switch(element)
        {
            case Element.BLUE:
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case Element.RED:
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            default:
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                break;
        }
        
    }

}
