using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject spherePrefab;
    public GameObject panel;
    public GameObject spawnObject;
    private bool isActive;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!isActive)
            {
                panel.SetActive(true);
                isActive = true;
            }
            else
            {
                panel.SetActive(false);
                isActive = false;
            }
        }
    }

    public void CreateBox()
    {
        Instantiate(boxPrefab, spawnObject.transform.position, spawnObject.transform.rotation);
    }
    public void CreateSphere()
    {
        Instantiate(spherePrefab, spawnObject.transform.position, spawnObject.transform.rotation);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
