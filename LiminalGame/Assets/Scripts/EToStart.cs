using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EToStart : MonoBehaviour
{
    public Material ScreenMatte;
    // Start is called before the first frame update
    void Start()
    {
        ScreenMatte.SetFloat("_NoiseAmount", 0);
        ScreenMatte.SetFloat("_GlitchStrength", 0);
        ScreenMatte.SetFloat("_ScanLineStrength", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Start");
        }
    }
}
