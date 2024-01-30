using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material material001; 
    public Material material002;

    public void OnGeographySelected()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Earth");
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); // Correctly get the Renderer component
            if (renderer != null) // Check if the renderer is not null
            {
                renderer.material = material002; // Assign the new material
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
