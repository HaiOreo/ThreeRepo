using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 面板基类 所有面板 都会继承它 方便我们的使用 节约代码量
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class BasePanel<T> : MonoBehaviour where T:class
{
    private static T instance;

    public static T Instance => instance;

    protected virtual void Awake()
    {
        instance = this as T;
    }

    // Start is called before the first frame update
    void Start()
    {
        //父类当中会去强行调用 初始化方法
        //该初始化方法 又是一个抽象函数 子类就必须去实现
        Init();
    }

    public abstract void Init();//初始化面板

    public virtual void ShowMe()
    {
        this.gameObject.SetActive(true);
    }

    public virtual void HideMe()
    {
        this.gameObject.SetActive(false);//隐藏、关闭面板
    }
}
