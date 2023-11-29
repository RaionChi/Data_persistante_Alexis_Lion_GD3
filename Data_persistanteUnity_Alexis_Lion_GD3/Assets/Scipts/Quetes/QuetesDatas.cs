using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu(menuName = "New Quest")]

public class QuestDatas : ScriptableObject
{
    public ObjectiveDatas[] Objectives;
    public bool IsStarted;
    public bool IsFinished;

    public void CheckQuest()
    {
        bool result = true;
        for (int i = 0; i< Objectives.Length; i++)
        {
            if (!Objectives[i].IsFinished)
            {
                result = false;
                break;
            }
        }
        if (result)
        {
            EndQuest();
        }
    }
    public void StartQuest()
    {
        IsStarted = true;
    }
    public void EndQuest()
    {
        IsFinished = true;
    }
    public void CheckObjectives(int NumObject)
    {
        if (Objectives[NumObject].ActualValue >= Objectives[NumObject].MaxValue)
        {
            Objectives[NumObject].IsFinished = true;
            CheckQuest();
        }
        
    }
    public void UpdateObjectives(Collectible collectible)
    {
        for( int i = 0;i <Objectives.Length;i++)
        {
            if (Objectives[i].CollectibleType == collectible.GetCollectibleType())
            {
                Objectives[i].ActualValue += collectible.GetCollectibleValue();
                CheckObjectives(i);
                break;
            }
            
        }
        
    }
          
        

}
