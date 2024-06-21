---
title: Documents migration
uid: document-migrate-to-online
description: Understanding document migration
author: Martin Pavlas
date: 10.18.2023
keywords: migrate, document
topic: guide
envir: onsite, online
# client:
---
# Understanding document migration: reasons why some documents may not be migrated

## Introduction

Migrating documents from an Onsite database to an Online Production environment is a critical step to ensure a smooth data transfer. However, some documents may be left behind. Let's examine why this happens and how to fix it.

### Blank document names

One significant reason for non-migrated documents is having blank document names. When documents lack names, they're hard to identify during migration. To prevent this, enforce data integrity rules and validation checks in the Onsite database to ensure all documents have meaningful names.

### Missing appointment records

Another important factor contributing to document migration issues is the absence of appointment records. During migration, documents are often tied to specific appointments for crucial context and information. Documents without linked appointments may not migrate. To address this, ensure all documents are associated with valid appointment records.

### Non-existent associates

Besides appointment records, documents rely on linked associates. If an appointment record references an associate not present in the database, it can impede document migration. Resolve this by maintaining an updated database of active associates and ensuring appointment records only reference valid, currently active associates.

## Solving the migration challenges

To ensure a successful document migration, address the following Onsite database issues:

### Document naming

Implement checks and validation rules in the Onsite database to prevent documents without names. This maintains data integrity and aids document identification during migration.

### Appointment records

Confirm that all documents have valid appointment records. Implement checks to ensure every document is linked to an appointment before migration.

### Associate data

Maintain up-to-date and accurate associate data. Eliminate references to non-existent associates in appointment records to prevent migration complications.

Taking these steps to clean and prepare the Onsite database significantly improves the success of document migration. With complete and accurate information, the migration tool efficiently transfers all relevant documents to the Online Production environment, ensuring a smooth transition.

## Conclusion

Document migration is a pivotal phase in data transfer, vital for data integrity and continuity. By tackling document naming, appointment records, and associate data issues in the Onsite database, you elevate migration success. This proactive approach streamlines the process, benefiting your organization's data management.
