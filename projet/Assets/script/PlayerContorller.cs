using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    public string name = "zy";
    public float health = 10;
    public float atk = 2.2f;
    public bool isbuff;//bool值初始值为false（假，未勾选）
    
    // Start is called before the first frame update
    void Awake()//无论script是否启动，都开始执行
    {
        
    }
    void Start()
    {
        /**health -= atk;
        Debug.Log(name+"的攻击力"+health);
        if (isbuff)
        {
            health += 5f;
            Debug.Log("you are buff,now you health is"+health);
        }**/

    }

    // Update is called once per frame每一帧都会刷新
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position(transform.)
        }
    }
}
