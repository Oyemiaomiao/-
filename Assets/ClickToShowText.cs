using UnityEngine;
using UnityEngine.UI;  // ����UI�����ռ�

public class ClickToShowText : MonoBehaviour
{
    public GameObject textObject;  // ָ��UI�ı����������

    void Start()
    {
        // ȷ����Ϸ��ʼʱ�ı������ص�
        textObject.SetActive(false);
    }
 void OnMouseDown()
    {
       textObject.SetActive(true);
    }
}
