using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     SoundManager.instance.PlayBGM(Soundmanager.BGM.Main);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
