---
# Mandatory fields.
title: basic_scripting       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Basic NetServer scripting # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 04.15.2009
keywords:
so.topic: concept             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Basic NetServer scripting

## Events

There are Before, After, and AfterAsync events for each method on each web service agent. These are void methods, Sub-routines in Visual Basic.NET, where there is no return value. The naming standard of every available scripting event is the exact same as the web service method, prefixed with the `Before` or `After` keyword. Asynchronous scripting events are always prefixed with "After" and have an "Async" suffix.

### \[Before|After\]ServiceMethod\[Async\]

The `Before` method has the same parameters as the agent method.

The `After` method has the same parameters as the agent method + the return value at the end of the param list.

The `AfterAsync` method has the same parameters as the agent method plus the return value at the end of the parameter list, however, changes done to the return value parameter are not passed on.

### Scripting Method Prototypes

* public static void BeforeGetContactEntity(int contactid, ref object State)
* public static void AfterGetContactEntity(int contactid, ref ContactEntity entity, ref object State)
* public static void AfterGetContactEntityAsync(int contactid, ref ContactEntity entity, ref object State)

* public static void BeforeSaveContactEntity(ContactEntity entity, ref object State)
* public static void AfterSaveContactEntity(ContactEntity entity, ref ContactEntity returnedEntity, ref object State)
* public static void AfterSaveContactEntityAsync(ContactEntity entity, ref ContactEntity returnedEntity, ref object State)

* public static void BeforeGetDuplicates(string name, ref object State)
* public static void AfterGetDuplicates(string name, ref DuplicateEntry\[\] result, ref object State)
* public static void AfterGetDuplicatesAsync(string name, ref DuplicateEntry\[\] result, ref object State)

## Script APIs

All scripts inherit the current NetServer session that initiated the call. This is an important point because scripts do not need to do any additional authentication. The scripts execute within the same context as the application and are free to use all of NetServer, or any other objects they can create – to do their work. The only restriction is that the scripts can not display any user interface - since these scripts run on the application server.

The script event handlers are raised on the application server, meaning inside the services layer that the web client uses to get all SuperOffice data. Therefore, you have complete access to the NetServer core's lower layer APIs, and you want to use the fastest code possible to conduct your business logic.  

Use NetServer core APIs for data access, not the web service Agent APIs. Use Entities, Rows, and OSQL for your business logic, and this will avoid any re-entrance issues you might have by raising other events that may have event handlers as well.

**Example AfterGetContactEntity single function script:**

```csharp
public static void AfterGetContactEntity(int contactId, ref ContactEntity contact, ref object state)
{
  //Write entities, row(s) or OSQL code
  //Lookup the fetched contact for business logic routines...
  SuperOffice.CRM.Entities.Contact contact = SuperOffice.CRM.Entities.Contact.GetFromIdxContactId(contactId);

  //But make updates to the ContactEntity that will be returned to the web client
  //and let the user decide if any changes should be saved where it's appropriate.
  contact.Name += "(added by script)";
  contact.Department += "(ScriptDemo)";
}
```

## Script Error Logging, Tracing

Script compilation and runtime errors are logged using normal NetServer logging features. The script itself may contain an OnError( errorDetails ) event handler that can report errors to the script author.

```csharp
public static void OnError(string message)
{
  ...
}
```

## Register scripts

To enable your scripts, simply drop the script files (or assemblies) into the folder specified in the Scripting section of the configuration file. Remember to flush to get SuperOffice web aware of the new *scripts.dll*.
