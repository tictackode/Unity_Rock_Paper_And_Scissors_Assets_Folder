using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class RockImage : MonoBehaviour
{
    //public Image rockImage;

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
        RockPaperAndScissors.playerChoice = RockPaperAndScissors.gameOptions.Rock;
    }

    public void invokeFinalGameResult()
    {
       // RockPaperAndScissors.final
    }

}
