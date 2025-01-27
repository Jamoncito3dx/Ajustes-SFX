# Unity SFX Volume Settings

Este proyecto contiene un script de Unity que permite ajustar el volumen de los efectos de sonido (SFX) utilizando un `Slider` de la interfaz gráfica y un `TextMeshProUGUI` para mostrar el porcentaje de volumen. Está diseñado para integrarse con un `Audio Mixer` en Unity.

## 📋 Características

- Ajusta dinámicamente el volumen de los efectos de sonido (SFX) en tiempo real.
- Convierte valores de porcentaje del `Slider` a decibelios para aplicarlos en un `Audio Mixer`.
- Muestra el volumen actual como porcentaje mediante un `TextMeshProUGUI`.

## 🛠️ Requisitos

- **Unity** (versión recomendada: 2021.3 o superior).
- **TextMeshPro**: Asegúrate de que el paquete TextMeshPro esté instalado en tu proyecto de Unity.
- **Audio Mixer**: Configurado con un parámetro expuesto para el volumen de los SFX.

## 🚀 Cómo usar el script

1. **Agregar el script al proyecto:**
   - Copia el archivo `SFXVolumeSettings.cs` y colócalo en la carpeta `Scripts` de tu proyecto de Unity.

2. **Configurar el Audio Mixer:**
   - Crea o abre un `Audio Mixer` en Unity.
   - Añade un grupo para los efectos de sonido (SFX).
   - ![image](https://github.com/user-attachments/assets/abdae68e-85b2-4b78-8f17-eeaea1229e45)
   - Expón el parámetro de volumen del grupo SFX (clic derecho > Expose to script).
   - ![image](https://github.com/user-attachments/assets/c33de333-fc25-41f0-bd5e-c9e4fecf8164)
   - Despues cambia el nombre en Exposed Parameters a "SFXVolume"
   - ![image](https://github.com/user-attachments/assets/061fa39e-2e58-466e-8fbf-f2969c508494)




3. **Configurar el Slider y el Texto TMP:**
   - Crea un `Slider` en tu interfaz gráfica y configúralo como desees.
   - Crea un objeto de texto usando `TextMeshPro`.
   - Asigna el `Slider` al campo `sfxSlider` y el texto TMP al campo `sfxText` en el Inspector.
   - Asigna el `Audio Mixer` al campo correspondiente y verifica que el parámetro coincide con el nombre en el script (`SFXVolume`).

4. **Ejecutar el proyecto:**
   - Al iniciar el juego, el slider reflejará el volumen actual de los SFX.
   - Ajusta el slider para cambiar el volumen en tiempo real. El porcentaje se actualizará en el texto TMP.

## 📂 Estructura del proyecto

```plaintext
UnitySFXVolumeSettings/
├── SFXVolumeSettings.cs    # Script principal para ajustar volumen de SFX.
├── README.md               # Documentación del proyecto.
