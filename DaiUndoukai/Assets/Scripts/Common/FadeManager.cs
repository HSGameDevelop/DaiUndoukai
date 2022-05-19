using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// �t�F�[�h�Ǘ��N���X
/// </summary>
static public class FadeManager
{
    static private ViewBase _viewFade = null;

    /// <summary>
    /// �t�F�[�h�I�u�W�F�N�g�̐ݒ�
    /// </summary>
    /// <param name="viewFade"></param>
    static public void SetViewFade(ViewBase viewFade)
    {
        _viewFade = viewFade;
    }

    /// <summary>
    /// �t�F�[�h�C�� �񓯊�
    /// </summary>
    /// <returns></returns>
    public static async UniTask FadeIn()
    {
        await _viewFade.Show();
    }

    /// <summary>
    /// �t�F�[�h�A�E�g �񓯊�
    /// </summary>
    /// <returns></returns>
    public static async UniTask FadeOut()
    {
        await _viewFade.Hide();
    }
}
