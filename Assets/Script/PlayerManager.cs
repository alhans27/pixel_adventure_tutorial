using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoginRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator LoginRoutine()
    {
        bool done = false;
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (response.success)
            {
                Debug.Log("Player Berhasil Login ke LootLocker");
                PlayerPrefs.SetString("playerID", response.player_id.ToString());
                done = true;
            }
            else
            {
                Debug.Log("Tidak bisa menjalankan Session");
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);
    }
}
