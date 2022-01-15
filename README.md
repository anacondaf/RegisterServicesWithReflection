#Inject services using reflection:
#### Purpose of project
- Show different ways on how to register services ready for DI
- Using reflection to register services
- Four different ways of registering services
- Each method is in a separate branch

If you want to test the functionality of the API you can run the following command and it will spin the Database up in a docker container.
```bash
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

API: http://localhost:8002/swagger/index.html

Otherwise, you can just build the solution