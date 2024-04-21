using UnityEngine;

public class ClickToSwap : MonoBehaviour
{
    public GameObject objectToActivate; // ��קҪ����Ķ�������ֶ�

    void OnMouseDown()
    {
        // �����ǰ����ʱ����������
        gameObject.SetActive(false);

        // ����Ƿ�������Ҫ����Ķ���
        if (objectToActivate != null)
        {
            // ������һ������
            objectToActivate.SetActive(true);
        }
    }
}
