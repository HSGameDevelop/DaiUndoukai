using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// �\�����̊�{�ƂȂ�N���X
/// </summary>
public class ViewBase : MonoBehaviour
{
    private const string _SHOW_ANIM_NAME_ = "Show";
    private const string _HIDE_ANIM_NAME_ = "Hide";

    /// <summary>
    /// �A�j���[�^�[ Show/Hide ��Animation�������Ă���K�v������
    /// </summary>
    [SerializeField]
    protected Animator _animator = null;

    /// <summary>
    /// �\�� �񓯊�
    /// </summary>
    /// <returns></returns>
    public async UniTask Show()
    {
        _animator.Play(_SHOW_ANIM_NAME_);

        await UniTask.WaitUntil(() => _animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f);
    }

    /// <summary>
    /// ��\�� �񓯊�
    /// </summary>
    /// <returns></returns>
    public async UniTask Hide()
    {
        _animator.Play(_HIDE_ANIM_NAME_);

        await UniTask.WaitUntil(() => _animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f);
    }
}
