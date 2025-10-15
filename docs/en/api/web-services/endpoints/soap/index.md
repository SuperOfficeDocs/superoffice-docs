---
title: SOAP
uid: soap
description: SuperOffice SOAP API endpoints
author: Bergfrid Dias
date: 12.02.2021
keywords: API, web services, endpoints, SOAP, Agents, Services88
content_type: concept
redirect_from: /en/api/netserver/web-services/endpoints/soap/index
---

# SOAP API

Simple Object Access Protocol (SOAP) is a simple XML-based messaging protocol used to let applications exchange information over HTTP. In SuperOffice we can access the web services using WCF-based SOAP requests and responses.

Earlier versions of NetServer (ca. 7.0) used versioning to ensure that an applications targeting a specific API version would continue to work without issue til the end of time.

As newer versions came out, each one needed a complete set of mapping strategies for older versions. It just became a lot of technical debt. Around 2020 SuperOffice decided to discard all versions older than Services84, with the introduction access token support.

NetServer service API's only add functionality, so anyone transitioning from older versions would have minimal changes, depending on their choice of tooling, code generation and proxies.

Today we support the following versioned services:

* [Services88][1]
* [Services87][2]
* [Services86][3]
* [Services85][4]
* [Services84][5]

> [!NOTE]
> The above services do not contain [SuperOffice Customer Service SOAP APIs][6] (customer, admin, and ticket).
>
> Those services are part of the Customer Service FastCGI modules and not part of NetServer web services. NetServer web services includes most of the same functionality, and will continue to evolve for 100% coverage.

WSDL files for all versioned endpoints are [available for download][8] in the reference section, or as individual files on each endpoint reference page. Alternatively, you can use the [SuperOffice.NetServer.Services][9] nuget package.

**Download All:**

![Download all WSDLs][wsdl-all]

**Download Single:**

![Download all WSDLs][wsdl-single]

## SOAP web service architecture

NetServer SOAP web services are built using Microsoft Windows Communication Foundation (WCF), and implement the Service Agent pattern.

![Service Agent pattern][service-agent]

Each agent represents one area, or entity, of SuperOffice. For example, to manage Appointments use service agent Appointment.svc. The .svc extension is specific to WCF hosted services.

The complete URL, assuming the target version is services88, is:

```http
http://www.your-superoffice.com/remote/services88/appointment.svc
```

In SuperOffice Online, that would be:

```http
http://{env}.superoffice.com/Cust12345/remote/services88/appointment.svc
```

## Service agent and carrier pattern

All services are called through an agent that is designed to handle a specific **business area**.

An **agent** has a set of methods, typically for inserting, retrieving, updating, and deleting data. Each method on the agent corresponds to one HTTP request.

Depending on your development platform of choice, the following code snippets represent the interactions using SuperOffice NetServer .NET proxy. This may or not be similar to a proxy generated using Java toolkit or PHP, but is close enough to convey the concepts.

The following code segment shows how to create an `AppointmentAgent`. Once the agent has been created, we can use it to access the different methods exposed by the agent.

```csharp
AppointmentAgent newConAgt = new AppointmentAgent();
```

The Appointment.svc endpoint, for example, has a list of methods that facilitate data transfer of Data Transfer Objects (DTOs). SuperOffice calls DTOs `Carriers`.

A **Carrier** is the data structure that represents data sent between the client [proxy] and Agent services. In an attempt to reduce the amount of XML send on the network, there are two kinds of carriers: lightweight carriers and entity carriers. The primary difference is that lightweight carriers are read-only, and only entity carriers are used to create or update entities in the database.

### Read-only carriers

The read-only carrier is a **lightweight** DTO. It exposes its properties primarily as string values, or integer ID values correlating to the ID field in the corresponding table.

The advantage of a lightweight carrier is its **simplicity**, avoiding the overhead that comes with larger, more complex, entities classes.

Below is an example that shows how to load a read-only carrier using an Agent.

```csharp
using SuperOffice.CRM.Services;

ContactAgent contactAgent = new ContactAgent();
Contact myContact = contactAgent.GetContact(4);

string myContactName = myContact.Name;
string myContactCategory = myContact.CategoryName;
string myContactWebUrl = myContact.URL;
```

Here, the `ContactAgent` will return a `Contact` instance through the `GetContact` method, then read a few of it's properties.

ContactAgent does not have a `SaveContact(Contact)` method, and therefore no changes to this DTO can be persisted - is it read-only.

### Entity carriers

An entity carrier, unlike read-only carriers, expose their properties as more **complex structures**. For example, the `PersonEntity.Contact` contains all relational information about the corresponding contact - including name, address, contact ID, phone collection, and more.

The example below demonstrates how to retrieve a `ContactEntity` instance using the `ContactAgent.GetContactEntity` method.

```csharp
using SuperOffice.CRM.Services;

ContactAgent contactAgent = new ContactAgent();
ContactEntity myContact = contactAgent.GetContactEntity(4);

string myContactName = myContact.Name;
string myContactCategory = myContact.Category.Value;
string myContactWebUrl = myContact.Urls.Length > 0 ? myContact.Urls[0].Value : "";
```

To summarize: an agent represents the service and the carrier represent the data passed between the client and the service. Agents are used to execute actions by calling methods.

Entity carriers resemble [NetServer Core Entities][1]. In contrast, lightweight carriers are more similar to [NetServer Core Rows][10].

## Example requests

### Example SOAP request

This example demonstrates how to get a sent a GetContact request to the ContactAgent service.

[!code-xml[XML](../../../authentication/onsite/sosession/includes/soap-env.xml)]

### Example `ContactAgent.ContactEntity`

This example demonstrates how to get a `ContactEntity` using the `ContactAgent`, using the .NET [SuperOffice.NetServer.Services][9] nuget package.

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

[Read about SOAP proxy.][7]

> [!WARNING]
> SuperOffice SOAP web services are not at the center of the API focal point any longer. Instead, focus has shifted towards REST web services. Therefore, it's recommended that all who wish to continue using Service Agent pattern switch to using the SuperOffice.WebApi library. It has the exact same Agent/Carrier/Methods, but uses the [Agent REST API][11].

<!-- Referenced links -->
[1]: ../../../entities/index.md
[2]: ../../../reference/soap/Services87/index.md
[3]: ../../../reference/soap/Services86/index.md
[4]: ../../../reference/soap/Services85/index.md
[5]: ../../../reference/soap/Services84/index.md
[6]: ../../../reference/soap/customer-service/index.md
[7]: ../../proxies/index.md#soap-client-proxy
[8]: ../../../reference/soap/index.md
[9]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
[10]: ../../../rows/index.md
[11]: ../rest-webapi/index.md

<!-- Referenced images -->
[service-agent]: ../../media/netserver-servce-agent.png
[wsdl-all]: ../../media/download-all-wsdls.png
[wsdl-single]: ../../media/download-all-wsdls.png
