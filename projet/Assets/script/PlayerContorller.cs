using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    public string name = "zy";
    public int health = 10;
    public float attack = 2.2f;
    // Start is called before the first frame update
    void Awake()//����script�Ƿ�����������ʼִ��
    {
        
    }
    void Start()
    {
        
        Debug.Log(name+"'s health"+(health-attack));
    }

    // Update is called once per frameÿһ֡����ˢ��
    void Update()
    {
        
    }
}
