---
title: call_tooltip_service       
description: Calling the ToolTip Service
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto
---

# How to call the ToolTip service

The examples below show how we can retrieve the tooltips for different business objects in SuperOffice.

## Example 1

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //create a tooltip agent
  using(TooltipsAgent toolTipAgent = new TooltipsAgent())
  {
    //using the GetTooltip  method the tooltip agent retrieve the
    //tooltip for contact ID 5
    string ContactToolTip = toolTipAgent.GetTooltip("{contact_id=5}");

    //show the output
    Console.WriteLine(ContactToolTip);
  }
}
```

**Output:**

```text
{contact_id=5}
Bjørge AS, BAvdeling
B-gaten 45
04
Kunde
Admin Adminson
```

Here we can see that we have used the `GetToolTip` method of the tooltip agent to retrieve the tooltip we want, for contact in this case.

The next examples use the same method to retrieve the tooltip. They will also show what should be the parameter for the `GetToolTip` method.

## Example 2

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //create a tooltip agent
  using(TooltipsAgent toolTipAgent = new TooltipsAgent())
  {
    //using the GetTooltip  method the tooltip agent retrieve the
    //tooltip for contact ID 5

    string personToolTip = toolTipAgent.GetTooltip("{person_id=9}");
    //show the output
    Console.WriteLine(personToolTip);
  }
}
```

**Output:**

```text
{person_id=9}
Admin Adminson
(ADMIN - Administrasjon)
StateZeroDatabase
Norway
qa.testbruker@superoffice.com
```

> [!NOTE]
> The tooltip service returns language-independent strings. The `SuperOffice.CRM.Web.UI.ToolTipHelper` class turns the tooltip string into HTML.

## Example 3

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //create a tooltip agent
  using(TooltipsAgent toolTipAgent = new TooltipsAgent())
  {
    //using the GetTooltip  method the tooltip agent retrieve the
    //tooltip for contact ID 5
    string appointmentTooltip =
    toolTipAgent.GetTooltip("{appointment_id=59}");

    //show the output
    Console.WriteLine(appointmentTooltip);
  }
}
```

**Output:**

```text
{appointment_id=59}
Yngve Yssen (Yngve'S Fisk & Vilt, YAvdeling)
Prösjöökt
Telefon ut
[SR_DONE]: [DT:08/07/2002 14:39:56.0000000]
BTelefon utBBB
([DT:03/31/2002 18:00:00.0000000] - [DT:03/31/2002 18:15:00.0000000])
Brede Bredesen  [DT:08/07/2002 12:39:47.0000000], Brede Bredesen [DT:08/07/2002 12:39:56.0000000]
```

> [!NOTE]
> The parameter of the `GetTooltip` method must be specified using the following syntax ("{person_id=10}").

The key part of the parameter should be the primary key of the database table concerning the SuperOffice business object. The key is used to find the appropriate tooltip plugins on the server to provide the actual tooltip result. If you want to provide your own tooltips on your tables, then you need to use your own tooltip key and ID. You will also need to [create your own tooltip provider plugin][1]. For example, for contacts, it should be the primary key of the `contact` table in the SuperOffice database.

<!-- Referenced links -->
[1]: create-tooltip-plugin.md
