using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour,ICollectible
{
    [SerializeField] int _Value;
    [SerializeField] ScoreData _scoreData;
    [SerializeField] string _collectibleType;
    [SerializeField] QuestDatas _questData;


    public void Collect()
    {
        _questData.UpdateObjectives(this);
        Destroy(gameObject);
    }
    public string GetCollectibleType()
    {
        return _collectibleType;
    }
    public int GetCollectibleValue()
    {
        return _Value;
    }

}
