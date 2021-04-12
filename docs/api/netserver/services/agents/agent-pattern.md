---
# Mandatory fields.
title: agent_pattern       # (Required) Very important for SEO.
description: Agent pattern # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Agent pattern

SuperOffice has created a set of objects based on the **Agent pattern** that will perform your work for you. A typical agent on the NetServer will have all useful service methods that are capable of inserting, retrieving, updating, and deleting data.

An agent represents a set of related services. Each method on an Agent object is a service call. If your services are configured to use SOAP, then each method call is a SOAP call that will travel over the network. An agent consumes and returns carrier objects.

The goal of the agent pattern is to make it clear when you are making potentially expensive service calls.

The Agent factory returns implementation objects that talk directly to the database or to return proxy objects that talk to the back-end via SOAP. The advantage of this is that it gives flexibility since you can run everything on one box or two separate boxes without changing the program. Only the config file needs to be changed.

The following section of the config file shows where the web services are turned on:

```XML
<Services>
  <!-- Mode can be Local, Remote, Switch -->
  <add key="DefaultMode" value="Local" />

  <!-- Default mode for the switch.  Can be Local or Remote -->
  <add key="SwitchDefault"  value="Remote" />

  <!-- Timeout before failover in seconds -->
  <add key="SwitchFailover" value="60" />

  <!-- Base URL for remote services -->
  <add key="RemoteBaseURL" value="http://localhost/Webs/SuperOffice.Services.Stub" />

  <!-- URL to the Data Set Definition file -->
  <add key="DataSetDefinitionURL" value="http://localhost/Webs/SuperOffice.Services.Stub/dsd.xml" />
</Services>
```

Through a given agent you can manipulate a carrier.

> [!NOTE]
> A carrier is an object that carries data between the Agent and the NetServer services. The 2 kinds of carriers that are available through NetServer include [simple read-only carriers][1] and [complex entity carriers][2]. The main difference between these 2 types of carriers is that entity carriers can be updated and sent back for saving to the database while read-only carriers cannot be saved back to the database.

<!-- Referenced links -->
[1]: ../carriers/read-only-carriers.md
[2]: ../carriers/entity-carriers.md
