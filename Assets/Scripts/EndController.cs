using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{
    public void ReStart()
    {
        SceneManager.LoadScene("Inicio");
    }
    
}
