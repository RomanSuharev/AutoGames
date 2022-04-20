using UnityEngine;

public class Player : MonoBehaviour
{
      void Update() {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
    } 
    private void OnCollisionstay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Car"))
        {
            Destroy(gameObject);
        }
    }
}
