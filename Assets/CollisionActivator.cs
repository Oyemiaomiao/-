using UnityEngine;

public class CollisionActivator : MonoBehaviour
{
    public GameObject button; // ��ק��İ�ť���������������

    void Start()
    {
        // ȷ����Ϸ��ʼʱ��ť�ǷǼ���״̬
        button.SetActive(false);
    }

void OnCollisionEnter2D(Collision2D collision)
{
    Debug.Log("Collision Detected with: " + collision.collider.name);
    button.SetActive(true);
}


}
