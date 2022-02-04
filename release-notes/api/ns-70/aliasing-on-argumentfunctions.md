---
title: Aliasing on ArgumentFunctions
uid: whats_new_70_aliasing
description: NetServer 7.0
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: reference
---

# Aliasing on ArgumentFunctions

You can now set an alias name on an ArgumentFunction Such as Day, Count, …

* Earlier, you could say Count(fieldInfo) with an alias on the fieldInfo.

* Now you can set the alias on the function itself, making it possible to use the same fieldInfo in multiple functions – such as dateparts

You can then retrieve values by alias name, instead of ordinal number
