using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    public GameObject yellow0;
    public GameObject yellow1;
    public GameObject yellow2;
    public GameObject yellow3;
    public GameObject yellow4;
    public GameObject yellow5;
    public GameObject yellow6;
    public GameObject yellow7;
    public GameObject yellow8;
    public GameObject yellow9;
    public GameObject blue0;
    public GameObject blue1;
    public GameObject blue2;
    public GameObject blue3;
    public GameObject blue4;
    public GameObject blue5;
    public GameObject blue6;
    public GameObject blue7;
    public GameObject blue8;
    public GameObject blue9;
    public GameObject red0;
    public GameObject red1;
    public GameObject red2;
    public GameObject red3;
    public GameObject red4;
    public GameObject red5;
    public GameObject red6;
    public GameObject red7;
    public GameObject red8;
    public GameObject red9;
    public GameObject green0;
    public GameObject green1;
    public GameObject green2;
    public GameObject green3;
    public GameObject green4;
    public GameObject green5;
    public GameObject green6;
    public GameObject green7;
    public GameObject green8;
    public GameObject green9;
    public Transform p1SpawnPoint;
    public Transform middle;

    private int round = 0;

    public GameObject playerCounter;
    public GameObject ai1Counter;
    public GameObject ai2Counter;
    public GameObject ai3Counter;
    public GameObject TimerCounter;
    public GameObject RoundTimeCounter;

    Text roundTimer;
    Text timer;
    Text playerCounterText;
    Text ai1CounterText;
    Text ai2CounterText;
    Text ai3CounterText;

    Vector3 nextP1SpawnPoint;
    Vector3 cardXPosition;

    GameObject placingCard;

    bool clockwise = false;

    int mins = 9;
    float sec = 60;
    float roundTime = 20;
    bool nextOne = true;

    int playerCardAmount = 10;
    int playerLife = 50;
    int ai1CardAmount = 10;
    int ai1Life = 50;
    int ai2CardAmount = 10;
    int ai2Life = 50;
    int ai3CardAmount = 10;
    int ai3Life = 50;

    int[] p1CardColor = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] p1CardNum = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai1CardColor = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai1CardNum = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai2CardColor = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai2CardNum = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai3CardColor = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai3CardNum = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] lastCard = new int[2];

    private void Start()
    {
        roundTimer = RoundTimeCounter.GetComponent<Text>();
        timer = TimerCounter.GetComponent<Text>();
        playerCounterText = playerCounter.GetComponent<Text>();
        ai1CounterText = ai1Counter.GetComponent<Text>();
        ai2CounterText = ai2Counter.GetComponent<Text>();
        ai3CounterText = ai3Counter.GetComponent<Text>();
        
        StartCard();
        for (int a=0;a<10;a++)
        {
            GetRandomCard(0);
            //GetRandomCard(1);
            GetRandomCard(2);
            GetRandomCard(3);
            
        }
    }
    private void Update()
    {
        if (sec >= 0 && sec < 10)
        {
            timer.text = "Time Left: 0" + Mathf.Floor(mins) + ":" + "0" + Mathf.Floor(sec);
        }
        else timer.text = "Time Left: 0" + Mathf.Floor(mins) + ":" + Mathf.Floor(sec);

        if (sec < 0 && mins > 0)
        {
            sec = 60;
            mins -= 1;
        }
        sec -= Time.deltaTime;

        roundTimer.text = "Time for placing card: " + Mathf.Floor(roundTime);
        roundTime -= Time.deltaTime;

        playerCounterText.text = "Card Left: " + playerCardAmount.ToString() + " " + "Life: " + playerLife.ToString();
        ai1CounterText.text = "Card Left: " + ai1CardAmount.ToString() + " " + "Life: " + ai1Life.ToString();
        ai2CounterText.text = "Card Left: " + ai2CardAmount.ToString() + " " + "Life: " + ai2Life.ToString();
        ai3CounterText.text = "Card Left: " + ai3CardAmount.ToString() + " " + "Life: " + ai3Life.ToString();

        Player();
        AI1();
        AI2();
        AI3();

    }

    public void Player()
    {
        if (round == 0)
        {
            if (nextOne == true)
            {
                roundTime = 20;
                nextOne = false;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                if (clockwise == false)
                {
                    GetCard(0);
                    nextOne = true;
                    round = 1;
                }
                else
                {
                    GetCard(0);
                    nextOne = true;
                    round = 3;
                }
            }
            if (Input.GetButtonDown("Fire2"))
            {
                if (clockwise == false)
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit pointer;
                    if (Physics.Raycast(ray, out pointer, 20))
                    {
                        if (pointer.collider.tag == "Card")
                        {
                            cardXPosition = pointer.collider.GetComponent<Transform>().position;
                            if (p1CardColor[(int)cardXPosition.x+8] == lastCard[0] || p1CardNum[(int)cardXPosition.x + 8] == lastCard[1])
                            {
                                PlaceCard(cardXPosition);
                                Destroy(pointer.collider.gameObject);
                                playerCardAmount -= 1;
                                nextOne = true;
                                round = 1;
                            }
                        }
                    }
                }
                else
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit pointer;
                    if (Physics.Raycast(ray, out pointer, 20))
                    {
                        if (pointer.collider.tag == "Card")
                        {
                            cardXPosition = pointer.collider.GetComponent<Transform>().position;
                            if (p1CardColor[(int)cardXPosition.x + 8] == lastCard[0] || p1CardNum[(int)cardXPosition.x + 8] == lastCard[1])
                            {
                                PlaceCard(cardXPosition);
                                Destroy(pointer.collider.gameObject);
                                playerCardAmount -= 1;
                                nextOne = true;
                                round = 3;
                            }
                        }
                    }
                }
            }
            if (roundTime < 0)
            {
                if (clockwise == false)
                {
                    nextOne = true;
                    round = 1;
                }
                else
                {
                    nextOne = true;
                    round = 3;
                }
            }
        }
    }
    public void AI1()
    {
        if (round == 1)
        {
            if (nextOne == true)
            {
                roundTime = 20;
                nextOne = false;
            }
            if (roundTime < 16)
            {
                int i = 0;
                while (ai1CardColor[i] != lastCard[0] && ai1CardNum[i] != lastCard[1] && i < 19)
                {
                    i++;
                }
                if (ai1CardColor[i] == lastCard[0] || ai1CardNum[i] == lastCard[1])
                {
                    AIPlaceCard(1, i);
                    nextOne = true;
                    if (clockwise == false)
                    {
                        round = 2;
                    }
                    else round = 0;
                }
                else
                {
                    GetCard(1);
                    nextOne = true;
                    if (clockwise == false)
                    {
                        round = 2;
                    }
                    else round = 0;
                }
            }
        }
    }

    public void AI2()
    {
        if (round == 2)
        {
            if (nextOne == true)
            {
                roundTime = 20;
                nextOne = false;
            }
            if (roundTime < 16)
            {
                int i = 0;
                while (ai2CardColor[i] != lastCard[0] && ai2CardNum[i] != lastCard[1] && i < 19)
                {
                    i++;
                }
                if (ai2CardColor[i] == lastCard[0] || ai2CardNum[i] == lastCard[1])
                {
                    AIPlaceCard(2, i);
                    nextOne = true;
                    if (clockwise == false)
                    {
                        round = 3;
                    }
                    else round = 1;
                }
                else
                {
                    GetCard(2);
                    nextOne = true;
                    if (clockwise == false)
                    {
                        round = 3;
                    }
                    else round = 1;
                }
            }
        }
    }

    public void AI3()
    {
        if (round == 3)
        {
            if (nextOne == true)
            {
                roundTime = 20;
                nextOne = false;
            }
            if (roundTime < 16)
            {
                int i = 0;
                while (ai3CardColor[i] != lastCard[0] && ai3CardNum[i] != lastCard[1] && i < 19)
                {
                    i++;
                }
                if (ai3CardColor[i] == lastCard[0] || ai3CardNum[i] == lastCard[1])
                {
                    AIPlaceCard(3, i);
                    nextOne = true;
                    if (clockwise == false)
                    {
                        round = 0;
                    }
                    else round = 2;
                }
                else
                {
                    GetCard(3);
                    nextOne = true;
                    if (clockwise == false)
                    {
                        round = 0;
                    }
                    else round = 2;
                }
            }
        }
    }
    public void StartCard()
    {
        GameObject startCard;
        int rndcolor = Random.Range(1, 5); //1=red, 2=yellow, 3=blue, 4=green
        int rndnum = Random.Range(0, 10);
        Debug.Log(rndcolor + " " + rndnum);
        Vector3 startPoint = middle.position;
        switch (rndcolor)
        {
            case 1:
                switch (rndnum)
                {
                    case 0:
                        startCard = Instantiate(red0, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 1:
                        startCard = Instantiate(red1, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 2:
                        startCard = Instantiate(red2, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 3:
                        startCard = Instantiate(red3, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 4:
                        startCard = Instantiate(red4, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 5:
                        startCard = Instantiate(red5, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 6:
                        startCard = Instantiate(red6, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 7:
                        startCard = Instantiate(red7, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 8:
                        startCard = Instantiate(red8, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 9:
                        startCard = Instantiate(red9, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                }
                break;
            case 2:
                switch (rndnum)
                {
                    case 0:
                        startCard = Instantiate(yellow0, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 1:
                        startCard = Instantiate(yellow1, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 2:
                        startCard = Instantiate(yellow2, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 3:
                        startCard = Instantiate(yellow3, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 4:
                        startCard = Instantiate(yellow4, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 5:
                        startCard = Instantiate(yellow5, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 6:
                        startCard = Instantiate(yellow6, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 7:
                        startCard = Instantiate(yellow7, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 8:
                        startCard = Instantiate(yellow8, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 9:
                        startCard = Instantiate(yellow9, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                }
                break;
            case 3:
                switch (rndnum)
                {
                    case 0:
                        startCard = Instantiate(blue0, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 1:
                        startCard = Instantiate(blue1, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 2:
                        startCard = Instantiate(blue2, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 3:
                        startCard = Instantiate(blue3, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 4:
                        startCard = Instantiate(blue4, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 5:
                        startCard = Instantiate(blue5, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 6:
                        startCard = Instantiate(blue6, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 7:
                        startCard = Instantiate(blue7, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 8:
                        startCard = Instantiate(blue8, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 9:
                        startCard = Instantiate(blue9, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                }
                break;
            case 4:
                switch (rndnum)
                {
                    case 0:
                        startCard = Instantiate(green0, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 1:
                        startCard = Instantiate(green1, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 2:
                        startCard = Instantiate(green2, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 3:
                        startCard = Instantiate(green3, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 4:
                        startCard = Instantiate(green4, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 5:
                        startCard = Instantiate(green5, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 6:
                        startCard = Instantiate(green6, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 7:
                        startCard = Instantiate(green7, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 8:
                        startCard = Instantiate(green8, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                    case 9:
                        startCard = Instantiate(green9, startPoint, middle.rotation);
                        startCard.AddComponent<Rigidbody>();
                        startCard.gameObject.tag = "Placed";
                        break;
                }
                break;
        }
        lastCard[0] = rndcolor;
        lastCard[1] = rndnum;
    }
    public void GetCard(int target) //0=player 1,2,3=AI
    {
        switch (target)
            {
            case 0:
                if (playerCardAmount <= 18) {
                    playerCardAmount += 1;
                    playerLife -= 2;
                    GetRandomCard(0);
                    playerCardAmount += 1;
                    GetRandomCard(0);
                }
                break;
            case 1:
                if (ai1CardAmount <= 18)
                {
                    ai1CardAmount += 2;
                    ai1Life -= 2;
                    GetRandomCard(1);
                    GetRandomCard(1);

                }
                break;
            case 2:
                if (ai2CardAmount <= 18)
                {
                    ai2CardAmount += 2;
                    ai2Life -= 2;
                    GetRandomCard(2);
                    GetRandomCard(2);
                }
                break;
            case 3:
                if (ai3CardAmount <= 18)
                {
                    ai3CardAmount += 2;
                    ai3Life -= 2;
                    GetRandomCard(3);
                    GetRandomCard(3);
                }
                break;
            default:
                break;
        }
    }

    public void AIPlaceCard(int target, int cp)
    {
        if (target == 1)
        {
            lastCard[0] = ai1CardColor[cp];
            lastCard[1] = ai1CardNum[cp];
            switch (ai1CardColor[cp])
            {
                case 1:
                    switch (ai1CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(red0);
                            break;
                        case 1:
                            PlaceMiddle(red1);
                            break;
                        case 2:
                            PlaceMiddle(red2);
                            break;
                        case 3:
                            PlaceMiddle(red3);
                            break;
                        case 4:
                            PlaceMiddle(red4);
                            break;
                        case 5:
                            PlaceMiddle(red5);
                            break;
                        case 6:
                            PlaceMiddle(red6);
                            break;
                        case 7:
                            PlaceMiddle(red7);
                            break;
                        case 8:
                            PlaceMiddle(red8);
                            break;
                        case 9:
                            PlaceMiddle(red9);
                            break;
                    }
                    break;
                case 2:
                    switch (ai1CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(yellow0);
                            break;
                        case 1:
                            PlaceMiddle(yellow1);
                            break;
                        case 2:
                            PlaceMiddle(yellow2);
                            break;
                        case 3:
                            PlaceMiddle(yellow3);
                            break;
                        case 4:
                            PlaceMiddle(yellow4);
                            break;
                        case 5:
                            PlaceMiddle(yellow5);
                            break;
                        case 6:
                            PlaceMiddle(yellow6);
                            break;
                        case 7:
                            PlaceMiddle(yellow7);
                            break;
                        case 8:
                            PlaceMiddle(yellow8);
                            break;
                        case 9:
                            PlaceMiddle(yellow9);
                            break;
                    }
                    break;
                case 3:
                    switch (ai1CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(blue0);
                            break;
                        case 1:
                            PlaceMiddle(blue1);
                            break;
                        case 2:
                            PlaceMiddle(blue2);
                            break;
                        case 3:
                            PlaceMiddle(blue3);
                            break;
                        case 4:
                            PlaceMiddle(blue4);
                            break;
                        case 5:
                            PlaceMiddle(blue5);
                            break;
                        case 6:
                            PlaceMiddle(blue6);
                            break;
                        case 7:
                            PlaceMiddle(blue7);
                            break;
                        case 8:
                            PlaceMiddle(blue8);
                            break;
                        case 9:
                            PlaceMiddle(blue9); ;
                            break;
                    }
                    break;
                case 4:
                    switch (ai1CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(green0);
                            break;
                        case 1:
                            PlaceMiddle(green1);
                            break;
                        case 2:
                            PlaceMiddle(green2);
                            break;
                        case 3:
                            PlaceMiddle(green3);
                            break;
                        case 4:
                            PlaceMiddle(green4);
                            break;
                        case 5:
                            PlaceMiddle(green5);
                            break;
                        case 6:
                            PlaceMiddle(green6);
                            break;
                        case 7:
                            PlaceMiddle(green7);
                            break;
                        case 8:
                            PlaceMiddle(green8);
                            break;
                        case 9:
                            PlaceMiddle(green9);
                            break;
                    }
                    break;
            }
            ai1CardColor[cp] = -1;
            ai1CardNum[cp] = -1;
            ai1CardAmount -= 1;
        }
        if (target == 2)
        {
            lastCard[0] = ai2CardColor[cp];
            lastCard[1] = ai2CardNum[cp];
            switch (ai2CardColor[cp])
            {
                case 1:
                    switch (ai2CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(red0);
                            break;
                        case 1:
                            PlaceMiddle(red1);
                            break;
                        case 2:
                            PlaceMiddle(red2);
                            break;
                        case 3:
                            PlaceMiddle(red3);
                            break;
                        case 4:
                            PlaceMiddle(red4);
                            break;
                        case 5:
                            PlaceMiddle(red5);
                            break;
                        case 6:
                            PlaceMiddle(red6);
                            break;
                        case 7:
                            PlaceMiddle(red7);
                            break;
                        case 8:
                            PlaceMiddle(red8);
                            break;
                        case 9:
                            PlaceMiddle(red9);
                            break;
                    }
                    break;
                case 2:
                    switch (ai2CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(yellow0);
                            break;
                        case 1:
                            PlaceMiddle(yellow1);
                            break;
                        case 2:
                            PlaceMiddle(yellow2);
                            break;
                        case 3:
                            PlaceMiddle(yellow3);
                            break;
                        case 4:
                            PlaceMiddle(yellow4);
                            break;
                        case 5:
                            PlaceMiddle(yellow5);
                            break;
                        case 6:
                            PlaceMiddle(yellow6);
                            break;
                        case 7:
                            PlaceMiddle(yellow7);
                            break;
                        case 8:
                            PlaceMiddle(yellow8);
                            break;
                        case 9:
                            PlaceMiddle(yellow9);
                            break;
                    }
                    break;
                case 3:
                    switch (ai2CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(blue0);
                            break;
                        case 1:
                            PlaceMiddle(blue1);
                            break;
                        case 2:
                            PlaceMiddle(blue2);
                            break;
                        case 3:
                            PlaceMiddle(blue3);
                            break;
                        case 4:
                            PlaceMiddle(blue4);
                            break;
                        case 5:
                            PlaceMiddle(blue5);
                            break;
                        case 6:
                            PlaceMiddle(blue6);
                            break;
                        case 7:
                            PlaceMiddle(blue7);
                            break;
                        case 8:
                            PlaceMiddle(blue8);
                            break;
                        case 9:
                            PlaceMiddle(blue9); ;
                            break;
                    }
                    break;
                case 4:
                    switch (ai2CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(green0);
                            break;
                        case 1:
                            PlaceMiddle(green1);
                            break;
                        case 2:
                            PlaceMiddle(green2);
                            break;
                        case 3:
                            PlaceMiddle(green3);
                            break;
                        case 4:
                            PlaceMiddle(green4);
                            break;
                        case 5:
                            PlaceMiddle(green5);
                            break;
                        case 6:
                            PlaceMiddle(green6);
                            break;
                        case 7:
                            PlaceMiddle(green7);
                            break;
                        case 8:
                            PlaceMiddle(green8);
                            break;
                        case 9:
                            PlaceMiddle(green9);
                            break;
                    }
                    break;
            }
            ai2CardColor[cp] = -1;
            ai2CardNum[cp] = -1;
            ai2CardAmount -= 1;
        }
        if (target == 3)
        {
            lastCard[0] = ai3CardColor[cp];
            lastCard[1] = ai3CardNum[cp];
            switch (ai3CardColor[cp])
            {
                case 1:
                    switch (ai3CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(red0);
                            break;
                        case 1:
                            PlaceMiddle(red1);
                            break;
                        case 2:
                            PlaceMiddle(red2);
                            break;
                        case 3:
                            PlaceMiddle(red3);
                            break;
                        case 4:
                            PlaceMiddle(red4);
                            break;
                        case 5:
                            PlaceMiddle(red5);
                            break;
                        case 6:
                            PlaceMiddle(red6);
                            break;
                        case 7:
                            PlaceMiddle(red7);
                            break;
                        case 8:
                            PlaceMiddle(red8);
                            break;
                        case 9:
                            PlaceMiddle(red9);
                            break;
                    }
                    break;
                case 2:
                    switch (ai3CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(yellow0);
                            break;
                        case 1:
                            PlaceMiddle(yellow1);
                            break;
                        case 2:
                            PlaceMiddle(yellow2);
                            break;
                        case 3:
                            PlaceMiddle(yellow3);
                            break;
                        case 4:
                            PlaceMiddle(yellow4);
                            break;
                        case 5:
                            PlaceMiddle(yellow5);
                            break;
                        case 6:
                            PlaceMiddle(yellow6);
                            break;
                        case 7:
                            PlaceMiddle(yellow7);
                            break;
                        case 8:
                            PlaceMiddle(yellow8);
                            break;
                        case 9:
                            PlaceMiddle(yellow9);
                            break;
                    }
                    break;
                case 3:
                    switch (ai3CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(blue0);
                            break;
                        case 1:
                            PlaceMiddle(blue1);
                            break;
                        case 2:
                            PlaceMiddle(blue2);
                            break;
                        case 3:
                            PlaceMiddle(blue3);
                            break;
                        case 4:
                            PlaceMiddle(blue4);
                            break;
                        case 5:
                            PlaceMiddle(blue5);
                            break;
                        case 6:
                            PlaceMiddle(blue6);
                            break;
                        case 7:
                            PlaceMiddle(blue7);
                            break;
                        case 8:
                            PlaceMiddle(blue8);
                            break;
                        case 9:
                            PlaceMiddle(blue9); ;
                            break;
                    }
                    break;
                case 4:
                    switch (ai3CardNum[cp])
                    {
                        case 0:
                            PlaceMiddle(green0);
                            break;
                        case 1:
                            PlaceMiddle(green1);
                            break;
                        case 2:
                            PlaceMiddle(green2);
                            break;
                        case 3:
                            PlaceMiddle(green3);
                            break;
                        case 4:
                            PlaceMiddle(green4);
                            break;
                        case 5:
                            PlaceMiddle(green5);
                            break;
                        case 6:
                            PlaceMiddle(green6);
                            break;
                        case 7:
                            PlaceMiddle(green7);
                            break;
                        case 8:
                            PlaceMiddle(green8);
                            break;
                        case 9:
                            PlaceMiddle(green9);
                            break;
                    }
                    break;
            }
            ai3CardColor[cp] = -1;
            ai3CardNum[cp] = -1;
            ai3CardAmount -= 1;
        }
        
    }
    public void PlaceCard(Vector3 position)
    {

        int cp = (int)position.x + 8; //cp = card position , first card = 0
        lastCard[0] = p1CardColor[cp];
        lastCard[1] = p1CardNum[cp];
        switch (p1CardColor[cp])
        {
            case 1:
                switch (p1CardNum[cp])
                {
                    case 0:
                        PlaceMiddle(red0);
                        break;
                    case 1:
                        PlaceMiddle(red1);
                        break;
                    case 2:
                        PlaceMiddle(red2);
                        break;
                    case 3:
                        PlaceMiddle(red3);
                        break;
                    case 4:
                        PlaceMiddle(red4);
                        break;
                    case 5:
                        PlaceMiddle(red5);
                        break;
                    case 6:
                        PlaceMiddle(red6);
                        break;
                    case 7:
                        PlaceMiddle(red7);
                        break;
                    case 8:
                        PlaceMiddle(red8);
                        break;
                    case 9:
                        PlaceMiddle(red9);
                        break;
                }
                break;
            case 2:
                switch (p1CardNum[cp])
                {
                    case 0:
                        PlaceMiddle(yellow0);
                        break;
                    case 1:
                        PlaceMiddle(yellow1);
                        break;
                    case 2:
                        PlaceMiddle(yellow2);
                        break;
                    case 3:
                        PlaceMiddle(yellow3);
                        break;
                    case 4:
                        PlaceMiddle(yellow4);
                        break;
                    case 5:
                        PlaceMiddle(yellow5);
                        break;
                    case 6:
                        PlaceMiddle(yellow6);
                        break;
                    case 7:
                        PlaceMiddle(yellow7);
                        break;
                    case 8:
                        PlaceMiddle(yellow8);
                        break;
                    case 9:
                        PlaceMiddle(yellow9);
                        break;
                }
                break;
            case 3:
                switch (p1CardNum[cp])
                {
                    case 0:
                        PlaceMiddle(blue0);
                        break;
                    case 1:
                        PlaceMiddle(blue1);
                        break;
                    case 2:
                        PlaceMiddle(blue2);
                        break;
                    case 3:
                        PlaceMiddle(blue3);
                        break;
                    case 4:
                        PlaceMiddle(blue4);
                        break;
                    case 5:
                        PlaceMiddle(blue5);
                        break;
                    case 6:
                        PlaceMiddle(blue6);
                        break;
                    case 7:
                        PlaceMiddle(blue7);
                        break;
                    case 8:
                        PlaceMiddle(blue8);
                        break;
                    case 9:
                        PlaceMiddle(blue9);;
                        break;
                }
                break;
            case 4:
                switch (p1CardNum[cp])
                {
                    case 0:
                        PlaceMiddle(green0);
                        break;
                    case 1:
                        PlaceMiddle(green1);
                        break;
                    case 2:
                        PlaceMiddle(green2);
                        break;
                    case 3:
                        PlaceMiddle(green3);
                        break;
                    case 4:
                        PlaceMiddle(green4);
                        break;
                    case 5:
                        PlaceMiddle(green5);
                        break;
                    case 6:
                        PlaceMiddle(green6);
                        break;
                    case 7:
                        PlaceMiddle(green7);
                        break;
                    case 8:
                        PlaceMiddle(green8);
                        break;
                    case 9:
                        PlaceMiddle(green9);
                        break;
                }
                break;
        }
        p1CardColor[cp] = -1;
        p1CardNum[cp] = -1;
        
    }

    public void PlaceMiddle(GameObject card)
    {
        GameObject placed = Instantiate(card, middle.position, middle.rotation);
        placed.AddComponent<Rigidbody>();
        placed.gameObject.tag = "Placed";
    }

    public void GetRandomCard(int target)
    {
        int rndcolor = Random.Range(1, 5); //1=red, 2=yellow, 3=blue, 4=green
        int rndnum = Random.Range(0, 10);
        int i = 0;
        switch (target)
        {
            case 0:
                while (p1CardColor[i] != -1)
                {
                    i++;
                }
                if (p1CardColor[i] == -1)
                {
                    p1CardColor[i] = rndcolor;
                    p1CardNum[i] = rndnum;
                }
                switch (rndcolor)
                {
                    case 1:
                        switch (rndnum)
                        {
                            case 0:
                                Duplicate(red0, i);
                                break;
                            case 1:
                                Duplicate(red1, i);
                                break;
                            case 2:
                                Duplicate(red2, i);
                                break;
                            case 3:
                                Duplicate(red3, i);
                                break;
                            case 4:
                                Duplicate(red4, i);
                                break;
                            case 5:
                                Duplicate(red5, i);
                                break;
                            case 6:
                                Duplicate(red6, i);
                                break;
                            case 7:
                                Duplicate(red7, i);
                                break;
                            case 8:
                                Duplicate(red8, i);
                                break;
                            case 9:
                                Duplicate(red9, i);
                                break;
                        }
                        break;
                    case 2:
                        switch (rndnum)
                        {
                            case 0:
                                Duplicate(yellow0, i);
                                break;
                            case 1:
                                Duplicate(yellow1, i);
                                break;
                            case 2:
                                Duplicate(yellow2, i);
                                break;
                            case 3:
                                Duplicate(yellow3, i);
                                break;
                            case 4:
                                Duplicate(yellow4, i);
                                break;
                            case 5:
                                Duplicate(yellow5, i);
                                break;
                            case 6:
                                Duplicate(yellow6, i);
                                break;
                            case 7:
                                Duplicate(yellow7, i);
                                break;
                            case 8:
                                Duplicate(yellow8, i);
                                break;
                            case 9:
                                Duplicate(yellow9, i);
                                break;
                        }
                        break;
                    case 3:
                        switch (rndnum)
                        {
                            case 0:
                                Duplicate(blue0, i);
                                break;
                            case 1:
                                Duplicate(blue1, i);
                                break;
                            case 2:
                                Duplicate(blue2, i);
                                break;
                            case 3:
                                Duplicate(blue3, i);
                                break;
                            case 4:
                                Duplicate(blue4, i);
                                break;
                            case 5:
                                Duplicate(blue5, i);
                                break;
                            case 6:
                                Duplicate(blue6, i);
                                break;
                            case 7:
                                Duplicate(blue7, i);
                                break;
                            case 8:
                                Duplicate(blue8, i);
                                break;
                            case 9:
                                Duplicate(blue9, i);
                                break;
                        }
                        break;
                    case 4:
                        switch (rndnum)
                        {
                            case 0:
                                Duplicate(green0, i);
                                break;
                            case 1:
                                Duplicate(green1, i);
                                break;
                            case 2:
                                Duplicate(green2, i);
                                break;
                            case 3:
                                Duplicate(green3, i);
                                break;
                            case 4:
                                Duplicate(green4, i);
                                break;
                            case 5:
                                Duplicate(green5, i);
                                break;
                            case 6:
                                Duplicate(green6, i);
                                break;
                            case 7:
                                Duplicate(green7, i);
                                break;
                            case 8:
                                Duplicate(green8, i);
                                break;
                            case 9:
                                Duplicate(green9, i);
                                break;
                        }
                        break;
                }
                break;
            case 1:
                while (ai1CardColor[i] != -1)
                {
                    i++;
                }
                if (ai1CardColor[i] == -1)
                {
                    ai1CardColor[i] = rndcolor;
                    ai1CardNum[i] = rndnum;
                }
                break;
            case 2:
                while (ai2CardColor[i] != -1)
                {
                    i++;
                }
                if (ai2CardColor[i] == -1)
                {
                    ai2CardColor[i] = rndcolor;
                    ai2CardNum[i] = rndnum;
                }
                break;
            case 3:
                while (ai3CardColor[i] != -1)
                {
                    i++;
                }
                if (ai3CardColor[i] == -1)
                {
                    ai3CardColor[i] = rndcolor;
                    ai3CardNum[i] = rndnum;
                }
                break;
        }
    }
    void Duplicate(GameObject card , int position)
    {
        nextP1SpawnPoint = p1SpawnPoint.position;
        nextP1SpawnPoint.x = p1SpawnPoint.position.x + position;
        GameObject clone = Instantiate(card, nextP1SpawnPoint, p1SpawnPoint.rotation);

    }
}

