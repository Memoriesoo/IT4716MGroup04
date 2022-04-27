using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    public GameObject attackyellow1;
    public GameObject attackyellow2;
    public GameObject attackyellow3;
    public GameObject attackyellow4;
    public GameObject attackyellow5;
    public GameObject attackyellow6;
    public GameObject attackyellow7;
    public GameObject attackyellow8;
    public GameObject attackyellow9;
    public GameObject attackblue1;
    public GameObject attackblue2;
    public GameObject attackblue3;
    public GameObject attackblue4;
    public GameObject attackblue5;
    public GameObject attackblue6;
    public GameObject attackblue7;
    public GameObject attackblue8;
    public GameObject attackblue9;
    public GameObject attackred1;
    public GameObject attackred2;
    public GameObject attackred3;
    public GameObject attackred4;
    public GameObject attackred5;
    public GameObject attackred6;
    public GameObject attackred7;
    public GameObject attackred8;
    public GameObject attackred9;
    public GameObject attackgreen1;
    public GameObject attackgreen2;
    public GameObject attackgreen3;
    public GameObject attackgreen4;
    public GameObject attackgreen5;
    public GameObject attackgreen6;
    public GameObject attackgreen7;
    public GameObject attackgreen8;
    public GameObject attackgreen9;

    public GameObject healyellow1;
    public GameObject healyellow2;
    public GameObject healyellow3;
    public GameObject healyellow4;
    public GameObject healyellow5;
    public GameObject healyellow6;
    public GameObject healyellow7;
    public GameObject healyellow8;
    public GameObject healyellow9;
    public GameObject healblue1;
    public GameObject healblue2;
    public GameObject healblue3;
    public GameObject healblue4;
    public GameObject healblue5;
    public GameObject healblue6;
    public GameObject healblue7;
    public GameObject healblue8;
    public GameObject healblue9;
    public GameObject healred1;
    public GameObject healred2;
    public GameObject healred3;
    public GameObject healred4;
    public GameObject healred5;
    public GameObject healred6;
    public GameObject healred7;
    public GameObject healred8;
    public GameObject healred9;
    public GameObject healgreen1;
    public GameObject healgreen2;
    public GameObject healgreen3;
    public GameObject healgreen4;
    public GameObject healgreen5;
    public GameObject healgreen6;
    public GameObject healgreen7;
    public GameObject healgreen8;
    public GameObject healgreen9;
    public GameObject healanimation;

    public GameObject reverseyellow;
    public GameObject reverseblue;
    public GameObject reversered;
    public GameObject reversegreen;

    public GameObject skipyellow;
    public GameObject skipblue;
    public GameObject skipred;
    public GameObject skipgreen;

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
    public Slider roundTimeSlider;
    public Button getCardButton;
    public GameObject targetMenu;
    public GameObject currentRound;

    private int round = 0;

    public GameObject playerCounter;
    public GameObject ai1Counter;
    public GameObject ai2Counter;
    public GameObject ai3Counter;
    public GameObject TimerCounter;
    public GameObject RoundTimeCounter;

    public GameObject win;
    public GameObject lose;

    public AudioSource click;
    public AudioSource place;
    public AudioSource send;
    public AudioSource attack;
    public AudioSource heal;

    public Slider soundVolumeSlider;

    public GameObject Ai1Ui;
    public GameObject Ai2Ui;
    public GameObject Ai3Ui;
    public GameObject PlayerUi;
    public GameObject hitanimation;

    bool hitAnimation = false;

    Text roundTimer;
    Text timer;
    Text playerCounterText;
    Text ai1CounterText;
    Text ai2CounterText;
    Text ai3CounterText;
    Text currentRoundText;

    Vector3 nextP1SpawnPoint;
    Vector3 cardXPosition;
    Vector3 attackCardPosition;

    GameObject placingCard;

    bool nextOne = true;
    bool clockwise = false;
    bool choosingTarget = false;

    int healValue = 0;
    int attackValue = 0;
    int mins = 9;
    float sec = 60;
    float roundTime = 20;
    float animationTime = 2;

    int playerCardAmount = 10;
    int playerLife = 1;
    int ai1CardAmount = 10;
    int ai1Life = 50;
    int ai2CardAmount = 10;
    int ai2Life = 50;
    int ai3CardAmount = 10;
    int ai3Life = 50;

    int[] p1CardColor = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] p1CardNum = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] p1CardType = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai1CardColor = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai1CardNum = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai1CardType = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai2CardColor = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai2CardNum = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai2CardType = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai3CardColor = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai3CardNum = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] ai3CardType = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int[] lastCard = new int[3];


    //Color: 1=red, 2=yellow, 3=blue, 4=green
    //Type: 1=basic , 2=attack, 3=heal, 4=reverse, 5=skip
    public void Click()
    {
        click.Play();
    }
    private void Start()
    {
        send.Play();
        roundTimer = RoundTimeCounter.GetComponent<Text>();
        timer = TimerCounter.GetComponent<Text>();
        playerCounterText = playerCounter.GetComponent<Text>();
        ai1CounterText = ai1Counter.GetComponent<Text>();
        ai2CounterText = ai2Counter.GetComponent<Text>();
        ai3CounterText = ai3Counter.GetComponent<Text>();
        currentRoundText = currentRound.GetComponent<Text>();
        StartCard();
        for (int a=0;a<10;a++)
        {
            GetRandomCard(0);
            GetRandomCard(1);
            GetRandomCard(2);
            GetRandomCard(3);
        }
    }
    private void Update()
    {
        if(hitAnimation==true)
        {
            hitanimation.SetActive(true);
            animationTime -= Time.deltaTime;
            if(animationTime <= 0)
            {
                hitanimation.SetActive(false);
                hitAnimation = false;
                animationTime = 1;
            }
        }
        fill();
        if (ai1Life <= 0 && ai2Life <= 0 && ai3Life <= 0)
        {
            Win();
        }
        if (playerLife <= 0 || ((mins <= 0 && sec <= 0) && (playerLife <= ai1Life || playerLife <= ai2Life || playerLife <= ai3Life)))
        {
            Lose();
        }
        click.volume = soundVolumeSlider.value;
        place.volume = soundVolumeSlider.value;
        send.volume = soundVolumeSlider.value;
        attack.volume = soundVolumeSlider.value;
        heal.volume = soundVolumeSlider.value;


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


        roundTimer.text = Mathf.Ceil(roundTime).ToString();
        roundTime -= Time.deltaTime;
        roundTimeSlider.value = roundTime;

        playerCounterText.text = "Card Left: " + playerCardAmount.ToString() + " " + "Life: " + playerLife.ToString();
        ai1CounterText.text = "Card Left: " + ai1CardAmount.ToString() + " " + "Life: " + ai1Life.ToString();
        ai2CounterText.text = "Card Left: " + ai2CardAmount.ToString() + " " + "Life: " + ai2Life.ToString();
        ai3CounterText.text = "Card Left: " + ai3CardAmount.ToString() + " " + "Life: " + ai3Life.ToString();
        currentRoundText.text = "Round: P" + (round + 1).ToString();

        Player();
        AI1();
        AI2();
        AI3();

        
    }

    public void fill()
    {
        for (int i = 0; i < 20; i++)
        {
            int cp = 0;
            while (p1CardColor[cp] != -1 && cp < 18)
            {
                cp++;
            }
            if (p1CardColor[cp] == -1 && p1CardColor[cp + 1] != -1)
            {
                GameObject[] choose;
                choose = GameObject.FindGameObjectsWithTag("Card");
                foreach (GameObject choosed in choose)
                {
                    if (choosed.transform.position.x == cp - 7)
                    {
                        Vector3 pos = choosed.transform.position;
                        pos.x = cp - 8;
                        p1CardColor[cp] = p1CardColor[cp + 1];
                        p1CardNum[cp] = p1CardNum[cp + 1];
                        p1CardType[cp] = p1CardType[cp + 1];
                        p1CardColor[cp + 1] = -1;
                        p1CardNum[cp + 1] = -1;
                        p1CardType[cp + 1] = -1;
                        choosed.transform.position = pos;
                    }
                }
            }
        }
    }
    public void Player()
    {
        if (round == 0)
        {
            getCardButton.gameObject.SetActive(true);
            roundTimeSlider.gameObject.SetActive(true);
            healanimation.SetActive(false);
            hitanimation.SetActive(false);
            if (nextOne == true)
            {
                roundTime = 20;
                nextOne = false;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit pointer;
                if (Physics.Raycast(ray, out pointer, 20))
                {
                    if (pointer.collider.tag == "Card")
                    {
                        cardXPosition = pointer.collider.GetComponent<Transform>().position;
                        if ((p1CardColor[(int)cardXPosition.x + 8] == lastCard[0] || (p1CardNum[(int)cardXPosition.x + 8] == lastCard[1] && p1CardNum[(int)cardXPosition.x + 8] != (-2)) || (p1CardType[(int)cardXPosition.x + 8] == lastCard[2] &&
                            (p1CardType[(int)cardXPosition.x + 8] == 4 || p1CardType[(int)cardXPosition.x + 8] == 5))) && choosingTarget == false)
                        {
                            if (p1CardType[(int)cardXPosition.x + 8] != 2)
                            {
                                Destroy(pointer.collider.gameObject);
                                playerCardAmount -= 1;
                                nextOne = true;
                                roundTimeSlider.gameObject.SetActive(false);
                                getCardButton.gameObject.SetActive(false);
                                if (p1CardType[(int)cardXPosition.x + 8] == 5)
                                {
                                        round = 2;
                                }
                                else if (p1CardType[(int)cardXPosition.x + 8] == 4)
                                {
                                    if (clockwise == false)
                                    {
                                        round = 3;
                                    }
                                    else
                                    {
                                        round = 1;
                                    }
                                }
                                else
                                {
                                    if (clockwise == false)
                                    {
                                        round = 1;
                                    }
                                    else
                                    {
                                        round = 3;
                                    }
                                }
                                PlaceCard(cardXPosition);
                            }
                            else
                            {
                                choosingTarget = true;
                                targetMenu.SetActive(true);
                                attackValue = p1CardNum[(int)cardXPosition.x + 8];
                                attackCardPosition = cardXPosition;
                            }
                        }
                    }
                }
            }
            if(roundTime <= 0)
            {
                //playerLife -= 2;
                GetCard(0);
                if (clockwise == false)
                {
                    round = 1;
                }
                else
                    round = 3;
            }
        }
        
    }
    public void AI1()
    {
        if (ai1Life <= 0) ai1Life = 0;
        if (round == 1)
        {
            if (ai1Life > 0)
            {
                if (nextOne == true)
                {
                    roundTime = 20;
                    nextOne = false;
                }
                if (roundTime < 18)
                {
                    int i = 0;
                    while (ai1CardColor[i] != lastCard[0] && (ai1CardNum[i] != lastCard[1] && ai1CardNum[i] == (-2)) && (ai1CardType[i] != lastCard[2] && (ai1CardType[i] != 4 || ai1CardType[i] != 5)) && i < 19)
                    {
                        i++;
                    }
                    if (ai1CardColor[i] == lastCard[0] || (ai1CardNum[i] == lastCard[1] && ai1CardNum[i] != (-2)) || (ai1CardType[i] == lastCard[2] && (ai1CardType[i] == 4 || ai1CardType[i] == 5)))
                    {
                        nextOne = true;
                        if (ai1CardType[i] != 5)
                        {
                            if (clockwise == false)
                            {
                                round = 2;
                            }
                            else round = 0;
                        }
                        else if (ai1CardType[i] == 5)
                        {
                            round = 3;
                        }
                        AIPlaceCard(1, i);
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
            else if (clockwise == false)
            {
                round = 2;
            }
            else round = 0;
        }
    }

    public void AI2()
    {
        if (ai2Life <= 0) ai2Life = 0;
        if (round == 2)
        {
            if (ai2Life > 0)
            {
                if (nextOne == true)
                {
                    roundTime = 20;
                    nextOne = false;
                }
                if (roundTime < 18)
                {
                    int i = 0;
                    while (ai2CardColor[i] != lastCard[0] && (ai2CardNum[i] != lastCard[1] && ai2CardNum[i] == (-2)) && (ai2CardType[i] != lastCard[2] && (ai2CardType[i] != 4 || ai2CardType[i] != 5)) && i < 19)
                    {
                        i++;
                    }
                    if (ai2CardColor[i] == lastCard[0] || (ai2CardNum[i] == lastCard[1] && ai2CardNum[i] != (-2)) || (ai2CardType[i] == lastCard[2] && (ai2CardType[i] == 4 || ai2CardType[i] == 5)))
                    {
                        nextOne = true;
                        if (ai2CardType[i] != 5)
                        {
                            if (clockwise == false)
                            {
                                round = 3;
                            }
                            else round = 1;
                        }
                        else if (ai2CardType[i] == 5)
                        {
                            round = 0;
                        }
                        AIPlaceCard(2, i);
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
            else if (clockwise == false)
            {
                round = 3;
            }
            else round = 1;
        }
    }

    public void AI3()
    {
        if (ai3Life <= 0) ai3Life = 0;
        if (round == 3) 
        {
            if (ai3Life > 0)
            {
                if (nextOne == true)
                {
                    roundTime = 20;
                    nextOne = false;
                }
                if (roundTime < 18)
                {
                    int i = 0;
                    while (ai3CardColor[i] != lastCard[0] && (ai3CardNum[i] != lastCard[1] && ai3CardNum[i] == (-2)) && (ai3CardType[i] != lastCard[2] && (ai3CardType[i] != 4 || ai3CardType[i] != 5)) && i < 19)
                    {
                        i++;
                    }
                    if (ai3CardColor[i] == lastCard[0] || (ai3CardNum[i] == lastCard[1] && ai3CardNum[i] != (-2)) || (ai3CardType[i] == lastCard[2] && (ai3CardType[i] == 4 || ai3CardType[i] == 5)))
                    {
                        nextOne = true;
                        if (ai3CardType[i] != 5)
                        {
                            if (clockwise == false)
                            {
                                round = 0;
                            }
                            else round = 2;
                        }
                        else if (ai3CardType[i] == 5)
                        {
                            round = 1;
                        }
                        AIPlaceCard(3, i);
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
            else if (clockwise == false)
            {
                round = 0;
            }
            else round = 2;
        }
    }
    public void StartCard()
    {
        GameObject startCard;
        int rndcolor = Random.Range(1, 5); //1=red, 2=yellow, 3=blue, 4=green
        int rndnum = Random.Range(0, 10);
        int rndtype = Random.Range(1, 6);
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

    public void Attack(int attacktarget)
    {
        hitAnimation = true;
        Vector3 cp = attackCardPosition;
        switch (attacktarget)
        {
            case 1:
                if(ai1Life > 0)
                {
                    hitanimation.transform.position = Ai1Ui.transform.position;
                    choosingTarget = false;
                    ai1Life -= attackValue;
                    PlaceCard(attackCardPosition);
                    targetMenu.SetActive(false);
                    playerCardAmount -= 1;
                    nextOne = true;
                    roundTimeSlider.gameObject.SetActive(false);
                    getCardButton.gameObject.SetActive(false);
                    GameObject[] AIchoose;
                    AIchoose = GameObject.FindGameObjectsWithTag("Card");
                    foreach (GameObject choosed in AIchoose)
                    {
                        if (choosed.transform.position == cp)
                        {
                            Destroy(choosed);
                        }
                    }
                    if (clockwise == false)
                    {
                        round = 1;
                    }
                    else round = 3;

                }
                break;
            case 2:
                if (ai2Life > 0)
                {
                    hitanimation.transform.position = Ai2Ui.transform.position;
                    choosingTarget = false;
                    ai2Life -= attackValue;
                    PlaceCard(attackCardPosition);
                    targetMenu.SetActive(false);
                    playerCardAmount -= 1;
                    nextOne = true;
                    roundTimeSlider.gameObject.SetActive(false);
                    getCardButton.gameObject.SetActive(false);
                    GameObject[] AIchoose;
                    AIchoose = GameObject.FindGameObjectsWithTag("Card");
                    foreach (GameObject choosed in AIchoose)
                    {
                        if (choosed.transform.position == cp)
                        {
                            Destroy(choosed);
                        }
                    }
                    if (clockwise == false)
                    {
                        round = 1;
                    }
                    else round = 3;
                }
                break;
            case 3:
                if (ai3Life > 0)
                {
                    hitanimation.transform.position = Ai3Ui.transform.position;
                    choosingTarget = false;
                    ai3Life -= attackValue;
                    PlaceCard(attackCardPosition);
                    targetMenu.SetActive(false);
                    playerCardAmount -= 1;
                    nextOne = true;
                    roundTimeSlider.gameObject.SetActive(false);
                    getCardButton.gameObject.SetActive(false);
                    GameObject[] AIchoose;
                    AIchoose = GameObject.FindGameObjectsWithTag("Card");
                    foreach (GameObject choosed in AIchoose)
                    {
                        if (choosed.transform.position == cp)
                        {
                            Destroy(choosed);
                        }
                    }
                    if (clockwise == false)
                    {
                        round = 1;
                    }
                    else round = 3;
                }
                break;
        }
        attack.Play();
    }

    public void AIAttack(int target, int position)
    {
        switch (target)
        {
            case 0:
                if (ai1Life > 0)
                {
                    hitAnimation = true;
                    hitanimation.transform.position = Ai1Ui.transform.position;
                    ai1Life -= attackValue;
                    PlaceCard(attackCardPosition);
                    roundTimeSlider.gameObject.SetActive(false);
                    getCardButton.gameObject.SetActive(false);
                    targetMenu.SetActive(false);
                }
                else if (ai2Life > 0)
                {
                    hitAnimation = true;
                    hitanimation.transform.position = Ai2Ui.transform.position;
                    ai2Life -= attackValue;
                    PlaceCard(attackCardPosition);
                    roundTimeSlider.gameObject.SetActive(false);
                    getCardButton.gameObject.SetActive(false);
                    targetMenu.SetActive(false);
                }
                else
                {
                    hitAnimation = true;
                    hitanimation.transform.position = Ai3Ui.transform.position;
                    ai3Life -= attackValue;
                    PlaceCard(attackCardPosition);
                    roundTimeSlider.gameObject.SetActive(false);
                    getCardButton.gameObject.SetActive(false);
                    targetMenu.SetActive(false);
                }
                break;
            case 1:
                if (ai2Life > 0)
                {
                    hitAnimation = true;
                    hitanimation.transform.position = Ai2Ui.transform.position;
                    ai2Life -= attackValue;
                }
                else if (ai3Life > 0)
                {
                    hitAnimation = true;
                    hitanimation.transform.position = Ai3Ui.transform.position;
                    ai3Life -= attackValue;
                }
                else
                {
                    hitAnimation = true;
                    hitanimation.transform.position = PlayerUi.transform.position;
                    playerLife -= attackValue;
                }
                break;
            case 2:
                if (ai3Life > 0)
                {
                    hitAnimation = true;
                    hitanimation.transform.position = Ai3Ui.transform.position;
                    ai3Life -= attackValue;
                }
                else if (playerLife > 0)
                {
                    hitAnimation = true;
                    hitanimation.transform.position = PlayerUi.transform.position;
                    playerLife -= attackValue;
                }
                else
                {
                    hitAnimation = true;
                    hitanimation.transform.position = Ai1Ui.transform.position;
                    ai1Life -= attackValue;
                }
                break;
            case 3:
                if (playerLife > 0)
                {
                    hitAnimation = true;
                    hitanimation.transform.position = PlayerUi.transform.position;
                    playerLife -= attackValue;
                }
                else if (ai1Life > 0)
                {
                    hitAnimation = true;
                    hitanimation.transform.position = Ai1Ui.transform.position;
                    ai1Life -= attackValue;
                }
                else
                {
                    hitAnimation = true;
                    hitanimation.transform.position = Ai2Ui.transform.position;
                    ai2Life -= attackValue;
                }
                break;
        }
        attack.Play();
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
                    getCardButton.gameObject.SetActive(false);
                    if (clockwise == false)
                    {
                        nextOne = true;
                        round = 1;
                        roundTimeSlider.gameObject.SetActive(false);
                    }
                    else
                    {
                        nextOne = true;
                        round = 3;
                        roundTimeSlider.gameObject.SetActive(false);
                    }
                }
                else
                {
                    playerLife -= 2;
                    RandomChangeCard(0);
                    getCardButton.gameObject.SetActive(false);
                    if (clockwise == false)
                    {
                        nextOne = true;
                        round = 1;
                        roundTimeSlider.gameObject.SetActive(false);
                    }
                    else
                    {
                        nextOne = true;
                        round = 3;
                        roundTimeSlider.gameObject.SetActive(false);
                    }
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
                else
                {
                    ai1Life -= 2;
                    RandomChangeCard(1);
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
                else
                {
                    ai2Life -= 2;
                    RandomChangeCard(2);
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
                else
                {
                    ai3Life -= 2;
                    RandomChangeCard(3);
                }
                break;
            default:
                break;
        }
        send.Play();
    }

    public void AIPlaceCard(int target, int cp)
    {
        if (target == 1)
        {
            lastCard[0] = ai1CardColor[cp];
            lastCard[1] = ai1CardNum[cp];
            lastCard[2] = ai1CardType[cp];
            switch (ai1CardType[cp])
            {
                case 1:
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
                    break;
                case 2:
                    attackValue = ai1CardNum[cp];
                    AIAttack(1,cp);
                    switch (ai1CardColor[cp])
                    {
                        case 1:
                            switch (ai1CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackred1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackred2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackred3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackred4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackred5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackred6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackred7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackred8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackred9);
                                    break;
                            }
                            break;
                        case 2:
                            switch (ai1CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackyellow1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackyellow2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackyellow3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackyellow4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackyellow5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackyellow6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackyellow7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackyellow8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackyellow9);
                                    break;
                            }
                            break;
                        case 3:
                            switch (ai1CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackblue1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackblue2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackblue3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackblue4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackblue5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackblue6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackblue7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackblue8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackblue9); ;
                                    break;
                            }
                            break;
                        case 4:
                            switch (ai1CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackgreen1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackgreen2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackgreen3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackgreen4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackgreen5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackgreen6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackgreen7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackgreen8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackgreen9);
                                    break;
                            }
                            break;
                    }
                    break;
                case 3:
                    ai1Life += ai1CardNum[cp];
                    switch (ai1CardColor[cp])
                    {
                        case 1:
                            switch (ai1CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healred1);
                                    break;
                                case 2:
                                    PlaceMiddle(healred2);
                                    break;
                                case 3:
                                    PlaceMiddle(healred3);
                                    break;
                                case 4:
                                    PlaceMiddle(healred4);
                                    break;
                                case 5:
                                    PlaceMiddle(healred5);
                                    break;
                                case 6:
                                    PlaceMiddle(healred6);
                                    break;
                                case 7:
                                    PlaceMiddle(healred7);
                                    break;
                                case 8:
                                    PlaceMiddle(healred8);
                                    break;
                                case 9:
                                    PlaceMiddle(healred9);
                                    break;
                            }
                            break;
                        case 2:
                            switch (ai1CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healyellow1);
                                    break;
                                case 2:
                                    PlaceMiddle(healyellow2);
                                    break;
                                case 3:
                                    PlaceMiddle(healyellow3);
                                    break;
                                case 4:
                                    PlaceMiddle(healyellow4);
                                    break;
                                case 5:
                                    PlaceMiddle(healyellow5);
                                    break;
                                case 6:
                                    PlaceMiddle(healyellow6);
                                    break;
                                case 7:
                                    PlaceMiddle(healyellow7);
                                    break;
                                case 8:
                                    PlaceMiddle(healyellow8);
                                    break;
                                case 9:
                                    PlaceMiddle(healyellow9);
                                    break;
                            }
                            break;
                        case 3:
                            switch (ai1CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healblue1);
                                    break;
                                case 2:
                                    PlaceMiddle(healblue2);
                                    break;
                                case 3:
                                    PlaceMiddle(healblue3);
                                    break;
                                case 4:
                                    PlaceMiddle(healblue4);
                                    break;
                                case 5:
                                    PlaceMiddle(healblue5);
                                    break;
                                case 6:
                                    PlaceMiddle(healblue6);
                                    break;
                                case 7:
                                    PlaceMiddle(healblue7);
                                    break;
                                case 8:
                                    PlaceMiddle(healblue8);
                                    break;
                                case 9:
                                    PlaceMiddle(healblue9); ;
                                    break;
                            }
                            break;
                        case 4:
                            switch (ai1CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healgreen1);
                                    break;
                                case 2:
                                    PlaceMiddle(healgreen2);
                                    break;
                                case 3:
                                    PlaceMiddle(healgreen3);
                                    break;
                                case 4:
                                    PlaceMiddle(healgreen4);
                                    break;
                                case 5:
                                    PlaceMiddle(healgreen5);
                                    break;
                                case 6:
                                    PlaceMiddle(healgreen6);
                                    break;
                                case 7:
                                    PlaceMiddle(healgreen7);
                                    break;
                                case 8:
                                    PlaceMiddle(healgreen8);
                                    break;
                                case 9:
                                    PlaceMiddle(healgreen9);
                                    break;
                            }
                            break;
                    }
                    break;
                case 4:
                    if (clockwise == false)
                    {
                        clockwise = true;
                    }
                    else clockwise = false;
                    switch (ai1CardColor[cp])
                    { 
                        case 1:
                            PlaceMiddle(reversered);
                            break;
                        case 2:
                            PlaceMiddle(reverseyellow);
                            break;
                        case 3:
                            PlaceMiddle(reverseblue);
                            break;
                        case 4:
                            PlaceMiddle(reversegreen);
                            break;
                    }
                    break;
                case 5:
                    switch (ai1CardColor[cp])
                    {
                        case 1:
                            PlaceMiddle(skipred);
                            break;
                        case 2:
                            PlaceMiddle(skipyellow);
                            break;
                        case 3:
                            PlaceMiddle(skipblue);
                            break;
                        case 4:
                            PlaceMiddle(skipgreen);
                            break;
                    }
                    break;

            }
            ai1CardColor[cp] = -1;
            ai1CardNum[cp] = -1;
            ai1CardType[cp] = -1;
            ai1CardAmount -= 1;
        }
        if (target == 2)
        {
            lastCard[0] = ai2CardColor[cp];
            lastCard[1] = ai2CardNum[cp];
            lastCard[2] = ai2CardType[cp];
            switch (ai2CardType[cp])
            {
                case 1:
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
                    break;
                case 2:
                    attackValue = ai2CardNum[cp];
                    AIAttack(2,cp);
                    switch (ai2CardColor[cp])
                    {
                        case 1:
                            switch (ai2CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackred1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackred2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackred3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackred4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackred5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackred6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackred7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackred8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackred9);
                                    break;
                            }
                            break;
                        case 2:
                            switch (ai2CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackyellow1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackyellow2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackyellow3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackyellow4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackyellow5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackyellow6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackyellow7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackyellow8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackyellow9);
                                    break;
                            }
                            break;
                        case 3:
                            switch (ai2CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackblue1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackblue2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackblue3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackblue4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackblue5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackblue6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackblue7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackblue8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackblue9); ;
                                    break;
                            }
                            break;
                        case 4:
                            switch (ai2CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackgreen1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackgreen2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackgreen3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackgreen4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackgreen5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackgreen6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackgreen7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackgreen8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackgreen9);
                                    break;
                            }
                            break;
                    }
                    break;
                case 3:
                    ai2Life += ai2CardNum[cp];
                    switch (ai2CardColor[cp])
                    {
                        case 1:
                            switch (ai2CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healred1);
                                    break;
                                case 2:
                                    PlaceMiddle(healred2);
                                    break;
                                case 3:
                                    PlaceMiddle(healred3);
                                    break;
                                case 4:
                                    PlaceMiddle(healred4);
                                    break;
                                case 5:
                                    PlaceMiddle(healred5);
                                    break;
                                case 6:
                                    PlaceMiddle(healred6);
                                    break;
                                case 7:
                                    PlaceMiddle(healred7);
                                    break;
                                case 8:
                                    PlaceMiddle(healred8);
                                    break;
                                case 9:
                                    PlaceMiddle(healred9);
                                    break;
                            }
                            break;
                        case 2:
                            switch (ai2CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healyellow1);
                                    break;
                                case 2:
                                    PlaceMiddle(healyellow2);
                                    break;
                                case 3:
                                    PlaceMiddle(healyellow3);
                                    break;
                                case 4:
                                    PlaceMiddle(healyellow4);
                                    break;
                                case 5:
                                    PlaceMiddle(healyellow5);
                                    break;
                                case 6:
                                    PlaceMiddle(healyellow6);
                                    break;
                                case 7:
                                    PlaceMiddle(healyellow7);
                                    break;
                                case 8:
                                    PlaceMiddle(healyellow8);
                                    break;
                                case 9:
                                    PlaceMiddle(healyellow9);
                                    break;
                            }
                            break;
                        case 3:
                            switch (ai2CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healblue1);
                                    break;
                                case 2:
                                    PlaceMiddle(healblue2);
                                    break;
                                case 3:
                                    PlaceMiddle(healblue3);
                                    break;
                                case 4:
                                    PlaceMiddle(healblue4);
                                    break;
                                case 5:
                                    PlaceMiddle(healblue5);
                                    break;
                                case 6:
                                    PlaceMiddle(healblue6);
                                    break;
                                case 7:
                                    PlaceMiddle(healblue7);
                                    break;
                                case 8:
                                    PlaceMiddle(healblue8);
                                    break;
                                case 9:
                                    PlaceMiddle(healblue9); ;
                                    break;
                            }
                            break;
                        case 4:
                            switch (ai2CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healgreen1);
                                    break;
                                case 2:
                                    PlaceMiddle(healgreen2);
                                    break;
                                case 3:
                                    PlaceMiddle(healgreen3);
                                    break;
                                case 4:
                                    PlaceMiddle(healgreen4);
                                    break;
                                case 5:
                                    PlaceMiddle(healgreen5);
                                    break;
                                case 6:
                                    PlaceMiddle(healgreen6);
                                    break;
                                case 7:
                                    PlaceMiddle(healgreen7);
                                    break;
                                case 8:
                                    PlaceMiddle(healgreen8);
                                    break;
                                case 9:
                                    PlaceMiddle(healgreen9);
                                    break;
                            }
                            break;
                    }
                    break;
                case 4:
                    if (clockwise == false)
                    {
                        clockwise = true;
                    }
                    else clockwise = false;
                    switch (ai2CardColor[cp])
                    {
                        case 1:
                            PlaceMiddle(reversered);
                            break;
                        case 2:
                            PlaceMiddle(reverseyellow);
                            break;
                        case 3:
                            PlaceMiddle(reverseblue);
                            break;
                        case 4:
                            PlaceMiddle(reversegreen);
                            break;
                    }
                    break;
                case 5:
                    switch (ai2CardColor[cp])
                    {
                        case 1:
                            PlaceMiddle(skipred);
                            break;
                        case 2:
                            PlaceMiddle(skipyellow);
                            break;
                        case 3:
                            PlaceMiddle(skipblue);
                            break;
                        case 4:
                            PlaceMiddle(skipgreen);
                            break;
                    }
                    break;
            }
            ai2CardColor[cp] = -1;
            ai2CardNum[cp] = -1;
            ai2CardType[cp] = -1;
            ai2CardAmount -= 1;
        }
        if (target == 3)
        {
            lastCard[0] = ai3CardColor[cp];
            lastCard[1] = ai3CardNum[cp];
            lastCard[2] = ai3CardType[cp];
            switch (ai3CardType[cp])
            {
                case 1:
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
                    break;
                case 2:
                    attackValue = ai3CardNum[cp];
                    AIAttack(3,cp);
                    switch (ai3CardColor[cp])
                    {
                        case 1:
                            switch (ai3CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackred1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackred2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackred3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackred4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackred5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackred6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackred7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackred8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackred9);
                                    break;
                            }
                            break;
                        case 2:
                            switch (ai3CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackyellow1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackyellow2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackyellow3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackyellow4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackyellow5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackyellow6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackyellow7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackyellow8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackyellow9);
                                    break;
                            }
                            break;
                        case 3:
                            switch (ai3CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackblue1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackblue2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackblue3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackblue4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackblue5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackblue6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackblue7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackblue8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackblue9); ;
                                    break;
                            }
                            break;
                        case 4:
                            switch (ai3CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(attackgreen1);
                                    break;
                                case 2:
                                    PlaceMiddle(attackgreen2);
                                    break;
                                case 3:
                                    PlaceMiddle(attackgreen3);
                                    break;
                                case 4:
                                    PlaceMiddle(attackgreen4);
                                    break;
                                case 5:
                                    PlaceMiddle(attackgreen5);
                                    break;
                                case 6:
                                    PlaceMiddle(attackgreen6);
                                    break;
                                case 7:
                                    PlaceMiddle(attackgreen7);
                                    break;
                                case 8:
                                    PlaceMiddle(attackgreen8);
                                    break;
                                case 9:
                                    PlaceMiddle(attackgreen9);
                                    break;
                            }
                            break;
                    }
                    break;
                case 3:
                    ai3Life += ai3CardNum[cp];
                    switch (ai3CardColor[cp])
                    {
                        case 1:
                            switch (ai3CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healred1);
                                    break;
                                case 2:
                                    PlaceMiddle(healred2);
                                    break;
                                case 3:
                                    PlaceMiddle(healred3);
                                    break;
                                case 4:
                                    PlaceMiddle(healred4);
                                    break;
                                case 5:
                                    PlaceMiddle(healred5);
                                    break;
                                case 6:
                                    PlaceMiddle(healred6);
                                    break;
                                case 7:
                                    PlaceMiddle(healred7);
                                    break;
                                case 8:
                                    PlaceMiddle(healred8);
                                    break;
                                case 9:
                                    PlaceMiddle(healred9);
                                    break;
                            }
                            break;
                        case 2:
                            switch (ai3CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healyellow1);
                                    break;
                                case 2:
                                    PlaceMiddle(healyellow2);
                                    break;
                                case 3:
                                    PlaceMiddle(healyellow3);
                                    break;
                                case 4:
                                    PlaceMiddle(healyellow4);
                                    break;
                                case 5:
                                    PlaceMiddle(healyellow5);
                                    break;
                                case 6:
                                    PlaceMiddle(healyellow6);
                                    break;
                                case 7:
                                    PlaceMiddle(healyellow7);
                                    break;
                                case 8:
                                    PlaceMiddle(healyellow8);
                                    break;
                                case 9:
                                    PlaceMiddle(healyellow9);
                                    break;
                            }
                            break;
                        case 3:
                            switch (ai3CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healblue1);
                                    break;
                                case 2:
                                    PlaceMiddle(healblue2);
                                    break;
                                case 3:
                                    PlaceMiddle(healblue3);
                                    break;
                                case 4:
                                    PlaceMiddle(healblue4);
                                    break;
                                case 5:
                                    PlaceMiddle(healblue5);
                                    break;
                                case 6:
                                    PlaceMiddle(healblue6);
                                    break;
                                case 7:
                                    PlaceMiddle(healblue7);
                                    break;
                                case 8:
                                    PlaceMiddle(healblue8);
                                    break;
                                case 9:
                                    PlaceMiddle(healblue9); ;
                                    break;
                            }
                            break;
                        case 4:
                            switch (ai3CardNum[cp])
                            {
                                case 1:
                                    PlaceMiddle(healgreen1);
                                    break;
                                case 2:
                                    PlaceMiddle(healgreen2);
                                    break;
                                case 3:
                                    PlaceMiddle(healgreen3);
                                    break;
                                case 4:
                                    PlaceMiddle(healgreen4);
                                    break;
                                case 5:
                                    PlaceMiddle(healgreen5);
                                    break;
                                case 6:
                                    PlaceMiddle(healgreen6);
                                    break;
                                case 7:
                                    PlaceMiddle(healgreen7);
                                    break;
                                case 8:
                                    PlaceMiddle(healgreen8);
                                    break;
                                case 9:
                                    PlaceMiddle(healgreen9);
                                    break;
                            }
                            break;
                    }
                    break;
                case 4:
                    if (clockwise == false)
                    {
                        clockwise = true;
                    }
                    else clockwise = false;
                    switch (ai3CardColor[cp])
                    {
                        case 1:
                            PlaceMiddle(reversered);
                            break;
                        case 2:
                            PlaceMiddle(reverseyellow);
                            break;
                        case 3:
                            PlaceMiddle(reverseblue);
                            break;
                        case 4:
                            PlaceMiddle(reversegreen);
                            break;
                    }
                    break;
                case 5:
                    switch (ai3CardColor[cp])
                    {
                        case 1:
                            PlaceMiddle(skipred);
                            break;
                        case 2:
                            PlaceMiddle(skipyellow);
                            break;
                        case 3:
                            PlaceMiddle(skipblue);
                            break;
                        case 4:
                            PlaceMiddle(skipgreen);
                            break;
                    }
                    break;
            }
            ai3CardColor[cp] = -1;
            ai3CardNum[cp] = -1;
            ai3CardType[cp] = -1;
            ai3CardAmount -= 1;
        }
        place.Play();
        
    }
    public void PlaceCard(Vector3 position)
    {

        int cp = (int)position.x + 8; //cp = card position , first card = 0
        lastCard[0] = p1CardColor[cp];
        lastCard[1] = p1CardNum[cp];
        lastCard[2] = p1CardType[cp];
        switch (p1CardType[cp])
        {
            case 1:
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
                                PlaceMiddle(blue9); ;
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
                break;
            case 2:
                switch (p1CardColor[cp])
                {
                    case 1:
                        switch (p1CardNum[cp])
                        {
                            case 1:
                                PlaceMiddle(attackred1);
                                break;
                            case 2:
                                PlaceMiddle(attackred2);
                                break;
                            case 3:
                                PlaceMiddle(attackred3);
                                break;
                            case 4:
                                PlaceMiddle(attackred4);
                                break;
                            case 5:
                                PlaceMiddle(attackred5);
                                break;
                            case 6:
                                PlaceMiddle(attackred6);
                                break;
                            case 7:
                                PlaceMiddle(attackred7);
                                break;
                            case 8:
                                PlaceMiddle(attackred8);
                                break;
                            case 9:
                                PlaceMiddle(attackred9);
                                break;
                        }
                        break;
                    case 2:
                        switch (p1CardNum[cp])
                        {
                            case 1:
                                PlaceMiddle(attackyellow1);
                                break;
                            case 2:
                                PlaceMiddle(attackyellow2);
                                break;
                            case 3:
                                PlaceMiddle(attackyellow3);
                                break;
                            case 4:
                                PlaceMiddle(attackyellow4);
                                break;
                            case 5:
                                PlaceMiddle(attackyellow5);
                                break;
                            case 6:
                                PlaceMiddle(attackyellow6);
                                break;
                            case 7:
                                PlaceMiddle(attackyellow7);
                                break;
                            case 8:
                                PlaceMiddle(attackyellow8);
                                break;
                            case 9:
                                PlaceMiddle(attackyellow9);
                                break;
                        }
                        break;
                    case 3:
                        switch (p1CardNum[cp])
                        {
                            case 1:
                                PlaceMiddle(attackblue1);
                                break;
                            case 2:
                                PlaceMiddle(attackblue2);
                                break;
                            case 3:
                                PlaceMiddle(attackblue3);
                                break;
                            case 4:
                                PlaceMiddle(attackblue4);
                                break;
                            case 5:
                                PlaceMiddle(attackblue5);
                                break;
                            case 6:
                                PlaceMiddle(attackblue6);
                                break;
                            case 7:
                                PlaceMiddle(attackblue7);
                                break;
                            case 8:
                                PlaceMiddle(attackblue8);
                                break;
                            case 9:
                                PlaceMiddle(attackblue9); ;
                                break;
                        }
                        break;
                    case 4:
                        switch (p1CardNum[cp])
                        {
                            case 1:
                                PlaceMiddle(attackgreen1);
                                break;
                            case 2:
                                PlaceMiddle(attackgreen2);
                                break;
                            case 3:
                                PlaceMiddle(attackgreen3);
                                break;
                            case 4:
                                PlaceMiddle(attackgreen4);
                                break;
                            case 5:
                                PlaceMiddle(attackgreen5);
                                break;
                            case 6:
                                PlaceMiddle(attackgreen6);
                                break;
                            case 7:
                                PlaceMiddle(attackgreen7);
                                break;
                            case 8:
                                PlaceMiddle(attackgreen8);
                                break;
                            case 9:
                                PlaceMiddle(attackgreen9);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                playerLife += p1CardNum[cp];
                healanimation.SetActive(true);
                switch (p1CardColor[cp])
                {
                    case 1:
                        switch (p1CardNum[cp])
                        {
                            case 1:
                                PlaceMiddle(healred1);
                                break;
                            case 2:
                                PlaceMiddle(healred2);
                                break;
                            case 3:
                                PlaceMiddle(healred3);
                                break;
                            case 4:
                                PlaceMiddle(healred4);
                                break;
                            case 5:
                                PlaceMiddle(healred5);
                                break;
                            case 6:
                                PlaceMiddle(healred6);
                                break;
                            case 7:
                                PlaceMiddle(healred7);
                                break;
                            case 8:
                                PlaceMiddle(healred8);
                                break;
                            case 9:
                                PlaceMiddle(healred9);
                                break;
                        }
                        break;
                    case 2:
                        switch (p1CardNum[cp])
                        {
                            case 1:
                                PlaceMiddle(healyellow1);
                                break;
                            case 2:
                                PlaceMiddle(healyellow2);
                                break;
                            case 3:
                                PlaceMiddle(healyellow3);
                                break;
                            case 4:
                                PlaceMiddle(healyellow4);
                                break;
                            case 5:
                                PlaceMiddle(healyellow5);
                                break;
                            case 6:
                                PlaceMiddle(healyellow6);
                                break;
                            case 7:
                                PlaceMiddle(healyellow7);
                                break;
                            case 8:
                                PlaceMiddle(healyellow8);
                                break;
                            case 9:
                                PlaceMiddle(healyellow9);
                                break;
                        }
                        break;
                    case 3:
                        switch (p1CardNum[cp])
                        {
                            case 1:
                                PlaceMiddle(healblue1);
                                break;
                            case 2:
                                PlaceMiddle(healblue2);
                                break;
                            case 3:
                                PlaceMiddle(healblue3);
                                break;
                            case 4:
                                PlaceMiddle(healblue4);
                                break;
                            case 5:
                                PlaceMiddle(healblue5);
                                break;
                            case 6:
                                PlaceMiddle(healblue6);
                                break;
                            case 7:
                                PlaceMiddle(healblue7);
                                break;
                            case 8:
                                PlaceMiddle(healblue8);
                                break;
                            case 9:
                                PlaceMiddle(healblue9); ;
                                break;
                        }
                        break;
                    case 4:
                        switch (p1CardNum[cp])
                        {
                            case 1:
                                PlaceMiddle(healgreen1);
                                break;
                            case 2:
                                PlaceMiddle(healgreen2);
                                break;
                            case 3:
                                PlaceMiddle(healgreen3);
                                break;
                            case 4:
                                PlaceMiddle(healgreen4);
                                break;
                            case 5:
                                PlaceMiddle(healgreen5);
                                break;
                            case 6:
                                PlaceMiddle(healgreen6);
                                break;
                            case 7:
                                PlaceMiddle(healgreen7);
                                break;
                            case 8:
                                PlaceMiddle(healgreen8);
                                break;
                            case 9:
                                PlaceMiddle(healgreen9);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                if (clockwise == false)
                {
                    clockwise = true;
                }
                else clockwise = false;
                switch (p1CardColor[cp])
                {
                    case 1:
                        PlaceMiddle(reversered);
                        break;
                    case 2:
                        PlaceMiddle(reverseyellow);
                        break;
                    case 3:
                        PlaceMiddle(reverseblue);
                        break;
                    case 4:
                        PlaceMiddle(reversegreen);
                        break;
                }
                break;
            case 5:
                switch (p1CardColor[cp])
                {
                    case 1:
                        PlaceMiddle(skipred);
                        break;
                    case 2:
                        PlaceMiddle(skipyellow);
                        break;
                    case 3:
                        PlaceMiddle(skipblue);
                        break;
                    case 4:
                        PlaceMiddle(skipgreen);
                        break;
                }
                break;
        }
        p1CardColor[cp] = -1;
        p1CardNum[cp] = -1;
        p1CardType[cp] = -1;
        targetMenu.SetActive(false);
        place.Play();
    }

    public void PlaceMiddle(GameObject card)
    {
        GameObject placed = Instantiate(card, middle.position, middle.rotation);
        placed.AddComponent<Rigidbody>();
        placed.gameObject.tag = "Placed";
    }

    public void RandomChangeCard(int target)
    {
        GameObject[] AIchoose;
        int rndcolor = (int)Random.Range(1, 5);
        int rndnum = (int)Random.Range(0, 10);
        int rndtype = (int)Random.Range(1, 6);
        int rndposition = (int)Random.Range(0, 20);
        int i = 0;
        switch (target)
        {
            case 0:
                if (playerCardAmount < 20)
                {
                    while (p1CardColor[i] != -1)
                    {
                        i++;
                    }
                    if (p1CardColor[i] == -1)
                    {
                        p1CardColor[i] = rndcolor;
                        p1CardNum[i] = rndnum;
                        p1CardType[i] = rndtype;
                        playerCardAmount += 1;
                    }
                    switch (rndtype)
                    {
                        case 1:
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
                        case 2:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackred1, i);
                                            break;
                                        case 2:
                                            Duplicate(attackred2, i);
                                            break;
                                        case 3:
                                            Duplicate(attackred3, i);
                                            break;
                                        case 4:
                                            Duplicate(attackred4, i);
                                            break;
                                        case 5:
                                            Duplicate(attackred5, i);
                                            break;
                                        case 6:
                                            Duplicate(attackred6, i);
                                            break;
                                        case 7:
                                            Duplicate(attackred7, i);
                                            break;
                                        case 8:
                                            Duplicate(attackred8, i);
                                            break;
                                        case 9:
                                            Duplicate(attackred9, i);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackyellow1, i);
                                            break;
                                        case 2:
                                            Duplicate(attackyellow2, i);
                                            break;
                                        case 3:
                                            Duplicate(attackyellow3, i);
                                            break;
                                        case 4:
                                            Duplicate(attackyellow4, i);
                                            break;
                                        case 5:
                                            Duplicate(attackyellow5, i);
                                            break;
                                        case 6:
                                            Duplicate(attackyellow6, i);
                                            break;
                                        case 7:
                                            Duplicate(attackyellow7, i);
                                            break;
                                        case 8:
                                            Duplicate(attackyellow8, i);
                                            break;
                                        case 9:
                                            Duplicate(attackyellow9, i);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackblue1, i);
                                            break;
                                        case 2:
                                            Duplicate(attackblue2, i);
                                            break;
                                        case 3:
                                            Duplicate(attackblue3, i);
                                            break;
                                        case 4:
                                            Duplicate(attackblue4, i);
                                            break;
                                        case 5:
                                            Duplicate(attackblue5, i);
                                            break;
                                        case 6:
                                            Duplicate(attackblue6, i);
                                            break;
                                        case 7:
                                            Duplicate(attackblue7, i);
                                            break;
                                        case 8:
                                            Duplicate(attackblue8, i);
                                            break;
                                        case 9:
                                            Duplicate(attackblue9, i);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackgreen1, i);
                                            break;
                                        case 2:
                                            Duplicate(attackgreen2, i);
                                            break;
                                        case 3:
                                            Duplicate(attackgreen3, i);
                                            break;
                                        case 4:
                                            Duplicate(attackgreen4, i);
                                            break;
                                        case 5:
                                            Duplicate(attackgreen5, i);
                                            break;
                                        case 6:
                                            Duplicate(attackgreen6, i);
                                            break;
                                        case 7:
                                            Duplicate(attackgreen7, i);
                                            break;
                                        case 8:
                                            Duplicate(attackgreen8, i);
                                            break;
                                        case 9:
                                            Duplicate(attackgreen9, i);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 3:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healred1, i);
                                            break;
                                        case 2:
                                            Duplicate(healred2, i);
                                            break;
                                        case 3:
                                            Duplicate(healred3, i);
                                            break;
                                        case 4:
                                            Duplicate(healred4, i);
                                            break;
                                        case 5:
                                            Duplicate(healred5, i);
                                            break;
                                        case 6:
                                            Duplicate(healred6, i);
                                            break;
                                        case 7:
                                            Duplicate(healred7, i);
                                            break;
                                        case 8:
                                            Duplicate(healred8, i);
                                            break;
                                        case 9:
                                            Duplicate(healred9, i);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healyellow1, i);
                                            break;
                                        case 2:
                                            Duplicate(healyellow2, i);
                                            break;
                                        case 3:
                                            Duplicate(healyellow3, i);
                                            break;
                                        case 4:
                                            Duplicate(healyellow4, i);
                                            break;
                                        case 5:
                                            Duplicate(healyellow5, i);
                                            break;
                                        case 6:
                                            Duplicate(healyellow6, i);
                                            break;
                                        case 7:
                                            Duplicate(healyellow7, i);
                                            break;
                                        case 8:
                                            Duplicate(healyellow8, i);
                                            break;
                                        case 9:
                                            Duplicate(healyellow9, i);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healblue1, i);
                                            break;
                                        case 2:
                                            Duplicate(healblue2, i);
                                            break;
                                        case 3:
                                            Duplicate(healblue3, i);
                                            break;
                                        case 4:
                                            Duplicate(healblue4, i);
                                            break;
                                        case 5:
                                            Duplicate(healblue5, i);
                                            break;
                                        case 6:
                                            Duplicate(healblue6, i);
                                            break;
                                        case 7:
                                            Duplicate(healblue7, i);
                                            break;
                                        case 8:
                                            Duplicate(healblue8, i);
                                            break;
                                        case 9:
                                            Duplicate(healblue9, i);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healgreen1, i);
                                            break;
                                        case 2:
                                            Duplicate(healgreen2, i);
                                            break;
                                        case 3:
                                            Duplicate(healgreen3, i);
                                            break;
                                        case 4:
                                            Duplicate(healgreen4, i);
                                            break;
                                        case 5:
                                            Duplicate(healgreen5, i);
                                            break;
                                        case 6:
                                            Duplicate(healgreen6, i);
                                            break;
                                        case 7:
                                            Duplicate(healgreen7, i);
                                            break;
                                        case 8:
                                            Duplicate(healgreen8, i);
                                            break;
                                        case 9:
                                            Duplicate(healgreen9, i);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 4:
                            switch (rndcolor)
                            {
                                case 1:
                                    Duplicate(reversered, i);
                                    break;
                                case 2:
                                    Duplicate(reverseyellow, i);
                                    break;
                                case 3:
                                    Duplicate(reverseblue, i);
                                    break;
                                case 4:
                                    Duplicate(reversegreen, i);
                                    break;
                            }
                            break;
                        case 5:
                            switch (rndcolor)
                            {
                                case 1:
                                    Duplicate(skipred, i);
                                    break;
                                case 2:
                                    Duplicate(skipyellow, i);
                                    break;
                                case 3:
                                    Duplicate(skipblue, i);
                                    break;
                                case 4:
                                    Duplicate(skipgreen, i);
                                    break;
                            }
                            break;
                    }


                    int rnd = (int)Random.Range(0, 20);
                    while (rnd == i)
                    {
                        rnd = (int)Random.Range(0, 20);
                    }
                    rndcolor = (int)Random.Range(1, 5);
                    rndnum = (int)Random.Range(0, 10);
                    rndtype = (int)Random.Range(1, 3);
                    p1CardColor[rnd] = rndcolor;
                    p1CardNum[rnd] = rndnum;
                    p1CardType[rnd] = rndtype;
                    AIchoose = GameObject.FindGameObjectsWithTag("Card");
                    foreach (GameObject choosed in AIchoose)
                    {
                        if (choosed.transform.position.x == (rnd - 8))
                        {
                            Destroy(choosed);
                        }
                    }
                    switch (rndtype)
                    {
                        case 1:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 0:
                                            Duplicate(red0, rnd);
                                            break;
                                        case 1:
                                            Duplicate(red1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(red2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(red3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(red4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(red5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(red6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(red7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(red8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(red9, rnd);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 0:
                                            Duplicate(yellow0, rnd);
                                            break;
                                        case 1:
                                            Duplicate(yellow1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(yellow2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(yellow3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(yellow4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(yellow5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(yellow6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(yellow7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(yellow8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(yellow9, rnd);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 0:
                                            Duplicate(blue0, rnd);
                                            break;
                                        case 1:
                                            Duplicate(blue1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(blue2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(blue3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(blue4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(blue5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(blue6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(blue7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(blue8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(blue9, rnd);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 0:
                                            Duplicate(green0, rnd);
                                            break;
                                        case 1:
                                            Duplicate(green1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(green2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(green3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(green4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(green5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(green6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(green7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(green8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(green9, rnd);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackred1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(attackred2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(attackred3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(attackred4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(attackred5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(attackred6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(attackred7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(attackred8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(attackred9, rnd);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackyellow1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(attackyellow2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(attackyellow3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(attackyellow4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(attackyellow5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(attackyellow6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(attackyellow7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(attackyellow8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(attackyellow9, rnd);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackblue1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(attackblue2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(attackblue3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(attackblue4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(attackblue5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(attackblue6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(attackblue7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(attackblue8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(attackblue9, rnd);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackgreen1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(attackgreen2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(attackgreen3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(attackgreen4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(attackgreen5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(attackgreen6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(attackgreen7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(attackgreen8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(attackgreen9, rnd);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 3:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healred1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(healred2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(healred3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(healred4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(healred5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(healred6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(healred7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(healred8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(healred9, rnd);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healyellow1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(healyellow2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(healyellow3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(healyellow4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(healyellow5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(healyellow6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(healyellow7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(healyellow8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(healyellow9, rnd);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healblue1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(healblue2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(healblue3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(healblue4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(healblue5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(healblue6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(healblue7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(healblue8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(healblue9, rnd);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healgreen1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(healgreen2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(healgreen3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(healgreen4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(healgreen5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(healgreen6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(healgreen7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(healgreen8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(healgreen9, rnd);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 4:
                            switch (rndcolor)
                            {
                                case 1:
                                    Duplicate(reversered, rnd);
                                    break;
                                case 2:
                                    Duplicate(reverseyellow, rnd);
                                    break;
                                case 3:
                                    Duplicate(reverseblue, rnd);
                                    break;
                                case 4:
                                    Duplicate(reversegreen, rnd);
                                    break;
                            }
                            break;
                        case 5:
                            switch (rndcolor)
                            {
                                case 1:
                                    Duplicate(skipred, rnd);
                                    break;
                                case 2:
                                    Duplicate(skipyellow, rnd);
                                    break;
                                case 3:
                                    Duplicate(skipblue, rnd);
                                    break;
                                case 4:
                                    Duplicate(skipgreen, rnd);
                                    break;
                            }
                            break;
                    }

                }
                else
                {
                    i = rndposition;
                    p1CardColor[i] = rndcolor;
                    p1CardNum[i] = rndnum;
                    p1CardType[i] = rndtype;
                    AIchoose = GameObject.FindGameObjectsWithTag("Card");
                    foreach (GameObject choosed in AIchoose)
                    {
                        if (choosed.transform.position.x == (i - 8))
                        {
                            Destroy(choosed);
                        }
                    }
                    switch (rndtype)
                    {
                        case 1:
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
                        case 2:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackred1, i);
                                            break;
                                        case 2:
                                            Duplicate(attackred2, i);
                                            break;
                                        case 3:
                                            Duplicate(attackred3, i);
                                            break;
                                        case 4:
                                            Duplicate(attackred4, i);
                                            break;
                                        case 5:
                                            Duplicate(attackred5, i);
                                            break;
                                        case 6:
                                            Duplicate(attackred6, i);
                                            break;
                                        case 7:
                                            Duplicate(attackred7, i);
                                            break;
                                        case 8:
                                            Duplicate(attackred8, i);
                                            break;
                                        case 9:
                                            Duplicate(attackred9, i);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackyellow1, i);
                                            break;
                                        case 2:
                                            Duplicate(attackyellow2, i);
                                            break;
                                        case 3:
                                            Duplicate(attackyellow3, i);
                                            break;
                                        case 4:
                                            Duplicate(attackyellow4, i);
                                            break;
                                        case 5:
                                            Duplicate(attackyellow5, i);
                                            break;
                                        case 6:
                                            Duplicate(attackyellow6, i);
                                            break;
                                        case 7:
                                            Duplicate(attackyellow7, i);
                                            break;
                                        case 8:
                                            Duplicate(attackyellow8, i);
                                            break;
                                        case 9:
                                            Duplicate(attackyellow9, i);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackblue1, i);
                                            break;
                                        case 2:
                                            Duplicate(attackblue2, i);
                                            break;
                                        case 3:
                                            Duplicate(attackblue3, i);
                                            break;
                                        case 4:
                                            Duplicate(attackblue4, i);
                                            break;
                                        case 5:
                                            Duplicate(attackblue5, i);
                                            break;
                                        case 6:
                                            Duplicate(attackblue6, i);
                                            break;
                                        case 7:
                                            Duplicate(attackblue7, i);
                                            break;
                                        case 8:
                                            Duplicate(attackblue8, i);
                                            break;
                                        case 9:
                                            Duplicate(attackblue9, i);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackgreen1, i);
                                            break;
                                        case 2:
                                            Duplicate(attackgreen2, i);
                                            break;
                                        case 3:
                                            Duplicate(attackgreen3, i);
                                            break;
                                        case 4:
                                            Duplicate(attackgreen4, i);
                                            break;
                                        case 5:
                                            Duplicate(attackgreen5, i);
                                            break;
                                        case 6:
                                            Duplicate(attackgreen6, i);
                                            break;
                                        case 7:
                                            Duplicate(attackgreen7, i);
                                            break;
                                        case 8:
                                            Duplicate(attackgreen8, i);
                                            break;
                                        case 9:
                                            Duplicate(attackgreen9, i);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 3:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healred1, i);
                                            break;
                                        case 2:
                                            Duplicate(healred2, i);
                                            break;
                                        case 3:
                                            Duplicate(healred3, i);
                                            break;
                                        case 4:
                                            Duplicate(healred4, i);
                                            break;
                                        case 5:
                                            Duplicate(healred5, i);
                                            break;
                                        case 6:
                                            Duplicate(healred6, i);
                                            break;
                                        case 7:
                                            Duplicate(healred7, i);
                                            break;
                                        case 8:
                                            Duplicate(healred8, i);
                                            break;
                                        case 9:
                                            Duplicate(healred9, i);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healyellow1, i);
                                            break;
                                        case 2:
                                            Duplicate(healyellow2, i);
                                            break;
                                        case 3:
                                            Duplicate(healyellow3, i);
                                            break;
                                        case 4:
                                            Duplicate(healyellow4, i);
                                            break;
                                        case 5:
                                            Duplicate(healyellow5, i);
                                            break;
                                        case 6:
                                            Duplicate(healyellow6, i);
                                            break;
                                        case 7:
                                            Duplicate(healyellow7, i);
                                            break;
                                        case 8:
                                            Duplicate(healyellow8, i);
                                            break;
                                        case 9:
                                            Duplicate(healyellow9, i);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healblue1, i);
                                            break;
                                        case 2:
                                            Duplicate(healblue2, i);
                                            break;
                                        case 3:
                                            Duplicate(healblue3, i);
                                            break;
                                        case 4:
                                            Duplicate(healblue4, i);
                                            break;
                                        case 5:
                                            Duplicate(healblue5, i);
                                            break;
                                        case 6:
                                            Duplicate(healblue6, i);
                                            break;
                                        case 7:
                                            Duplicate(healblue7, i);
                                            break;
                                        case 8:
                                            Duplicate(healblue8, i);
                                            break;
                                        case 9:
                                            Duplicate(healblue9, i);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healgreen1, i);
                                            break;
                                        case 2:
                                            Duplicate(healgreen2, i);
                                            break;
                                        case 3:
                                            Duplicate(healgreen3, i);
                                            break;
                                        case 4:
                                            Duplicate(healgreen4, i);
                                            break;
                                        case 5:
                                            Duplicate(healgreen5, i);
                                            break;
                                        case 6:
                                            Duplicate(healgreen6, i);
                                            break;
                                        case 7:
                                            Duplicate(healgreen7, i);
                                            break;
                                        case 8:
                                            Duplicate(healgreen8, i);
                                            break;
                                        case 9:
                                            Duplicate(healgreen9, i);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 4:
                            switch (rndcolor)
                            {
                                case 1:
                                    Duplicate(reversered, i);
                                    break;
                                case 2:
                                    Duplicate(reverseyellow, i);
                                    break;
                                case 3:
                                    Duplicate(reverseblue, i);
                                    break;
                                case 4:
                                    Duplicate(reversegreen, i);
                                    break;
                            }
                            break;
                        case 5:
                            switch (rndcolor)
                            {
                                case 1:
                                    Duplicate(skipred, i);
                                    break;
                                case 2:
                                    Duplicate(skipyellow, i);
                                    break;
                                case 3:
                                    Duplicate(skipblue, i);
                                    break;
                                case 4:
                                    Duplicate(skipgreen, i);
                                    break;
                            }
                            break;
                    }
                    rndcolor = (int)Random.Range(1, 5);
                    rndnum = (int)Random.Range(0, 10);
                    rndtype = (int)Random.Range(1, 3);
                    int rnd = (int)Random.Range(0, 20);
                    while (rnd == i)
                    {
                        rnd = (int)Random.Range(0, 20);
                    }
                    p1CardColor[rnd] = rndcolor;
                    p1CardNum[rnd] = rndnum;
                    p1CardType[rnd] = rndtype;
                    foreach (GameObject choosed in AIchoose)
                    {
                        if (choosed.transform.position.x == (rnd - 8))
                        {
                            Destroy(choosed);
                        }
                    }
                    switch (rndtype)
                    {
                        case 1:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 0:
                                            Duplicate(red0, rnd);
                                            break;
                                        case 1:
                                            Duplicate(red1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(red2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(red3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(red4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(red5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(red6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(red7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(red8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(red9, rnd);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 0:
                                            Duplicate(yellow0, rnd);
                                            break;
                                        case 1:
                                            Duplicate(yellow1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(yellow2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(yellow3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(yellow4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(yellow5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(yellow6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(yellow7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(yellow8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(yellow9, rnd);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 0:
                                            Duplicate(blue0, rnd);
                                            break;
                                        case 1:
                                            Duplicate(blue1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(blue2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(blue3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(blue4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(blue5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(blue6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(blue7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(blue8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(blue9, rnd);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 0:
                                            Duplicate(green0, rnd);
                                            break;
                                        case 1:
                                            Duplicate(green1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(green2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(green3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(green4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(green5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(green6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(green7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(green8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(green9, rnd);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackred1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(attackred2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(attackred3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(attackred4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(attackred5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(attackred6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(attackred7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(attackred8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(attackred9, rnd);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackyellow1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(attackyellow2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(attackyellow3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(attackyellow4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(attackyellow5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(attackyellow6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(attackyellow7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(attackyellow8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(attackyellow9, rnd);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackblue1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(attackblue2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(attackblue3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(attackblue4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(attackblue5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(attackblue6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(attackblue7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(attackblue8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(attackblue9, rnd);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(attackgreen1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(attackgreen2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(attackgreen3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(attackgreen4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(attackgreen5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(attackgreen6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(attackgreen7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(attackgreen8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(attackgreen9, rnd);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 3:
                            switch (rndcolor)
                            {
                                case 1:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healred1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(healred2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(healred3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(healred4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(healred5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(healred6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(healred7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(healred8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(healred9, rnd);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healyellow1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(healyellow2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(healyellow3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(healyellow4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(healyellow5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(healyellow6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(healyellow7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(healyellow8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(healyellow9, rnd);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healblue1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(healblue2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(healblue3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(healblue4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(healblue5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(healblue6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(healblue7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(healblue8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(healblue9, rnd);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (rndnum)
                                    {
                                        case 1:
                                            Duplicate(healgreen1, rnd);
                                            break;
                                        case 2:
                                            Duplicate(healgreen2, rnd);
                                            break;
                                        case 3:
                                            Duplicate(healgreen3, rnd);
                                            break;
                                        case 4:
                                            Duplicate(healgreen4, rnd);
                                            break;
                                        case 5:
                                            Duplicate(healgreen5, rnd);
                                            break;
                                        case 6:
                                            Duplicate(healgreen6, rnd);
                                            break;
                                        case 7:
                                            Duplicate(healgreen7, rnd);
                                            break;
                                        case 8:
                                            Duplicate(healgreen8, rnd);
                                            break;
                                        case 9:
                                            Duplicate(healgreen9, rnd);
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 4:
                            switch (rndcolor)
                            {
                                case 1:
                                    Duplicate(reversered, rnd);
                                    break;
                                case 2:
                                    Duplicate(reverseyellow, rnd);
                                    break;
                                case 3:
                                    Duplicate(reverseblue, rnd);
                                    break;
                                case 4:
                                    Duplicate(reversegreen, rnd);
                                    break;
                            }
                            break;
                        case 5:
                            switch (rndcolor)
                            {
                                case 1:
                                    Duplicate(skipred, rnd);
                                    break;
                                case 2:
                                    Duplicate(skipyellow, rnd);
                                    break;
                                case 3:
                                    Duplicate(skipblue, rnd);
                                    break;
                                case 4:
                                    Duplicate(skipgreen, rnd);
                                    break;
                            }
                            break;
                    }
                }
                break;

            case 1:
                if (ai1CardAmount < 20)
                {
                    while (ai1CardColor[i] != -1)
                    {
                        i++;
                    }
                    if (ai1CardColor[i] == -1)
                    {
                        ai1CardColor[i] = rndcolor;
                        ai1CardNum[i] = rndnum;
                        ai1CardType[i] = rndtype;
                        ai1CardAmount += 1;
                    }
                    int rnd = (int)Random.Range(0, 20);
                    while (rnd == i)
                    {
                        rnd = (int)Random.Range(0, 20);
                    }
                    rndcolor = (int)Random.Range(1, 5);
                    rndnum = (int)Random.Range(0, 10);
                    rndtype = (int)Random.Range(1, 3);
                    ai1CardColor[rnd] = rndcolor;
                    ai1CardNum[rnd] = rndnum;
                    ai1CardType[rnd] = rndtype;
                }
                else
                {
                    i = rndposition;
                    ai1CardColor[i] = rndcolor;
                    ai1CardNum[i] = rndnum;
                    ai1CardType[i] = rndtype;

                    int rnd = (int)Random.Range(0, 20);
                    while (rnd == i)
                    {
                        rnd = (int)Random.Range(0, 20);
                    }
                    rndcolor = (int)Random.Range(1, 5);
                    rndnum = (int)Random.Range(0, 10);
                    rndtype = (int)Random.Range(1, 3);
                    ai1CardColor[rnd] = rndcolor;
                    ai1CardNum[rnd] = rndnum;
                    ai1CardType[rnd] = rndtype;
                }
                break;
            case 2:
                if (ai2CardAmount < 20)
                {
                    while (ai2CardColor[i] != -1)
                    {
                        i++;
                    }
                    if (ai2CardColor[i] == -1)
                    {
                        ai2CardColor[i] = rndcolor;
                        ai2CardNum[i] = rndnum;
                        ai2CardType[i] = rndtype;
                        ai2CardAmount += 1;
                    }
                    int rnd = (int)Random.Range(0, 20);
                    while (rnd == i)
                    {
                        rnd = (int)Random.Range(0, 20);
                    }
                    rndcolor = (int)Random.Range(1, 5);
                    rndnum = (int)Random.Range(0, 10);
                    rndtype = (int)Random.Range(1, 3);
                    ai2CardColor[rnd] = rndcolor;
                    ai2CardNum[rnd] = rndnum;
                    ai2CardType[rnd] = rndtype;
                }
                else
                {
                    i = rndposition;
                    ai2CardColor[i] = rndcolor;
                    ai2CardNum[i] = rndnum;
                    ai2CardType[i] = rndtype;

                    int rnd = (int)Random.Range(0, 20);
                    while (rnd == i)
                    {
                        rnd = (int)Random.Range(0, 20);
                    }
                    rndcolor = (int)Random.Range(1, 5);
                    rndnum = (int)Random.Range(0, 10);
                    rndtype = (int)Random.Range(1, 3);
                    ai2CardColor[rnd] = rndcolor;
                    ai2CardNum[rnd] = rndnum;
                    ai2CardType[rnd] = rndtype;
                }
                break;
            case 3:
                if (ai3CardAmount < 20)
                {
                    while (ai3CardColor[i] != -1)
                    {
                        i++;
                    }
                    if (ai3CardColor[i] == -1)
                    {
                        ai3CardColor[i] = rndcolor;
                        ai3CardNum[i] = rndnum;
                        ai3CardType[i] = rndtype;
                        ai3CardAmount += 1;
                    }
                    int rnd = (int)Random.Range(0, 20);
                    while (rnd == i)
                    {
                        rnd = (int)Random.Range(0, 20);
                    }
                    rndcolor = (int)Random.Range(1, 5);
                    rndnum = (int)Random.Range(0, 10);
                    rndtype = (int)Random.Range(1, 3);
                    ai3CardColor[rnd] = rndcolor;
                    ai3CardNum[rnd] = rndnum;
                    ai3CardType[rnd] = rndtype;
                }
                else
                {
                    i = rndposition;
                    ai3CardColor[i] = rndcolor;
                    ai3CardNum[i] = rndnum;
                    ai3CardType[i] = rndtype;

                    int rnd = (int)Random.Range(0, 20);
                    while (rnd == i)
                    {
                        rnd = (int)Random.Range(0, 20);
                    }
                    rndcolor = (int)Random.Range(1, 5);
                    rndnum = (int)Random.Range(0, 10);
                    rndtype = (int)Random.Range(1, 3);
                    ai3CardColor[rnd] = rndcolor;
                    ai3CardNum[rnd] = rndnum;
                    ai3CardType[rnd] = rndtype;
                }
                break;
        }
    }
    public void GetRandomCard(int target)
    {
        int rndcolor = (int)Random.Range(1, 5);
        int rndnum = (int)Random.Range(0, 10);
        int rndtype = (int)Random.Range(1, 6);
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
                    p1CardType[i] = rndtype;
                    if (rndtype == 4 || rndtype == 5)
                    {
                        p1CardNum[i] = -2;
                    }
                    else if (rndtype == 2||rndtype==3)
                    {
                        if (rndnum == 0)
                        {
                            rndnum = 1;
                        }
                        p1CardNum[i] = rndnum;
                    }
                    else p1CardNum[i] = rndnum;
                }
                switch (rndtype)
                {
                    case 1:
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
                    case 2:
                        switch (rndcolor)
                        {
                            case 1:
                                switch (rndnum)
                                {
                                    case 1:
                                        Duplicate(attackred1, i);
                                        break;
                                    case 2:
                                        Duplicate(attackred2, i);
                                        break;
                                    case 3:
                                        Duplicate(attackred3, i);
                                        break;
                                    case 4:
                                        Duplicate(attackred4, i);
                                        break;
                                    case 5:
                                        Duplicate(attackred5, i);
                                        break;
                                    case 6:
                                        Duplicate(attackred6, i);
                                        break;
                                    case 7:
                                        Duplicate(attackred7, i);
                                        break;
                                    case 8:
                                        Duplicate(attackred8, i);
                                        break;
                                    case 9:
                                        Duplicate(attackred9, i);
                                        break;
                                }
                                break;
                            case 2:
                                switch (rndnum)
                                {
                                    case 1:
                                        Duplicate(attackyellow1, i);
                                        break;
                                    case 2:
                                        Duplicate(attackyellow2, i);
                                        break;
                                    case 3:
                                        Duplicate(attackyellow3, i);
                                        break;
                                    case 4:
                                        Duplicate(attackyellow4, i);
                                        break;
                                    case 5:
                                        Duplicate(attackyellow5, i);
                                        break;
                                    case 6:
                                        Duplicate(attackyellow6, i);
                                        break;
                                    case 7:
                                        Duplicate(attackyellow7, i);
                                        break;
                                    case 8:
                                        Duplicate(attackyellow8, i);
                                        break;
                                    case 9:
                                        Duplicate(attackyellow9, i);
                                        break;
                                }
                                break;
                            case 3:
                                switch (rndnum)
                                {
                                    case 1:
                                        Duplicate(attackblue1, i);
                                        break;
                                    case 2:
                                        Duplicate(attackblue2, i);
                                        break;
                                    case 3:
                                        Duplicate(attackblue3, i);
                                        break;
                                    case 4:
                                        Duplicate(attackblue4, i);
                                        break;
                                    case 5:
                                        Duplicate(attackblue5, i);
                                        break;
                                    case 6:
                                        Duplicate(attackblue6, i);
                                        break;
                                    case 7:
                                        Duplicate(attackblue7, i);
                                        break;
                                    case 8:
                                        Duplicate(attackblue8, i);
                                        break;
                                    case 9:
                                        Duplicate(attackblue9, i);
                                        break;
                                }
                                break;
                            case 4:
                                switch (rndnum)
                                {
                                    case 1:
                                        Duplicate(attackgreen1, i);
                                        break;
                                    case 2:
                                        Duplicate(attackgreen2, i);
                                        break;
                                    case 3:
                                        Duplicate(attackgreen3, i);
                                        break;
                                    case 4:
                                        Duplicate(attackgreen4, i);
                                        break;
                                    case 5:
                                        Duplicate(attackgreen5, i);
                                        break;
                                    case 6:
                                        Duplicate(attackgreen6, i);
                                        break;
                                    case 7:
                                        Duplicate(attackgreen7, i);
                                        break;
                                    case 8:
                                        Duplicate(attackgreen8, i);
                                        break;
                                    case 9:
                                        Duplicate(attackgreen9, i);
                                        break;
                                }
                                break;
                        }
                        break;
                    case 3:
                        switch (rndcolor)
                        {
                            case 1:
                                switch (rndnum)
                                { 
                                    case 1:
                                        Duplicate(healred1, i);
                                        break;
                                    case 2:
                                        Duplicate(healred2, i);
                                        break;
                                    case 3:
                                        Duplicate(healred3, i);
                                        break;
                                    case 4:
                                        Duplicate(healred4, i);
                                        break;
                                    case 5:
                                        Duplicate(healred5, i);
                                        break;
                                    case 6:
                                        Duplicate(healred6, i);
                                        break;
                                    case 7:
                                        Duplicate(healred7, i);
                                        break;
                                    case 8:
                                        Duplicate(healred8, i);
                                        break;
                                    case 9:
                                        Duplicate(healred9, i);
                                        break;
                                }
                                break;
                            case 2:
                                switch (rndnum)
                                {
                                    case 1:
                                        Duplicate(healyellow1, i);
                                        break;
                                    case 2:
                                        Duplicate(healyellow2, i);
                                        break;
                                    case 3:
                                        Duplicate(healyellow3, i);
                                        break;
                                    case 4:
                                        Duplicate(healyellow4, i);
                                        break;
                                    case 5:
                                        Duplicate(healyellow5, i);
                                        break;
                                    case 6:
                                        Duplicate(healyellow6, i);
                                        break;
                                    case 7:
                                        Duplicate(healyellow7, i);
                                        break;
                                    case 8:
                                        Duplicate(healyellow8, i);
                                        break;
                                    case 9:
                                        Duplicate(healyellow9, i);
                                        break;
                                }
                                break;
                            case 3:
                                switch (rndnum)
                                {
                                    case 1:
                                        Duplicate(healblue1, i);
                                        break;
                                    case 2:
                                        Duplicate(healblue2, i);
                                        break;
                                    case 3:
                                        Duplicate(healblue3, i);
                                        break;
                                    case 4:
                                        Duplicate(healblue4, i);
                                        break;
                                    case 5:
                                        Duplicate(healblue5, i);
                                        break;
                                    case 6:
                                        Duplicate(healblue6, i);
                                        break;
                                    case 7:
                                        Duplicate(healblue7, i);
                                        break;
                                    case 8:
                                        Duplicate(healblue8, i);
                                        break;
                                    case 9:
                                        Duplicate(healblue9, i);
                                        break;
                                }
                                break;
                            case 4:
                                switch (rndnum)
                                {
                                    case 1:
                                        Duplicate(healgreen1, i);
                                        break;
                                    case 2:
                                        Duplicate(healgreen2, i);
                                        break;
                                    case 3:
                                        Duplicate(healgreen3, i);
                                        break;
                                    case 4:
                                        Duplicate(healgreen4, i);
                                        break;
                                    case 5:
                                        Duplicate(healgreen5, i);
                                        break;
                                    case 6:
                                        Duplicate(healgreen6, i);
                                        break;
                                    case 7:
                                        Duplicate(healgreen7, i);
                                        break;
                                    case 8:
                                        Duplicate(healgreen8, i);
                                        break;
                                    case 9:
                                        Duplicate(healgreen9, i);
                                        break;
                                }
                                break;
                        }
                        break;
                    case 4:
                        switch (rndcolor)
                        {
                            case 1:
                                Duplicate(reversered, i);
                                break;
                            case 2:
                                Duplicate(reverseyellow, i);
                                break;
                            case 3:
                                Duplicate(reverseblue, i);
                                break;
                            case 4:
                                Duplicate(reversegreen, i);
                                break;
                        }
                        break;
                    case 5:
                        switch (rndcolor)
                        {
                            case 1:
                                Duplicate(skipred, i);
                                break;
                            case 2:
                                Duplicate(skipyellow, i);
                                break;
                            case 3:
                                Duplicate(skipblue, i);
                                break;
                            case 4:
                                Duplicate(skipgreen, i);
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
                    ai1CardType[i] = rndtype;
                    if (rndtype == 4 || rndtype == 5)
                    {
                        ai1CardNum[i] = -2;
                    }
                    else if (rndtype == 2 || rndtype == 3)
                    {
                        if (rndnum == 0)
                        {
                            rndnum = 1;
                        }
                        ai1CardNum[i] = rndnum;
                    }
                    else ai1CardNum[i] = rndnum;
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
                    ai2CardType[i] = rndtype;
                    if (rndtype == 4 || rndtype == 5)
                    {
                        ai2CardNum[i] = -2;
                    }
                    else if (rndtype == 2 || rndtype == 3)
                    {
                        if (rndnum == 0)
                        {
                            rndnum = 1;
                        }
                        ai2CardNum[i] = rndnum;
                    }
                    else ai2CardNum[i] = rndnum;
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
                    ai3CardType[i] = rndtype;
                    if (rndtype == 4 || rndtype == 5)
                    {
                        ai3CardNum[i] = -2;
                    }
                    else if (rndtype == 2 || rndtype == 3)
                    {
                        if (rndnum == 0)
                        {
                            rndnum = 1;
                        }
                        ai3CardNum[i] = rndnum;
                    }
                    else ai3CardNum[i] = rndnum;
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
    public void Win()
    {
        Time.timeScale = 0;
        win.SetActive(true);
    }
    public void Lose()
    {
        Time.timeScale = 0;
        lose.SetActive(true);
    }
}

