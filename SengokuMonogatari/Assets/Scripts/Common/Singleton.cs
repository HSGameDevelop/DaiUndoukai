using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> where T : new()
{
    static private T _instance;

    /// <summary>
    /// �I�u�W�F�N�g�C���X�^���X����
    /// </summary>
    static private void CreateInstance()
    {
        _instance = new T();
    }

    /// <summary>
    /// �I�u�W�F�N�g�C���X�^���X�擾
    /// </summary>
    /// <returns>�I�u�W�F�N�g�C���X�^���X</returns>
    static public T GetInstance()
    {
        if (_instance == null)
        {
            CreateInstance();
        }

        return _instance;
    }
}
