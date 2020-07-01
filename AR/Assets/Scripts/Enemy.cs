using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("速度"), Range(0, 10)]
    public float speed = 1.5f;

    [Header("停止距離"), Range(0, 5)]
    public float stopDistance = 2;

    [Header("追蹤目標名稱")]
    public string targetName = "";

    [Header("爆炸效果")]
    public GameObject explosion;

    [Header("傷害"), Range(10, 100)]
    public float damage;

    /// <summary>
    /// 目標 : 
    /// </summary>
    private Transform target;

    /// <summary>
    /// 導覽網路代理器
    /// </summary>
    private NavMeshAgent nma;

    private void Start()
    {
        nma = GetComponent<NavMeshAgent>();
        nma.speed = speed;
        nma.stoppingDistance = stopDistance;

        target = GameObject.Find(targetName).transform;
        nma.SetDestination(target.position);
    }

    private void CreateEffect()
    {
        
    }
}
