using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : Singleton<InputManager>
{
    private Mouse _mouse;

    /// <summary>
    /// ‰Šú‰»
    /// </summary>
    static public void Init()
    {
        InputManager inputManager = GetInstance();
        inputManager._mouse = Mouse.current;
    }

    /// <summary>
    /// ƒ{ƒ^ƒ“‰Ÿ‰º‚µ‚½‚©‚Ç‚¤‚©
    /// </summary>
    /// <returns>true:‰Ÿ‚µ‚½/false:‰Ÿ‚µ‚Ä‚¢‚È‚¢</returns>
    static public bool GetPush()
    {
        InputManager inputManager = GetInstance();
        return inputManager._mouse.leftButton.wasPressedThisFrame;
    }
}
