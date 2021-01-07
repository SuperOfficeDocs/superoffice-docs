---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: mirroring_requirements       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SQLServer prerequisites for database mirroring # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# SQLServer prerequisites for database mirroring

If you need to set up [database mirroring][1].

Customers who want to use the [database mirroring application][2] must have a valid mirroring subscription. Standard applications that incorporate database mirroring don't require the mirroring subscription.

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
[1]: index.md
[2]: https://online.superoffice.com/appstore/superoffice-as/database-mirroring-service