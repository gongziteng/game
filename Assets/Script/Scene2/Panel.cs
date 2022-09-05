using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    Image image;
    float a;
    public Image[] hp;     // 创建Image数组
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        Color color = image.color;
        a = color.a;
        color.a = 0;
        image.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        Color color = image.color;
        color.a -= Time.deltaTime;
        image.color = color;
    }
    // 显示红屏
    public void ShowBlood()
    {
        Color color = image.color;
        color.a = a;          // 恢复初始透明度
        image.color = color;
    }
    public void ReduceHp(int hp)
    {
        if (hp == 1)
        {
            this.hp[1].enabled = false;
        }
        else if (hp == 0)
        {
            this.hp[0].enabled = false;
        }
    }
}
