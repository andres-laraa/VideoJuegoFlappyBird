using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour {

    public static SoundSystem instance;

    public AndioClip audioClipPol;

    private void Awake()
    {
        if(SoundSystem.instance == null)
        {
            SoundSystem.instance = this;
        }else if (SoundSystem.instance != this)
        {
            Destroy(gameObject);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

     private void OnDestroy()
    {
        if(SoundSystem.instance == this)
        {
            SoundSystem.instance = null;
        }
    }
}
