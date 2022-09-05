using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public float scrollSpeed = 1000;
    public float moveSpeed = 10;
    public Panel ps;
    public Text scoreText;
    // 设置小球的起始位置（中间）和左侧、右侧位置
    Vector3 leftPosition = new Vector3(-3, 1, -20);
    Vector3 middlePosition = new Vector3(0, 1, -20);
    Vector3 rightPosition = new Vector3(3, 1, -20);
    // 设置小球血量
    int hp = 2;
    // 记录小球的得分
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = middlePosition;
        scoreText.text = string.Format("Score:{0}", score);
    }

    // Update is called once per frame
    void Update()
    {
        this.Scroll();
        this.MoveLeftRight();
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            return;
        }
    }
    void Scroll()
    {
        this.transform.Rotate(new Vector3(scrollSpeed * Time.deltaTime, 0, 0));
    }
    void MoveLeftRight()
    {
        // 位置在左边时
        if (transform.position == leftPosition)
        {
            if (Input.GetKeyDown(KeyCode.A) == true)
            {
                transform.position = leftPosition;
            }
            else if (Input.GetKeyDown(KeyCode.D) == true)
            {
                transform.position = middlePosition;
            }
        }
        // 位置在中间时
        else if (transform.position == middlePosition)
        {
            if (Input.GetKeyDown(KeyCode.A) == true)
            {
                transform.position = leftPosition;
            }
            else if (Input.GetKeyDown(KeyCode.D) == true)
            {
                transform.position = rightPosition;
            }
        }
        // 位置在右边时
        else if (transform.position == rightPosition)
        {
            if (Input.GetKeyDown(KeyCode.A) == true)
            {
                transform.position = middlePosition;
            }
            else if (Input.GetKeyDown(KeyCode.D) == true)
            {
                transform.position = rightPosition;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.StartsWith("Barrier"))
        {
            hp--;
            ps.ShowBlood();
            ps.ReduceHp(hp);
            if (hp == 0)
            {
                scoreText.text = scoreText.text + "游戏结束，按R重新开始";
                Time.timeScale = 0;
            }
        }
        else if (other.gameObject.name.StartsWith("Cylinder"))
        {
            score+=1;
            scoreText.text = string.Format("Score:{0}", score);
        }
    }
}