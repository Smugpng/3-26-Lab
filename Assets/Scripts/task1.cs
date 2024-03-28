using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class task1 : MonoBehaviour
{
    private List<string> names = new List<string>() {"Whitley", "Byron", "Livia", "Mateo", "Madilyn", "Adriel", "Ariyah", "Kellan", "Nalani", "Mack", "Marlowe", "Kristopher", "Eloise", "Mohammad", "Khaleesi", "Chance", "Pearl", "Justice", "Alicia", "Jair", "Scout", "Onyx", "Gracelyn", "Atlas", "Julianna"};
    private List<string> first5 = new List<string>();
    private Queue<string> loginQueue = new Queue<string>();

    Random rnd = new Random();

    void Start()
    {
        for(int i = 0; i <= 4; i++) //gets 5 initial people to be in the queue & removes them from the list
        {
            int r = rnd.Next(names.Count);
            char let = (char)('a' + r);
            loginQueue.Enqueue(names[r] + " " + let);
            Debug.Log(loginQueue.Dequeue());
            first5.Add(names[r] + " " + let);
            names.RemoveAt(r);
        }
        Debug.Log("Initial login queue created. There are 5 players in the queue: " + first5[0] + ", " + first5[1] + ", " + first5[2] + ", " + first5[3] + ", " + first5[4]);
        
        StartCoroutine("queueOperation");
    }

    private IEnumerator queueOperation() //Dequeue someone from loginqueue and enqueue new name from names list until names list is empty
    {
        for(int i = 0; i <= names.Count; i++) //this could work maybe switch to a foreach items in names?
        {
            Debug.Log("in queueOperation");
            yield return new WaitForSeconds(1f);
        }
    }
}