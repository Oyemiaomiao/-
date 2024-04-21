using UnityEngine;

public class StretchAndRotate : MonoBehaviour
{
    private Vector3 Firsttransmit; // 初始缩放
    private float cumulativeAngle = 0f; // 累积角度

    void Start()
    {
        Firsttransmit = transform.localScale; // 保存初始缩放
        transform.localScale = new Vector3(0.5f, 5f, 1f); // 设置初始大小
    }

    void Update()
    {
        // 旋转直到达到目标角度
        float value = 0.8f;
        float angleRadians = Mathf.Asin(value);
        float angleDegrees = angleRadians * (180f / Mathf.PI); // 使用Mathf.PI转换为度

        if (cumulativeAngle < angleDegrees)
        {
            float rotationStep = 0.2f; // 每帧旋转0.2度
            transform.Rotate(0, 0, rotationStep);
            cumulativeAngle += rotationStep;

            float radians = cumulativeAngle * Mathf.PI / 180f; // 转换为弧度
            float newlocalScaleY = Firsttransmit.y / Mathf.Cos(radians); // 根据cosine调整缩放
            float newpositionX = -5 + (6 / 2) * Mathf.Tan(radians); // 计算新的X位置
            
            // 应用新的缩放和位置
            transform.localScale = new Vector3(0.5f, newlocalScaleY, 1);
            Vector3 newPosition = transform.position;
            newPosition.x = newpositionX;
            transform.position = newPosition;
        }
    }
}
