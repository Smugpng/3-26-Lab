using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;
using Random = System.Random;

public class Task2 : MonoBehaviour
{
    public string[] smallernames = new string[] { };

    private HashSet<string> names = new HashSet<string>
    {"Whitley", "Byron", "Livia", "Mateo", "Madilyn", "Adriel", "Ariyah", "Kellan", "Nalani", "Mack", "Marlowe", "Kristopher", 
     "Eloise", "Mohammad", "Khaleesi", "Chance", "Pearl", "Justice", "Alicia", "Jair", "Scout", "Onyx", "Gracelyn", "Atlas", "Julianna"};
    // Start is called before the first frame update
    Random random = new Random();
   
    void Start()
    {

        for (int i = 0; i < 15; i++) 
        {
            string smallernames = names.ElementAt(random.Next(names.Count));
            
        }

        foreach (string smallarray in smallernames)
        {
            Debug.Log(smallarray.ToString());
        }
        
        names.IntersectWith(smallernames);
        foreach (string names in names)
        {
            Debug.Log(names.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
