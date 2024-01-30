using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Material material001;
    public Material material002;
    public Material material003;

    public void Dropdown(int index)
    {
        switch (index)
        {
            case 0:
                OnEarthSelected();
                break;
            case 1:
                OnGeographySelected();
                break;
            case 2:
                OnGeologySelected();
                break;

        }
    }
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
    public void OnGeologySelected()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Earth");
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); // Correctly get the Renderer component
            if (renderer != null) // Check if the renderer is not null
            {
                renderer.material = material003; // Assign the new material
            }
        }
    }
    public void OnEarthSelected()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Earth");
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); // Correctly get the Renderer component
            if (renderer != null) // Check if the renderer is not null
            {
                renderer.material = material001; // Assign the new material
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
