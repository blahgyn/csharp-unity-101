using UnityEngine;

// Class (Reference Type)
public class PlayerClass 
{
    public int health;
}

// Struct (Value Type)
public struct PlayerStruct 
{
    public int health;
}

public class ClassVsStruct : MonoBehaviour 
{
    void Start() 
    {
        PlayerClass player1 = new PlayerClass();
        player1.health = 100;

        PlayerStruct player2 = new PlayerStruct();
        player2.health = 100;

        ModifyClass(player1);
        ModifyStruct(player2);

        Debug.Log("Class Health: " + player1.health); // Will change to 50
        Debug.Log("Struct Health: " + player2.health); // Remains 100
    }

    void ModifyClass(PlayerClass p) {
        p.health = 50; // Reference modified
    }

    void ModifyStruct(PlayerStruct p) {
        p.health = 50; // Local copy modified (no effect outside)
    }
}