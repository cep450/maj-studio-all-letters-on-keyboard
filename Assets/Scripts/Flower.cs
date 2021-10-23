using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    public AudioSource myAudioSource;
    public float audioScale;

    public GameObject childObj;
    float startJiggle = 0.1f;
    float chJiggle = 0.075f;
    float colorJMult = 0.3f;

    float r;
    float g;
    float b;

/*
    float lerpTime = 0f;
    float lerpLength = 5f;
    float lerpSizeMax = 1.5f;
*/
   
    // Start is called before the first frame update
    void Start()
    {
        //generate a color for this 
        r = Random.Range(0f, 1f);   
        g = Random.Range(0f, 1f);  
        b = Random.Range(0f, 1f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pressed(int num) {

        //play sound, pitch shifted so the keyboard acts like a piano 
        //A (num 10) is middle C 
        ////"The general rule is to multiply the frequency by 1.05946^n, where n is the number of semitones you want to raise it."
        //and myAudioSource.pitch is a multiplier- starts at 1, 0.5 is half, ect
        //so, just set it to 1.05946^n
        //myAudioSource.pitch = Mathf.Pow(1.05946f, num - 10); //this one goes each step. doesnt account for black keys
        /*
        0   G   -17
        1   A   -15
        2   B   -13
        3   C   -12
        4   D   -10
        5   E   -8
        6   F   -7
        7   G   -5
        8   A   -3
        9   B   -1
        10  C   0
        11  D   2
        12  E   4
        13  F   5
        14  G   7
        15  A   9
        16  B   11
        1y  C   12
        18  D   14
        19  E   16
        20  F   17
        21  G   19
        22  A   21
        23  B   23
        24  C   24
        25  D   26
        */  

        //semitone multiplier
                //TODO would optimize this out by having the num be preconverted since it's done by hand/as constants in the Keyboard class. but whatever for now
        //stands for semitone multiplier
        int stm = 0;
        switch(num) {
            case 0: stm = -17; break;
            case 1: stm = -15; break;
            case 2: stm = -13; break;
            case 3: stm = -12; break;
            case 4: stm = -10; break;
            case 5: stm = -8; break;
            case 6: stm = -7; break;
            case 7: stm = -5; break;
            case 8: stm = -3; break;
            case 9: stm = -1; break;
            case 10: stm = 0; break;
            case 11: stm = 2; break;
            case 12: stm = 4; break;
            case 13: stm = 5; break;
            case 14: stm = 7; break;
            case 15: stm = 9; break;
            case 16: stm = 11; break;
            case 17: stm = 12; break;
            case 18: stm = 14; break;
            case 19: stm = 16; break;
            case 20: stm = 17; break;
            case 21: stm = 19; break;
            case 22: stm = 21; break;
            case 23: stm = 23; break;
            case 24: stm = 24; break;
            case 25: stm = 26; break;
        }
        myAudioSource.pitch = Mathf.Pow(1.05946f, stm);
        myAudioSource.PlayOneShot(myAudioSource.clip, audioScale);

        //add another flower
        GameObject flowerchild = Instantiate(childObj, new Vector3(transform.position.x + jiggle(chJiggle), transform.position.y + jiggle(chJiggle), 0), Quaternion.identity);
        flowerchild.transform.SetParent(transform);

        //give it a color, based on the baseline one. 
        float rr = (r + jiggle(chJiggle * colorJMult));
        float gg = (g + jiggle(chJiggle * colorJMult));
        float bb = (b + jiggle(chJiggle * colorJMult));
        Color c = new Color(rr, gg, bb, 1);
        flowerchild.GetComponent<SpriteRenderer>().color = c;


        //grow children 
        //increase scale by (jiggle by current jiggle) 
        //could do this as a subroutine to animate it 
        for(int i = transform.childCount; i > 0; i--) {
            float j = Random.Range(0f, startJiggle);
            Vector3 v = transform.GetChild(i - 1).localScale;
            v = new Vector3(v.x + j, v.y + j, v.z);
            transform.GetChild(i-1).localScale = v;
        }

        //TODO 
        //gets bigger/does a little bounce/animates 

        //jiggle is gonna increase each time 
        chJiggle += startJiggle;

    }

        float jiggle(float jvalue) {
        return Random.Range(-jvalue, jvalue);
    }
}


