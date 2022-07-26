---
title: How to get all user-defined fields
uid: ws-get-all-udef-fields
description: Describes how to get all user-defined fields using web services
author: AnthonyYates
so.date: 03.11.2022
keywords: get user-defined field, custom field, udef
so.topic: how-to-guide
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

### [RESTful Agent API](#tab/get-all-agent)

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

<!-- 
How to write good how-to guides 

- Provide a series of steps​
- Focus on results​
- Solve a problem​
- Don’t explain concepts, link to them​
- Allow for some flexibility, point out more ways to do same thing​
- Leave things out – start and end where it seems appropriate​
- Bloated how-to guides don’t help the reader get speedy solution​
- Name them well
-->

<!-- Link references -->

[1]: xref:SuperOffice.WebApi.Data.UDefType
