---
title:
description:
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic:
so.client: web
so.envir: onsite
---

# SoProtocol and SuperState

The SoProtocolModule drives the [SuperState][1] at all times. The SuperState is defined by the SoProtocol URL together with the values of the last used SuperState. If no SoProtocol is given, the last valid SuperState will be used.

It uses manager classes such as `SuperStateManager` and `ConfigurationManager` to retrieve the current SuperState date and merges this data with any incoming SoProtocol data.

<!-- Referenced links -->
[1]: ../pagebuilder/superstate/index.md

<!-- Referenced images -->
