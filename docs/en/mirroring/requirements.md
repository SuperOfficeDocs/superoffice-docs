---
title: Requirements
uid: mirroring_requirements
description: SQLServer prerequisites for database mirroring
author: SuperOffice Product and Engineering
keywords:
content_type: reference
deployment: online
platform: web
---

# Database Mirroring Requirements

Database mirroring only works with **Microsoft SQL Server** database server. Customers who want to use the [database mirroring application][2] must have a valid mirroring subscription. Standard applications that incorporate database mirroring don't require a mirroring subscription.

## Stand-alone server

* 8 gigabytes of RAM (minimum 4)
* 100 gigabytes of available hard-drive space (minimum 50)

## Software requirements

* SQL Server Express Edition (or standard edition, depending on if SQL agent is needed)
* IIS 8.5 or higher
* DNS entry plus a valid public SSL certificate
  * For the event-based call to the interface from SuperOffice CRM Online (push mechanism)

Databases and applications of the interface usually don't need any special backup, because the data is transient and kept primarily in the cloud (SuperOffice CRM Online).

<!-- Referenced links -->
[2]: https://online.superoffice.com/appstore/superoffice-as/database-mirroring-service
