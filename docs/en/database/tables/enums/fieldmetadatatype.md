---
uid: enum-fieldmetadatatype
title: Enum values for FieldMetadataType
description: Lists the enum values for FieldMetadataType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# FieldMetadataType Enum

Field type

| Name | Value | Description |
|------|-------|-------------|
|Checkbox|0|Checkbox widget: Boolean value|
|Text|1|Single line textbox.|
|Password|2|Single line edit field with password characters - input is hidden.|
|Integer|3|Single line integer number field. |
|Double|4|Single line decimal number field. |
|List|5|Dropdown listbox. The list name must be provided. The list items are provided by another interface. The default value should be the list key, not the text of the list item.|
|Date|6|Date|
|Label|99|Static text - has no input widget associated with it. Can be used for spacing/layout.|

## Usage

* [ErpField](../erpfield.md).FieldType - Store the metadata describing the fields that belong to an actor/connection combination, as described by the Erp Connector
