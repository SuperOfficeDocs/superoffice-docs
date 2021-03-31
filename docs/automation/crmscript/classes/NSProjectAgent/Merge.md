---
uid: crmscript_ref_NSProjectAgent_Merge
title: Void Merge(Integer sourceProjectId, Integer destinationProjectId, Bool replaceEmptyFieldsOnDestination)
intellisense: NSProjectAgent.Merge
keywords: NSProjectAgent, Merge
so.topic: reference
---

Merge two projects into one, removing the source project in the process

**Parameters:**
 - **sourceProjectId** Id of source project for merge. This project is removed after the merge is completed.
 - **destinationProjectId** Id of destination project to merge to. This project is updated with info from the source.
 - **replaceEmptyFieldsOnDestination** Fill in empty fields on destination from source?
