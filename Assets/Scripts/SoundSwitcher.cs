using UnityEngine;

public class SoundSwitcher : MonoBehaviour
{
    [SerializeField] private AudioSource _soundEffectsPlayer;
    [SerializeField] private AudioSource _musicPlayer;

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
        _soundEffectsPlayer.mute = isMuted;
        _musicPlayer.mute = isMuted;
        _isAllSoundsMuted = isMuted;
    }
}
