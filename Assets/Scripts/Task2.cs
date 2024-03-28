using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using Random = System.Random;

public class Task2 : MonoBehaviour
{

    public string[] smallernames = new string[15];

    Random Random = new Random();
    private HashSet<string> names = new HashSet<string>
    {"Whitley", "Byron", "Livia", "Mateo", "Madilyn", "Adriel", "Ariyah", "Kellan", "Nalani", "Mack", "Marlowe", "Kristopher", 
     "Eloise", "Mohammad", "Khaleesi", "Chance", "Pearl", "Justice", "Alicia", "Jair", "Scout", "Onyx", "Gracelyn", "Atlas", "Julianna"};
  

    Random random = new Random();
   
    void Start()
    {
        
        int nameCount = 0;
        List<String> namesList = new List<string>(names);
        while (nameCount < smallernames.Length && namesList.Count > 0)
        {
            int randomCount = random.Next(namesList.Count);
            string randomName = namesList[randomCount];
            smallernames[nameCount++] = randomName;
            namesList.Remove(randomName);
        }
        Debug.Log("Created the name array:" + string.Join(", ", smallernames)); 

        names.IntersectWith(smallernames);
        Debug.Log("The array has duplicate names: " + string.Join(", ", names));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
