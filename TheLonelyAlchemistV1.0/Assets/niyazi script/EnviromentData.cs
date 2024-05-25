using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnviromentData
{
    public List<string> pickedupItems;

    public List<string> droppedItems;

    public List<StorageData> storage;
    public List<CampfireData> campfire;


    public List<TreeData> treeData;

    public List<DroppedData> droppeditemdata;


    public EnviromentData(List<string> _pickedupItems, List<string> _droppedItems, List<StorageData> _storage, List<TreeData> _treeData, List<DroppedData> _dropped , List<CampfireData> _campfire)
    {
        pickedupItems = _pickedupItems;
        droppedItems = _droppedItems;
        storage = _storage;
        treeData = _treeData;
        droppeditemdata = _dropped;
        campfire = _campfire;
    }

}

[System.Serializable]
public class TreeData
{
    public string name;
    public Vector3 position;
    public Vector3 rotation;
}

[System.Serializable]
public class StorageData
{
    public List<string> items;
    public Vector3 position;
    public Vector3 rotation;
}

[System.Serializable]
public class DroppedData
{
    public List<string> items;
    public string name;
    public Vector3 position;
    public Vector3 rotation;
}

[System.Serializable]
public class CampfireData
{
    public Vector3 position;
    public Vector3 rotation;
}

