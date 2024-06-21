---
uid: help-en-data-exchange
title: Data Exchange
description: Data Exchange
author: SuperOffice RnD
date: 06.29.2022
keywords: Service, Data Exchange
topic: reference
audience: settings
audience_tooltip: Settings and maintenance
language: en
envir: onsite
---

# Data Exchange (ONSITE only)

[!include[Requirement](../../../../learn/includes/req-expander-services.md)]

This area is used to configure database integrations between the system and other data sources.

## Agents

This screen contains a list of any existing Data Exchange (database integrator) agents. SuperOffice Service can be connected to one or more agents to synchronize with other databases.

| Element | Description |
|---|---|
| New agent | Used to create a new agent. |
| Name | Displays the agent name. |
| Protocol | Displays the communication protocol used to connect to the agent. |

## Agent properties

This screen shows the properties of a Data Exchange agent.

| Element | Description |
|---|---|
| Edit agent | Used to edit the agent properties. |
| New agent task | Used to create a new agent task. |
| Edit fields | Used to specify fields that will should read-only in SuperOffice Service. |
| Agent | This pane lists different properties for the agent. |
| Name | Name of the Data Exchange agent. |
| Protocol | Select the protocol used to communicate with the Data Exchange agent. |
| Path/URL | Path or network address used to communicate with the Data Exchange agent. |
| Parameters | Parameters used by CRMScript or the Data Exchange agent. |
| Tasks | In this pane, all registered tasks for this agent are displayed. The status of each task is also displayed. Click a task to edit it. |
| Fields | Displays all fields in SuperOffice Service that are not editable. Click **Edit fields** to add a new field. |

## Edit agent

This screen is used to edit the properties of a new or existing Data Exchange agent. You can also create schedules to activate the agent at given intervals.

| Element | Description |
|---|---|
| Name | Name of the Data Exchange agent. |
| Protocol | Select the protocol used to communicate with the Data Exchange agent. |
| Path/URL | Path or URL used to communicate with the Data Exchange agent. |
| Parameters | Parameters used by CRMScript or the Data Exchange agent. |
| OK (Alt-O) | Click this button to save. |
| Cancel | Click this button to cancel. |
| Delete | Click this button to delete. |
| Apply | Select to use these settings. |

## Agent schedule properties

This screen is used to edit the properties of a new or existing schedule used by a Data Exchange agent. Here you can choose how often to synchronize the agent with SuperOffice.

| Element | Description |
|---|---|
| Name | Here you can enter the name of the schedule. |
| ejScript/CRMScript | Here you can select the CRMScript which the schedule activates. |
| Parameters | Parameters used by CRMScript or the Data Exchange agent. |
| OK** (Alt-O): Click this button to save. |
| Cancel | Click this button to cancel. |
| Delete | Click this button to delete. |
| Reset | If the agent task does not stop, you can click this button to reset it. |
| Stop | Click this button to stop the agent task. |
| Apply | Click this button to use the settings. |

## Agent field properties

This screen is used to edit the properties of a field connected to an agent. The fields displayed are read-only in SuperOffice Service.

| Element | Description |
|---|---|
| Field names | A list of database field names that are read-only in the interface, for example 'cust-company.name'. |

<!-- Referenced links -->

<!-- Referenced images -->
