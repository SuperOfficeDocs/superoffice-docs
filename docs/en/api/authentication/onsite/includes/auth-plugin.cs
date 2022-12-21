List<SecurityToken> tokenList = new List<SecurityToken>(Tokens);
ISoSecurityTokenValidator[] preValidators = PluginFactory.Create<ISoSecurityTokenValidator>();

string reason = null;

foreach (ISoSecurityTokenValidator validator in preValidators)
{
  if (validator.TryValidateTokens(tokenList, out reason) == TokenValidationResult.Rejected)
    throw new SoSessionException("Failed to validate tokens: " + reason);
}

ISoIdentityResolver[] resolvers = PluginFactory.Create<ISoIdentityResolver>();
ISoIdentityValidator[] postValidators = PluginFactory.Create<ISoIdentityValidator>();

List<string> reasons = new List<string>();

foreach (ISoIdentityResolver resolver in resolvers)
{
  ISoIdentity identity = resolver.ResolveIdentity(tokenList, dbConnection);

  if (identity != null)
  {
    bool isValid = false;
    bool isRejected = false;

    foreach (ISoIdentityValidator validator in postValidators)
    {
      //string reason = null;
      switch(validator.TryValidateIdentity(tokenList, identity, dbConnection, out reason))
      {
        case TokenValidationResult.Valid:
          isValid = true;
          break;
        case TokenValidationResult.Rejected:
          isRejected = true;
          reasons.Add(reason);
          continue;
      }
    }
    if (isRejected)
      continue;
    if (isValid)
      return identity;
    }
  }
}