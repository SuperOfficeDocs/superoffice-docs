---
title: Continuous Database (CD)
uid: cdd
description: Continuous Database (CD)
author: {github-id}
keywords: database
topic: concept
---

# Data dictionary

SuperOffice 8.1 changed the dictionary structure to allow more flexible evolution. We refer to this as CDD - **Continuous Database Development**.

## Introduction

Long gone are the days when software is built using a fixed waterfall approach of establishing product requirements, designing software architecture, coding an implementation, verifying results, and finally entering the maintenance mode.

Nearly all software projects these days have adopted agile methodologies that take an iterative approach; where there are no permanent requirements and instead the incremental evolutionary product lifecycle is the standard.

Unlike most software applications upgrade paths, which simply replace existing application files, deploying database structural changes is hard, because the data in the tables cannot be thrown away when a new structure is deployed. Harder still, are changes that require both structural and data changes. Another problem is maintaining the change-logs of specific software versions and associated database versions. There is no easy way of documenting which software versions depend on which database schema version.

Therefore, based on principles set forth by *evolutionary database design*, **Continuous Database** (CD) is the latest SuperOffice process for instrumenting incremental changes toward the SuperOffice database that enables changes in a continuous way.

This new process is a way both SuperOffice and third-parties can continuously update a database schema that reflects ever-changing business requirements without ever having to depend on a hardcoded fixed-system again.

* Partners can also develop and deploy their custom dictionary steps to add their fields and tables to the database.
* Partner changes will not be overwritten or lost when the database is upgraded.

## Fundamentals

So how does SuperOffice isolate itself from unpredictable database changes? From version 8.1, SuperOffice creates an in-memory model of the database from the one stored in the `DatabaseModel` table. The model is a direct representation of what tables physically exist in the database. The database model also contains a list of the latest schema changes that have been applied to the database as a list of dictionary steps.

CD defines database variations in two dimensions. Individual features refer to step names. Each feature, or step name, will have individual steps for each version of the feature. Teams can work in parallel on their features and produce steps in numbered series.

![x][img1]

SuperOffice CRM demonstrates multiple features being developed in parallel. Even though this is not exposed for customizations by partners, the concept of features being developed in parallel is verified, the same way as if it were partners developing customizations in different versions in parallel. The current version of SuperOffice CRM Online consist of 9 different features with 35+ steps.

For each table, field, index, and relation definition in the database model, there is a reference to the dictionary step responsible for its creation, as well as the last step update. This is useful for tracing artifact changes and origin.

## Getting started

You are going to start by interacting with a SuperOffice database that is either pre-version 8.1, version 8.1, or post-version 8.1, and one that either does or does not have third-party tables. Under those assumptions, you are most likely to encounter one or more of the following scenarios:

* Pre-SuperOffice 8.1 database with third-party tables
* Pre-SuperOffice 8.1 database without third-party tables.
* SuperOffice 8.1 or higher with third-party tables.
* SuperOffice 8.1 or higher without third-party tables.

For pre-8.1 scenarios, we recommend using **ServerSetup** to upgrade customer installations. This will upgrade both the customers’ installation and database to the latest continuous database process.

If customers do not upgrade to SuperOffice 8.1, the only available option for third-party tables is the continued use of the legacy Dictionary SDK to create new or modified existing third-party tables.

For SuperOffice 8.1 and later, all third-parties must come to accept, understand and adopt the continuous database processes.

<!-- Referenced images -->
[img1]: media/swimminlane-description.png
