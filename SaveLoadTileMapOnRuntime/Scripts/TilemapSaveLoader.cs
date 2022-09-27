using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace tutorial_2d
{
    [ExecuteAlways]
    public class TilemapSaveLoader : MonoBehaviour
    {

        [SerializeField] private TilemapBufferObject tilemapBuffer;
        private Tilemap tilemap;


        private void Awake()
        {
            tilemap = GetComponent<Tilemap>();
        }

        public void OnSaveTileMap()
        {
            tilemapBuffer.ClearBuffer();

            tilemap.CompressBounds();
            BoundsInt bounds = tilemap.cellBounds;
            TileBase[] allTiles = tilemap.GetTilesBlock(bounds);

            tilemapBuffer.SetBoundsBuffer(bounds);
            tilemapBuffer.AddToBuffer(allTiles);  

        }

        public void OnLoadTileMap()
        {
            

            BoundsInt _bounds = tilemapBuffer.GetBounds();
            if(_bounds.size.x != 0 && _bounds.size.y != 0) // just there so i dont accidently load from an empty buffer
            {
                
                tilemap.ClearAllTiles();
                tilemap.size = _bounds.size;
                tilemap.origin = _bounds.position;
                tilemap.ResizeBounds();

                tilemap.SetTilesBlock(_bounds, tilemapBuffer.GetTileBuffer());

                tilemapBuffer.ClearBuffer();

            }


        }


    }

}
