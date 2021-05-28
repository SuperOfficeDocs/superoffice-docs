---
uid: crmscript_class_customer_save
title: Customer.save()
description: CRMScript method in class Customer that creates a new or updates an existing customer
intellisense: Customer.save
sortOrder: 182
keywords: save(), save(String)
so.topic: reference
---

# Integer save()

Saves the customer. If ID is set, the customer will be updated. Otherwise, a new customer entry will be created.

You can optionally provide the source key of the StoreAndProcess consent.

Returns the ID of the saved customer.

## Functions

* Integer save()
* Integer save(String gdprSourceKey)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| gdprSourceKey | String | The source key of the StoreAndProcess consent to set. These keys can be found in the consent system. |
