---
uid: crmscript_netserver
title: NetServer agents and carriers
author:
so.date:
keywords:
so.topic:
---

# NetServer agents and carriers

**NetServer** is a layered library that enables developers to work with the SuperOffice database without having to know the details of how data is stored. Think of it as a set of high-level APIs where all the hard work of language decoding, security checks, database selects, and joining tables are handled for you.

By *work with* we mean CRUD operations: create, read, update, and delete. A **service** is primarily a method exposed by the NetServer to handle the data in the SuperOffice database or enhance the presentation of said data. A single service call will represent many database queries and contain business logic, user-preference checking, and default handling.

> [!TIP]
> In CRMScript, all NetServer classes are prefixed NS and their methods typically follow Pascal-case naming conventions.

## Authentication

When using NetServer, the SCMScript runs as the **currently signed in user**.

For background tasks such as email import, scheduled tasks and data exchange (DBI), the script runs as a **system user**. 

> [!NOTE]
> Sentry will apply to your CRMScripts.

## Agent and carrier software pattern

The agent and carrier pattern separates data from actions:

* Agents govern actions
* Carriers are containers of content (data)

All NetServer services are called through an agent. To get your hands on data, you must go through the appropriate agent.

A few services are not reachable through CRMScript. These exceptions are:

* AudienceAgent
* EmailAgent
* FileManagerAgent
* TrayAppAgent

## Agents

Agents are designed to handle a specific business area, for example, sale.

* An agent represents a set of related service calls
* Each method on the agent corresponds to 1 service call

Here's how it works:

1. Create a new agent.
2. Use the agent to access 1 (or more) of the CRUD methods exposed by it.
3. Set or get data.
4. Save (if applicable).

**Typical methods:**

* `CreateDefaultEntity()`
* `GetEntity(id)`
* `SaveEntity()`
* `DeleteEntity()`

> [!TIP]
> The corresponding CRMScript class is labeled `NS[Businessarea]Agent`. For example, NSPersonAgent, NSContactAgent, and NSAppointmentAgent.

### Declaration

CRMScript treats an agent as any other object, except agents don't have a **state**. Thus, you need to declare each agent only once.

## Carriers

Carriers represent the data passed back and forth to the server by the agent. There are 2 types of carriers:

* Simple read-only carriers
* Complex entity carriers

> [!TIP]
> To tell them apart, look for the word *Entity* at the end of the CRMScript class name.

### Read-only carriers (item carriers)

The simple carriers expose the properties of their content primarily as simple **string values**. In many situations, this simplicity is all you need and gives you the advantage of avoiding overhead. However, they **can't be saved back** to the database!

```crmscript!
NSPersonAgent personAgent;
NSPerson p = personAgent.GetPerson(5);
printLine(p.GetFullName());
```

> [!NOTE]
> Whenever you want to add to or change the database, you must use an entity carrier.

### Entity carriers

The complex carriers expose the properties of their content as **objects**, which are populated with more detailed data. They **can be updated and stored back** to the database.

```crmscript!
NSPersonAgent personAgent;
NSAssociateAgent associateAgent;

NSPersonEntity p = personAgent.GetPersonEntity(5);
printLine("Original name: " + p.GetFullName());

p.SetMiddleName("de");
personAgent.SavePersonEntity(p);

printLine("Updated name: " + personAgent.GetPerson(5).GetFullName());
```

> [!TIP]
> Remember to call `save()` to push the changes back to the database!

### Declaration

**Declared carrier objects are NOT initialized!**
This is especially important for objects that use enumerations, because those objects will contain illegal values. If you try to access them, NetServer will throw an exception.

> [!TIP]
> To create a new "blank" entity, use the `CreateDefaultEntity()` method. Then set at least enums.

Use Get and Set to access attributes of entities.

* Get methods return another carrier or a [basic type][1]
* Set methods take a carrier or basic type as argument

<!-- Referenced links -->
[1]: ../fundamentals/index.md
