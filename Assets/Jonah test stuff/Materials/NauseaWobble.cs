using UnityEngine;

public class NauseaWobble : MonoBehaviour
{

    
        public float wobbleSpeed = 2f;
        public float wobbleAmount = 1f;
        private Vector3 startRotation;

        void Start()
        {
            startRotation = transform.localEulerAngles;
        }

        void Update()
        {
            float wobbleX = Mathf.Sin(Time.time * wobbleSpeed) * wobbleAmount;
            float wobbleY = Mathf.Cos(Time.time * wobbleSpeed * 0.8f) * wobbleAmount;
            transform.localEulerAngles = startRotation + new Vector3(wobbleX, wobbleY, 0f);
        }
}

