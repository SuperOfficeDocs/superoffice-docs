---
title: Enum ConfigFieldType
uid: quote_connector_enum_configfieldtype
description: ERP Quote Connector Interface data carrier - Enum ConfigFieldType
author: SuperOffice Product and Engineering
date:
keywords: quote
content_type: reference
redirect_from:
  - /en/api/plugins/quote-connectors/api/enums/index
  - /en/api/netserver/plugins/quote-connectors/api/enums/configfieldtype
  - /en/api/netserver/plugins/quote-connectors/api/enums/index
---

# Enum ConfigFieldType

Describes the different types of controls that can appear in the Configure connection dialog

| Control | Description |
|---|---|
| Checkbox | checkbox control. Returns 0 or 1 |
| Text | edit field |
| Password | edit field with `***` masking |
| Integer | edit field: digits only, accepts integers |
| Double | edit field: digits only, accepts decimal numbers formatted with CultureInfo.InvariantCulture (for instance: "-1000.01") |
| List | dropdown list |
| Label | static text (no value entered or saved) |
