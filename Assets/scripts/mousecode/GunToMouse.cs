using UnityEngine;

public class GunToMouse:MonoBehaviour 
{
    public float angle;
    public float directionX;
    private Animator animator;
    private float gunposx;
    private void Start()
    {
       
    }

    private void Update()
    {
       
        Direction();
       
        
       

    }
    public  void Direction()
    {

        Vector3 MouseScreenPos = Input.mousePosition;
        Vector3 MouseWorldPos = Camera.main.ScreenToWorldPoint(new Vector3(MouseScreenPos.x, MouseScreenPos.y, -Camera.main.transform.position.z));
        Vector2 direction = (MouseWorldPos - transform.position).normalized;
         angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.localEulerAngles = new Vector3(0, 0, angle);
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
         directionX = MouseWorldPos.x - transform.parent.position.x;
        if (directionX <-0.1f)
        {
            transform.localPosition = new Vector3(-0.1f, 0, 0);
            sr.flipY = true;
        }
        else if(directionX >0.1f)
        {
            transform.localPosition = new Vector3(0.1f, 0, 0);
            sr.flipY = false;
        }

    }
}
