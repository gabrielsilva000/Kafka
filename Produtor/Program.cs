using Confluent.Kafka;
using Confluent.SchemaRegistry;
using Confluent.SchemaRegistry.Serdes;

var SchemaConfig = new SchemaRegistryConfig
{ 
    Url = "http://localhost:8081"
};

var schemaRegistry = new CachedSchemaRegistryClient(SchemaConfig);

var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

                                                 //kafka.io.Curso
using var producer = new ProducerBuilder<string, string>(config)
    //.SetValueSerializer(new AvroSerializer<kafka.io.Curso>())
    .Build();

                                  //kafka.io.Curso
var message = new Message<string, string>
{
    Key = Guid.NewGuid().ToString(),
    Value = $"Messagem teste {DateTime.Now.Second}" //new kafka.io.Curso { Id = Guid.NewGuid().ToString(), Descricao = "Curso de Apache Kafka" }
};

var result = await producer.ProduceAsync("topico-teste", message);

Console.WriteLine($"{result.Offset}");
