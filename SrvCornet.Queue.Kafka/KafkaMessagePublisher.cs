using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;
using Iken.Core;
using NLog;
using SrvCornet.Queue.Kafka;

namespace Ikel.Common.Kafka
{
    public class KafkaMessagePublisher
    {
        private Producer<string,string> producer;
        private Logger logger = LogManager.GetLogger("KafkaMessagePublisher");

        public KafkaMessagePublisher(IkenKafkaProducer producer)
        {
            this.producer = producer;
        }
        public async Task<Message<string, string>> Publish(string topic, object obj)
        {
            string payload = null;
            if (obj.GetType().Equals(typeof(string)))
                payload = (string)obj;
            else
                payload = SrvCornetJsonConverter.Serialize(obj);
            try
            {
                var message = await producer.ProduceAsync(topic, DateTime.Now.ToLongTimeString(), payload);
                return message;
            }
            catch(Exception e)
            {
                logger.Error(e);
                throw;
            }
        }
    }
}
