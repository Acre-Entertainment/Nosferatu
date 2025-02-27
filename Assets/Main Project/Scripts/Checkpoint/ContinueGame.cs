using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

sealed class ContinueGame : MonoBehaviour, IDataPersistance
{
    [Header("CanContinue")]
    [SerializeField]
    private UnityEvent canContinue;
    [SerializeField]
    private UnityEvent cantContinue;

    [SerializeField]
    private bool _hasFinishedTutorial;
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
