using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem { }
public class Delirious : IItem 
{
    public string Name = "Delirious";
    void start()
    {
        Object.Instantiate(Resources.Load("Delirious"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class TheBible : IItem 
{
    public string Name = "The Bible";
    void start()
    {
        Object.Instantiate(Resources.Load("TheBible"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class CrownOfLight : IItem 
{
    public string Name = "Crown of Light";
    void start()
    {
        Object.Instantiate(Resources.Load("CrownOfLight"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class TrinityShield : IItem 
{
    public string Name = "Trinity Shield";
    void start()
    {
        Object.Instantiate(Resources.Load("TrinityShield"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class TheNail : IItem 
{
    public string Name = "The Nail";
    void start()
    {
        Object.Instantiate(Resources.Load("TheNail"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class GuppysPaw : IItem 
{
    public string Name = "Guppy's Paw";
    void start()
    {
        Object.Instantiate(Resources.Load("GuppiesPaw"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class TheMark : IItem 
{
    public string Name = "The Mark";
    void start()
    {
        Object.Instantiate(Resources.Load("TheMark"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class EmptyVessel : IItem
{
    public string Name = "Empty Vessel";
    void start()
    {
        Object.Instantiate(Resources.Load("EmptyVessel"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class RedCandle : IItem 
{
    public string Name = "Red Candle";
    void start()
    {
        Object.Instantiate(Resources.Load("RedCandle"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class TheD6 : IItem 
{
    public string Name = "The D6";
    void start()
    {
        Object.Instantiate(Resources.Load("TheD6"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class NightLight : IItem 
{
    public string Name = "Night Light";
    void start()
    {
        Object.Instantiate(Resources.Load("NightLight"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class SpiderMod : IItem 
{
    public string Name = "Spider Mod";
    void start()
    {
        Object.Instantiate(Resources.Load("SpiderMod"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class DoctorsRemote : IItem 
{
    public string Name = "Doctors Remote";
    void start()
    {
        Object.Instantiate(Resources.Load("DoctorsRemote"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class RemoteDetonator : IItem 
{
    public string Name = "Remote Detonator";
    void start()
    {
        Object.Instantiate(Resources.Load("RemoteDetonator"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class CupidsArrow : IItem 
{
    public string Name = "Cupids Arrow";
    void start()
    {
        Object.Instantiate(Resources.Load("CupidsArrow"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
public class Ankh : IItem 
{
    public string Name = "Ankh";
    void start()
    {
        Object.Instantiate(Resources.Load("Ankh"), new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}