using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;
    
    //var that you can change from unity Emty Object (GameObject) where you attacehd this .cs file !!
    public Text displayGuess;
    public int max_guesses_allowed = 10;


    // Use this for initialization
    void Start () {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
       
        guess = 500;
        NextGuess();

        
        /*
        print("===================================");
        print("Welcome to number wizard.");
        print("Pick a number in your head, but don't tell me!");



        print("The highest numer you can pick is " + max);
        print("The lowest numer you can pick is " + min);

        print("Is the number higher or lower then " + guess + "?");
        print("Up arrow / down arrow / enter for equal.");
        */
        
    }

    void NextGuess()
    {
        guess = Random.Range(min, max+1); //(max + min) / 2;

        displayGuess.text = guess.ToString();

        max_guesses_allowed -= 1;
        if (max_guesses_allowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
        //print("Higher or lower than " + guess);
        //print("Up arrow / down arrow / enter for equal.");
    }

    // Update is called once per frame
    void Update () {
       /* if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GuessHigher();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GuesLower();
        }
       */
    }

    public void GuessHigher()
    {
        print("UP!");
        min = guess;
        NextGuess();
    }

    public void GuesLower()
    {
        print("Down!");
        max = guess;
        NextGuess();
    }

    

}
