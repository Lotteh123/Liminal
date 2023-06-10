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
        ScreenMatte.SetFloat("_NoiseAmount", 0);
        ScreenMatte.SetFloat("_GlitchStrength", 0);
        ScreenMatte.SetFloat("_ScanLineStrength", 1);
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
                ScreenMatte.SetFloat("_NoiseAmount", 100);
                ScreenMatte.SetFloat("_GlitchStrength", 100);
                ScreenMatte.SetFloat("_ScanLineStrength", 0);
            }
        }
    }
}