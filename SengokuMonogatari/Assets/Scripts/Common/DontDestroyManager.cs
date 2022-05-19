using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// 削除されないオブジェクトの管理クラス
/// </summary>
public class DontDestroyManager : MonoBehaviour
{
    /// <summary>
    /// フェードオブジェクト
    /// </summary>
    [SerializeField]
    private ViewBase _viewFade = null;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        FadeManager.SetViewFade(_viewFade);
    }
}
