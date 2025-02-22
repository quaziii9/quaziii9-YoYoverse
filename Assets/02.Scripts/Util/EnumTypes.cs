using UnityEngine;

namespace EnumTypes
{
    public enum EnemyState { Idle, Patrol, Move, Trace, Attack, Die , Assassination, AssassinationFail, AssassinationDie }
    
    public enum EnemyType { Melee, Sniper }

    public enum Layers
    {
        Default,
        TransparentFX,
        IgnoreRaycast,
        Reserved1,
        Water,
        UI,
        Reserved2,
        Reserved3,
        Player,
        Enemy,
    }

    public enum PlayerEvents
    {
        PlayerSpawn,
        PlayerDamaged,
        PlayerDead,
        OnAttackEffect,
        Clear,

    }

    public enum YoYoEvents
    {
        YoYoAttached,
    }

    public enum UIEvents
    {
        OnClickDiskListItem,
        OnClickWireListItem,
        StartDraggingSkillIcon,
        StopDraggingSkillIcon,
        UpdateSkillDescription,
    }

    public enum GameEvents
    {
        SelectedDisk,
        SelectedWire,
        IsEquipReady,
        IsSkillReady,
        StartGame,
        PlayerDeath,
        Respawn,
        GameComplete
    }
    
    public enum EnemyEvents
    {
        ChangeEnemyStateAttack,
        AllStop,
        PlayerDetected,
        PlayerLost
    }

    public enum SkillEvents
    {
        UseSkill,
        SuccessQTE,
        FailQTE
    }

    public class EnumTypes : MonoBehaviour { }
}