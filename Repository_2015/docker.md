-----------------------------
docker run 
          -p 8001:80
		  -d detach
		  --name
		  image

--------------
docker exec -it mysql01 bash



----------------

Docker �����ȫ
------------------------------------------
�����������ڹ���
docker   run
docker   start/stop/restart
docker   kill
docker   rm   ɾ��һ����������
docker   pause/unpause
docker   create
docker   exec
--------------------------------------
��������
docker   ps   �г�����
docker   inspect
docker   top
docker   attach
docker   events
docker   logs    ��ȡ��������־
docker   wait
docker   export
docker   port
����rootfs����
commit
cp
diff
����ֿ�
login
pull
push
search
���ؾ������
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
