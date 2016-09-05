using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public Text highScoreText;
    private string highScoreString;
    private float highscore;

    // Use this for initialization
    void Start()
    {
        highScoreText = highScoreText.GetComponent<Text>();
        highScoreText.text = PlayerPrefs.GetFloat("HighScore").ToString() + "s";
    }

    void Update () {
        highscore = PlayerPrefs.GetFloat("HighScore");
        highScoreString = highscore.ToString();
        if (highscore < 10f)
        {
            highScoreString = highScoreString.Substring(0, 5) + "s";
            highScoreText.text = highScoreString;
        }
        else if (highscore >= 10f)
        {
            highScoreString = highScoreString.Substring(0, 6) + "s";
            highScoreText.text = highScoreString;
        }
        else if (highscore >= 100f)
        {
            highScoreString = highScoreString.Substring(0, 7) + "s";
            highScoreText.text = highScoreString;
        }
	}
}
