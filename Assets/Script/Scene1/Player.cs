using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 5;
    //public float scrollSpeed=10;
    public GameObject prefabMusic;
    // Start is called before the first frame update
    void Start()
    {
        var music = GameObject.Find("BackMusic");
        if (music == null)
        {
            var m = Instantiate(prefabMusic, null);
            m.name = "BackMusic";
            DontDestroyOnLoad(m);
        }
    }
    //void Scroll()
    //{
    //    this.transform.Rotate(new Vector3(scrollSpeed * Time.deltaTime, 0, 0));
    //}
    // Update is called once per frame
    void Update()
    {
        //this.Scroll();
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            return;
        }
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * turnSpeed * Time.deltaTime, 0, speed * Time.deltaTime);
        if (transform.position.x < -4.5 || transform.position.x > 4.5)
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
        }
        if (transform.position.y < -20)
        {
            Time.timeScale = 0;
        }
    }
}