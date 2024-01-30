using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public string tagToRotate = "Earth";
    public float rotationSpeed = 30f;
    public void Clickbutton(string dir)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToRotate);
        Vector3 rotationDirection;

        switch (dir)
        {
            case "up":
                rotationDirection = Vector3.right; 
                break;
            case "down":
                rotationDirection = Vector3.left; 
                break;
            case "right":
                rotationDirection = Vector3.down; 
                break;
            case "left":
                rotationDirection = Vector3.up; 
                break;
            default:
                rotationDirection = Vector3.zero; 
                break;
        }
        foreach (GameObject obj in objectsWithTag)
        {
            obj.transform.Rotate(rotationDirection * rotationSpeed, Space.World);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
