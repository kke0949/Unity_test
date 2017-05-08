using System;
using UnityEngine;
using System.Collections;

public class LoadAssetBundleExample : MonoBehaviour
{
    /* 출저 : http://itmining.tistory.com/56 */

    // 번들 다운 받을 서버의 주소 - http://113.198.234.35:8000/Asset/ (베리즈)
    public string BundleURL;
    // 번들의 version
    public int version;

    void Start()
    {
        StartCoroutine(LoadAssetBundle());
    }

    IEnumerator LoadAssetBundle()
    {
        while (!Caching.ready)
            yield return null;

        // using문은 File 및 Font 처럼 컴퓨터 에서 관리되는 리소스들을 쓰고 나서
        // 쉽게 자원을 되돌려줄수 있도록 기능을 제공
        using (WWW www = WWW.LoadFromCacheOrDownload(BundleURL, version))
        {
            string Filename = BundleURL.Substring(33);
            print(Filename);
            yield return www;
            if (www.error != null)
                throw new Exception("WWW 다운로드에 에러가 생겼습니다.:" + www.error);

            AssetBundle bundle = www.assetBundle;

            AssetBundleRequest request = bundle.LoadAssetAsync(Filename, typeof(GameObject));
            yield return request;

            GameObject obj = Instantiate(request.asset) as GameObject;
            obj.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

            bundle.Unload(false);
            www.Dispose();

        } 
    }
}