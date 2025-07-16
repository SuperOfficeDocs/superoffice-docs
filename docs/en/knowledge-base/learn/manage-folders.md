---
uid: help-en-kb-folders
title: Manage folders
description: Organize reply templates, FAQ entries, external documents, and email addresses in folders for easy access and logical grouping.
keywords: knowledge base folder, template folder, FAQ folder, create folder, delete folder
author: Bergfrid Dias
date: 07.16.2025
version: 10.5
content_type: howto
category: service
topic: knowledge base
license: serviceessentials
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: en
redirect_from:
  - /en/email/service/learn/kb-aliases/manage-folders
  - /en/faq/learn/manage-folders
  - /en/request/reply-templates/learn/manage-folders
---

# Manage folders

Organize reply templates, FAQ entries, email addresses, and external documents in a logical folder structure within the knowledge base to make it easier to find information. You can create sub-folders at any level.

## Create folders

To create a new folder:

1. Go to the parent folder where you want to create a subfolder.
1. Click **New folder** at the top of the screen.
1. Confirm the parent folder in the **Folder** field or select a different one.
1. Enter a descriptive name for the folder in the **Name** field.
1. Optionally, add a brief explanation in the **Description** field.

1. Extra steps for **FAQ folders**:

    * In the **Position** field, select a number for the entry's position in the sort order of the folder it belongs in. 1 means the top of the list.
    * In the **Access** field, select who is to have access to the folder in question. A registered customer is a customer who has access to a customer centre.
    * In the **Access control** field, optionally enter a script to use to control external customers' access to this folder. If this field contains a script, it is evaluated and access granted only if the script returns a value of "1".

1. Extra steps for **external documents**:

    * In the **Access** list box, select who is to have access to read and edit the folder.

1. Click **OK** to create the folder.

You are now ready to add knowledge-base items to the new folder. Either add new items, or change the **Folder** field on existing items.

## Delete folders

**Before you delete a folder, remove all contained items** by either:

* Deleting the items.
* Moving the items to another folder (change the **Folder** field on each item's edit screen).

> [!NOTE]
> Deleting a folder with **external documents** also deletes all files within it immediately; you do not need to empty it first.

When you are ready to delete the folder itself:

1. Go to the required folder.
1. Click the **Edit folder** button.
1. Click **Delete**. The folder is deleted immediately.

## Related content

* [Add reply templates][1]
* [Edit reply templates][2]
* [Add FAQ entries][3]
* [Edit FAQ entries][4]
* [Add or edit email addresses][5]
* [Add or edit external documents][7]

<!-- Referenced links -->
[1]: reply-templates/create.md
[2]: reply-templates/edit.md
[3]: faq/create.md
[4]: faq/edit.md
[5]: email-addresses.md
[7]: external-document.md
