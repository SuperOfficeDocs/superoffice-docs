---
uid: crmscript_uc
title: What can I do with CRMScript?
author:
so.date:
keywords:
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

## Limitations

Because of security restrictions and performance considerations, there are some things you can't do with CRMScripts.

* You can't put files on our **online** webserver (no upload or import of scripts).
* You can't read from or write to physical files on our **online** webserver.
* It is not allowed to run a script for more than 60 seconds.
* Memory-intensive scripts are not allowed. Each script may not consume more than 8 MB of memory.
* The **BulkUpdate** API is unavailable because updates can take a long time.
* ODBC endpoints are unavailable, which makes it technically impossible to access an Access-database from CRMScript. You can use Zapier instead.

### Complete list of blacklisted data types

The following data types are unsupported in CRMScript.

1. NSAudienceAgent
2. NSBulkUpdateAgent
3. NSCRMScriptAgent
4. NSDashboardAgent
5. NSDatabaseAgent
6. NSDatabaseTableAgent
7. NSErpSyncAgent
8. NSTrayAppAgent
