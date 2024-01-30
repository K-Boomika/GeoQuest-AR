using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ARTouchColorPicker : MonoBehaviour
{
    public TextMeshProUGUI outputText;
    public GameObject PopUpPanel;
    public TextMeshProUGUI CountryName;
    public TextMeshProUGUI CountryCapital;
    public Image Flag;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.CompareTag("India"))
                    {
                        outputText.text = "Touched India";
                        ShowCountryDetail("India");
                    }
                    else if (hit.transform.CompareTag("China"))
                    {
                        outputText.text = "Touched China";
                        ShowCountryDetail("China");
                    }
                    else if (hit.transform.CompareTag("Mexico"))
                    {
                        outputText.text = "Touched Mexico";
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                    }
                    else if (hit.transform.CompareTag("Earth"))
                    {
                        outputText.text = "Touched Earth";
                    }
                    else
                    {
                        outputText.text = "Touched something else.";
                    }
                }
                else
                {
                    outputText.text = "Touched empty space.";
                }
            }
        }
    }
    public void ShowCountryDetail(string country)
    {
        PopUpPanel.SetActive(true);

        // Set country-specific information
        switch (country)
        {
            case "India":
                CountryName.text = "India";
                CountryCapital.text = "New Delhi";
                Flag.sprite = Resources.Load<Sprite>("Flags/India"); // Assuming you have a folder named "Flags" in Resources
                break;
            case "China":
                CountryName.text = "China";
                CountryCapital.text = "Beijing";
                Flag.sprite = Resources.Load<Sprite>("Flags/China");
                break;
            // Add cases for other countries
            default:
                Debug.LogWarning("Country not recognized.");
                break;
        }
    }

}