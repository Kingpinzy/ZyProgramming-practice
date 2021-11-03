using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    public string name = "zy";
    public int health = 10;
    public float attack = 2.2f;
    // Start is called before the first frame update
    void Awake()//无论script是否启动，都开始执行
    {
        
    }
    void Start()
    {
        
        Debug.Log(name+"'s health"+(health-attack));
    }

    // Update is called once per frame每一帧都会刷新
    void Update()
    {
        
    }
}
