# MicroService_Demo

## Target .net particular framework

dotnet new webapi -n CommandsService -f net5.0

## Open particular directory file using vs code

code -r .\MicroService_Demo\

# Docker

1. docker run -p 8080:80 -d username/platformservice
2. docker ps
3. docker stop <containerid>
4. docker push username/platformservice

# Kubernates commands used

1. kubectl apply -f platforms-depl.yaml
2. kubectl get deployment
3. kubectl get pods
4. Kubectl delete deployment platforms-depl.yaml

<!-- node port to access the kubernates  container-->

kubectl apply -f platforms-np-sv.yaml
kubectl get services

## Points

1. We us **HttpFactory** because if your making multiple requests using httpClient, it manages connection safety, you dont end up connection exhaustion
