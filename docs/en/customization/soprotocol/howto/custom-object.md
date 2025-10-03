---
uid: sop-custom-objects
title: How to work with custom objects using SoProtocol
description: How to show or create a custom object with or without prefilled values using SoProtocol.
keywords: soprotocol, custom object
author: Michel Krohn-Dale
date: 09.24.2024
version: 10.3.8
content_type: howto
category: customization
topic: soprotocol
platform: web
deployment: online, onsite
pilot: yes
redirect_from:
  - /en/ui/soprotocol/custom-object
  - /en/ui/soprotocol/howto/custom-object
language: en
---

# How to work with custom objects using SoProtocol

You can create a new [custom object][1] from for instance a button or link added in the Screen designer. Here are examples of how to accomplish this by using SoProtocol.

## Add new custom object

```http
customobject?customobject_name=y_car
```

## Add new custom object with prefilled values

For new entries, we can pass any value to a field or prefill it with currents. Just add `&<custom_field_name>=<value>` to SOProtocol. Current is referred by "{current_id}".

```http
// Prefilling current
customobject?customobject_name=y_car?<custom_field_name>={contact_id}

// Prefilling values in fields
customobject?customobject_name=y_car?<custom_field_name>=blue
```

## Show existing custom object based on ID

```http
customobject?customobject_name=y_car&customobject_id=1520
```

<!-- Referenced links -->
[1]: ../../../custom-objects/learn/extra-table.md

<!-- Referenced images -->
