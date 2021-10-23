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

    //Flower [] flowers = new Flower[26];
    int numFlowers = 36;
    Flower [] flowers = new Flower[36];

    float xyJiggle = 0.25F;

    float xyMult = 1.7f;

    // Start is called before the first frame update
    void Start()
    {
        
        //instantiate a bunch of flowers 
        //float x = -5.45f;
        //float y = 0.7525f;
        float x = -5.5f;
        float y = 1.5f;
        for(int i = 0; i < numFlowers; i++) {
            
            x++;
            if(i == 10) {
                y--;
                x = -5f;
            } else if(i == 20) {
                y--;
                x = -4.5f;
            } else if(i == 29) {
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
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            flowers[0].Pressed(0);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            flowers[1].Pressed(1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)) {
            flowers[2].Pressed(2);
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)) {
            flowers[3].Pressed(3);
        }
        if(Input.GetKeyDown(KeyCode.Alpha5)) {
            flowers[4].Pressed(4);
        }
        if(Input.GetKeyDown(KeyCode.Alpha6)) {
            flowers[5].Pressed(5);
        }
        if(Input.GetKeyDown(KeyCode.Alpha7)) {
            flowers[6].Pressed(6);
        }
        if(Input.GetKeyDown(KeyCode.Alpha8)) {
            flowers[7].Pressed(7);
        }
        if(Input.GetKeyDown(KeyCode.Alpha9)) {
            flowers[8].Pressed(8);
        }
        if(Input.GetKeyDown(KeyCode.Alpha0)) {
            flowers[9].Pressed(9);
        }
        if(Input.GetKeyDown(KeyCode.Q)) {
            flowers[10].Pressed(10);
        }
        if(Input.GetKeyDown(KeyCode.W)) {
            flowers[11].Pressed(11);
        }
        if(Input.GetKeyDown(KeyCode.E)) {
            flowers[12].Pressed(12);
        }
        if(Input.GetKeyDown(KeyCode.R)) {
            flowers[13].Pressed(13);
        }
        if(Input.GetKeyDown(KeyCode.T)) {
            flowers[14].Pressed(14);
        }
        if(Input.GetKeyDown(KeyCode.Y)) {
            flowers[15].Pressed(15);
        }
        if(Input.GetKeyDown(KeyCode.U)) {
            flowers[16].Pressed(16);
        }
        if(Input.GetKeyDown(KeyCode.I)) {
            flowers[17].Pressed(17);
        }
        if(Input.GetKeyDown(KeyCode.O)) {
            flowers[18].Pressed(18);
        }
        if(Input.GetKeyDown(KeyCode.P)) {
            flowers[19].Pressed(19);
        }
        if(Input.GetKeyDown(KeyCode.A)) {
            flowers[20].Pressed(20);
        }
        if(Input.GetKeyDown(KeyCode.S)) {
            flowers[21].Pressed(21);
        }
        if(Input.GetKeyDown(KeyCode.D)) {
            flowers[22].Pressed(22);
        }
        if(Input.GetKeyDown(KeyCode.F)) {
            flowers[23].Pressed(23);
        }
        if(Input.GetKeyDown(KeyCode.G)) {
            flowers[24].Pressed(24);
        }
        if(Input.GetKeyDown(KeyCode.H)) {
            flowers[25].Pressed(25);
        }
        if(Input.GetKeyDown(KeyCode.J)) {
            flowers[26].Pressed(26);
        }
        if(Input.GetKeyDown(KeyCode.K)) {
            flowers[27].Pressed(27);
        }
        if(Input.GetKeyDown(KeyCode.L)) {
            flowers[28].Pressed(28);
        }
        if(Input.GetKeyDown(KeyCode.Z)) {
            flowers[29].Pressed(29);
        }
        if(Input.GetKeyDown(KeyCode.X)) {
            flowers[30].Pressed(30);
        }
        if(Input.GetKeyDown(KeyCode.C)) {
            flowers[31].Pressed(31);
        }
        if(Input.GetKeyDown(KeyCode.V)) {
            flowers[32].Pressed(32);
        }
        if(Input.GetKeyDown(KeyCode.B)) {
            flowers[33].Pressed(33);
        }
        if(Input.GetKeyDown(KeyCode.N)) {
            flowers[34].Pressed(34);
        }
        if(Input.GetKeyDown(KeyCode.M)) {
            flowers[35].Pressed(35);
        }
        /*
        if(Input.GetKeyDown(KeyCode.M)) {
            flowers[36].Pressed(36);
        }
        if(Input.GetKeyDown(KeyCode.M)) {
            flowers[37].Pressed(37);
        }
        if(Input.GetKeyDown(KeyCode.M)) {
            flowers[38].Pressed(38);
        }
        if(Input.GetKeyDown(KeyCode.M)) {
            flowers[39].Pressed(39);
        }
        if(Input.GetKeyDown(KeyCode.M)) {
            flowers[40].Pressed(40);
        }
        */
    }
}
