using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 이전 총알생성기에서 사용했던 방식인
// 매번 필요시마다 사용했던 Instantiate(생성) 이 아닌
// 오브젝트 풀링 방식을 사용할 거임
// 오브젝트 풀링(Object Pooling)?
// '풀(Pool):웅덩이'에 쌓아두는 방식임
// 왜 해당 방식이 필요하냐
// Instantiate() 메서드처럼 오브젝트를 실시간으로 생성하거나,
// Destroy() 메서드처럼 오브젝트를 실시간으로 파괴하는 처리는
// 성능을 많이 요구함
// 또한 메모리를 정리하는 GC(GarbageCollection)을 유발하기 쉬움
// 게임 도중에 오브젝트를 너무 자주 생성하거나 파괴하면
// 게임 끊김(Freeze) 현상이 발생 됨

public class PlatformSpawner : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
