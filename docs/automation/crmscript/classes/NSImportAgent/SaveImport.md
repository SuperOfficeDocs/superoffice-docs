---
title: crmscript_ref_NSImportAgent_SaveImport_NSImportLine__p_0_String__p_1_Bool_p_2_String_p_3_String_p_4
description: NSImportAgent.SaveImport(NSImportLine[] p_0, String[] p_1, Bool p_2, String p_3, String p_4)
intellisense: NSImportAgent.SaveImport
sortOrder: 3954
keywords: SaveImport(NSImportLine[],String[],Bool,String,String)
so.topic: reference
---


Do the actual import



* **importLines:** The rows that will be imported
* **columnDefinition:** An array of the columndefinitions, like firstname, lastname, ...
* **createSelection:** true if a selection of the imported entities shall be made
* **culture:** The current culture used in the import. Used to match language specific strings
* **context:** Optional context for the import.
* **Returns:** First part: the id of the selection created after the import, 0 if no selection is created. Second part: The number of rows actually imported


