using UnityEngine;

public class ActivateObjectsOnClick : MonoBehaviour
{
    public GameObject[] objectsToActivate; // ���ڴ洢Ҫ�������Ϸ��������

    private void OnMouseDown()
    {
        // ����˶���ʱ��������ָ���Ķ���
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                // ���������е�ÿ������
                obj.SetActive(true);
            }
        }

        // ��������ʹ�ö���������ʧ
        gameObject.SetActive(false);
    }
}
