# ZyProgramming-practice

### 2022.1.4

#### 变量与变量的运算
```c#
	Debug.Log(name+"的攻击力"+health)
	其中+号可作为连接符使用
	a = a - b; 可以写作为 a -= b;
	同理可得 += （拾取buff获得生命值等）
	
```

+ 循环语句
```c#
 if (health > atk)
        {
            health -= atk;
            Debug.Log("你赢了"+health);
            if (isbuff)
            {
                health += 5f;
                Debug.Log("聪聪获得了buff，生命值增加5，当前生命为：" + health);
            }
        }
        else
            Debug.Log("你死了");

    }
void updata()
{
		if (Input.GetKeyDown(KeyCode.D))
		        {
		            transform.position = new Vector2(transform.position.x + 1,0);

		        }
}
```
循环语句，没什么好说的，其中穿插了一些变量的计算与bool值的运用。
> 关于大小写的一些说明Transform与transform，其中Transform通常指代组件，transform通常指代组件当中的一些属性。
---
#### 函数Function
+ 函数分为有返回值&无返回值
	+ 无返回值相当于一个代码的集合体，按顺序执行步骤
	+ 


