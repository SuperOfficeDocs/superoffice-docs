---
title: pb_usercontrols_id_and_reference
description: UserControls - ID and references
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# ID and references

Each element (panel, card, view, control) in a page is uniquely identified by the ID of that object.

As a general rule, a card, view, or control may have a reference instead of actual content. In that case, a configuration fragment of that type and with the name specified in the reference attribute value will be fetched and merged into the configuration.

```XML
<view id="MainView" reference="MainView"></view>
```

This will cause the system to look for a view configuration fragment with the reference name *MainView*. In *SoMainViewView.config*, the filename is constructed from the reference name: "So\<reference-name>\<TagName>.config".
