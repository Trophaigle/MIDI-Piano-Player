using UnityEngine;

public class DemoPlayMIDI : MonoBehaviour
{
    public MIDIPianoPlayer player;

    void Start()
    {
       player.PlayMusic();
    }

    public void onMusicFinishedEvent()
    {
        Debug.Log("Music finished !");
    }
}
