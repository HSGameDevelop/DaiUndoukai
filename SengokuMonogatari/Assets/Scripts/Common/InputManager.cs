using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : Singleton<InputManager>
{
    private Mouse _mouse;

    /// <summary>
    /// ������
    /// </summary>
    static public void Init()
    {
        InputManager inputManager = GetInstance();
        inputManager._mouse = Mouse.current;
    }

    /// <summary>
    /// �{�^�������������ǂ���
    /// </summary>
    /// <returns>true:������/false:�����Ă��Ȃ�</returns>
    static public bool GetPush()
    {
        InputManager inputManager = GetInstance();
        return inputManager._mouse.leftButton.wasPressedThisFrame;
    }
}
