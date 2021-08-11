---
uid: crmscript_ref_Customer_findFromAgentAndKey_Integer_agent_String_key
title: Customer.findFromAgentAndKey(Integer agent, String key)
intellisense: Customer.findFromAgentAndKey
sortOrder: 181
keywords: findFromAgentAndKey(Integer,String)
so.topic: reference
---

# Customer.findFromAgentAndKey(Integer agent, String key)

Finds a customer entry in the database based on the given agent id and external key.

This function will find a customer entry in the database based on an agent id and an external key.

## Parameters

 - agent: The agent id for the external entry. Implicitly defines the external datasource.
 - key: The primary key of the external entry.

Returns the id for the customer entry in the database, or -1 if not found.

