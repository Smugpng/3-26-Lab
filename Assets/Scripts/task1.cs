using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class task1 : MonoBehaviour
{
    private List<string> names = new List<string>() {"Whitley", "Byron", "Livia", "Mateo", "Madilyn", "Adriel", "Ariyah", "Kellan", "Nalani", "Mack", "Marlowe", "Kristopher", "Eloise", "Mohammad", "Khaleesi", "Chance", "Pearl", "Justice", "Alicia", "Jair", "Scout", "Onyx", "Gracelyn", "Atlas", "Julianna"};
    private List<string> first5 = new List<string>();
    private Queue<string> loginQueue = new Queue<string>();
    private int totalUsers;

    Random rnd = new Random();

    void Start()
    {
        totalUsers = names.Count;
        for(int i = 0; i <= 4; i++) //gets 5 initial people to be in the queue & removes them from the list
        {
            int r = rnd.Next(names.Count);
            char let = (char)('a' + r);
            loginQueue.Enqueue(names[r] + " " + let);
            first5.Add(names[r] + " " + let);
            names.RemoveAt(r);
        }
        Debug.Log("Initial login queue created. There are 5 players in the queue: " + first5[0] + ", " + first5[1] + ", " + first5[2] + ", " + first5[3] + ", " + first5[4]);
        
        StartCoroutine("queueOperation");
    }

    private IEnumerator queueOperation() //Dequeues someone from loginqueue and enqueues new name from names list until names list is empty
    {
        for(int i = 0; i < totalUsers-1; i++)
        {
            //Debug.Log("in queueOperation");
            int r = rnd.Next(names.Count);
            char let = (char)('a' + r);
            Debug.Log(loginQueue.Dequeue() + ". is now inside the game.");
            if(names.Count > 0)
            {
                loginQueue.Enqueue(names[r] + " " + let);
                Debug.Log(names[r] + " " + let + ". is trying to login and added to the login queue.");
                names.RemoveAt(r);
            }
            yield return new WaitForSeconds(1f);
        }
        Debug.Log(loginQueue.Dequeue() + ". is now inside the game.");
        Debug.Log("All users have joined.");
    }
}