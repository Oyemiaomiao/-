using UnityEngine;
using UnityEngine.EventSystems; // ���ڴ���UI�¼�
using UnityEngine.UI; // ���ڴ���UI���

public class ActivateMultiple2DObjects : MonoBehaviour, IPointerClickHandler // ʵ�ֵ���ӿ�
{
    public GameObject[] objectsToActivate; // Ҫ����Ķ��2D���������
     public Button[] buttonsToActivate; // Ҫ����İ�ť����

    public void OnPointerClick(PointerEventData eventData)
    {
        // ����Ƿ�������Ҫ����Ķ�������
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                // ���������е�ÿ��2D����
                obj.SetActive(true);
            }
            
        }
        
        foreach (Button btn in buttonsToActivate)
        {
            if (btn != null)
            {
                // ���������е�ÿ����ť
                btn.gameObject.SetActive(true);
            }
        }


        // �����ʹ�ö���������ʧ
        gameObject.SetActive(false);
    }
}
