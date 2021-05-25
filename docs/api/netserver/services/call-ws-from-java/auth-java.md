---
title: Connect to the web service using the Java secret
uid: auth_ws_java
description: Authenticate web service using Java
author: {github-id}
so.date:
keywords:
so-topic: howto
---

# Connect to the web service using the Java secret

After [creating the secret][2], we need to set the credential to connect to the web service client.

```java
  SoCredentialsHeader newCredHead = new SoCredentialsHeader();
  newCredHead.setUserId("SAL0");

  newCredHead.setAuthenticationType(SoAuthenticationType.fromValue( "CRM5"));
  String authType = newCredHead.getAuthenticationType().toString();
  String userName = newCredHead.getUserId();
  String userPass = "";
  String soSecret = getSecret(authType, userName, userPass);
  newCredHead.setSecret(soSecret);
```

**Next:** [Use the connection to get an entity][1]

<!-- Referenced links -->
[1]: get-entity.md
[2]: auth-java.md
