
using UnityEngine;
using UnityEngine.UI;


public class RockPaperAndScissors : MonoBehaviour
{
    public enum gameOptions { Rock = 0, Paper = 1, Scissors = 2 };

    public static gameOptions playerChoice;
    gameOptions CPUChoice;

    public Text final_output;
    public Text cpu_text;
    public Text player_text;
    public Text initial_message;

    public Image Image_Rock;
    public Image Image_Paper;
    public Image Image_Scissors;

    //public static RockPaperAndScissors Instance { get; private set; }


    void Awake()
    {
        /* if (Instance != null)
         {
             Debug.LogError("There is more than one instance!");
             return;
         }


         Instance = this;*/


    }



    // Start is called before the first frame update
    void Start()
    {
        




    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Getting access to the images to manipulate them
            Transform image_Rock = transform.Find("Image_Rock");
            this.Image_Rock = image_Rock.GetComponent<Image>();

            Transform image_Paper = transform.Find("Image_Paper");
            this.Image_Paper = image_Paper.GetComponent<Image>();

            Transform image_Scissors = transform.Find("Image_Scissors");
            this.Image_Scissors = image_Scissors.GetComponent<Image>();

            //Disabling images
            this.Image_Rock.enabled = false;
            this.Image_Paper.enabled = false;
            this.Image_Scissors.enabled = false;


            this.CPUChoice = RockPaperAndScissors.generateChoice();
            //RockPaperAndScissors.playerChoice = RockPaperAndScissors.generateChoice();

            //Debug.Log("CPU's choice is: " + this.CPUChoice.ToString());
            //Debug.Log("Player's choice is: " + this.playerChoice.ToString());

            //Disabling the initial message
            Transform initialMsg = transform.Find("initial_message");
            this.initial_message = initialMsg.GetComponent<Text>();
            this.initial_message.enabled= false;

            //Showing the CPU's choice
            Transform child = transform.Find("cpu_choice");
            this.cpu_text = child.GetComponent<Text>();
            cpu_text.text = "CPU's choice is: " + this.CPUChoice.ToString();

            //Showing player's choice
            Transform child2 = transform.Find("player_choice");
            this.player_text = child2.GetComponent<Text>();
            player_text.text = "Players's choice is: " + RockPaperAndScissors.playerChoice.ToString();

            //Showing final output (game result)
            Transform child3 = transform.Find("final_output");
            this.final_output = child3.GetComponent<Text>();
            final_output.text = this.compareChoices();




        }



    }

    public static gameOptions generateChoice()
    {
        gameOptions choice = (gameOptions)Random.Range(0, 3);

        return choice;
    }

    string compareChoices()
    {

        string string_output = "";

        if (RockPaperAndScissors.playerChoice == gameOptions.Rock)
        {
            if (this.CPUChoice == gameOptions.Rock)
            {
                string_output = "Rock and Rock - Draw Game!";
            }
            else if (this.CPUChoice == gameOptions.Paper)
            {
                string_output = "Rock and Paper - Paper beats Rock - CPU wins!";
            }
            else if (this.CPUChoice == gameOptions.Scissors)
            {

                string_output = "Rock and Scissors - Rock beats Scissors - Player wins!";
            }

        }
        else if (RockPaperAndScissors.playerChoice == gameOptions.Paper)
        {
            if (this.CPUChoice == gameOptions.Paper)
            {
                string_output = "Paper and Paper - Draw Game!";
            }
            else if (this.CPUChoice == gameOptions.Scissors)
            {
                string_output = "Paper and Scissors - Scissors beats Paper - CPU wins!";
            }
            else if (this.CPUChoice == gameOptions.Rock)
            {
                string_output = "Paper and Rock - Paper beats Rock - Player wins!";
            }
        }
        else if (RockPaperAndScissors.playerChoice == gameOptions.Scissors)
        {
            if (this.CPUChoice == gameOptions.Scissors)
            {
                string_output = "Scissors and Scissors - Draw Game!";
            }
            else if (this.CPUChoice == gameOptions.Rock)
            {
                string_output = "Scissors and Rock - Rock beats Scissors - CPU wins!";
            }
            else if (this.CPUChoice == gameOptions.Paper)
            {
                string_output = "Scissors and Paper - Scissors beats Paper - Player wins!";
            }

        }
        return string_output;
    }
}

