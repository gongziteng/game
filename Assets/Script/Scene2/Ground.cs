using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    //找到场景中的两个物体
    public GameObject Cube0;
    public GameObject Cube1;
    public float speed;
    List<GameObject> Cubes = new List<GameObject>();
    int width = 9;
    int height = 1;
    int length = 50;
    //当这个脚本被载入内存的时候，开始执行的时候，执行这里的代码
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject new_Cube0 = Instantiate(Cube0);
            new_Cube0.transform.SetParent(Cube0.transform.parent);
            new_Cube0.transform.localScale = new Vector3(width, height, length);
            new_Cube0.transform.localPosition = Vector3.forward * (i + 1) * length * 2;
            this.Cubes.Add(new_Cube0);

            GameObject new_Cube1 = Instantiate(Cube1);
            new_Cube1.transform.SetParent(Cube1.transform.parent);
            new_Cube1.transform.localScale = new Vector3(9, 1, 50);
            new_Cube1.transform.localPosition = Vector3.forward * ((i + 1) * length * 2 + length);
            this.Cubes.Add(new_Cube1);
        }
        this.Cubes.Add(Cube0);
        this.Cubes.Add(Cube1);
    }

    //当程序执行每一帧，即屏幕刷新一次，调用这个函数一次
    void Update()
    {
        this.GroundMoveOnce();
    }
    //每一帧地面的移动
    void GroundMoveOnce()
    {
        for (int i = 0; i < this.Cubes.Count; i++)
        {
            GameObject cube = Cubes[i];
            Vector3 position = cube.transform.localPosition;
            position -= Vector3.forward * speed * Time.deltaTime;
            if (position.z < -50)
            {
                position.z += this.Cubes.Count * length;
                Obstacle gc = cube.GetComponent<Obstacle>();
                gc.GotoBack();
            }
            cube.transform.localPosition = position;
        }
    }
}