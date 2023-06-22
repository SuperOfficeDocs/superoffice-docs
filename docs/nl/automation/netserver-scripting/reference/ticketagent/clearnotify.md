---
uid: ticketagent-clearnotify
title: Gebeurtenismethode TicketAgent.ClearNotify
description: Scriptgebeurtenissen die de methode ClearNotify op de serviceagent van TicketAgent aanroepen.
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

Scriptgebeurtenissen die de methode <see cref='M:SuperOffice.CRM.Services.ITicketAgent.ClearNotify'>ClearNotify</see> op de serviceagent van <see cref='ITicketAgent'>ITicketAgent</see> aanroepen.

## BeforeClearNotify

```cs
    statische leegte BeforeClearNotify(
       Int32[] ids,
       ref object eventState
      );
```

Wordt uitgevoerd voordat de servicemethode wordt aangeroepen.
Er kan een bepaalde status worden opgeslagen in de parameter *eventState* die wordt doorgegeven aan de methoden **Na** en **AfterAsync** in deze serviceoproep.
De gebeurtenisstatus blijft niet behouden tussen verschillende serviceoproepen. Het is ingesteld op nul aan het begin van elke serviceoproep.

## AfterClearNotify

```cs
    statische leegte AfterClearNotify(
       Int32[] ids,
       ref object eventState
      );
```

Wordt uitgevoerd nadat de servicemethode is aangeroepen. De service wacht tot deze methode is voltooid voordat het resultaat aan de beller wordt geretourneerd.
Deze serviceoproep heeft geen retourwaarde, dus er is geen parameter **returnValue**
Elke status die u instelt in de methode **Voor** wordt doorgegeven via de parameter *eventState*.

## AfterClearNotifyAsync

```cs
    statische leegte AfterClearNotifyAsync(
       Int32[] ids,
       ref object eventState
      );
```

Wordt uitgevoerd nadat de servicemethode is aangeroepen, zonder te wachten tot de oproep terugkeert.
De serviceoproep wordt niet geblokkeerd terwijl deze methode is voltooid.
Elke status die u instelt in de methode **Voor** wordt doorgegeven via de parameter *eventState*.
