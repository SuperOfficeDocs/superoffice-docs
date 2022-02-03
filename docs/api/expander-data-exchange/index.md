---
title: Expander Data Exchange
uid: expander_data_exchange
description: What is SuperOffice Expander Data Exchange
author: {github-id}
so.date: 
keywords: 
so.topic: concept
---

# SuperOffice Expander Data Exchange

The SuperOffice Expander Data Exchange (EDE, formerly DBI) module is essentially an asynchronous service for updating/copying data to/from SuperOffice Service and some other source. Thanks to the columns `dbi_key` and `dbi_agent_id` on several central tables in CS, we can keep track of an entry's primary key in another system, which allows us to synchronize entities (keep track of which local entities correspond to the ones in the other system).

The EDE is built up in a modular architecture, where the communication with the other system is managed using a plug-in system. These plug-ins are referred to as **agents**. The EDE-engine is communicating with an agent either using a File-pipe, or HTTP. In either case, the agent will receive input formatted as XML, perform some tasks, and then return output as XML. An agent may have any number of tasks, which will be executed according to various schedules (ranging from every minute to once a week). Normally, a single task will execute something resembling a single SQL query, transferring data one way (into CS or out from CS). A typical task is "Get all companies from an external source which has been updated lately". Inside Service, a task is interacting with a CRMScript to access our business layer, handle data mapping, transformations, and so on.

## Agents (connectors)

Out of the box, we offer 3 agents:

* **ODBCAgent:** allows you to connect to an ODBC DSN and perform standard SQL queries.

* **SuperOfficeAgent:** uses the COM interface of the Sales & Marketing Windows client and supports methods for inserting/updating central SuperOffice CRM entities, such as person, contact, and project.

* **LDAPAgent:** uses LDAP to connect to a directory (such as Microsoft Active Directory) to read data. It is normally used to retrieve users from AD to integrate them as persons (customers) or users in SuperOffice Service.

Write your own connector in PHP, Perl, or c#. Needs to not be more than 10 lines.

## Use cases

* Synchronize contacts/persons from some system to SuperOffice CRM
* Synchronize calendar events into CRM
* Synchronize stuff into an extra table with purchases or products, viewed in the contact tab in Sales & Marketing.
* Synchronize sales from CRM to another system.

## Example

The other CRM system is kept in a SQL database

![x -screenshot][img1]

### Configure the agent

![x -screenshot][img2]

### Configure the task

![x][img3]

### Configure the schedule

![x][img4]

### Create the processing script

![x][img5]

### Results

Results are visible in Customer Service

![x][img6]

and in Sales & Marketing

![x][img7]

## How-tos and tutorials

* [How to create a custom Data Exchange agent][1]

<!-- Referenced links -->
[1]:../tutorials/custom-data-exchange-agent/index.md

<!-- Referenced images -->
[img1]: media/image014.jpg
[img2]: media/image015.jpg
[img3]: media/image016.jpg
[img4]: media/image017.jpg
[img5]: media/image018.jpg
[img6]: media/image019.jpg
[img7]: media/image020.jpg
