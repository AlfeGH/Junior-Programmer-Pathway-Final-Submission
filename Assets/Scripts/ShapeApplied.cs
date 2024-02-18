using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeApplied : Shape // INHERITANCE
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
    }
}
