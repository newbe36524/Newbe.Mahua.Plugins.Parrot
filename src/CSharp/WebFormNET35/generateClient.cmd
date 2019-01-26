del /S /Q MahuaClient
java -jar ../../swagger-codegen-cli-2.4.1.jar generate -i http://127.0.0.1:36524/swagger/v1/swagger.json -l csharp -o MahuaClient -c generate.json