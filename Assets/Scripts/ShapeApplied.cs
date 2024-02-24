using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeApplied : Shape // INHERITANCE
{
    [SerializeField] private int inputVertices;  // ENCAPSULATION
    private int safeVertices;  // ENCAPSULATION
    private int vertices  // ENCAPSULATION
    {
        get { return safeVertices; }
        set { 
            if (value < 0)
           {
                Debug.LogError("Number of vertices cannot be negative");
           }
              else
            {
                safeVertices = value;
            }
        }   // ENCAPSULATION
    }
    // Start is called before the first frame update
    void Start()
    {
        vertices = inputVertices;  // ENCAPSULATION
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetMaterialColor();
        GetShapeName();
        ShowShapeVertices(vertices);
    }
}
