---
title: crmscript_ref_NSDatabaseTableAgent_UpdateRow
description: Void UpdateRow(String tableName, Integer id, StringDictionary values)
intellisense: NSDatabaseTableAgent.UpdateRow
keywords: NSDatabaseTableAgent,UpdateRow
so.topic: reference
---

Update a row in a table

**Parameters:**
 - **tableName** The name of the table to update; in the current release this must be an 'extratable'. Use the database name, on the form y_aTable
 - **id** The id of the row to update
 - **values** A StringDictionary with the values to update. You do not need to specify all the values in the table. The omitted ones will remain unchanged
