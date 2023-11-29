using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private DialogueDatas _DialogueDatas;
    [SerializeField] private UIDialogueLong _UIDialogue;
    [SerializeField] private UIDialogueAnswers _UIDialogueAnswer;
    private int actualSentence;

    public void StartTalking(int DialogueSentenceNumber)
    {
        actualSentence = DialogueSentenceNumber;
        _UIDialogue.ShowLongDialogue(_DialogueDatas.Sentences[actualSentence].LongSentence);
        int[] answerNumbers = new int[2];
        answerNumbers[0] = _DialogueDatas.Sentences[DialogueSentenceNumber].Answer1;
        answerNumbers[1] = _DialogueDatas.Sentences[DialogueSentenceNumber].Answer2;
        string[] answers = new string[2];
        for(int i = 0; i < answerNumbers.Length; i++) 
        {
            if (answerNumbers[i] != -1)
            {
                answers[i] = _DialogueDatas.Sentences[answerNumbers[i]].ShortSentence;
            }
            else
            {
                answers[i] = ""; 
            }
            
        }
   
        _UIDialogueAnswer.ShowAnswers(answers);
    }

    public void SelectAnswer(int answerNumber)
    {
        if(answerNumber == 0)
        {
            StartTalking(_DialogueDatas.Sentences[actualSentence].Answer1);
        }
        else
        {
            StartTalking(_DialogueDatas.Sentences[actualSentence].Answer2);
        }
        
    }
}
