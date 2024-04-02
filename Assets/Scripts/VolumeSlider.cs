
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    private float _defaultValue;

    private void Start()
    {
        _defaultValue = 0.5f;
        GetComponent<Slider>().value = _defaultValue;
    }
}
