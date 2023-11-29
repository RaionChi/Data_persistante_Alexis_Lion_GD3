using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="New Score")]

public class ScoreData : ScriptableObject
{
    public int ScoreValue;
    public delegate void ScoreUpdate(int Value);
    public static event ScoreUpdate OnUpdate;

   public void updateScoreValue(int value)
    {
        ScoreValue = Mathf.Clamp(ScoreValue + value, 0, 999999);
        UpdateScoreUi();
    }
    public void InitScoreValue(int InitValue)
    {
        ScoreValue = Mathf.Clamp(InitValue, 0, 999999);
        updateScoreValue(InitValue);
    }
    private void UpdateScoreUi()
    {
        OnUpdate? . Invoke (ScoreValue);
    }
}
