---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: cdd-intro       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Continuous database # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
so.version-from: 8.1
---

# Continuous database

How to create tables in the SuperOffice database for version 8.1 and higher.

## Introduction

Long gone are the days when software is built using a fixed Waterfall approach of establishing product requirements, designing software architecture, coding an implementation, verifying results and finally entering the maintenance mode.

Nearly all software projects these days have adopted agile methodologies that take an iterative approach; where there are no permanent requirements and instead the incremental evolutionary product lifecycle is the standard.

Unlike most software applications upgrade paths, which simply replace existing application files, deploying database structural changes is hard, because the data in the tables cannot be thrown away when a new structure is deployed. Harder still are changes requiring both structural and data changes. Another problem is maintaining the change logs of specific software versions and associated database versions. There is no easy way of documenting which software versions depend on which database schema version.

Therefore, based on principles set forth by *evolutionary database design*, Continuous Database is the latest SuperOffice process for instrumenting incremental changes toward the SuperOffice database that enables changes in a continuous way. This new process is a way both SuperOffice and third-parties can continuously update a database schema that reflects ever-changing business requirements without ever having to depend on a hardcoded fixed-system again.

## Getting started

Before diving into details, let’s first establish a point of reference. You are going to start by interacting with a SuperOffice database that is either pre-version 8.1, version 8.1, or post-version 8.1, and one that either does or does not have third-party tables. Under those assumptions, you are most likely to encounter one or more of the following scenarios:

* Pre-SuperOffice 8.1 database with third-party tables
* Pre-SuperOffice 8.1 database without third-party tables.
* SuperOffice 8.1 or higher with third-party tables.
* SuperOffice 8.1 or higher without third-party tables.

For pre-8.1 scenarios, we recommend using ServerSetup to upgrade customer installations. This will upgrade both the customers’ installation and database to the latest continuous database process.

If customers do not upgrade to SuperOffice 8.1, the only available option for third-party tables is the continued use of the legacy Dictionary SDK to create new or modified existing third-party tables.

For SuperOffice 8.1 and later, all third-parties must come to accept, understand and adopt the continuous database processes – as the remainder of this article presents.

## Fundamentals

So how does SuperOffice isolate itself from unpredictable database changes? From version 8.1, SuperOffice creates an in-memory model of the database from the a record stored in the DatabaseModel table. The model is a direct representation of what tables physically exists in the database. The database model also contains a list of all schema changes that have been applied to the database as a list of historical dictionary steps.

For each table, field, index, and relation definition in the database model, there is a reference to the dictionary step responsible for its creation, as well as the last step update. This is useful for tracing artifact changes and origin.
