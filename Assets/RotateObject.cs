using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public string tagToRotate = "Earth";
    public float rotationSpeed = 30f;
    public void Clickbutton(string dir)
    {
        // Find all objects with the specified tag
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToRotate);
        Vector3 rotationDirection;

        // Determine the rotation direction based on the input string
        switch (dir)
        {
            case "up":
                rotationDirection = Vector3.right; // Rotating around the x-axis
                break;
            case "down":
                rotationDirection = Vector3.left; // Rotating around the x-axis in the opposite direction
                break;
            case "right":
                rotationDirection = Vector3.down; // Rotating around the y-axis in the opposite direction
                break;
            case "left":
                rotationDirection = Vector3.up; // Rotating around the y-axis
                break;
            default:
                rotationDirection = Vector3.zero; // No rotation
                break;
        }
        // Rotate each object found
        foreach (GameObject obj in objectsWithTag)
        {
            // Rotate around the y-axis (up vector) at rotationSpeed degrees per second
            obj.transform.Rotate(rotationDirection * rotationSpeed, Space.World);
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
