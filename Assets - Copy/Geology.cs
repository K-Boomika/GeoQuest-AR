using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Geology : MonoBehaviour
{
    public Button Topo;
    public Button Ocean;
    public Button Prec;
    public Button TecP;
    public Material material001;
    public Material material002;
    public Material material003;
    public Material material004;
    public GameObject canvaMenu;
    public TextMeshProUGUI outputText;

    private GameObject earth;
    private GameObject childObject;
    public void TopoClicked()
    {
        Color newColor;
        if (ColorUtility.TryParseHtmlString("#B2F67A", out newColor))
        {
            Topo.GetComponent<Image>().color = newColor;
        }
        Ocean.GetComponent<Image>().color = Color.white;
        Prec.GetComponent<Image>().color = Color.white;
        TecP.GetComponent<Image>().color = Color.white;
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Earth");
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); 
            if (renderer != null) 
            {
                resetIt();
                renderer.material = material001;
                outputText.text = "A topographical world map with green and brown continents, blue underwater areas, and dark brown mountain ranges formed by tectonic plate movements.";
            }
        }
    }
    public void OceanClicked()
    {
        Color newColor;
        if (ColorUtility.TryParseHtmlString("#B2F67A", out newColor))
        {
            Ocean.GetComponent<Image>().color = newColor;
        }

        Topo.GetComponent<Image>().color = Color.white;
        Prec.GetComponent<Image>().color = Color.white;
        TecP.GetComponent<Image>().color = Color.white;
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Earth");
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); 
            if (renderer != null) 
            {
                resetIt();
                renderer.material = material002;
                outputText.text = "Map displaying ocean floor age with colors indicating crust age, ranging from red (new) to purple (280 million years old), highlighting areas like the mid-Atlantic ridge with younger rocks and demonstrating seafloor spreading.";
            }
        }
    }
    public void PrecClicked()
    {
        Color newColor;
        if (ColorUtility.TryParseHtmlString("#B2F67A", out newColor))
        {
            Prec.GetComponent<Image>().color = newColor;
        }

        Ocean.GetComponent<Image>().color = Color.white;
        Topo.GetComponent<Image>().color = Color.white;
        TecP.GetComponent<Image>().color = Color.white;
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Earth");
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null) 
            {
                renderer.material = material003;
                childObject = FindChildByName("Menu", "PrepChart");
                childObject.SetActive(true);
                outputText.text = "The map shows precipitation patterns, illustrating water vapor condensed into forms like rain or snow, falling to Earth as part of the water cycle, influenced by atmospheric and oceanic circulation.";
            }
        }
    }
    public void TecPClicked()
    {
        Color newColor;
        if (ColorUtility.TryParseHtmlString("#B2F67A", out newColor))
        {
            TecP.GetComponent<Image>().color = newColor;
        }

        Ocean.GetComponent<Image>().color = Color.white;
        Prec.GetComponent<Image>().color = Color.white;
        Topo.GetComponent<Image>().color = Color.white;
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Earth");
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); 
            if (renderer != null) 
            {
                resetIt();
                renderer.material = material004;
                outputText.text = "The boundary that forms like seven different plate tectonics is typically where major tectonic plates meet, resulting in various geological features and activities such as earthquakes, volcanic eruptions, and mountain building.";
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

    private void resetIt()
    {
        childObject = FindChildByName("Menu", "PrepChart");
        childObject.SetActive(false);
    }
}
