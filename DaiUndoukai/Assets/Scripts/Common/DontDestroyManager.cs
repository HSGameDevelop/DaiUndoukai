using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// �폜����Ȃ��I�u�W�F�N�g�̊Ǘ��N���X
/// </summary>
public class DontDestroyManager : MonoBehaviour
{
    /// <summary>
    /// �t�F�[�h�I�u�W�F�N�g
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
