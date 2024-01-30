using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    public string tagToScale = "Earth";
    public float scaleSpeed = 10f;
    public float maxScale = 150f;  // Maximum scale limit
    public float minScale = 70f;  // Minimum scale limit

    public void ClickButtonScale(string scale)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToScale);

        float scaleChange;

        // Determine the scale change based on the input string
        switch (scale)
        {
            case "up":
                scaleChange = scaleSpeed;  // Increasing scale
                break;
            case "down":
                scaleChange = -scaleSpeed; // Decreasing scale
                break;
            default:
                scaleChange = 0; // No scale change
                break;
        }

        // Scale each object found
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
