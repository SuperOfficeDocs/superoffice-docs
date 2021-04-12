---
title: quote_connector_enum_configfieldtype
description: ERP Quote Connector Interface data carrier - Enum ConfigFieldType
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# Enum ConfigFieldType

Describes the different types of controls that can appear in the Configure connection dialog

| Control | Description |
|---|---|
| Checkbox | checkbox control. Returns 0 or 1 |
| Text | edit field |
| Password | edit field with `***` masking |
| Integer | edit field | digits only, accepts integers |
| Double | edit field | digits only, accepts decimal numbers formatted with CultureInfo.InvariantCulture (for instance: "-1000.01") |
| List | dropdown list |
| Label | static text (no value entered or saved) |
