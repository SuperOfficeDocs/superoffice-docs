---
title: q1uote_connector_carrier_fieldmetadatainfo
description: ERP Quote Connector Interface data carrier - FieldMetadataInfo
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# FieldMetadataInfo

This carrier describes a custom field to be added to the config dialog at runtime. It is used to populate the Admin configuration dialog for a connection.

> [!NOTE]
> This is just a description of the field - it is not the field itself.

The GUI will use this info to build the user interface controls. The call to the ERP Connector’s `GetConfigurationFields` method returns a list of fields and field types. The Admin client builds a dialog with these fields.

**Admin Quote Connection Dialog:**

![31][img1]

## string FieldKey

Internal name of the field. Used as the key in the dictionary of values.

## int Rank

A way to set the order of the fields. The lowest value will be displayed first/over the fields with other values.

## string DisplayName

Localized field name - shown in the GUI as the label for the control.

## string DisplayDescription

Tooltip for the field.

## FieldMetadataTypeInfo FieldType

String, int, decimal, etc.

Kind of field widget to use: textbox, number field, password field, dropdown list, or checkbox?

## string ListName

Used for getting the list items from the list provider. The source of the items must ultimately be exposed as an IQuoteListProvider, through various naming conventions and adapters. The actual Quote and ERP Connectors solve this in slightly different ways.

## string DefaultValue

A default value for the field. The value in the widget when the configure dialog is opened in Add Connection mode.

This will vary a bit depending on the type, of course.

Obviously, if the field is a label, text, or password, then the text is used.

* If the field is an int or double, we shall try to convert the string into a number. (If the conversion fails, we shall use zero or 0.00 as the default value.)
* If the field is a list, we shall try to find a list item where the field's default value matches the listsitem’s ERPQuoteListItemKey.

## int MaxLength

Maximum length for strings, if set.

0 means no restriction. (Though sooner or later something will no doubt overflow if you pile on the gigabytes.)

## FieldAccessInfo Access

Access restrictions on the field

<!-- Referenced images -->
[img1]: media/image031.jpg
