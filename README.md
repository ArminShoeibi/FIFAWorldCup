# FIFAWorldCup

## How to run?

1. Navigate to the root directory
`docker build --file src/FIFAWorldCup.API/Dockerfile --tag fifaworldcup:v1.0.0 .`

2. Apply K8s manifests
`kubectl apply -f src/FIFAWorldCup.API/K8s/FIFAWorldCup.API.Deployment.yml`
`kubectl apply -f src/FIFAWorldCup.API/K8s/FIFAWorldCup.API.Service.yml`
