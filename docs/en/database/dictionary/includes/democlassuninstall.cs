using SuperOffice.CD.DSL.V1.StepModel;

namespace ExampleDictionaryStep
{
  [Dictionary("DemoFeature", int.MaxValue, ReleaseState.Released)]
  public class DemoClassUninstall : DictionaryStep
  {
    public override void Structure()
    {
      DropTable("Demo");
    }
  }
}