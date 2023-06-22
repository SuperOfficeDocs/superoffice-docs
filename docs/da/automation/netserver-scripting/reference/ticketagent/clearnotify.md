---
uid: ticketagent-clearnotify
title: TicketAgent.ClearNotify-hændelsesmetode
description: Scriptinghændelser kaldte ClearNotify-metoden på TicketAgent-serviceagenten.
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

Scriptinghændelser kaldte <see cref='M:SuperOffice.CRM.Services.ITicketAgent.ClearNotify'>ClearNotify</see>-metoden på TicketAgent</see>-serviceagenten.

## BeforeClearNotify

```cs
    static void BeforeClearNotify(
       Int32[]  ids,
       ref object  eventState
      );
```

Udføres, før servicemetoden aktiveres.
Den kan gemme en tilstand i parameteren *eventState* der overføres til metoderne **Efter** og **AfterAsync** i dette servicekald.
Hændelsestilstanden bevares ikke mellem forskellige servicekald. Den er indstillet til nul i starten af hvert servicekald.

## AfterClearNotify

```cs
    static void AfterClearNotify(
       Int32[]  ids,
       ref object  eventState
      );
```

Udføres, når servicemetoden er aktiveret. Tjenesten venter på, at denne metode fuldføres, før resultatet returneres til den, der ringer op.
Dette servicekald har ingen returværdi, så der er ingen **returnValue-**parameter
Alle tilstande, du angiver i metoden **Før**, overføres via parameteren *eventState* .

## AfterClearNotifyAsync

```cs
    static void AfterClearNotifyAsync(
       Int32[]  ids,
       ref object  eventState
      );
```

Udføres, når servicemetoden er aktiveret, uden at vente på, at opkaldet vender tilbage.
Serviceopkaldet blokeres ikke, mens du venter på, at denne metode fuldføres.
Alle tilstande, du angiver i metoden **Før**, overføres via parameteren *eventState* .
