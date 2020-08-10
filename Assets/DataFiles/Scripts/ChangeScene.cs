using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void CVButton()
    {
        SceneManager.LoadScene("CV");
    }

    public void PortalButton()
    {
        SceneManager.LoadScene("Portal");
    }
}
