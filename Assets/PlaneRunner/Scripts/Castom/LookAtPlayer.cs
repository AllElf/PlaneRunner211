using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        gameObject.transform.LookAt(player.transform);
    }
}
