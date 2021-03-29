---
title: crmscript_ref_SearchEngine_setDistinct_String_field
description: SearchEngine.setDistinct(String field)
intellisense: SearchEngine.setDistinct
keywords: setDistinct(String)
so.topic: reference
---


This function makes the entries distinct so that equal tickets will not be listed.


se.setDistinct("ticked.id"); There will only be one entry with the same ticket id, very useful with many to many relations.


