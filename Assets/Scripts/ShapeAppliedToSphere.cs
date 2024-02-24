using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeAppliedToSphere : Shape // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetMaterialColor();
        GetShapeName();
        ShowShapeVertices(0);
    }

    protected override void ShowShapeVertices(int vertices) // POLYMORPHISM
    {
        Debug.Log("Spheres have no vertices");
    }
}
