using NUnit.Framework.Internal.Commands;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    public bool IsEffectActive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public abstract void ApplyEffect(Player player);




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
