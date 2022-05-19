using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneControl : MonoBehaviour
{
    /// <summary>タイトルの状態</summary>
    private enum TitleState
    {
        TITLE_NONE = 0,
        TITLE_INIT,
        TITLE_START,
        TITLE_RUN,
        TITLE_END,

        TITLE_STATE_MAX
    } 
    private TitleState _titleState = TitleState.TITLE_NONE;

    /// <summary>
    /// タイトルロゴ
    /// </summary>
    [SerializeField]
    private ViewBase _viewTitleLogo = null;

    [SerializeField]
    private DontDestroyManager _dontDestroyManager = null;


    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Init()
    {
        InputManager.Init();
        _titleState = TitleState.TITLE_INIT;
    }

    /// <summary>
    /// タイトルの状態に応じたアップデート処理
    /// </summary>
    private async void TitleStateUpdate()
    {
        switch(_titleState)
        {
            case TitleState.TITLE_INIT: // 初期化処理
                await FadeManager.FadeOut();
                _titleState = TitleState.TITLE_START;
                break;
            case TitleState.TITLE_START:
                await _viewTitleLogo.Show();
                _titleState = TitleState.TITLE_RUN;
                break;
            case TitleState.TITLE_RUN:
                if (InputManager.GetPush())
                {
                    await FadeManager.FadeIn();
                    _titleState = TitleState.TITLE_END;
                }
                break;
            case TitleState.TITLE_END:
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        TitleStateUpdate();
    }
}
