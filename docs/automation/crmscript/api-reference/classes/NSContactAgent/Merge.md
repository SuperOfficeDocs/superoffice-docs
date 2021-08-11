---
uid: crmscript_ref_NSContactAgent_Merge
title: Void Merge(Integer sourceContactId, Integer destinationContactId, Bool mergeIdenticalPersons, Bool replaceEmptyFieldsOnDestination)
intellisense: NSContactAgent.Merge
keywords: NSContactAgent, Merge
so.topic: reference
---

# Void Merge(Integer sourceContactId, Integer destinationContactId, Bool mergeIdenticalPersons, Bool replaceEmptyFieldsOnDestination)

Merge two contacts. The destination contact will remain.

**Parameters:**
 - **sourceContactId** Source contact to merge from. This contact will disappear after the merge.
 - **destinationContactId** Destination contact to merge into
 - **mergeIdenticalPersons** Persons with identical names will be merged
 - **replaceEmptyFieldsOnDestination** If true, empty fields on destination will be replaced by values from source.
