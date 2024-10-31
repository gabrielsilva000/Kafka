# Kafka
Kafka - implementando um produtor e consumidor
#
# Comandos 

CRIANDO PROJETO 

dotnet new sln -n Kafka

dotnet new console -n Produtor

dotnet add Produtor package Confluent.kafka --version 1.8.2

dotnet new console -n Consumidor

dotnet add Consumidor package Confluent.kafka --version 1.8.2

dotnet sln add Produtor

dotnet sln add Consumidor

dotnet build
#
