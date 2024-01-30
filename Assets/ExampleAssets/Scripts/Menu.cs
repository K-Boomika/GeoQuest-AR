using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Android;

public class Menu : MonoBehaviour
{
    public Material material001;
    public Material material002;
    public Material material003;
    public GameObject Volcano; 
    public ARCameraManager cameraManager; // Assign in Inspector
    public ARRaycastManager rayCastManager; // Assign in Inspector
    public TextMeshProUGUI Text;
    public GameObject canvaMenu;
    public GameObject canvaCam;
    public ARFaceManager faceManager;
    private Volcano scriptV;

    private GameObject childObject;

    private GameObject earth;


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
            case 3:
                OnDisasterSimSelected();
                break;
            case 4:
                OnFunTimeSelected();
                break;

        }
    }
    public void OnGeographySelected()
    {
        earth.SetActive(true);
        Volcano.SetActive(false);
        ResetEverything();
        SetScene("Geography");
        Text.text = "Touch on any country flag to learn more about it.";
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
    private GameObject FindChildByName(string objectname, string childName)
    {
        if (objectname == "Earth")
        {
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
    public void OnGeologySelected()
    {
        earth.SetActive(true);
        Volcano.SetActive(false);
        ResetEverything();
        SetScene("Geology");
        Text.text = "A topographical world map with green and brown continents, blue underwater areas, and dark brown mountain ranges formed by tectonic plate movements.";
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
        earth.SetActive(true);
        Volcano.SetActive(false);
        ResetEverything();
        Text.text = "Just look at out beautiful Earth! :)";
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

    public void OnDisasterSimSelected()
    {

        ResetEverything();
        SetScene("Disaster");
        Vector3 popupPosition = earth.transform.position;
        Text.text = "Are you ready to rock and lava with some volcanic action?";
        // Set the position in world space
        Volcano.transform.position = popupPosition;
        earth.SetActive(false);
        Volcano.SetActive(true);
    }
    public void OnFunTimeSelected()
    {
        earth.SetActive(true);
        Volcano.SetActive(false);
        canvaMenu.SetActive(false);
        canvaCam.SetActive(true);
        ToggleCamera();
    }

    public void ToggleCamera()
    {
        // Check if the ARCameraManager has been assigned
        if (cameraManager == null)
        {
            Debug.LogError("ARCameraManager is not assigned.");
            Text.text = "ARCameraManager is not assigned.";
            return;
        }

        // Check if the ARRaycastManager has been assigned
        if (rayCastManager == null)
        {
            Debug.LogError("ARRaycastManager is not assigned.");
            Text.text = "ARRaycastManager is not assigned.";
            return;
        }

        // Toggle the camera facing direction
        if (cameraManager.requestedFacingDirection == CameraFacingDirection.World)
        {
            // Disable raycasting when using the user-facing (front) camera
            rayCastManager.enabled = false;

            Text.text = "Selfie Time!!!";
            Debug.Log("Changing to user-facing (front) camera...");
            cameraManager.requestedFacingDirection = CameraFacingDirection.User;

            earth.SetActive(false);
        }
        else
        {
            // Enable raycasting when using the world-facing (rear) camera
            rayCastManager.enabled = true;

            Text.text = "Changing to world-facing (rear) camera...";
            Debug.Log("Changing to world-facing (rear) camera...");
            cameraManager.requestedFacingDirection = CameraFacingDirection.World;
            earth.SetActive(true);
        }
    }

    public void backClicked()
    {
        canvaMenu.SetActive(false);
        canvaCam.SetActive(false);
        faceManager.enabled = false;
        rayCastManager.enabled = true;
        ResetScene();
        faceManager.enabled = false;
        rayCastManager.enabled = true;
        ToggleCamera();
    }
    public void ResetScene()
    {
        // Get the current active scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Reload the current active scene
        SceneManager.LoadScene(currentScene.name);
    }

    public void ResetEverything()
    {
        childObject = FindChildByName("Menu", "PopUp");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "CPopUp");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "DPopUp");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "Country");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "Continent");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "View");
        childObject.SetActive(false);
        childObject = FindChildByName("Earth", "Countries");
        childObject.SetActive(false);
        childObject = FindChildByName("Earth", "Continents");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "Topography");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "Precipitation");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "OceanAge");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "TectonicPlate");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "Pressure");
        childObject.SetActive(false);
        childObject = FindChildByName("Menu", "ScaleUp");
        childObject.SetActive(true);
        childObject = FindChildByName("Menu", "ScaleDown");
        childObject.SetActive(true);
        childObject = FindChildByName("Menu", "RotateRight");
        childObject.SetActive(true);
        childObject = FindChildByName("Menu", "RotateLeft");
        childObject.SetActive(true);
        childObject = FindChildByName("Menu", "RotateUp");
        childObject.SetActive(true);
        childObject = FindChildByName("Menu", "RotateDown");
        childObject.SetActive(true);
    }

    public void SetScene(string option)
    {
        if(option == "Geography")
        {
            childObject = FindChildByName("Menu", "Country");
            childObject.SetActive(true);
            childObject = FindChildByName("Menu", "Continent");
            childObject.SetActive(true);
            childObject = FindChildByName("Menu", "View");
            childObject.SetActive(true);
            childObject = FindChildByName("Earth", "Countries");
            childObject.SetActive(true);
            return;
        }
        if (option == "Earth3D")
        {
            return;
        }
        if (option == "Geology")
        {
            childObject = FindChildByName("Menu", "Topography");
            childObject.SetActive(true);
            childObject = FindChildByName("Menu", "Precipitation");
            childObject.SetActive(true);
            childObject = FindChildByName("Menu", "OceanAge");
            childObject.SetActive(true);
            childObject = FindChildByName("Menu", "TectonicPlate");
            childObject.SetActive(true);
            childObject = FindChildByName("Menu", "View");
            childObject.SetActive(true);
            return;
        }
        if (option == "Disaster")
        {
            childObject = FindChildByName("Menu", "Pressure");
            childObject.SetActive(true);
            childObject = FindChildByName("Menu", "ScaleUp");
            childObject.SetActive(false);
            childObject = FindChildByName("Menu", "ScaleDown");
            childObject.SetActive(false);
            childObject = FindChildByName("Menu", "RotateRight");
            childObject.SetActive(false);
            childObject = FindChildByName("Menu", "RotateLeft");
            childObject.SetActive(false);
            childObject = FindChildByName("Menu", "RotateUp");
            childObject.SetActive(false);
            childObject = FindChildByName("Menu", "RotateDown");
            childObject.SetActive(false);
            childObject = FindChildByName("Menu", "DPopUp");
            childObject.SetActive(true);
            //scriptV.resetValues();
            return;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (earth == null)
        {
            earth = GameObject.FindGameObjectWithTag("Earth");
            if(earth!=null)Text.text = "Look at our beautiful Earth! :)";
        }

    }
}
