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
EXECUTANDO PROJETO

        cd ./Consumidor/
        dotnet run


        cd ./Produtor/
        dotnet run
#
INSTALANDO TOOLS DO APACHE AVRO

        dotnet tool install --global Apache.Avro.Tools

        dotnet add Produtor package Confluent.SchemaRegistry.Serdes.Avro

        dotnet add Consumidor package Confluent.SchemaRegistry.Serdes.Avro

#
CRIANDO UM SCHEMA

        cd Produtor

        avrogen -s ..\Avros\Curso.avsc .


#
IMPLEMENTANDO SCHEMA REGISTRY

        cd .\Consumidor\
        dotnet run

        cd .\Produtor\
        dotnet run


