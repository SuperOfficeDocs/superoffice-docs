---
uid: ticketagent-clearnotify
title: TicketAgent.ClearNotify event method
description: Skripthändelser som anropas av ClearNotify-metoden för serviceagenten TicketAgent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.01.2023
so.topic: reference
so.envir:
  - "onsite"
---
# TicketAgent.ClearNotify

Skripthändelser som anropas av <see cref='M:SuperOffice.CRM.Services.ITicketAgent.ClearNotify'>ClearNotify</see>-metoden för serviceagenten <see cref='ITicketAgent'>ITicketAgent</see>.

## BeforeClearNotify

```cs
    static void BeforeClearNotify(
       Int32[]  ids,
       ref object  eventState
      );
```

Körs innan servicemetoden anropas.
Vissa statusar kan sparas i parametern *eventState*, som skickas till metoderna **After** och **AfterAsync** i det här serviceanropet.
Händelsestatusen sparas inte mellan olika serviceanrop. Den nollställs vid starten av varje serviceanrop.

## AfterClearNotify

```cs
    static void AfterClearNotify(
       Int32[]  ids,
       ref object  eventState
      );
```

Körs efter att servicemetoden har anropats. Systemet väntar tills den här metoden har slutförts innan resultatet returneras till anroparen.
Det här serviceanropet har inget returvärde och därför finns ingen **returnValue**-parameter
Alla statusar som du anger i metoden **Before** kommer in via parametern *eventState*.

## AfterClearNotifyAsync

```cs
    static void AfterClearNotifyAsync(
       Int32[]  ids,
       ref object  eventState
      );
```

Körs efter att servicemetoden har anropats, utan att invänta svarsanropet.
Serviceanropet spärras inte i väntan på att metoden ska slutföras.
Alla statusar som du anger i metoden **Before** kommer in via parametern *eventState*.
