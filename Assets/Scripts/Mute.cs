using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public void MuteButton()
    {
        AudioListener.volume = 0;
    }
}
