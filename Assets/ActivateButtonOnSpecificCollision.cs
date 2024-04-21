using UnityEngine;
using UnityEngine.UI;  // ����UI�����ռ�

public class ActivateButtonOnSpecificCollision : MonoBehaviour
{
    public Button buttonToActivate; // ָ��Ҫ����İ�ť������

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �����ײ�������Ƿ�Ϊ����ָ���ġ�Activator����ǩ
        if (collision.gameObject.CompareTag("Activator"))
        {
            // ���ť��ʹ��ɵ��
            buttonToActivate.interactable = true;
        }
    }
}
