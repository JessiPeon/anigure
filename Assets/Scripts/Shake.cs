using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public Animator camShake;

    public void activeShake()
    {
        camShake.SetTrigger("shake");
    }
}
