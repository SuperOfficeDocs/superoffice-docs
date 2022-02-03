```csharp
public class CustomerDataSource
{
    private const string _dataSource = @"C:\Temp\Customers.xml";

    public CustomerDataSource()
    {
        Deserialize();
    }

    public List<CustomerInfo> Customers = new List<CustomerInfo>();

    public void Save()
    {
         XmlSerializer serializer = new XmlSerializer(typeof(List<CustomerInfo>));

        using (TextWriter writer = new StreamWriter( _dataSource))
        {
             serializer.Serialize(writer, Customers);
        }
    }

    private void Deserialize()
    {
        if (!File.Exists(_dataSource))
        {
            return;
        }

        XmlSerializer deserializer = new XmlSerializer(typeof(List<CustomerInfo>));
        using(TextReader reader = new StreamReader(_dataSource))
        {
            object obj = deserializer.Deserialize(reader);
            Customers = (List<CustomerInfo>)obj;
            reader.Close();
        }
    }
}
```