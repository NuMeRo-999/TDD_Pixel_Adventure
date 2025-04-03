using UnityEngine;

[System.Serializable]
public class NinjaFrogStats
{
    public int maxLives = 3;          
    public float speed = 5f;        
    public float jumpForce = 10f;    
    public int attackPower = 1;     

    public int attackRange = 1;       

    public bool CanAttack(int attackPower, int attackRange)
    {
        if (attackPower > 0 && attackRange > 0)
        {
            return true;
        }
        return false;
    }
}
