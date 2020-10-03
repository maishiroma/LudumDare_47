namespace Environment
{
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using GameBase;

    public class ConveyorBeltMovement : MonoBehaviour
    {
        public Rigidbody2D objRB;
        public Transform[] wayPoints;
        public float moveSpeed;
        public bool canMove;

        // private variables
        private int currPointIndex = 0;

        public int GetCurrentPointIndex
        {
            get { return currPointIndex; }
        }

        private void OnEnable()
        {
            SceneManager.sceneLoaded += ReturnFromEvent;
        }

        private void OnDisable()
        {
            SceneManager.sceneLoaded -= ReturnFromEvent;
        }

        private void FixedUpdate()
        {
            if(canMove == true)
            {
                Vector2 wayPointPos = wayPoints[currPointIndex].position;
                if (Mathf.Abs(Vector2.Distance(wayPointPos, objRB.position)) > 0.1f)
                {
                    Vector2 newVelocity = ((wayPointPos - objRB.position) * moveSpeed) * Time.deltaTime;
                    objRB.velocity = newVelocity.normalized;
                }
                else
                {
                    if (currPointIndex + 1 < wayPoints.Length)
                    {
                        currPointIndex++;
                    }
                    else
                    {
                        currPointIndex = 0;
                    }
                }
            }
        }

        private void ReturnFromEvent(Scene scene, LoadSceneMode mode)
        {
            currPointIndex = GameManager.Instance.savedWayPointIndex;

            objRB.position = wayPoints[currPointIndex].position;
        }
    }

}