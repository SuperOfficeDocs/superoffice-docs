---
uid: ticketagent-clearnotify
title: TicketAgent.ClearNotify-Ereignismethode
description: "Skripting-Ereignisse, die für die ClearNotify-Methode auf dem TicketAgent-Service-Mitarbeiter aufgerufen werden."
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

Skriptereignisse, die für die <see cref='M:SuperOffice.CRM.Services.ITicketAgent.ClearNotify'>ClearNotify-Methode</see> auf dem <see cref='ITicketAgent'>ITicketAgent</see> Service-Mitarbeiter aufgerufen werden.

## BeforeClearNotify

```cs
    static void BeforeClearNotify(
       Int32[]  ids,
       ref object  eventState
      );
```

Wird ausgeführt, bevor die Servicemethode aufgerufen wird.
Er kann einen Zustand im *eventState*-Parameter speichern, der in diesem Dienstaufruf an die **After**-Methode und die **AfterAsync-Methode** übergeben wird.
Der Ereignisstatus wird zwischen verschiedenen Serviceaufrufen nicht beibehalten. Er wird zu Beginn jedes Serviceaufrufs auf null festgelegt.

## AfterClearNotify

```cs
    static void AfterClearNotify(
       Int32[]  ids,
       ref object  eventState
      );
```

Wird ausgeführt, nachdem die Servicemethode aufgerufen wurde. Der Service wartet, bis diese Methode abgeschlossen ist, bevor er das Ergebnis an den Aufrufer zurückgibt.
Dieser Serviceaufruf hat keinen Rückgabewert, daher gibt es keinen **returnValue**-Parameter
Jeder Zustand, den Sie in der **Before**-Methode festlegen, wird über den *eventState*-Parameter übergeben.

## AfterClearNotifyAsync

```cs
    static void AfterClearNotifyAsync(
       Int32[]  ids,
       ref object  eventState
      );
```

Wird ausgeführt, nachdem die Servicemethode aufgerufen wurde, ohne auf die Rückgabe des Aufrufs zu warten.
Der Serviceaufruf wird nicht blockiert, wenn auf den Abschluss dieser Methode gewartet wird.
Jeder Zustand, den Sie in der **Before**-Methode festlegen, wird über den *eventState*-Parameter übergeben.
