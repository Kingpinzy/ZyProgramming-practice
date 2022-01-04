using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    
    public float health;
    public float atk;
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
        if (health > atk)
        {
            health -= atk;
            Debug.Log("你赢了" + health);
            if (isbuff)
            {
                health += 5f;
                Debug.Log("聪聪获得了buff，生命值增加5，当前生命为：" + health);
            }
        }
        else
            Debug.Log("你死了");

        Myinfo("zy", 26, true);
    }
    

    // Update is called once per frame每一帧都会刷新
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + 1, 0);

        }
    }
    void Myinfo(string name,int age,bool isboy)
    {
        if (isboy)
        {
            Debug.Log("他的名字叫" + name+"他的年龄" + age+",他是个男孩");
        }
        else
        {
            Debug.Log("她的名字叫" + name + "她的年龄" + age + ",她是个女孩");
        }
    }
}
