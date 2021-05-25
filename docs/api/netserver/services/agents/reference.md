---
title: List of NetServer agents
uid: ns_agents_reference
description: List of NetServer agents
author: {github-id}
so.date:
keywords:
so.topic: reference
# so.envir:
# so.client:
---

# List of NetServer agents

An Agent exposes many different service calls. Each service will operate on one type of carrier. Below is a list of all the Agents exposed in the NetServer API.

| Agent | Description |
|---|---|
| AgentBase<T> | This is the ultimate base class of all service agents |
| AppointmentAgent  | AppointmentAgent is a collection of services that helps to manipulate appointment data. |
| ArchiveAgent  | ArchiveAgent returns results as an archive list or a page of data with chosen columns from the archive, based on a specified restriction. |
|  AssociateAgent  | AssociateAgent returns an array of Strings or Associate objects that belongs to a person who is an Associate. |
| BLOBAgent | BLOBAgent provides a collection of operations that work on BLOB entities. |
| ConfigurationAgent | ConfigurationAgent retrieves configuration details for a specific webpage or the whole application. |
| ContactAgent | ContactAgent provides a collection of services that work with company contact data. |
| DiagnosticsAgent | The agent flushes all NetServer caches. |
| DocumentAgent | This agent contains a collection of services that work with document data which are handled by the BLOB service methods. |
| EMailAgent | The EMailAgent provides a collection of services that work with emails. |
| FindAgent | The agent is capable of saving restriction, which could be later used as search criteria, and then retrieving information from a set of saved criteria while executing a find operation, which returns a page of results. |
| ForeignSystemAgent | ForeignSystemAgent is a collection of services that work with foreign key data. |
| LicenseAgent | LicenseAgent provides a collection of services that work with license information. |
| ListAgent | This is a collection of services that work with different lists such as Dropdown lists, Check box lists, etc. |
| MDOAgent | MDOAgent contains a service that retrieves a flat or selectable MDO list with its own history and restrictions. |
| NavigatorAgent | The agent is capable of returning either a NavigatorCompany object or an array of NavigatorCompany objects. |
| PersonAgent | PersonAgent is a collection of services that helps to manipulate a person’s data. |
| PhoneListAgent | The agent contains a collection of services that are used when searching for an employee or company phone number.
| PreferenceAgent | PreferenceAgent provides a collection of services that work with preferences. |
| ProjectAgent | ProjectAgent is a collection of services that works with project data. |
| RelationAgent | RelationAgent provides a collection of services that work with company relation information. |
| ReplicationAgent | ReplicationAgent provides a collection of services that work with replication functions. |
| SaleAgent | SaleAgent is a collection of services that work with sale data. |
| SelectionAgent | SelectionAgent contains a collection of data that work with SelectionEntities. |
| SentryAgent | |
| TooltipsAgent | This contains a collection of services that work with tool-tips. |
| UserAgent | UserAgent provides a collection of services that work with associate user information. |
| UserDefinedFieldInfoAgent | UserDefinedFieldInfoAgent provides a collection of services that work with user-defined field data. |
| ViewStateAgent | ViewStateAgent contains a collection of services that work with data related to the currently logged-in user. |
