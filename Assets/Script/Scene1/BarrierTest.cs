using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "≈ˆµΩ¡ÀŒ“");
        if (other.name == "Player")
        {
            Time.timeScale = 0;
        }
    }
}