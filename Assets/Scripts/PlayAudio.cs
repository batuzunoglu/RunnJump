using System.Collections;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    // Set in Inspector
    public AudioSource audioSource;

    // Set as many as required in inspector
    public AudioClip[] audioclips;

    public void PlayClip(int clipNr, bool overide)
    {
        if (audioSource == null)
        {
            Debug.Log("No Audio Source. Fill in inspector");
            return;
        }
        if (!overide && audioSource.isPlaying) return;
        if (clipNr >= 0 && clipNr < audioclips.Length)
        {
            if (audioclips[clipNr] != null)
            {
                if (!overide)
                {
                    audioSource.clip = audioclips[clipNr];
                    audioSource.Play();
                }
                else
                {
                    audioSource.PlayOneShot(audioclips[clipNr]);
                }
            }
            else
            {
                Debug.Log("Missing Audio Clip" + clipNr + ". Check inspector");
            }
        }
        else
        {
            Debug.Log("Audio Clip out of bounds " + clipNr + ". Check inspector");
        }
    }
}