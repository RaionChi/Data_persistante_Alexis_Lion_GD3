using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDialogueLong : MonoBehaviour
{
    [SerializeField] GameObject _DialoguePanel;
    [SerializeField] TMP_Text _LongSentenceText;

    public void ShowLongDialogue(string longSentence)
    {
        _LongSentenceText.text = longSentence;
        if(!_DialoguePanel.activeInHierarchy)
        {
            _DialoguePanel.SetActive(true);

        }
    }
    public void HideDialog()
    {
        _DialoguePanel.SetActive(false);
    }
}
