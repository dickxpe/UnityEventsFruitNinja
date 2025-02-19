using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Game : MonoBehaviour
{

    private static int score = 0;

    public static void UpdateClickScore(int points)
    {
        score += points;
        scoreText.text = "SCORE: " + score;
    }

    public static void UpdateFloorScore(Collider collider)
    {
        if (collider.tag != "Bomb")
        {
            score -= 1;
            scoreText.text = "SCORE: " + score;
        }

        Destroy(collider.gameObject);

    }


    static TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText = transform.Find("ScoreText").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
