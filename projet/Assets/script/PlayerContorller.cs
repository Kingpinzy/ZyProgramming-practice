using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    public string name = "zy";
    public float health = 10;
    public float atk = 2.2f;
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

    }

    // Update is called once per frameÿһ֡����ˢ��
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position(transform.)
        }
    }
}
