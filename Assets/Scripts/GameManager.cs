using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndScreen endScreen;
    // Start is called before the first frame update
    void Start()
    {
        quiz = FindObjectOfType<Quiz>();
        endScreen = FindObjectOfType<EndScreen>();

        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
        }
    }

    public void onReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
//I have completed the quiz master but there are still many things I don't understand like: Getter methods, Arrays, ForLoop, Connecting the Timer, List, GameManager. I feel like Gary is going to fast
}
