using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionBehaviour : MonoBehaviour
{
    public Material ScreenMatte;
    public bool collided = false;
    public GameObject pressE;
    public float shader;

    private void Start()
    {
        pressE.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pressE.SetActive(true);
            print("PressE");
            collided = true;
        }
}
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pressE.SetActive(false);
            collided = false;
        }
    }
    public void Update()
    {
        if (collided == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("yay");
                SceneManager.LoadScene("End");
                ScreenMatte.SetFloat("NoiseAmount", 100);
                ScreenMatte.SetFloat("GlitchStrength", 100);
                ScreenMatte.SetFloat("ScanLineStrength", 0);
            }
        }
    }
}