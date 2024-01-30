using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CameraSwitcher : MonoBehaviour
{
    public ARCameraManager cameraManager; 
    public ARRaycastManager rayCastManager; 
    public TextMeshProUGUI Text;

    public void ToggleCamera()
    {
        if (cameraManager == null)
        {
            Debug.LogError("ARCameraManager is not assigned.");
            Text.text = "ARCameraManager is not assigned.";
            return;
        }

        if (rayCastManager == null)
        {
            Debug.LogError("ARRaycastManager is not assigned.");
            Text.text = "ARRaycastManager is not assigned.";
            return;
        }

        if (cameraManager.requestedFacingDirection == CameraFacingDirection.World)
        {
            rayCastManager.enabled = false;

            Text.text = "Changing to user-facing (front) camera...";
            Debug.Log("Changing to user-facing (front) camera...");
            cameraManager.requestedFacingDirection = CameraFacingDirection.User;
        }
        else
        {
            rayCastManager.enabled = true;

            Text.text = "Changing to world-facing (rear) camera...";
            Debug.Log("Changing to world-facing (rear) camera...");
            cameraManager.requestedFacingDirection = CameraFacingDirection.World;
        }
    }
}
