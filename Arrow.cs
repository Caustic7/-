using UnityEngine;

public class Arrow : MonoBehaviour 
{
    private float speed = 10.0f;
    private SpriteRenderer sprite;
    private Vector3 direction;
    public Vector3 Direction { set { direction = value; } }
    private GameObject parent;
    public GameObject Parent { set { parent = value; } }

    private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Start()
    {
        Destroy(gameObject, 1.5f);
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();
        if (unit && unit.gameObject != parent)
            Destroy(gameObject);
    }
}
