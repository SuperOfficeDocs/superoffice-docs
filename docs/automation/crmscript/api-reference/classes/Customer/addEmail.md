---
uid: crmscript_class_customer_addemail
title: Customer.addEmail(String email, Integer externalRank, Integer extTable, Integer dbiAgentId)
description: CRMScript method in the Customer class that adds an email to a customer
intellisense: Customer.addEmail
sortOrder: 186
keywords: addEmail(String,Integer,Integer), addEmail(String,Integer,Integer,Integer)
so.topic: reference
---

# Void addEmail()

Adds an email to a customer. Commonly used in database integrations.

You can optionally provide the external sorting rank.

## Functions

* Void addEmail(String email, Integer extTable, Integer dbiAgentId)
* Void addEmail(String email, Integer externalRank, Integer extTable, Integer dbiAgentId)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| email | String | Email address |
| externalRank | Integer | Optional. External sorting rank. (Can't be changed in the Service GUI). |
| extTable | Integer | External owner of this email address as an extTable ID. |
| dbiAgentId | Integer | External owner of this email address as a dbiAgent ID. |

> [!NOTE]
> `extTable` is a deprecated database integration called data sources.
