using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class defaultSate
{
    public int cardAmount = 10;
    public int life = 50;
}


public class PlayerState : MonoBehaviour
{
    defaultSate player;
    defaultSate firstAI;
    defaultSate secondAI;
    defaultSate thirdAI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void getCard(int target)
    {
        switch (target)
            {
            case 0:
                player.cardAmount += 1;
                player.life -= 2;
                break;
            case 1:
                firstAI.cardAmount += 1;
                firstAI.life -= 2;
                break;
            case 2:
                secondAI.cardAmount += 1;
                secondAI.life -= 2;
                break;
            case 3:
                thirdAI.cardAmount += 1;
                thirdAI.life -= 2;
                break;
            default:
                break;
        }
    }

    void placeCard()
    {

    }

    void randomCard()
    {

    }
}

