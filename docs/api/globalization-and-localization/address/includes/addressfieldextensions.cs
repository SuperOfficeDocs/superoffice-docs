
public static class AddressFieldExtensions
{
  /// <summary>
  /// Get a PersonEntity.Address as a Dictionary&lt;string, string&gt;.
  /// </summary>
  /// <param name="personEntity">The person entity.</param>
  /// <returns>Key/Value pair of address fields.</returns>
  public static Dictionary<string, string> GetAddress(this PersonEntity personEntity)
  {
      return new AddressHelper().GetAddressAsDictionary(personEntity.Address);
  }

  /// <summary>
  /// Get a ContactEntity.Address as a Dictionary&lt;string, string&gt;.
  /// </summary>
  /// <param name="contactEntity">The contact entity.</param>
  /// <returns>Key/Value pair of address field name and values.</returns>
  public static Dictionary<string, string> GetAddress(this ContactEntity contactEntity)
  {
      return new AddressHelper().GetAddressAsDictionary(contactEntity.Address);
  }

  /// <summary>
  /// Populates the PersonEntity.Address property from a Dictionary&lt;string, string&gt; of key valuepairs.
  /// </summary>
  /// <param name="personEntity">The PersonEntity</param>
  /// <param name="addressInformation">Key/Value pairs that represent address field name andvalues.</param>
  public static void SetAddress(this PersonEntity personEntity, Dictionary<string, string>addressInformation)
  {
      var helper = new AddressHelper();
      helper.SetAddressFromDictionary(personEntity.Address, addressInformation);
  }

  /// <summary>
  /// Populates the ContactEntity.Address property from a Dictionary&lt;string, string&gt; of key valuepairs.
  /// </summary>
  /// <param name="contactEntity">The ContactEntity</param>
  /// <param name="addressInformation">Key/Value pairs that represent address field name andvalues.</param>
  public static void SetAddress(this ContactEntity contactEntity, Dictionary<string, string>addressInformation)
  {
      var helper = new AddressHelper();
      helper.SetAddressFromDictionary(contactEntity.Address, addressInformation);
  }
}