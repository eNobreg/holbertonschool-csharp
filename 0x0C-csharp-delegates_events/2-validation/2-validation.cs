using System;

/// <summary>
/// Player baseclass
/// </summary>
public class Player
{
    string name;
    float maxHp;
    float hp;

    /// <summary>
    /// Player constructer
    /// </summary>
    /// <param name="name">Name of character</param>
    /// <param name="maxHp">MaxHP of charater</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// prints out health values of characters
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// Take damage function
    /// </summary>
    /// <param name="damage">Amount of damage to take</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{this.name} takes {damage} damage!");
        }
        float newHp = this.hp - damage;
        this.ValidateHP(newHp);
    }

    /// <summary>
    /// Heal damage function
    /// </summary>
    /// <param name="heal">Amount to heal</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
            heal = 0f;
        }
        else
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }
        float newHp = this.hp + heal;
        this.ValidateHP(newHp);
    }

    /// <summary>
    /// Sets the new HP Based on value given
    /// </summary>
    /// <param name="newHp">New HP to set it till</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }
}

/// <summary>
/// Delegate for calculating health
/// </summary>
/// <param name="i"></param>
public delegate void CalculateHealth(float i);


