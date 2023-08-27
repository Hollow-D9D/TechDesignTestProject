using UnityEngine;
using UnityEngine.Localization.Settings;
public class language_changer : MonoBehaviour
{
    int id = 0;
    int langCount = 4;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            id = (id + 1) % langCount;
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[id];
        }
    }
}
