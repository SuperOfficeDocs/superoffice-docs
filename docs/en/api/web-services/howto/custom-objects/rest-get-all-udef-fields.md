---
uid: ws-get-all-udef-fields
title: How to get all user-defined fields
description: Describes how to get all user-defined fields using web services
keywords: get user-defined field, custom field, udef
author: AnthonyYates
date: 03.11.2022
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/custom-objects/udef/howto/services/rest-get-all-udef-fields
  - /en/api/netserver/web-services/howto/custom-objects/rest-get-all-udef-fields
---

# How to get all user-defined fields using the web services API

This guide describes how to get all user-defined fields using the web services API.

## Steps

[!include[ALT](includes/how-to-guide-steps-intro.md)]

<!-- markdownlint-disable MD051 -->
### [RESTful REST API](#tab/get-all-rest)

The following examples demonstrate how to get all user-defined fields for a company, using the api/v1/Contact/UdefLayout endpoint.
To get the all user-defined fields for a different entity, use the `api/v1/{entity}/UdefLayout` entity endpoint,
i.e. `api/v1/Person/UdefLayout`, `api/v1/Project/UdefLayout` etc.

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
```

### [HTTP RPC Agent API](#tab/get-all-agent)

The following examples demonstrate how to get all user-defined fields for a company, using the `OwnerType` parameter.
To get the all user-defined fields for a different entity, use the appropriate [OwnerType][1] value.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/GetPublishedUserDefinedFieldList
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json; charset=utf-8

{
  "OwnerType": "Contact"
}
```

### [SuperOffice.WebApi](#tab/get-all-webapi)

The following examples demonstrate how to get all user-defined fields for a company, using the `OwnerType` parameter.
To get the all user-defined fields for a different entity, use the appropriate [OwnerType][1] value.

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken("8A:Cust12345.Example-Token", OnlineEnvironment.SOD);

var udefAgent = new UserDefinedFieldInfoAgent(config);
return await udefAgent.GetPublishedUserDefinedFieldListAsync(UDefType.Contact);
```

***
<!-- markdownlint-restore -->

<!-- Linked References -->
[1]: xref:SuperOffice.WebApi.Data.UDefType
