using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    
    public float health;
    public float atk;
    public bool isbuff;//boolֵ��ʼֵΪfalse���٣�δ��ѡ��

    // Start is called before the first frame update
    void Awake()//����script�Ƿ�����������ʼִ��
    {

    }
    void Start()
    {
        /**health -= atk;
        Debug.Log(name+"�Ĺ�����"+health);
        if (isbuff)
        {
            health += 5f;
            Debug.Log("you are buff,now you health is"+health);
        }**/
        if (health > atk)
        {
            health -= atk;
            Debug.Log("��Ӯ��" + health);
            if (isbuff)
            {
                health += 5f;
                Debug.Log("�ϴϻ����buff������ֵ����5����ǰ����Ϊ��" + health);
            }
        }
        else
            Debug.Log("������");

        Myinfo("zy", 26, true);
    }
    

    // Update is called once per frameÿһ֡����ˢ��
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
            Debug.Log("�������ֽ�" + name+"��������" + age+",���Ǹ��к�");
        }
        else
        {
            Debug.Log("�������ֽ�" + name + "��������" + age + ",���Ǹ�Ů��");
        }
    }
}
