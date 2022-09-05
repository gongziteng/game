using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "≈ˆµΩ¡ÀŒ“");
        if (other.name == "Sphere")
        {
            Time.timeScale = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
