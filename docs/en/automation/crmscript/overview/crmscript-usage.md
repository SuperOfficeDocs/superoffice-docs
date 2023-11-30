---
uid: crmscript-usage
title: What can I do with CRMScript?
description: Overview of what you can do with CRMScripts in SuperOffice and limitations pertaining to the online environment.
author: Bergfrid Skaara Dias
so.date: 12.02.2022
keywords: CRMScript, performance, security
so.topic: concept
---

# What can I do with CRMScript?

## Customize your workflows and automation

Scripts are a great way of automating processes in smart ways. For example, you can use CRMScript to improve your B2C customer service processes.

## Validate input

Want to make sure users enter the correct data, even in user-defined fields? To block save if essential fields haven't been filled out? CRMScript lets you intercept, parse, and take action to reduce errors and improve data quality.

## Dynamically update content

You can for example change the available items in a drop-down based on what the user has already selected in another field.

## Run code in response to certain events on a website

What should happen when a new ticket is registered or a sale is confirmed?

## Tailor the Customer Center

In many cases, our standard pages will suffice. However, if you need something a bit more customized, you can tailor almost everything with CRMScripts. You can even run any script in SuperOffice from the customer care center, given that you have the ID and the key for the script.

## Explore the database without access to the database server

**SearchEngine** provides some excellent ways of deep-diving into the database without having a remote session to the SQL Server.

> [!CAUTION]
> Searches may affect load. Ask only for the data you need. Don't ask for the entire database!

## Limitations in CRM online

Because of security restrictions and performance considerations in our online environment, there are some things you can't do with CRMScripts in online tenants.

* You can't put files on our **online** web server (no upload or import of scripts).
* You can't read from or write to physical files on our **online** web server.
* Scripts have a 60 second run-time. After 60 seconds, the script times out.
* Memory-intensive scripts are not allowed. Each script may not consume more than 8 MB of memory.
* The **BulkUpdate** API is unavailable because updates can take a long time.
* ODBC endpoints are unavailable, which makes it technically impossible to access an Access-database from CRMScript. You can use Zapier instead.
* Using the HTTP class, you can only access external resources over port 80 or 443.

[!include[Restricted agents](../../../includes/restricted-crmscript-agents.md)]
