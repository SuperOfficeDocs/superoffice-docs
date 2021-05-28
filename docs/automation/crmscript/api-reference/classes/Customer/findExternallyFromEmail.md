---
uid: crmscript_class_customer_findexternallyfromemail
title: Customer.findExternallyFromEmail(String email, Integer extTable)
description: CRMScript method in the Customer class that finds an entry in the external database based on an email address
intellisense: Customer.findExternallyFromEmail
sortOrder: 174
keywords: findExternallyFromEmail(String), findExternallyFromEmail(String,Integer)
so.topic: reference
---

# Bool findExternallyFromEmail()

Finds an entry in the external database based on an email address. It will search all external data sources for a Customer matching the given email address. If an entry is found, a proxy entry is created and saved.

You can optionally provide an extTable ID to limit the search to 1 data source.

Returns true if an entry is found, false if not.

## Functions

* Bool findExternallyFromEmail(String)
* Bool findExternallyFromEmail(String,Integer)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| email | String | The email address ("alias@domain"). |
| extTable | Integer | Optional. Is used if you want to search 1 data source only. |
