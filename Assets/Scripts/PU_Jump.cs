using UnityEngine;

public class PU_Jump : PowerUpScript
{
    public override void ApplyEffect()
    {
        
        player.jumpSpeed += 4;

        base.ApplyEffect();
    }

        protected override void NegateEffect()
    {
        base.NegateEffect();
        player.jumpSpeed -= 4;
    }
}
