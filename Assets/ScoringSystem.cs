using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int score;

    private void Update()
    {
        scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = "" + score;
    }
}
