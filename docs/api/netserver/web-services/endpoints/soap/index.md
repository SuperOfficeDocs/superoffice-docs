---
title: SOAP
uid: soap
description: SuperOffice SOAP API endpoints
author: Bergfrid Dias
so.date: 12.02.2021
keywords: API, web services, endpoints, SOAP, Agents, Services88
so.topic: concept
---

# SOAP API

SOAP is a simple XML-based protocol used to let applications exchange information over HTTP. In SuperOffice we can access the web services using WCF/SOAP requests and responses.

## Available endpoints

* [Services88][1]
* [Services87][2]
* [Services86][3]
* [Services85][4]
* [Services84][5]

> [!NOTE]
> The above endpoints are not the same as the legacy [SOAP interface of SuperOffice Service][6] (customer, admin, and ticket port).

## Calling

The raw SOAP looks something like this:

[!code-xml[XML](../../../../authentication/onsite/sosession/includes/soap-env.xml)]

The following example shows how to retrieve a `ContactEntity` using the `ContactAgent`.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiate agent
  using(ContactAgent myContactAgent = new ContactAgent())
  {
    //Retrieve a ContactEntity carrier
    ContactEntity myContactEntity = myContactAgent.GetContactEntity(5);

    //Retrieve values of the carrier properties
    string conName = myContactEntity.Name;
    string conDept = myContactEntity.Department;
  }
}
```

> [!NOTE]
> The `ContactAgent` class provides methods such as `GetAddress`, `GetAddressByCountry`, `GetContact`, `DeleteContactEntity`, and many more.

---

[Read more about SOAP proxies.][7]

<!-- Referenced links -->
[1]: ../../../../api-reference/soap/Services88/index.md
[2]: ../../../../api-reference/soap/Services87/index.md
[3]: ../../../../api-reference/soap/Services86/index.md
[4]: ../../../../api-reference/soap/Services85/index.md
[5]: ../../../../api-reference/soap/Services84/index.md
[6]: ../../../../service-soap/overview.md
[7]: ../../proxies/index.md

<!-- Referenced images -->
