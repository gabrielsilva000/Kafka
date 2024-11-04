using Confluent.Kafka;
using Confluent.SchemaRegistry;

var SchemaConfig = new SchemaRegistryConfig
{
    Url = "http://localhost:8081"
};

var schemaRegistry = new CachedSchemaRegistryClient(SchemaConfig);

var config = new ConsumerConfig
{ 
    GroupId = "devio",
    BootstrapServers = "localhost:9092" 
};

                                                 //kafka.io.Curso
using var consumer = new ConsumerBuilder<string, string>(config)
    //.SetValueDeserializer(new AvroDeserializer<kafka.io.Curso>(schemaRegistry).AsSyncOverAsync())
    .Build();
consumer.Subscribe("topico-teste");
while (true)
{
    var result = consumer.Consume();
    //Console.WriteLine($"Mensagem: {result.Message.Value.Descricao}");
}