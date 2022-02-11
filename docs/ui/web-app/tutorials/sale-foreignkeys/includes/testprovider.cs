[MDOProviderPlugin("DevNetTestList")]
public class testProvider : SuperOffice.CRM.Lists.LiteralsOnlyBase
{

  protected override void AddItems()
  {
    base.RawRootItems.Add(new SoListItem(1, "First item", "This is the first item", String.Empty));
    base.RawRootItems.Add(new SoListItem(2, "Second item", "This would be the second item", String.Empty));
    base.RawRootItems.Add(new SoListItem(3, "Third item", "This is the third and last item", String.Empty));
  }

}