using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyMode : MonoBehaviour
{
    public int levelOfDiff;
    // Start is called before the first frame update
   
     private void Awake()
    {
        // Do not destroy this object as it is used to check which menu item was chosen
        DontDestroyOnLoad(this.gameObject);
    }

}
