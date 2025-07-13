using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;

    public FroggerScore froggerScore;

    void Start()
    {
        txtScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        txtScore.text = froggerScore.score.ToString();
    }
}
