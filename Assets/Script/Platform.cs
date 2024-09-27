using UnityEngine;

public class Platform : MonoBehaviour
{
    public static Platform instance;
    private BoxCollider2D cof;
    private Animation anim;
    internal void Active(Vector3 pos)
    {
        transform.position = pos;

        if(Random.value < DataBaseManager.instance.itemSpawnPer)
        {
            item items = Instantiate<item>(DataBaseManager.instance.baseItem);
            items.Active(transform.position, GatHelfSizeX());
        }
        if(Random.value < DataBaseManager.instance.MonSpawnPer)
        {
            Monster monster = Instantiate<Monster>(DataBaseManager.instance.baseMonster);
            monster.Active(transform.position, GatHelfSizeX());
        }
    }
    
    internal void Init()
    {

    }
    public float GatHelfSizeY()
    {
        return cof.size.y * 0.5f;
    }
    public float GatHelfSizeX()
    {
        return cof.size.x * 0.5f;
    }
    private void Awake()
    {
        cof = GetComponentInChildren<BoxCollider2D>();
    }
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
