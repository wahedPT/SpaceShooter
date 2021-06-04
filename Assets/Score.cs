using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text Scoretext;
    public int score = 0;

   public void ScoreIncrese()
    {
        score++;
        print("the score is:" + score);
    }
}
