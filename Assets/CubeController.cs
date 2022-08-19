using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    //地面の位置
    private float groundLevel = -3.0f;

    //キューブのPrefab
    public GameObject cubePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y == groundLevel)
        {
            GetComponent<AudioSource>().volume = 0;
        }

        void OnCollisionEnter2D(Collider2D collision)
        {
            if(collision.gameObject.name == "cubePrefab")
            {
                GetComponent<AudioSource>().volume = 1;
            }
        }
        
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);

        }
    }
    void OnCollisionEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "UnityChan2D")
        {
            GetComponent<AudioSource>().volume = 0;
        }

    }
}
