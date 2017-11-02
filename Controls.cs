using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

    enum facing { left, right };
    facing direction;
    bool dead;
    int health;
    int framecounter;
    // Use this for initialization
    void Start() {
        dead = false;
        health = 100;
        framecounter = 0;
        direction = facing.left;
    }

    // Update is called once per frame
    void Update() {



        framecounter++;
        if (framecounter > 15)
        {
            health--;
            GameObject.Find("HealthBar").transform.localScale = new Vector3((float)0.01 * health, 0.025f, 0.1f);
            if (health <= 0 && !dead)
            {
                health = 100;
               //Kill();
            }
            framecounter = 0;
        }
    

        if (Input.GetKey(KeyCode.A) && direction == facing.right && !dead)
        {
            direction = facing.left;
            this.transform.Rotate(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.D) && direction == facing.left && !dead)
        {
            direction = facing.right;
            this.transform.Rotate(0, 180, 0);
        }

    }

    void Kill()
    {
        dead = true;
        this.transform.Rotate(0, 0, 180);
    }

}
