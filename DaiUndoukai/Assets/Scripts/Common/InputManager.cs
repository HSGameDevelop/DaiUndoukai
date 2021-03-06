using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : Singleton<InputManager>
{
    private Mouse _mouse;

    /// <summary>
    /// 初期化
    /// </summary>
    static public void Init()
    {
        InputManager inputManager = GetInstance();
        inputManager._mouse = Mouse.current;
    }

    /// <summary>
    /// ボタン押下したかどうか
    /// </summary>
    /// <returns>true:押した/false:押していない</returns>
    static public bool GetPush()
    {
        InputManager inputManager = GetInstance();
        return inputManager._mouse.leftButton.wasPressedThisFrame;
    }
}
