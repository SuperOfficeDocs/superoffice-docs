public class AddressHelper
{
  public Dictionary<string, string> GetAddressAsDictionary(Address address)
  {
    ValidateAddress(address);
    var result = new Dictionary<string, string>(14);

    foreach (var line in address.LocalizedAddress)
    {
      foreach (var field in line)
      {
        result.Add(field.Name, field.Value);
      }
    }
    return result;
  }

  public void SetAddressFromDictionary(Address address, Dictionary<string, string> addressInfo)
  {
    ValidateAddress(address);

    foreach (var line in address.LocalizedAddress)
    {
      foreach (var field in line)
      {
        if (addressInfo.ContainsKey(field.Name))
          field.Value = addressInfo[field.Name];
        }
      }
    }

  private void ValidateAddress(Address address)
  {
    if ( address == null
      || address.LocalizedAddress == null
      || address.LocalizedAddress.Length == 0)
      throw new Exception("Must provide a formatted Address");
  }
}