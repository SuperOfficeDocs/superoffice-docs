---
title: Integer[] SaveImport(NSImportLine[] importLines, String[] columnDefinition, Bool createSelection, String culture, String context)
path: /EJScript/Classes/NSImportAgent/Member functions/Integer[] SaveImport(NSImportLine[] p_0, String[] p_1, Bool p_2, String p_3, String p_4)
intellisense: 1
classref: 1
sortOrder: 3954
keywords: SaveImport(NSImportLine[],String[],Bool,String,String)
---


Do the actual import



* **importLines:** The rows that will be imported
* **columnDefinition:** An array of the columndefinitions, like firstname, lastname, ...
* **createSelection:** true if a selection of the imported entities shall be made
* **culture:** The current culture used in the import. Used to match language specific strings
* **context:** Optional context for the import.
* **Returns:** First part: the id of the selection created after the import, 0 if no selection is created. Second part: The number of rows actually imported


