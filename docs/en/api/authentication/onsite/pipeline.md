---
title: Authentication pipeline
uid: auth_pipeline
description: Authentication pipeline
author: SuperOffice Product and Engineering
date: 05.08.2018
keywords: security, identity, authentication, plugin
content_type: concept
deployment: onsite
redirect_from: /en/authentication/onsite/pipeline
---

# Authentication pipeline

NetServer contains several authentication plug-ins, for as many different ways of authenticating:

* SoCredentials (ticket string)
* Username+password (SuperOffice user, not Active Directory)
* Windows/AD user, who is a person (not System, Guest, and so on)
* Impersonation identity
* Username+password, matched against Windows/AD
* Windows/AD user, who is not a person

The plugins are called in this order, and each is given all the available evidence (credentials) at the time of invocation. The order is decided by the priority attribute value on the plugin, and the loop breaks on the first one to say "I know who this is!".

## Plug-ins

Authentication plugins are useful in many scenarios. For a web server, the IP address the request is coming from is a piece of evidence that can be taken into account. If a certain IP range is prohibited, then the check can refuse login right there. Or time of day... or whatever. You can write all sorts of funny rules into your plugins. Overdoing it is easy and leads to major frustration if your policies are too draconian.

To summarize:

1. Each plugin is given all the available evidence (credentials)

2. Each plugin can block login simply based on the credential type (you could, for instance, forbid login by certain means).

3. Each plugin looks for credentials it understands.

4. Such credentials are evaluated, for instance, a password is checked against stored information

5. Success results in an associate ID

6. Each plugin is finally given the opportunity to block login – we want to make it relatively easy to terminate access rights

> [!NOTE]
> So-called time-wise **expensive** plugins should come late in the order!

The full potential of this system is not yet leveraged. The grey parts are present in the code, but not currently leveraged; i.e., we’re not actively using them in the standard plugins in 7.0.

## Source code

This is the actual source code (stripped of comments to make it fit) of the authentication pipeline in NetServer. Included here so you can see what actually happens during authentication. A block of code equals any number of hand-waving words.

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

## Post validator

Each plugin can have a post-validator. The post-validators are **called after a plugin resolves an identity** and can block login if specific conditions are not met. This can be used to block based on any available knowledge.

The post-validator is interesting, for instance, where a company decided to have a policy stating that certain users are only allowed to log on during normal working hours. The plugin would then take the resolved identity, look at the clock and then return whether the user can sign in or not.

<!-- Referenced links -->
