using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Dropdown roomDropdown;
    public Dropdown utilityDropdown;
    public Dropdown typeDropdown;
    public Text Description;

    string TextContainer;


    public int Room;
    public int Utility;
    public int Type;
    GameObject AssetContainer;
    Vector3 Center = new Vector3(400,100,0);
    public void ActivateTheFactory()
    {
        Room = roomDropdown.value;
        Utility = utilityDropdown.value;
        Type = typeDropdown.value;

        ItemRequirements requirements = new ItemRequirements();
        requirements.Room = Room;
        requirements.Utility = Utility;
        requirements.Type = Type;

        AssetContainer = GameObject.FindGameObjectWithTag("3D");
        Destroy(AssetContainer);

        IItem i = GetItem(requirements);
        Debug.Log(i);
        TextContainer = i.ToString();
        Description.text = TextContainer;
        TextContainer += "_3D";
        Instantiate(Resources.Load(TextContainer), Center, Quaternion.identity);

    }

    private static IItem GetItem(ItemRequirements requirements)
    {
        ItemFactory factory = new ItemFactory(requirements);
        return factory.Create();
    }
}
