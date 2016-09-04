using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    private Text highScoreText;
    private string highScoreString;
    private float highscore;

    // Use this for initialization
    void Start()
    {
        highScoreText = GameObject.Find("HighScoreNum").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        highscore = PlayerPrefs.GetFloat("HighScore");
        highScoreString = highscore.ToString();
        if (highscore < 10f)
        {
            highScoreString = highScoreString.Substring(0, 5) + "s";
        }
        else if (highscore >= 10f)
        {
            highScoreString = highScoreString.Substring(0, 6) + "s";
        }
        else if (highscore >= 100f)
        {
            highScoreString = highScoreString.Substring(0, 7) + "s";
        }
        highScoreText.text = highScoreString;
	}
}
