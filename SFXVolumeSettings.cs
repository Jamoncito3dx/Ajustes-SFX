using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class SFXVolumeSettings : MonoBehaviour
{
    [Header("UI Elements")]
    public Slider sfxSlider; // Slider para el volumen de los SFX
    public TextMeshProUGUI sfxText; // Texto TMP para mostrar el porcentaje

    [Header("Audio Mixer")]
    public AudioMixer audioMixer; // Referencia al Audio Mixer

    private const string sfxVolumeParam = "SFXVolume";

    private void Start()
    {
        // Obtener el volumen actual del Audio Mixer y configurarlo en el slider
        float currentVolume;
        audioMixer.GetFloat(sfxVolumeParam, out currentVolume);
        sfxSlider.value = Mathf.Clamp(Mathf.Pow(10, currentVolume / 20) * 100, 0, 100);

        // Agregar listener al slider
        sfxSlider.onValueChanged.AddListener(delegate { OnSFXSliderChanged(); });

        UpdateSFXText(sfxSlider.value);
    }

    private void OnSFXSliderChanged()
    {
        // Convertir el porcentaje del slider a decibelios
        float porcentaje = Mathf.Max(sfxSlider.value, 0.01f);
        float decibelios = Mathf.Log10(porcentaje / 100) * 20;

        // Aplicar el volumen al Audio Mixer
        audioMixer.SetFloat(sfxVolumeParam, decibelios);

        // Actualizar el texto TMP
        UpdateSFXText(porcentaje);
    }

    private void UpdateSFXText(float porcentaje)
    {
        sfxText.text = Mathf.RoundToInt(porcentaje) + "%";
    }
}
