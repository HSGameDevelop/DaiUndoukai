using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// フェード管理クラス
/// </summary>
static public class FadeManager
{
    static private ViewBase _viewFade = null;

    /// <summary>
    /// フェードオブジェクトの設定
    /// </summary>
    /// <param name="viewFade"></param>
    static public void SetViewFade(ViewBase viewFade)
    {
        _viewFade = viewFade;
    }

    /// <summary>
    /// フェードイン 非同期
    /// </summary>
    /// <returns></returns>
    public static async UniTask FadeIn()
    {
        await _viewFade.Show();
    }

    /// <summary>
    /// フェードアウト 非同期
    /// </summary>
    /// <returns></returns>
    public static async UniTask FadeOut()
    {
        await _viewFade.Hide();
    }
}
