using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItemFactory
{
    IItem Create(ItemRequirements requirements);
}

public class ActiveItemFactory : IItemFactory
{
    public IItem Create(ItemRequirements requirements)
    {
        switch (requirements.Room)
        {
            case 0:
                if (requirements.Utility == 0) return new Delirious();
                return new TheBible();
                
            case 1:
                if (requirements.Utility == 0) return new TheNail();
                return new GuppysPaw();
                
            case 2:
                if (requirements.Utility == 0) return new RedCandle();
                return new TheD6();
                
            case 3:
                if (requirements.Utility == 0) return new DoctorsRemote();
                return new RemoteDetonator();
                
            default:
                return new TheD6();
        }
    }
}

public class PassiveItemFactory : IItemFactory
{
    public IItem Create(ItemRequirements requirements)
    {
        switch (requirements.Room)
        {
            case 0:
                if (requirements.Utility == 0) return new CrownOfLight();
                return new TrinityShield();

            case 1:
                if (requirements.Utility == 0) return new TheMark();
                return new EmptyVessel();

            case 2:
                if (requirements.Utility == 0) return new NightLight();
                return new SpiderMod();

            case 3:
                if (requirements.Utility == 0) return new CupidsArrow();
                return new Ankh();

            default:
                return new Ankh();
        }
    }
}


public abstract class AbstractItemFactory
{
    public abstract IItem Create();
}



public class ItemFactory : AbstractItemFactory
{
    private readonly IItemFactory _factory;
    private readonly ItemRequirements _requirements;

    public ItemFactory(ItemRequirements requirements)
    {
        _factory = (requirements.Type == 0) ? (IItemFactory) new ActiveItemFactory() : new PassiveItemFactory();
        _requirements = requirements;
    }

    public override IItem Create()
    {
        return _factory.Create(_requirements);
    }

    //gameobject.getobjects with tag

}


