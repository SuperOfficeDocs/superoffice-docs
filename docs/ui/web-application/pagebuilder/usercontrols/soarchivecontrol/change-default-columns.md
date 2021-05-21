---
title: How to change the default columns
uid: pb_usercontrol_archive_defaults
description: How to change the default columns in the project archive
author: Tony Yates
so.date: 06.24.2016
keywords: project
so.topic: howto
so.client: web
so.envir: onsite
---

# How to change the default columns in the project archive

The default columns list of all archives is contained in the *SoArchiveColumnList.config* file. The config file contains a default column list as well as an ignored column list for all providers available through the CRM.web. It is important to remember that if we change the default column list of a provider, in all places it is used the new column list will be shown. The chosen columns for each user are stored at the database level in the `superlistcolumnsize` table.

In the example below, our goal is to add 2 columns (project associates – first name and last name) to the **Project** view displayed on the **Company** page.

To achieve our goal, we must change the *SoArchiveColumnList.config* as follows:

[!code-xml[xml](includes/soarchivecolumnlist.xml)]

This adds 2 columns (projectAssociate/firstName and projectAssociate/contactName) to the `contactprojectsarchive`. How? We removed the 2 columns from the ignore column list and added them to the default column list.

**Before:**

![02][img1]

**After:**

![03][img2]

> [!NOTE]
> If the user has customized the columns in this archive, the default no longer applies, and the new columns won’t appear automatically. However, the new columns will appear in the archive customization dialog so that the user can add them to the customized view.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image002.jpg
[img2]: media/image003.jpg
