using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void imageClicked()
    {
        RockPaperAndScissors.playerChoice = RockPaperAndScissors.gameOptions.Scissors;
    }
}
