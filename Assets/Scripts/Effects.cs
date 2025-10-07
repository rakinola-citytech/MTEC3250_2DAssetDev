using UnityEngine;

public class Effects : MonoBehaviour
{
    public ParticleSystem ps;

    private void OnEnable()
    {
        Tile.CrateDestroyed += OnLifeTaken;
        
    }

    private void OnDisable()
    {
        Tile.CrateDestroyed -= OnLifeTaken;

    }


    private void OnLifeTaken(Tile tile)
    {
        Vector3 offset = new Vector3(tile.transform.position.x, tile.transform.position.y, tile.transform.position.z);
        ps.transform.position = offset;
        //ps.transform.position = Vector3(tile.transform.position);
        ps.Emit(15);

    }



}
