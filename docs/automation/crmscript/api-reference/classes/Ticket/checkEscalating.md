---
uid: crmscript_ref_Ticket_checkEscalating_Integer_action
title: Ticket.checkEscalating(Integer action)
intellisense: Ticket.checkEscalating
keywords: checkEscalating(Integer)
so.topic: reference
---

# Ticket.checkEscalating(Integer action)

This function does a check according to the ticket's pritority and the input action. The effect of calling this function might be that the escalation stops, restarts or continues.

* **action:** as an Integer.
   
**Possible values:**   
ActionRead = 0,
ActionChangedOwner = 1,
ActionNewInfo = 2,
ActionClosed = 3,
ActionChangedPriority = 4,
ActionNew = 5

