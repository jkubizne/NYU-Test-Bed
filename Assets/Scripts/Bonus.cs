using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    //counter for remaining collectibles in scene
    public int counter;

    //The prefab that will be instantiated
    public GameObject bonusObject;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectsWithTag("Pick Up").Length;
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void Pickup()
    {
        Debug.Log("Pickup message has been recieved!");
        counter--;

        if (counter == 0)
            SpawnBonus();
    }
        void SpawnBonus()
    {
        //Instantiate our Prefab!
        GameObject.Instantiate(bonusObject, transform);
    }
}

