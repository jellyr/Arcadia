using UnityEngine;
using clojure.lang;

public class OnCollisionExit2DHook : ArcadiaBehaviour   
{
  public void OnCollisionExit2D(UnityEngine.Collision2D a)
  {
      var _go = gameObject;
      var _fns = fns;
      for (int i = 0; i < _fns.Length; i++){
      	var fn = _fns[i];
      	fn.invoke(_go, a);
      }
  }
}