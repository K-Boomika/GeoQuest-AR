using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Volcano : MonoBehaviour
{
    public Button PressureButton;
    public GameObject canvaMenu;
    public GameObject popUp;
    public TextMeshProUGUI outputText;
    public TextMeshProUGUI InfoText;
    public TextMeshProUGUI PressureText;

    public ParticleSystem smokeSystem;
    public ParticleSystem lavaSystem;
    public GameObject smokeSystemS;
    public GameObject lavaSystemS;

    public GameObject volcano;

    private float currentPressure = 10.0f;
    private const float PressureIncrement = 20f;
    private const float EruptionThreshold = 50.0f;

    public Material material001;
    public Material material002;
    public Material material003;

    public void resetValues()
    {
        Renderer renderer = volcano.GetComponent<Renderer>();
        if (renderer != null)
        {
            currentPressure = 10.0f;
            PressureText.text = "10 MPa";
            renderer.material = material001;
            PressureButton.interactable = true;
            smokeSystem.Stop();
            lavaSystem.Stop();
            smokeSystemS.SetActive(false);
            lavaSystemS.SetActive(false);
        }
    }
    public void TPressureClicked()
    {
        Renderer renderer = volcano.GetComponent<Renderer>();
        if (renderer != null)
        {
            currentPressure += PressureIncrement;
            PressureText.text = $"{currentPressure} MPa";
            if (currentPressure == 30)
            {
                if (renderer != null) 
                {
                    renderer.material = material002; 
                }
            }
            if (currentPressure == 50)
            {
                if (renderer != null) 
                {
                    renderer.material = material003;
                }
            }
        }

        if (currentPressure >= EruptionThreshold)
        {
            TriggerEruption();
            PressureButton.interactable = false;
        }
    }
    private void TriggerEruption()
    {
        smokeSystemS.SetActive(true);
        smokeSystem.Play();
        lavaSystemS.SetActive(true);
        lavaSystem.Play();
    }

}
