using UnityEngine;
using System.Collections;

#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif

public class CameraPermission : MonoBehaviour
{
    void Start()
    {
#if PLATFORM_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
#endif
    }
}
