---
title: Upgrade
uid: automated_task_upgrade
description: Automated tasks in Service - upgrade
author: {github-id}
keywords: service
topic: reference
envir: onsite
# client:
---

# upgrade

Used after upgrading your Service installation. Should usually be run by just executing upgrade.exe without any parameters unless you need something specific.

Can also be used to install/update things that were left out earlier. (As an example, you may have chosen to not install FCGI, but want to install it at a later point, in which case you run `upgrade -onlyFCGI`)

**Usage:** `upgrade [options] [-u <username] [-d <domain>]`

* **-noconfirm** Do not confirm actions.
* **-dbDebug** Displays database debug information.
* **-verbose** Print debug info to stdout
* **-matchCrmUsername** Match username between ejuser and associate for unassigned ejusers
* **-recreateIndices** Recreate all indices in database
* **-u \<username>** Set user name of the person upgrading
* **-d \<domain>** Set the domain you wish to upgrade
* **-forcePackages** Force upgrade of unlocked packages
* **-force** Force upgrade of tables
* **-basePath \<path>** Set the base path of the installation
* **-resetSequences** Rebuild the sequence table
* **-onlySystemTemplates** Install new system templates
* **-onlyFCGI** Only installs the FastCGI handlers
* **-onlyRoleReport** Only generate report of role upgrade changes
* **-onlyMailingTemplates** Only update mailing templates
* **-onlyPackages** Only upgrade the packages
* **-config-file** Read a name-value file containing automated answers for all questions during upgrade
