---
title: agent
description: Agent
author: {github-id}
keywords:
so.topic: concept
---

# NetServer Service Agent

An agent is a class that exposes a set of methods. Each method on the agent corresponds to one service call.

```csharp
IContactAgent newConAgt = new ContactAgent();
```

The code segment above shows how we create a `ContactAgent`. The agent is the class factory that loads the local or remote agent based on the config file settings used when communicating remote using SOAP WebServices.

Once the agent has been created, we may use it to access the different methods exposed by the agent. These methods would vary according to the agent created.

The following example shows how we may retrieve a `ContactEntity` using the `IContactAgent`.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Retrieving a Contact Entity from a service agent
  //Instantiating a Contact Agent
  using(ContactAgent newConAgt = new ContactAgent())
  { 
    //Retrieving a Contact Entity carrier from a service call
    ContactEntity newConEnt = newConAgt.GetContactEntity(5);

    //Retrieving values of the carrier properties
    string conName = newConEnt.Name;
    string conDept = newConEnt.Department;
  }
}
```

In the example above, we have created an instance of the `IContactAgent` with use of the `GetContactAgent` method exposed by the `AgentFactory` class. Next, we use the created implementation of the `IContactAgent` to retrieve the `ContactEntity` as shown below.

```csharp
ContactEntity newConEnt = newConAgt.GetContactEntity(5);
```

> [!NOTE]
> The `IContactAgent` class provides methods such as `GetAddress`, `GetAddressByCountry`, `GetContact`, `DeleteContactEntity`, and many more, which can be used in a manner similar to the above.

## Agent pattern

SuperOffice has created a set of objects based on the **Agent pattern** that will perform your work for you. A typical agent on the NetServer will have all useful service methods that are capable of inserting, retrieving, updating, and deleting data.

An agent represents a set of related services. Each method on an Agent object is a service call. If your services are configured to use SOAP, then each method call is a SOAP call that will travel over the network. An agent consumes and returns carrier objects.

The goal of the agent pattern is to make it clear when you are making potentially expensive service calls.

The Agent factory returns implementation objects that talk directly to the database or to return proxy objects that talk to the back-end via SOAP. The advantage of this is that it gives flexibility since you can run everything on one box or two separate boxes without changing the program. Only the config file needs to be changed.

The following section of the config file shows where the web services are turned on:

```XML
<Services>
  <!-- Mode can be Local, Remote, Switch -->
  <add key="DefaultMode" value="Local" />

  <!-- Default mode for the switch.  Can be Local or Remote -->
  <add key="SwitchDefault"  value="Remote" />

  <!-- Timeout before failover in seconds -->
  <add key="SwitchFailover" value="60" />

  <!-- Base URL for remote services -->
  <add key="RemoteBaseURL" value="http://localhost/Webs/SuperOffice.Services.Stub" />

  <!-- URL to the Data Set Definition file -->
  <add key="DataSetDefinitionURL" value="http://localhost/Webs/SuperOffice.Services.Stub/dsd.xml" />
</Services>
```

Through a given agent you can manipulate a carrier.

> [!NOTE]
> A carrier is an object that carries data between the Agent and the NetServer services. The 2 kinds of carriers that are available through NetServer include [simple read-only carriers][1] and [complex entity carriers][1]. The main difference between these 2 types of carriers is that entity carriers can be updated and sent back for saving to the database while read-only carriers cannot be saved back to the database.

* [List of NetServer agents][2]

<!-- Referenced links -->
[1]: ../carriers/index.md
[2]: ../../../api-reference/netserver/services/SuperOffice.CRM.Services.yml
