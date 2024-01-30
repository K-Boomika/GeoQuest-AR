using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ARTouchColorPicker : MonoBehaviour
{
    public TextMeshProUGUI outputText;
    public GameObject PopUpPanel;
    public GameObject CPopUpPanel;
    public TextMeshProUGUI CountryName;
    public TextMeshProUGUI CountryCapital;
    public TextMeshProUGUI ContinentName;
    public TextMeshProUGUI ContinentDetail;
    public Image Flag;
    private bool started = false;
    public GameObject canva;

    void Update()
    {
        if (!started)
        {
            GameObject earth = GameObject.FindGameObjectWithTag("Earth");
            if (earth != null)
            {
                started = true;
                canva.SetActive(true);
                return;
            }

        }
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("Afghanistan"))
                    {
                        outputText.text = "Touched Afghanistan";
                        ShowCountryDetail("Afghanistan");
                    }
                    else if (hit.transform.CompareTag("Albania"))
                    {
                        outputText.text = "Touched Albania";
                        ShowCountryDetail("Albania");
                    }
                    else if (hit.transform.CompareTag("Algeria"))
                    {
                        outputText.text = "Touched Algeria";
                        ShowCountryDetail("Algeria");
                    }
                    else if (hit.transform.CompareTag("Andorra"))
                    {
                        outputText.text = "Touched Andorra";
                        ShowCountryDetail("Andorra");
                    }
                    else if (hit.transform.CompareTag("Angola"))
                    {
                        outputText.text = "Touched Angola";
                        ShowCountryDetail("Angola");
                    }
                    else if (hit.transform.CompareTag("Antigua and Barbuda"))
                    {
                        outputText.text = "Touched Antigua and Barbuda";
                        ShowCountryDetail("Antigua and Barbuda");
                    }
                    else if (hit.transform.CompareTag("Argentina"))
                    {
                        outputText.text = "Touched Argentina";
                        ShowCountryDetail("Argentina");
                    }
                    else if (hit.transform.CompareTag("Armenia"))
                    {
                        outputText.text = "Touched Armenia";
                        ShowCountryDetail("Armenia");
                    }
                    else if (hit.transform.CompareTag("Australia"))
                    {
                        outputText.text = "Touched Australia";
                        ShowCountryDetail("Australia");
                    }
                    else if (hit.transform.CompareTag("Austria"))
                    {
                        outputText.text = "Touched Austria";
                        ShowCountryDetail("Austria");
                    }
                    else if (hit.transform.CompareTag("Azerbaijan"))
                    {
                        outputText.text = "Touched Azerbaijan";
                        ShowCountryDetail("Azerbaijan");
                    }
                    else if (hit.transform.CompareTag("Bahamas"))
                    {
                        outputText.text = "Touched Bahamas";
                        ShowCountryDetail("Bahamas");
                    }
                    else if (hit.transform.CompareTag("Bahrain"))
                    {
                        outputText.text = "Touched Bahrain";
                        ShowCountryDetail("Bahrain");
                    }
                    else if (hit.transform.CompareTag("Bangladesh"))
                    {
                        outputText.text = "Touched Bangladesh";
                        ShowCountryDetail("Bangladesh");
                    }
                    else if (hit.transform.CompareTag("Barbados"))
                    {
                        outputText.text = "Touched Barbados";
                        ShowCountryDetail("Barbados");
                    }
                    else if (hit.transform.CompareTag("Belarus"))
                    {
                        outputText.text = "Touched Belarus";
                        ShowCountryDetail("Belarus");
                    }
                    else if (hit.transform.CompareTag("Belgium"))
                    {
                        outputText.text = "Touched Belgium";
                        ShowCountryDetail("Belgium");
                    }
                    else if (hit.transform.CompareTag("Mexico"))
                    {
                        outputText.text = "Touched Mexico";
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("India"))
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
                        ShowCountryDetail("Mexico");
                    }
                    else if (hit.transform.CompareTag("USA"))
                    {
                        outputText.text = "Touched USA";
                        ShowCountryDetail("USA");
                    }
                    else if (hit.transform.CompareTag("Canada"))
                    {
                        outputText.text = "Touched Canada";
                        ShowCountryDetail("Canada");
                    }
                    else if (hit.transform.CompareTag("Sudan"))
                    {
                        outputText.text = "Touched Sudan";
                        ShowCountryDetail("Sudan");
                    }
                    else if (hit.transform.CompareTag("Greenland"))
                    {
                        outputText.text = "Touched Greenland";
                        ShowCountryDetail("Greenland");
                    }
                    else if (hit.transform.CompareTag("SaudiArabia"))
                    {
                        outputText.text = "Touched Saudi Arabia";
                        ShowCountryDetail("SaudiArabia");
                    }
                    else if (hit.transform.CompareTag("Russia"))
                    {
                        outputText.text = "Touched Russia";
                        ShowCountryDetail("Russia");
                    }
                    else if (hit.transform.CompareTag("Brazil"))
                    {
                        outputText.text = "Touched Brazil";
                        ShowCountryDetail("Brazil");
                    }




















                    else if (hit.transform.CompareTag("Earth"))
                    {
                        outputText.text = "Touched Earth";
                    }
                    else if (hit.transform.CompareTag("Africa"))
                    {
                        outputText.text = "Touched Africa";
                        ShowContinentDetail("Africa");
                    }
                    else if (hit.transform.CompareTag("AustraliaC"))
                    {
                        outputText.text = "Touched Australia";
                        ShowContinentDetail("Australia");
                    }
                    else if (hit.transform.CompareTag("Asia"))
                    {
                        outputText.text = "Touched Asia";
                        ShowContinentDetail("Asia");
                    }
                    else if (hit.transform.CompareTag("NorthAmerica"))
                    {
                        outputText.text = "Touched North America";
                        ShowContinentDetail("NorthAmerica");
                    }
                    else if (hit.transform.CompareTag("SouthAmerica"))
                    {
                        outputText.text = "Touched South America";
                        ShowContinentDetail("SouthAmerica");
                    }
                    else if (hit.transform.CompareTag("Antarctica"))
                    {
                        outputText.text = "Touched Antarctica";
                        ShowContinentDetail("Antarctica");
                    }
                    else if (hit.transform.CompareTag("Europe"))
                    {
                        outputText.text = "Touched Europe";
                        ShowContinentDetail("Europe");
                    }
                }
            }
        }
    }
    public void ShowCountryDetail(string country)
    {
        PopUpPanel.SetActive(true);
        CPopUpPanel.SetActive(false);

        switch (country)
        {
            case "India":
                CountryName.text = "India";
                CountryCapital.text = "New Delhi";
                Flag.sprite = Resources.Load<Sprite>("Flags/India"); 
                break;
            case "China":
                CountryName.text = "China";
                CountryCapital.text = "Beijing";
                Flag.sprite = Resources.Load<Sprite>("Flags/China");
                break;
            case "Mexico":
                CountryName.text = "Mexico";
                CountryCapital.text = "Mexico City";
                Flag.sprite = Resources.Load<Sprite>("Flags/Mexico");
                break;
            case "USA":
                CountryName.text = "USA";
                CountryCapital.text = "Washington, D.C.";
                Flag.sprite = Resources.Load<Sprite>("Flags/USA");
                break;
            case "Canada":
                CountryName.text = "Canada";
                CountryCapital.text = "Ottawa";
                Flag.sprite = Resources.Load<Sprite>("Flags/Canada");
                break;
            case "Argentina":
                CountryName.text = "Argentina";
                CountryCapital.text = "Buenos Aires";
                Flag.sprite = Resources.Load<Sprite>("Flags/Argentina");
                break;
            case "Brazil":
                CountryName.text = "Brazil";
                CountryCapital.text = "Brasília";
                Flag.sprite = Resources.Load<Sprite>("Flags/Brazil");
                break;
            case "Greenland":
                CountryName.text = "Greenland";
                CountryCapital.text = "Nuuk";
                Flag.sprite = Resources.Load<Sprite>("Flags/Greenland");
                break;
            case "Russia":
                CountryName.text = "Russia";
                CountryCapital.text = "Moscow";
                Flag.sprite = Resources.Load<Sprite>("Flags/Russia");
                break;
            case "SaudiArabia":
                CountryName.text = "Saudi Arabia";
                CountryCapital.text = "Riyadh";
                Flag.sprite = Resources.Load<Sprite>("Flags/SaudiArabia");
                break;
            case "Sudan":
                CountryName.text = "Sudan";
                CountryCapital.text = "Khartoum";
                Flag.sprite = Resources.Load<Sprite>("Flags/Sudan");
                break;
            case "Australia":
                CountryName.text = "Australia";
                CountryCapital.text = "Canberra";
                Flag.sprite = Resources.Load<Sprite>("Flags/Australia");
                break;
            default:
                Debug.LogWarning("Country not recognized.");
                break;
        }
    }
    public void ShowContinentDetail(string country)
    {
        PopUpPanel.SetActive(false);
        CPopUpPanel.SetActive(true);

        switch (country)
        {
            case "Asia":
                ContinentName.text = "Asia";
                ContinentDetail.text = "The world's largest and most populous continent, rich in cultural diversity and ancient history.";
                break;
            case "Europe":
                ContinentName.text = "Europe";
                ContinentDetail.text = "A continent of significant historical and cultural influence, marked by its diverse cultures and political entities.";
                break;
            case "Antarctica":
                ContinentName.text = "Antarctica";
                ContinentDetail.text = "The coldest, driest, and windiest continent, largely covered by ice and home to unique wildlife.";
                break;
            case "NorthAmerica":
                ContinentName.text = "North America";
                ContinentDetail.text = "A continent characterized by a mix of modern urbanization, diverse cultures, and vast natural landscapes.";
                break;
            case "SouthAmerica":
                ContinentName.text = "South America";
                ContinentDetail.text = "Renowned for its lush rainforests, captivating cultures, and ancient civilizations.";
                break;
            case "Africa":
                ContinentName.text = "Africa";
                ContinentDetail.text = "Known for its vast diversity in ecosystems, cultures, and languages, and as the cradle of human civilization.";
                break;
            case "Australia":
                ContinentName.text = "Australia";
                ContinentDetail.text = "Known for its unique wildlife, indigenous cultures, and as the world's smallest continent comprising the Australian mainland and numerous islands in the Pacific.";
                break;
            default:
                Debug.LogWarning("Continent not recognized.");
                break;
        }
    }

}