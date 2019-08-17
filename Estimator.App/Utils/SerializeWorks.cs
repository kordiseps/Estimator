namespace Estimator.App.Utils
{
    public static class SerializeWorks
    {
        public static string Serialize<T>(T obj)
        {
            string result = string.Empty;

            System.IO.StringWriter writer = new System.IO.StringWriter();
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            serializer.Serialize(writer, obj);
            result = writer.ToString();

            return result;
        }

      
        public static T Deserialize<T>(string xml)
        {
            T result = default(T);

            if (!string.IsNullOrEmpty(xml))
            {
                System.IO.TextReader tr = new System.IO.StringReader(xml);
                System.Xml.XmlReader reader = System.Xml.XmlReader.Create(tr);
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

                if (serializer.CanDeserialize(reader))
                    result = (T)serializer.Deserialize(reader);
            }
            return result;
        }
    }
}
