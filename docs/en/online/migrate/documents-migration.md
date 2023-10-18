---
title: Documents migration
uid: documents_migration
description: Understanding documents migration
author: Martin Pavlas
so.date: 18.10.2023
keywords: migrate, documents
so.topic: guide
so.envir: onsite, online
# so.client:
---
# Understanding document migration: reasons why some documents may not be migrated

## Introduction

Migrating documents from an Onsite database to an Online Production environment is a critical step in ensuring the seamless transfer of data. However, it's not uncommon for some documents to be left behind during this process. We will explore the reasons why certain documents might not be migrated and what steps can be taken to address these issues.

1. Blank document names

    One of the primary reasons why some documents are not migrated is the presence of blank document names. When documents lack names, it becomes challenging to identify and locate them during the migration process. To avoid this issue, it is essential to ensure that all document records have meaningful names. This can be achieved by enforcing data integrity rules and validation checks in the Onsite database to prevent the creation of documents without names.

1. Missing appointment records

    Another key factor that contributes to document migration issues is the absence of appointment records. In the migration process, documents are often associated with specific appointments that provide critical context and information. If a document lacks an associated appointment, it may not be migrated. To address this, it is crucial to ensure that all documents have a valid appointment record linked to them.

1. Non-existent associates

    In addition to appointment records, documents also rely on associated associates. In cases where the appointment record points to an associate that does not exist in the database, document migration can be hindered. To resolve this issue, it is essential to maintain a clean and up-to-date database of associates. This includes ensuring that appointment records only reference associates that are currently active and valid.

## Solving the migration challenges

To ensure a successful document migration, it is imperative to address the following issues in the Onsite database:

1. Document naming

    Implement checks and validation rules in the Onsite database to prevent the creation of documents without names. This will help maintain data integrity and facilitate document identification during migration.

1. Appointment records

    Ensure that all documents are associated with valid appointment records. Implement checks to verify that every document has a linked appointment before migration.

1. Associate data

    Keep the associate data up-to-date and accurate. Remove references to non-existent associates in appointment records to prevent migration complications.

By taking these steps to clean and prepare the Onsite database, you can significantly improve the success rate of document migration. When the migration tool has access to complete and accurate information, it can efficiently transfer all relevant documents to the Online Production environment, ensuring a smooth transition.

## Conclusion

Document migration is a crucial step in the data transfer process, and ensuring that all documents are successfully migrated is essential for maintaining data integrity and continuity. By addressing issues related to document naming, appointment records, and associate data in the Onsite database, you can enhance the success of your migration efforts. This proactive approach will lead to a more seamless and efficient document migration process, ultimately benefiting your organization's data management efforts.