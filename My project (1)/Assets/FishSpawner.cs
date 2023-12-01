using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public Sprite[] fishSprites;
    public float fishSpeed = 2f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction);

            //Find the topmost fishmananbger clone 
            GameObject topmostFish = null;
            int highestSortingOrder = int.MinValue;

            foreach (var hit in hits)
            {
                if (hit.collider != null && hit.collider.name.StartsWith("FishManager(Clone)"))
                {
                    SpriteRenderer fishRenderer = hit.collider.GetComponent<SpriteRenderer>();
                    if (fishRenderer != null && fishRenderer.sortingOrder > highestSortingOrder)
                    {
                        highestSortingOrder = fishRenderer.sortingOrder;
                        topmostFish = hit.collider.gameObject;
                    }
                }
            }

            //Check if a fishmanger clone was found
            if (topmostFish != null && Time.timeScale != 0f)
            {
                Time.timeScale = 0f;
                //Destroy the fishmanager(clone) on top 
                Destroy(topmostFish);
            }
        }
    }

    void FixedUpdate()
    {
        MoveFish();
    }

    void MoveFish()
    {
        GameObject[] fishes = GameObject.FindGameObjectsWithTag("FishManager");

        foreach (var fish in fishes)
        {
            Rigidbody2D fishRigidbody = fish.GetComponent<Rigidbody2D>();

            //rigidbody check
            if (fishRigidbody != null)
            {
                //Apply continuous force in a randoom direction
                Vector2 movementDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
                fishRigidbody.AddForce(movementDirection * fishSpeed);
            }
        }
    }

    public void SpawnFish()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-3f, 3f), 0f);
            GameObject fish = Instantiate(fishPrefab, spawnPosition, Quaternion.identity);

            //Adding sprite for da fish
            SpriteRenderer fishRenderer = fish.GetComponent<SpriteRenderer>();
            if (fishRenderer != null && fishSprites.Length > 0)
            {
                fishRenderer.sprite = fishSprites[Random.Range(0, fishSprites.Length)];
            }

            // RigidBody2
            Rigidbody2D fishRigidbody = fish.AddComponent<Rigidbody2D>();
            fishRigidbody.gravityScale = 0; //No gravity
            fishRigidbody.freezeRotation = true; //Freeze rotation

            BoxCollider2D fishCollider = fish.AddComponent<BoxCollider2D>();
            fishCollider.size = new Vector2(5.9f, 2.46f);
        }
    }
}