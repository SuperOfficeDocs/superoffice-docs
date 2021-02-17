---
# Mandatory fields.
title: config_external_user       # (Required) Very important for SEO.
description: How to configure the external users in the config file # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to configure the external users in the config file

In the application config file, we can allow [external users][2] as shown below. When we authenticate a user as an external user, login fails if the config file says "ExternalPersonAllow = False".

```XML
<Explicit>
  <add key="ExternalPersonAllowed" value="True"/>
  <add key="EmployeeAllowed" value="True"/>
  <add key="SystemAllowed" value="True"  />
  <add key="DBUser" value="crm5"/>
  <add key="DBPassword" value="crm5myd"/>
  <add key="CommonDBConnection" value="True"/>
</Explicit>
```

Like with [anonymous users][1], we can also set data rights to the external user through SOAdmin. External users can access different data objects (like Company, Contact, Project) owned by different users like this particular external user, other associates, other external users, and so on.

Before running the following example, the SOAdmin had created an external user with username *EXTERNAL1@SUPEROFFICE.COM*. This user is allowed to read data belonging to the contact data object that this external person is registered on.

The following example demonstrates how to log in as an external user and call the `contact` [service agent][3].

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

//Authenticate as an External User
using (SoSession newSession = SoSession.Authenticate("EXTERNAL1@SUPEROFFICE.COM", ""))
{
  //Create a contact agent.
  using(ContactAgent agent = new ContactAgent())
  {
    //Retrieve a Contact belonging to this External user itself.
    ContactEntity myContact = agent.GetContactEntity(newSession.Principal.ContactId);
    string name = myContact.Name;
  }
}
```

Here we have logged in with an external user ID.

> [!NOTE]
> There is no difference between logging in as an external user and logging in as an internal user.

When retrieving a contact, we have passed the contact ID of this particular user. If we try to retrieve data belonging to anyone other than this user, an exception will be thrown unless it is allowed by the SOAdmin.

<!-- Referenced links -->
[1]: config-anonymous-user.md
[2]: anonymous-vs-external-user.md
[3]: ../services/agents/index.md
