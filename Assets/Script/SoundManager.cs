using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
[SerializeField] AudioSource audioSourceBGM = default;
[SerializeField] AudioClip[] audioClips = default;

public enum BGM
{
  Title,
  Main

}

public static SoundManager instance;

private void Awake()
{
	if(instance == null)
	{
      instance = this;
	  DontDestroyOnLoad(gameObject);
	}
   else
   {
      Destroy(gameObject);

   }

}





public void PlayBGM(BGM bgm)
{
 audioSourceBGM. clip = audioClips[(int)bgm];
 audioSourceBGM.Play();

}





}