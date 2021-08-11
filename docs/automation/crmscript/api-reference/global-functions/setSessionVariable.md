---
uid: crmscript_global_setsessionvariable
title: String setSessionVariable()
description: CRMScript function that writes a SessionObject entry to the database
intellisense: Void.setSessionVariable
langref: 1
keywords: setSessionVariable(String,String)
so.topic: reference
---

# String setSessionVariable()

Writes a SessionObject entry to the database. This function makes it possible to store variables in the database which the web application can use as long as a session lives. That is until a user logs out.

## Parameters

| Parameter | Type | Description |
|---|---|---|
| name | String  | Entry name. May be empty, in which case the ID of the first row will be used. |
| value | String |  Entry value to store. |
