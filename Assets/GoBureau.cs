using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBureau : MonoBehaviour
{
    public void GoToBureau()
    {
        SceneManager.LoadScene("Bureau");
    }
}
