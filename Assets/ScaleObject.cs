using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    public string tagToScale = "Earth";
    public float scaleSpeed = 10f;
    public float maxScale = 150f; 
    public float minScale = 50f;  

    public void ClickButtonScale(string scale)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToScale);

        float scaleChange;

        switch (scale)
        {
            case "up":
                scaleChange = scaleSpeed;  
                break;
            case "down":
                scaleChange = -scaleSpeed; 
                break;
            default:
                scaleChange = 0; 
                break;
        }

        foreach (GameObject obj in objectsWithTag)
        {
            Vector3 newScale = obj.transform.localScale + new Vector3(scaleChange, scaleChange, scaleChange);
            newScale = new Vector3(
                Mathf.Clamp(newScale.x, minScale, maxScale),
                Mathf.Clamp(newScale.y, minScale, maxScale),
                Mathf.Clamp(newScale.z, minScale, maxScale)
            );

            obj.transform.localScale = newScale;
        }
    }
}
