using SuperOffice.CD.DSL.V1.StepModel;
 
namespace ExampleDictionaryStep
{
  [Dictionary("DemoFeature", 1, ReleaseState.Released)]
  public class DemoClass1 : DictionaryStep
  {
    public override void Structure()
    {
      CreateTable("Demo", "Description of demo table", false, true)
        .TableProperties.Replication(ReplicationFlags.Up   | 
                                     ReplicationFlags.Down | 
                                     ReplicationFlags.Prototype)
        .AddBlob("BlobField", "Blogb field description")
        .AddBool("BoolField", "Boolean field description")
        .AddDateTime("DateTimeField", "Datetime field description")
        .AddDouble("DoubleField", "Double field description")
        .AddForeignKey("ForeignKeyField", "Foreign key field description", "contact")
        .AddInt("IntField", "Integer field description")
        .AddRegisteredUpdated()
        .AddString("StringField", "String field description", 256)
        .AddUShort("UIntField", "UintField description")
        ;
    }
  }
}