using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewObject : MonoBehaviour
{
    public GameObject newObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickButton()
    {
        GameObject earth = GameObject.FindGameObjectWithTag("Earth");

        Vector3 popupPosition = earth.transform.position;

        newObject.transform.position = popupPosition;
        earth.SetActive(false);
        newObject.SetActive(true);
    }
}
