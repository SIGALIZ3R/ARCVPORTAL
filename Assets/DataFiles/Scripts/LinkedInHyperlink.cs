using UnityEngine;

public class LinkedInHyperlink : MonoBehaviour
{
    public string url;

    public void Open()
    {
        Application.OpenURL(url);
    }
}
