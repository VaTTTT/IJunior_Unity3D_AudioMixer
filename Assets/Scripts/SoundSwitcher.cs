using System.Threading;
using UnityEngine;

public class SoundSwitcher : MonoBehaviour
{
    [SerializeField] private SoundEffectsPlayer _soundEffectsPlayer;
    [SerializeField] private MusicPlayer _musicPlayer;

    private bool _isAllSoundsMuted;

    private void Start()
    { 
        _isAllSoundsMuted = false;
    }

    public void SwitchAllSounds()
    {
        if (!_isAllSoundsMuted)
        {
            SetMuteSwitch(true);
        }
        else
        {
            SetMuteSwitch(false);
        }
    }

    private void SetMuteSwitch(bool isMuted)
    {
        _soundEffectsPlayer.GetComponent<AudioSource>().mute = isMuted;
        _musicPlayer.GetComponent<AudioSource>().mute = isMuted;
        _isAllSoundsMuted = isMuted;
    }
}
