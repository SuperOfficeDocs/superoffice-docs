---
title: How to work with Custom objects
uid: sop_custom_object
description: How to work with Custom objects with SoProtocol
author: Michel Krohn-Dale
date: 9.7.2024
keywords: soprotocol, customobjects
topic: howto
client: web
envir: online, onsite
---

# How to work with Custom objects using SoProtocol

For various reasons you might want to be able to create a new Custom object from for instance a button or link in added in Screen designer, below are some examples of how to accomplish this by using SoProtocol.

## Add new Custom object

```http
default.aspx?customobject?customobject_name=y_car
```

## Add new Custom object passing in current or other prefilled values

For new entries we can pass any value to field or prefill with currents. Just add &\<custom_field_name\>=\<value\> to SOProtocol. Current is referred by "{current_id}".

```http
// Prefilling current
default.aspx?customobject?customobject_name=y_car?<custom_field_name>={contact_id}

// Prefilling values in fields
default.aspx?customobject?customobject_name=y_car?<custom_field_name>=blue
```

## Showing an existing custom object based on Id

```http
default.aspx?customobject?customobject_name=y_car&customobject_id=1520
```
