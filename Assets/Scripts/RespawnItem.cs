using UnityEngine;

public class RespawnItem : MonoBehaviour
{

    [Header("Item a ser spawndado")]
    public GameObject item;

    [Header("Número de itens a serem respawndados")]
    public int numberItem;

    [Header("Tempo para o respawn")]
    public float respawnTime;

    [Header("Inicia pela diretira?")]
    public bool isRight;

    private float currentTime;

    private float paddingX;

    void Start()
    {
        paddingX = item.GetComponent<BoxCollider2D>().size.x + 0.02f;

        CreateItems(transform.position);
    }

    void Update()
    {
        if (currentTime > respawnTime)
        {
            CreateItems(transform.position);

            currentTime = 0;
        }
        else
        {
            currentTime += Time.deltaTime;
        }
    }

    void CreateItems(Vector3 position)
    {
        for (int i = 0; i < numberItem; i++)
        {
            var obj = Instantiate(item, position + new Vector3(paddingX * i, 0, 0), Quaternion.identity);
            obj.GetComponent<CarMovement>().isRight = isRight;
        }
    }
}
