using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Find("FinishPanel").gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Find("FinishPanel").gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}