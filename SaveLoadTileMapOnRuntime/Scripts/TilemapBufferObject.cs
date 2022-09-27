using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace tutorial_2d
{
    [CreateAssetMenu(fileName = "newTileMaBufferObject", menuName = "Data/Utility/Tilemap buffer")]
    public class TilemapBufferObject : ScriptableObject
    {

        private BoundsInt boundsBuffer;
        private TileBase[] tileBuffer;




        public void AddToBuffer(TileBase[] _tileBuffer)
        {
            tileBuffer = _tileBuffer;
        }

       

        public void SetBoundsBuffer(BoundsInt _boundsBuffer)
        {
            boundsBuffer = _boundsBuffer;
        }

        public void ClearBuffer()
        {
            tileBuffer = new TileBase[0];
            boundsBuffer = new BoundsInt(new Vector3Int(0, 0), new Vector3Int(0, 0));
        }

        public BoundsInt GetBounds()
        {
            return boundsBuffer;            
        }

        public TileBase[] GetTileBuffer()
        {
            return tileBuffer;
        }


    }


}
