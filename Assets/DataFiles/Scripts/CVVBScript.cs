using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class CVVBScript : MonoBehaviour
{
    public GameObject CVPage1, CVPage2, GitHubPage, WebsitePage;
    VirtualButtonBehaviour[] vbs;
    
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }
        CVPage1.SetActive(false);
        CVPage2.SetActive(false);
        GitHubPage.SetActive(false);
        WebsitePage.SetActive(false);
    }
  
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "CVVB")
        {
            UnityEngine.Debug.Log("CVVB Button pressed");
            CVPage1.SetActive(true);
            CVPage2.SetActive(true);
            GitHubPage.SetActive(false);
            WebsitePage.SetActive(false);
        }

        else if (vb.VirtualButtonName == "GithubVB")
        {
            UnityEngine.Debug.Log("GithubVB Button pressed");
            CVPage1.SetActive(false);
            CVPage2.SetActive(false);
            GitHubPage.SetActive(true);
            WebsitePage.SetActive(false);
        }

        else if (vb.VirtualButtonName == "WebsiteVB")
        {
            UnityEngine.Debug.Log("WebsiteVB Button pressed");
            CVPage1.SetActive(false);
            CVPage2.SetActive(false);
            GitHubPage.SetActive(false);
            WebsitePage.SetActive(true);
        }

        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log(vb.VirtualButtonName + " released");
    }
}