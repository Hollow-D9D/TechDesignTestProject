using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class activate_button : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI text1;
    [SerializeField] private TextMeshProUGUI text2;
    private void OnMouseDown()
    {
        button.interactable = true;
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(true);

    }

}
