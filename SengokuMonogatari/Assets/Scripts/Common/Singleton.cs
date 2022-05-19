using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> where T : new()
{
    static private T _instance;

    /// <summary>
    /// オブジェクトインスタンス生成
    /// </summary>
    static private void CreateInstance()
    {
        _instance = new T();
    }

    /// <summary>
    /// オブジェクトインスタンス取得
    /// </summary>
    /// <returns>オブジェクトインスタンス</returns>
    static public T GetInstance()
    {
        if (_instance == null)
        {
            CreateInstance();
        }

        return _instance;
    }
}
