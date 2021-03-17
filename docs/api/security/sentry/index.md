---
title: sentry      
description: Sentry
author: {github-id}             # Your GitHub alias.
keywords:
---

# Sentry

What is sentry? As the name implies it acts as **the watchdog that keeps an eye on all the access to data in the SuperOffice database**.

Sentry is a shared component used by all SuperOffice code to evaluate access rights. The Sentry objects answer questions regarding which tables and fields are accessible to a given type of operation, but do not themselves **enforce** these rights – this is up to the various client objects.

In SuperOffice the security is based on roles so all the user of SuperOffice belongs to a role. The different roles have different levels of rights to access the data in the database so Sentry is the mechanism that ensures that these levels get the proper data access. The levels of data access rights in SuperOffice are as follows.

* None
* Read
* Create
* Update
* Delete

Here *None* means that the user does not have any rights to the data, Read means that the user can read the data, Create means the user can create rows in a table, Update means the user can update the data and Delete means the user can delete the data. If a user has the right to Delete a data item that means that the user has the right to Read, Create and Update the data and if the user has the right to Update the user will have the rights to Create and Read as well like-wise the rights will be determined.

The role defines what rights he has to the data that he owns, data owned by other associates in his primary user group, and to associates of the other user groups he belongs to. It also defines what rights he has to data that belong to other associates outside his user groups and external users/anonymous users. All the users of the SO CRM application will have a role. The rights to each data item will be determined by these roles so that means there is a mechanism in place to protect access to data.

## Sentries, main tables, and sub-tables

The Sentry system is responsible for evaluating access rules. It consists of a common base class, and a subclass for each **main table** there is a Sentry for. The main tables at the time of writing are:

* contact
* person
* project
* appointment
* sale
* selection
* relation

Each Sentry, then, implements the rules that apply to its main table. However, a Sentry typically also handles one or more **sub-tables**, which contain data subordinate to the main table. Rights to the sub-table records are generally derived from rights to the main table record. The sub-tables are:

| Main table | Sub-tables |
|---|--|
| contact | Address, Phone, Email, Url, Text, ContactInterest, UdContSmall, UdContLarge |
| person | Address, Phone, Email, Url, Text, PersonInterest, UdPersSmall, UdPersLarge |
| project | Text, Url, ProjectMember, UdProjSmall, UdProjLarge |
| appointment | Document, Text |
| sale | Text, UdSaleSmall, UdSaleLarge |
| selection | SelectionMember |
| relation | |

Rights overrides may be applied to any table or field that is a main table or a sub-table of a main table.
