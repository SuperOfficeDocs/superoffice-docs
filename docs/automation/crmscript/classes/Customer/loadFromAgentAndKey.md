---
title: crmscript_ref_Customer_loadFromAgentAndKey_Integer_agent_String_key
description: Customer.loadFromAgentAndKey(Integer agent, String key)
intellisense: Customer.loadFromAgentAndKey
sortOrder: 179
keywords: loadFromAgentAndKey(Integer,String)
so.topic: reference
---

Loads a customer based on agent id and external key.

This function will load a customer (possibly overwriting existing values) from the database, based on the agent id and external key.



###Parameters:###


 - agent: The id of the agent that "owns" this customer.
 - key: The external key of this customer.


Returns true if operation was successful, false if the customer does not exist.


