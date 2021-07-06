cube=UnityEngine.GameObject.FindGameObjectWithTag("Player")
cube.name="123"
temRotate=cube:AddComponent(typeof(RotateSelf));
temRotate:Rotate()

--主入口函数。从这里开始lua逻辑
function Main()					
	print("logic start")	 		
end

--场景切换通知
function OnLevelWasLoaded(level)
	collectgarbage("collect")
	Time.timeSinceLevelLoad = 0
end

function OnApplicationQuit()
end