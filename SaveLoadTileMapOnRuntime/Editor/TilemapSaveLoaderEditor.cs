using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace tutorial_2d
{
    [CustomEditor(typeof(TilemapSaveLoader)), CanEditMultipleObjects]
    public class TilemapSaveLoaderEditor : Editor
    {

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            TilemapSaveLoader myScript = (TilemapSaveLoader)target;

            if(GUILayout.Button("Save tilemap"))
            {
                myScript.OnSaveTileMap();
            }

            if(GUILayout.Button("Load Tilemap"))
            {
                myScript.OnLoadTileMap();
            }
        }

    }

}
