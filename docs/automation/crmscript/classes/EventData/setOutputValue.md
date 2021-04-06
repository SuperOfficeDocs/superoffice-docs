---
uid: crmscript_ref_EventData_setOutputValue_String_fieldName_String_val
title: EventData.setOutputValue(String fieldName, String val)
intellisense: EventData.setOutputValue
sortOrder: 298
keywords: setOutputValue(String,String)
so.topic: reference
---

# Void setOutputValue(String name, String value)

This method sets the value of a specified output field (for example "ContactEntity.Department").

```crmscript
Integer newOrgNr = 987654321;
EventData ed = getEventData();
ed.setOutputValue("ContactEntity.OrgNr", newOrgNr);
```

## Example: summarize all sales connected to a project, then update a user-defined field on the current project

```crmscript
EventData ed = getEventData();
String projectId = ed.getInputValue("ProjectEntity.ProjectId");

SearchEngine se;
se.bypassNetServer(true);
se.addField("sale.amount", "sum");
se.addCriteria("sale.project_id", "Equals", projectId);

if(se.select() > 0) {
  ed.setOutputValue("ProjectEntity.UserDefinedFields.SuperOffice:1", "[F:" + se.getField(0) + "]");
}
```
