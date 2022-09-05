using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject leftOta;
    public GameObject middleOta;
    public GameObject rightOta;
    // Ǯ��
    public GameObject leftCoin;
    public GameObject middleCoin;
    public GameObject rightCoin;
    // Start is called before the first frame update
    void Start()
    {
        leftOta.SetActive(false);
        middleOta.SetActive(false);
        rightOta.SetActive(false);
        leftCoin.SetActive(false);
        middleCoin.SetActive(false);
        rightCoin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //��дһ�����������ϰ���/��ҳ��ֻ�����
    public void GotoBack()
    {
        //�ϰ������
        int num = Random.Range(0, 7);
        if (num == 0)
        {
            leftOta.SetActive(false);
            middleOta.SetActive(false);
            rightOta.SetActive(false);
        }
        else if (num == 1)
        {
            leftOta.SetActive(false);
            middleOta.SetActive(false);
            rightOta.SetActive(true);
        }
        else if (num == 2)
        {
            leftOta.SetActive(false);
            middleOta.SetActive(true);
            rightOta.SetActive(false);
        }
        else if (num == 3)
        {
            leftOta.SetActive(false);
            middleOta.SetActive(true);
            rightOta.SetActive(true);
        }
        else if (num == 4)
        {
            leftOta.SetActive(true);
            middleOta.SetActive(false);
            rightOta.SetActive(false);
        }
        else if (num == 5)
        {
            leftOta.SetActive(true);
            middleOta.SetActive(false);
            rightOta.SetActive(true);
        }
        else if (num == 6)
        {
            leftOta.SetActive(true);
            middleOta.SetActive(true);
            rightOta.SetActive(false);
        }
        //������
        num = Random.Range(0, 3);
        if (num == 0)
        {
            leftCoin.SetActive(true);
            middleCoin.SetActive(false);
            rightCoin.SetActive(false);
        }
        else if (num == 1)
        {
            leftCoin.SetActive(false);
            middleCoin.SetActive(true);
            rightCoin.SetActive(false);
        }
        else if (num == 2)
        {
            leftCoin.SetActive(false);
            middleCoin.SetActive(false);
            rightCoin.SetActive(true);
        }
    }
}