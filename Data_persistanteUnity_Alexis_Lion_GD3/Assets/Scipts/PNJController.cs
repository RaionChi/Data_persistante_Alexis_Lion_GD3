using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJController : MonoBehaviour, ITalk
{
    private DialogueSystem _dialogSystem;
    [SerializeField] private int _startSentence;
    [SerializeField] private int _intermediateSentence;
    [SerializeField] private int _endSentence;
    [SerializeField] private QuestDatas _questData;

    private void Start()
    {
        _dialogSystem = GetComponent<DialogueSystem>();
    }
    public void Talk()
    {
        if (_questData.IsStarted)
        {
            if (_questData.IsFinished)
            {
                _dialogSystem.StartTalking(_endSentence);
            }
            else
            {
                _dialogSystem.StartTalking(_intermediateSentence);
            }  
        }
        else
        {
            _dialogSystem.StartTalking(_startSentence);
        }
    }
}
