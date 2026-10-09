using UnityEngine;

public abstract class Actor : MonoBehaviour
{
    [SerializeField] protected int TotalHP;
    [SerializeField] protected int CurrentHP;
    [SerializeField] protected int MoveValue;
    public virtual void TakeDamage()
    {
        Debug.Log("Ouchy");
    }
}
