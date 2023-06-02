---
uid: ticketagent-clearnotify
title: Hendelsesmetoden TicketAgent.ClearNotify
description: Skripthendelser kalt på ClearNotify-metoden på TicketAgentens-serviceagenten.
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

Skripthendelser kalt på metoden <see cref='M:SuperOffice.CRM.Services.ITicketAgent.ClearNotify'>ClearNotify</see> på serviceagenten <see cref='ITicketAgent'>ITicketAgent</see>.

## BeforeClearNotify
```cs
    static void BeforeClearNotify(
       Int32[]  ids,
       ref object  eventState
      );
```
Kjøres før servicemetoden startes.
Den kan lagre en tilstand i parameteren *eventState* som overføres til metodene **After** og **AfterAsync** i dette servicekallet.
Hendelsestilstanden beholdes ikke mellom ulike servicekall. Den settes til null ved starten av hvert servicekall.
## AfterClearNotify
```cs
    static void AfterClearNotify(
       Int32[]  ids,
       ref object  eventState
      );
```
Kjøres etter at servicemetoden er startet. Tjenesten venter på at denne metoden skal fullføres før resultatet returneres til kalleren.
Dette servicekallet har ingen returverdi, så det finnes ikke en **returnValue**-parameter.
Alle tilstander du angir i metoden **Before**, overføres til parameteren *eventState*.
## AfterClearNotifyAsync
```cs
    static void AfterClearNotifyAsync(
       Int32[]  ids,
       ref object  eventState
      );
```
Kjøres etter at servicemetoden er startet, uten å vente på at kallet skal komme tilbake.
Servicekallet er ikke blokkert mens du venter på at denne metoden skal fullføres.
Alle tilstander du angir i metoden **Before**, overføres til parameteren *eventState*.

