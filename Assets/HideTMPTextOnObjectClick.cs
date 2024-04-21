using UnityEngine;
using TMPro;  // ����TextMeshPro�����ռ�

public class HideTMPTextOnObjectClick : MonoBehaviour
{
    public TextMeshProUGUI textToHide; // ����Inspector��ָ����TextMeshProUGUI���

    private void OnMouseDown()
    {
        // ����Ƿ�ָ����TMP�ı�
        if (textToHide != null)
        {
            textToHide.gameObject.SetActive(false); // ����TMP�ı�
        }
    }
}
