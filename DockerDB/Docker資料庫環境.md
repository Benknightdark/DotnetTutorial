# Backup Volume
```
docker run -d --rm --name dockerdb_sqldata2backup -v dockerdb_sqldata2:/volume alpine ping 127.0.0.1
docker exec -it dockerdb_sqldata2backup tar -cjf /sqldata.tar.bz2 -C /volume ./

docker commit -p dockerdb_sqldata2backup linux-mssql-volume

docker save -o DockerDB/linux-mssql-volume.tar linux-mssql-volume
```

# Restore Volume
```
cd DockerDB

docker load -i linux-mssql-volume.tar

docker run  --rm  -v dockerdb_sqldata2:/volume linux-mssql-volume sh -c 'rm -rf /volume/* /volume/..?* /volume/.[!.]* ; tar -C /volume/ -xjf  /sqldata.tar.bz2 ;'

docker-compose up -d
```



