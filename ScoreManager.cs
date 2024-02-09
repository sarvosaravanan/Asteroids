using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score;

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountScore(int score)
    {
       this.score += score;
    }

    private void OnGUI()
    {
        GUILayout.Label($"score{score}");
    }
}
