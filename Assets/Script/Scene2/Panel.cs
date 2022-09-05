using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    Image image;
    float a;
    public Image[] hp;     // ����Image����
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
    // ��ʾ����
    public void ShowBlood()
    {
        Color color = image.color;
        color.a = a;          // �ָ���ʼ͸����
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
