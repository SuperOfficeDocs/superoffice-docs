---
title: netserver-authentication-plugins
description: Authentication plug-ins
author: {github-id}
so.date: 05.29.2018
keywords: 
so.topic: concept
---

# Authentication plug-ins

This is the actual source code (stripped of comments to make it fit) of the [authentication pipeline][1] in NetServer. Included here so you can see what actually happens during authentication. A block of code equals any number of hand-waving words.

```csharp
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
```

<!-- Referenced links -->
[1]: pipeline.md
