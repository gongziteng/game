using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform ballTransform;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - ballTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = offset + ballTransform.position;
    }
}