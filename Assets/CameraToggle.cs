using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CameraSwitcher : MonoBehaviour
{
    public ARCameraManager cameraManager;

    public void ToggleCamera()
    {
        if (cameraManager.currentFacingDirection == CameraFacingDirection.World)
        {
            cameraManager.requestedFacingDirection = CameraFacingDirection.User;
        }
        else
        {
            cameraManager.requestedFacingDirection = CameraFacingDirection.World;
        }
    }
}