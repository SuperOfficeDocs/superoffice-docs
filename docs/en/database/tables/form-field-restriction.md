---
uid: table-form_field_restriction
title: form_field_restriction table
description: This table contains all form fields restrictions
generated: true
keywords: database table form_field_restriction
content_type: reference
envir: onsite, online
---

# form\_field\_restriction Table (491)

This table contains all form fields restrictions

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|form\_field\_restriction\_id|Primary key|PK| |
|field\_identifier|the identifier for the field|String(255)|&#x25CF;|
|field\_restriction|The restriction set on the field|Enum [FormFieldRestrictionType](enums/formfieldrestrictiontype.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![form_field_restriction table relationship diagram](./media/form_field_restriction.png)

[!include[details](./includes/form-field-restriction.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|field\_identifier |String(255) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

