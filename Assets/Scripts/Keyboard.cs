using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{

/*
    instantiate the keyboard garden
        run through em, give em a little random offset jiggle 
*/

    public GameObject flowerPrefab;

    Flower [] flowers = new Flower[26];

    float xyJiggle = 0.25F;

    float xyMult = 1.7f;

    // Start is called before the first frame update
    void Start()
    {
        
        //instantiate a bunch of flowers 
        float x = -5.45f;
        float y = 0.7525f;
        for(int i = 0; i < 26; i++) {
            
            x++;
            if(i == 10) {
                y--;
                x = -4.5f;
            } else if(i == 19) {
                y--;
                x = -4f;
            }

            //TODO also give a random color
            
            flowers[i] = Instantiate(flowerPrefab, new Vector3(x * xyMult + Random.Range(-xyJiggle, xyJiggle), y * xyMult + Random.Range(-xyJiggle, xyJiggle), 0), Quaternion.identity).GetComponent(typeof(Flower)) as Flower;

        }

    }

    // Update is called once per frame
    void Update()
    {
        //when each key is pressed... 
        //there has to be a better way to do this. 
        if(Input.GetKeyDown(KeyCode.Q)) {
            flowers[0].Pressed(0);
        }
        if(Input.GetKeyDown(KeyCode.W)) {
            flowers[1].Pressed(1);
        }
        if(Input.GetKeyDown(KeyCode.E)) {
            flowers[2].Pressed(2);
        }
        if(Input.GetKeyDown(KeyCode.R)) {
            flowers[3].Pressed(3);
        }
        if(Input.GetKeyDown(KeyCode.T)) {
            flowers[4].Pressed(4);
        }
        if(Input.GetKeyDown(KeyCode.Y)) {
            flowers[5].Pressed(5);
        }
        if(Input.GetKeyDown(KeyCode.U)) {
            flowers[6].Pressed(6);
        }
        if(Input.GetKeyDown(KeyCode.I)) {
            flowers[7].Pressed(7);
        }
        if(Input.GetKeyDown(KeyCode.O)) {
            flowers[8].Pressed(8);
        }
        if(Input.GetKeyDown(KeyCode.P)) {
            flowers[9].Pressed(9);
        }
        if(Input.GetKeyDown(KeyCode.A)) {
            flowers[10].Pressed(10);
        }
        if(Input.GetKeyDown(KeyCode.S)) {
            flowers[11].Pressed(11);
        }
        if(Input.GetKeyDown(KeyCode.D)) {
            flowers[12].Pressed(12);
        }
        if(Input.GetKeyDown(KeyCode.F)) {
            flowers[13].Pressed(13);
        }
        if(Input.GetKeyDown(KeyCode.G)) {
            flowers[14].Pressed(14);
        }
        if(Input.GetKeyDown(KeyCode.H)) {
            flowers[15].Pressed(15);
        }
        if(Input.GetKeyDown(KeyCode.J)) {
            flowers[16].Pressed(16);
        }
        if(Input.GetKeyDown(KeyCode.K)) {
            flowers[17].Pressed(17);
        }
        if(Input.GetKeyDown(KeyCode.L)) {
            flowers[18].Pressed(18);
        }
        if(Input.GetKeyDown(KeyCode.Z)) {
            flowers[19].Pressed(19);
        }
        if(Input.GetKeyDown(KeyCode.X)) {
            flowers[20].Pressed(20);
        }
        if(Input.GetKeyDown(KeyCode.C)) {
            flowers[21].Pressed(21);
        }
        if(Input.GetKeyDown(KeyCode.V)) {
            flowers[22].Pressed(22);
        }
        if(Input.GetKeyDown(KeyCode.B)) {
            flowers[23].Pressed(23);
        }
        if(Input.GetKeyDown(KeyCode.N)) {
            flowers[24].Pressed(24);
        }
        if(Input.GetKeyDown(KeyCode.M)) {
            flowers[25].Pressed(25);
        }
    }
}
