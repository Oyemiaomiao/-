using UnityEngine;
using UnityEngine.UI; // ����UI�����ռ�

public class HideUIText : MonoBehaviour
{
    public GameObject textToHide; // ��������Ҫ���ص��ı���

    // Ϊ��ť��ӵ���¼�����
    void Start()
    {
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(HideText);
        }
    }

    // ����ť�����ʱ���ô˷���
    void HideText()
    {
        if (textToHide != null)
        {
            textToHide.SetActive(false); // �����ı���
        }
    }
}
