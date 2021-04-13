---
title: Reuirements
uid: mirroring_requirements
description: SQLServer prerequisites for database mirroring
author: {github-id}
keywords:
so.topic: reference
so.envir: cloud
so.client: online
---

# SQLServer pre-requisites for database mirroring

If you need to set up [database mirroring][1].

Customers who want to use the [database mirroring application][2] must have a valid mirroring subscription. Standard applications that incorporate database mirroring don't require a mirroring subscription.

## System requirements

### Stand-alone server

* 8 gigabytes of RAM (minimum 4)
* 100 gigabytes of available hard-drive space (minimum 50)

### Existing server

The **hardware** requirements are reduced to what the interface actually needs (primarily the SQL Server databases) because there is no space to reserve for the operating system.

**SQL Server databases** require:

* The mirror database (DatabaseMirroring)
* The interface databases (test and production)

## Software requirements

* SQL Server Express Edition (or standard edition, depending on if SQL agent is needed)
* IIS 8.5 or higher
* DNS entry plus a valid public certificate
  * To make the view of the SAP documents available in SuperOffice CRM Online
  * For the event-based call to the interface from SuperOffice CRM Online (push mechanism)

Databases and applications of the interface usually don't need any special backup, because the data is transient and kept primarily in the cloud (SuperOffice CRM Online) and in ERP.

<!-- Referenced links -->
[1]: overview.md
[2]: https://online.superoffice.com/appstore/superoffice-as/database-mirroring-service