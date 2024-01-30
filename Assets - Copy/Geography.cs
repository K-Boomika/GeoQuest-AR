using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Geography : MonoBehaviour
{
    public Button Country;
    public Button Continent;
    public Material material001;
    public Material material002;
    public GameObject canvaMenu;
    public TextMeshProUGUI outputText;

    private GameObject earth;
    private GameObject childObject;
    public void CountryClicked()
    {
        Color newColor;
        if (ColorUtility.TryParseHtmlString("#B2F67A", out newColor))
        {
            Country.GetComponent<Image>().color = newColor;
        }

        childObject = FindChildByName("Earth", "Countries");
        childObject.SetActive(true);
        childObject = FindChildByName("Earth", "Continents");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "CPopUp");
        if (childObject != null) childObject.SetActive(false);
        outputText.text = "Touch on any country flag to learn more about it.";
        Continent.GetComponent<Image>().color = Color.white;
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Earth");
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); 
            if (renderer != null) 
            {
                renderer.material = material001; 
            }
        }
    }
    public void ContinentClicked()
    {
        Color newColor;
        if (ColorUtility.TryParseHtmlString("#B2F67A", out newColor))
        {
            Continent.GetComponent<Image>().color = newColor;
        }

        childObject = FindChildByName("Earth", "Countries");
        childObject.SetActive(false);
        childObject = FindChildByName("Earth", "Continents");
        childObject.SetActive(true);
        childObject = FindChildByName("Menu", "PopUp");
        if(childObject!=null)childObject.SetActive(false);
        outputText.text = "Touch on any continent to learn more about it.";
        Country.GetComponent<Image>().color = Color.white;
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Earth");
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); 
            if (renderer != null)
            {
                renderer.material = material002; 
            }
        }
    }
    private GameObject FindChildByName(string objectname, string childName)
    {
        if (objectname == "Earth")
        {
            earth = GameObject.FindGameObjectWithTag("Earth");
            Transform childTransform = earth.transform.Find(childName);
            return childTransform != null ? childTransform.gameObject : null;
        }
        if (objectname == "Menu")
        {
            Transform childTransform = canvaMenu.transform.Find(childName);
            return childTransform != null ? childTransform.gameObject : null;
        }
        return null;
    }
}
