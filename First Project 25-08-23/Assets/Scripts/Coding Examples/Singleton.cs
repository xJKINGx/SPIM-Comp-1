using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    // We get get the instance anywhere, but we can only set the instance in this class
    // This way we don't have to worry about setting the Instance = null anywhere in the code
    public static Singleton Instance { get; private set; }

    int difficulty = 3;

    // The two lines below are only needed if you don't reload the domain
    // Put this on all singleton objects
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
    private static void ReInitialize()
    {
        Instance = null;
    }

    private void Awake() 
    {
        if (Instance == null)
        {
        Instance = this;   
        }
        else
        {
            Destroy(this); 
            // "this" deletes the script component
            // If it was gameObject instead it would delete the entire object
        }
      
    }

    // This is to stop the script being able to be added in editor mode
    private void Reset() {
        var singleton = GameObject.FindObjectOfType<Singleton>();
        if (singleton == null)
        {
            Instance = this;   
        }
        else
        {
            DestroyImmediate(this); 
            print("Instance of singleton type already exists.");
        }
    }

    public int GetDifficulty()
    {
        return difficulty;
    }
}
