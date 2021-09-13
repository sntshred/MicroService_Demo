# MicroService_Demo

## Target .net particular framework

dotnet new webapi -n CommandsService -f net5.0

## Open particular directory file using vs code

code -r .\MicroService_Demo\

# Docker

Create the image with the below command

1. docker build -t santosh414/platformservice .
2. docker run -p 8080:80 -d username/platformservice
3. docker ps
4. docker stop <containerid>
5. docker push username/platformservice

## CommandService

Create the image with the below command

1. docker build -t santosh414/commandservice .
2. docker push username/commandservice
3. docker run -p 8080:80 santosh414/commandservice

# Kubernates commands used

1. kubectl apply -f platforms-depl.yaml
2. kubectl get deployment
3. kubectl get pods
4. Kubectl delete deployment platforms-depl.yaml
   5.kubectl rollout restart deployment platforms-depl

<!-- node port to access the kubernates  container-->

kubectl apply -f platforms-np-sv.yaml
kubectl get services

## After adding the cluset IP in platform-deplyoment files run the file and confirm the cluset IP services returned or added successfuly

1. kubectl apply -f .\commands-depl.yaml
2. kubectl get services
3. kubectl get deployments
4. kubectl get pods

## To refresh kubernates to get the latest container, we need force restart or refresh by

1. kubectl get deployments --> returns deployment names
2. kubectl rollout restart deployment <name of the deployment>
3. kubectl get pods

## Ngnix ingress controller setup

1. kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.0.0/deploy/static/provider/cloud/deploy.yaml
2. kubectl get pods --namespace=ingress-nginx
3. kubectl get services --namespace=ingress-nginx
4. kubectl apply -f .\ingress-serv.yaml

## Points

1. We us **HttpFactory** because if your making multiple requests using httpClient, it manages connection safety, you dont end up connection exhaustion

2. **K8S** - When we deplay the code in kubernettes it will run as production environment, our localhost settting wont work there.
3. **Namespace** - kubectl get pods --namespace=ingress-nginx: by default K8S works on default namespace, but nginx has its own namespace, to access the nginx pods we need to specify the namespace, otherwise in default namespace it doesn't return any nginx pods
