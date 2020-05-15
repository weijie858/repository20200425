-----------------------------
docker run 
          -p 8001:80
		  -d detach
		  --name
		  image

--------------
docker exec -it mysql01 bash



----------------

Docker 命令大全
------------------------------------------
容器生命周期管理
docker   run
docker   start/stop/restart
docker   kill
docker   rm   删除一个或多个容器
docker   pause/unpause
docker   create
docker   exec
--------------------------------------
容器操作
docker   ps   列出容器
docker   inspect
docker   top
docker   attach
docker   events
docker   logs    获取容器的日志
docker   wait
docker   export
docker   port
容器rootfs命令
commit
cp
diff
镜像仓库
login
pull
push
search
本地镜像管理
images
rmi
tag
build
history
save
load
import
------------------------------
info|version
docker  info
docker  version


-------------------
from  microsoft/dotnet:sdk sa build-env
workdir /code
copy . /code
run dotnet publish -c release -o out

from microsoft/dotnet:runtime
workdir /app
copy --from=build-env /code/out /app
entrypoint ["dotnet","console.dll"]
