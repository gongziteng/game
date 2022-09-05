using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinTest : MonoBehaviour
{
    public float speed = 90f;
    public AudioClip GoldDestroySound;
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            AudioSource.PlayClipAtPoint(GoldDestroySound, Vector3.one, 1f);
            Destroy(this.gameObject);
        }
    }
}