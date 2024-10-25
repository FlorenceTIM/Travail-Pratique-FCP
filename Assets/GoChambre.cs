using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoChambre : MonoBehaviour
{
    public void GoToChambre()
    {
        SceneManager.LoadScene("Chambre");
    }
}
