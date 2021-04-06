---
uid: crmscript_ref_NSPersonAgent_AddEmailAddressToPerson
title: Void AddEmailAddressToPerson(Integer personId, String emailAddress, Bool setAsPrimaryEmail)
intellisense: NSPersonAgent.AddEmailAddressToPerson
keywords: NSPersonAgent, AddEmailAddressToPerson
so.topic: reference
---

Sets the primary email address on person, possibly re-ranking email addresses accordingly.

**Parameters:**
 - **personId** Person id of the person
 - **emailAddress** The email address to set as primary email address
 - **setAsPrimaryEmail** True if the address shall be primary email address (have rank == 1)
