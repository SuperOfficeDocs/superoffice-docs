---
uid: crmscript-extra-fields
title: Extra fields
description: Working with extra fields in CRMScript.
author: Bergfrid Skaara Dias
date: 11.02.2021
keywords: extra field, custom, field, Service
topic: concept
---

# Extra fields

## List all extra fields

```crmscript!
SearchEngine se;
se.addFields("extra_fields", "id,name,field_name,domain,extra_table");
print(se.executeTextTable());
```

## Get and set extra field values

```crmscript!
Company c;
c.load(2);
printLine(c.getValue("x_label"));
c.setValue("x_label","13");
c.save();
```

## Field parameters

### Get params with SearchEngine

```crmscript!
String fieldName = "x_label";
SearchEngine se;

se.addFields("extra_fields", "id,target_extra_table,params");
se.addCriteria("extra_fields.field_name", "OperatorEquals", fieldName);

if (se.select() > 0) {
  String[] parameters = se.getField("extra_fields.params").split("\n");

  foreach (String param in parameters) {
    printLine(param);
  }
}
```

> [!TIP]
> You might have extra line breaks. If so, call `stripLeadingAndTrailing("\n")` to trim your string.

To filter the result, use the built-in string methods. For example:

```crmscript
if (param.beginsWith("option=")) {
  printLine(param.after("option="));
}
```

### Sort parameters

If you have many options and want to sort them alphabetically, here's how:

> [!TIP]
> The keys of a **map** are automatically sorted alphabetically on insert.

```crmscript
String fieldName = "x_label";
SearchEngine se;
se.addFields("extra_fields", "id,target_extra_table,params");
se.addCriteria("extra_fields.field_name", "OperatorEquals", fieldName);

if (se.select() > 0) {
  Map sorted;
  String sortedParameters;
  String fieldId = se.getField("extra_fields.id");
  String[] parameters = se.getField("extra_fields.params").split("\n");
  
  // add options to map and other params directly to result
  foreach (String param in parameters) {
    param.stripLeadingAndTrailing("\n");
  
    if (param.beginsWith("option=")) {
      sorted.insert(param.after("option="), "");
    }
    else {
      sortedParameters.append(param + "\n");
    }
  }

  // append sorted options
  for (sorted.first(); !sorted.eof(); sorted.next()) {
    sortedParameters.append("option=" + sorted.getKey() + "\n");
  }

  // update database
  SearchEngine seSort;
  seSort.addData("extra_fields.params", sortedParameters);
  seSort.addCriteria("extra_fields.id", "OperatorEquals", fieldId);
  seSort.update();
}
```

<!-- Referenced links -->
