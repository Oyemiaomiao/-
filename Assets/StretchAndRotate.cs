using UnityEngine;

public class StretchAndRotate : MonoBehaviour
{
    private Vector3 Firsttransmit; // ��ʼ����
    private float cumulativeAngle = 0f; // �ۻ��Ƕ�

    void Start()
    {
        Firsttransmit = transform.localScale; // �����ʼ����
        transform.localScale = new Vector3(0.5f, 5f, 1f); // ���ó�ʼ��С
    }

    void Update()
    {
        // ��תֱ���ﵽĿ��Ƕ�
        float value = 0.8f;
        float angleRadians = Mathf.Asin(value);
        float angleDegrees = angleRadians * (180f / Mathf.PI); // ʹ��Mathf.PIת��Ϊ��

        if (cumulativeAngle < angleDegrees)
        {
            float rotationStep = 0.2f; // ÿ֡��ת0.2��
            transform.Rotate(0, 0, rotationStep);
            cumulativeAngle += rotationStep;

            float radians = cumulativeAngle * Mathf.PI / 180f; // ת��Ϊ����
            float newlocalScaleY = Firsttransmit.y / Mathf.Cos(radians); // ����cosine��������
            float newpositionX = -5 + (6 / 2) * Mathf.Tan(radians); // �����µ�Xλ��
            
            // Ӧ���µ����ź�λ��
            transform.localScale = new Vector3(0.5f, newlocalScaleY, 1);
            Vector3 newPosition = transform.position;
            newPosition.x = newpositionX;
            transform.position = newPosition;
        }
    }
}
