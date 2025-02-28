using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

sealed class ContinueGame : MonoBehaviour, IDataPersistance
{
    [Header("CanContinue")]
    [SerializeField]
    private UnityEvent canContinue;
    [SerializeField]
    private UnityEvent cantContinue;

    [Header("Button")]
    [SerializeField]
    private TextMeshProUGUI _buttonContinue;

    [SerializeField]
    private bool _hasFinishedTutorial;

    private void Start()
    {
        if(_hasFinishedTutorial)
        {
            _buttonContinue.color = Color.white;
        }
    }
    public void LoadData(GameData data)
    {
        _hasFinishedTutorial = data.tutorial;
    }

    public void SaveData(GameData data)
    {
        
    }
    public void CheckSave()
    {
        if(_hasFinishedTutorial)
        {
            canContinue.Invoke();
        }
        else
        {
            cantContinue.Invoke();
        }
    }
}
