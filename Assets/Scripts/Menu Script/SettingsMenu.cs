using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
	public void SetVolume (float volume) {
        SoundManagerScript.PlaySound("Cursor3");
        Debug.Log (volume);
	}

  

}
