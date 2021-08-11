---
uid: crmscript_ref_Company_loadFromAgentAndKey_Integer_agent_String_key
title: Company.loadFromAgentAndKey(Integer agent, String key)
intellisense: Company.loadFromAgentAndKey
sortOrder: 161
keywords: loadFromAgentAndKey(Integer,String)
so.topic: reference
---

# Company.loadFromAgentAndKey(Integer agent, String key)

Loads a company based on agent id and external key.

This function will load a company (possibly overwriting existing values) from the database, based on the agent id and external key.

## Parameters

 - agent: The id of the agent that "owns" this company.
 - key: The external key of this company.

Returns true if operation was successful, false if the company does not exist.

