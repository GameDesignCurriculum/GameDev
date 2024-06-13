using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInventory : MonoBehaviour
{
    // Variables
    public bool adoptPet = false;

    //Class defining properties of food
    public class Food
    {
        public string name;
        public int amount;
    }

    // Create instances of each food item with class properties
    Food cat = new Food();
    Food dog = new Food();
    Food rabbit = new Food();
    Food hamster = new Food();
    Food feret = new Food();

    // Do something when the sprite is clicked
    void OnMouseDown()
    {
        // Changes Boolean value to true when sprite is clicked
        adoptPet = true;
    }

    // Start is called before the first frame update
    void Start()
    {   
        // Set each food item's initial values
        cat.name = "cat";
        cat.amount = 3;

        dog.name = "dog";
        dog.amount = 4;

        rabbit.name = "rabbit";
        rabbit.amount = 2;

        hamster.name = "hamster";
        hamster.amount = 1;

        feret.name = "feret";
        feret.amount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (adoptPet)  // Shorthand to check if `adoptPet` is true
        {
            // Update inventory
            cat.amount += 1;
            dog.amount -= 1;
            rabbit.amount -= 1;
            hamster.amount -= 1;
            feret.amount += 1;

            // Print current inventory status to console
            Debug.Log(cat.name + " = " +  cat.amount);
            if (dog.amount > -1)
            {
                Debug.Log(dog.name + " = " +  dog.amount);
            }
            if (rabbit.amount > -1)
            {
                Debug.Log(rabbit.name + " = " + rabbit.amount);
            }
            if (hamster.amount > -1)
            {
                Debug.Log(hamster.name + " = " +  hamster.amount);
            }
            Debug.Log(feret.name + " = " + feret.amount);

            // Change Boolean `adoptPet` back to false value
            adoptPet = false;
        }
    }
}

/*

    BRIEFLY DESCRIBE YOUR OBSERVATIONS HERE AFTER TESTING IN UNITY

*/