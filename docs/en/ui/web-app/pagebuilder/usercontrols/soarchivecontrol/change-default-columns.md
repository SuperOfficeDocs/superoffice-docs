---
uid: pb-usercontrol-archive-defaults
title: How to change the default columns
description: How to change the default columns in the project archive
keywords: project archive
author: Tony Yates
date: 06.24.2016
content_type: howto
category: customization
topic: Pagebuilder
platform: web
deployment: onsite
---

# How to change the default columns in the project archive

The default columns list of all archives is contained in the *SoArchiveColumnList.config* file. The config file contains a default column list as well as an ignored column list for all providers available through the CRM.web. It is important to remember that if we change the default column list of a provider, in all places it is used the new column list will be shown. The chosen columns for each user are stored at the database level in the `superlistcolumnsize` table.

In the example below, our goal is to add 2 columns (project associates – first name and last name) to the **Project** view displayed on the **Company** page.

To achieve our goal, we must change the *SoArchiveColumnList.config* as follows:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<archives>
  <!--Other providers and there defaukt columns-->
  <archive providername="contactprojects" guiname="contactprojectsarchive">
    <columns type="mandatory">
      <column name="type"/>
    </columns>
    <columns type="default">
      <column name="name"/>
      <column name="type" orderby="1:A"/>
      <column name="status"/>
      <column name="associateId"/>
      <!--Columns added by us />-->
      <column name="projectAssociate/firstName"/>
      <column name="projectAssociate/contactName"/>
      <!--END-->
    </columns>
    <columns type="ignore">
      <column name="contactId"/>
      <column name="projectUrl/URLDescription"/>
      <column name="projectAssociate/contactDepartment"/>
      <column name="projectAssociate/lastName"/>
      <column name="projectAssociate/middleName"/>
      <column name="projectAssociate/contactId"/>
      <column name="projectAssociate/mrMrs"/>
      <column name="projectAssociate/title"/>
      <column name="projectAssociate/associateId"/>
      <column name="projectAssociate/contactFullName"/>
    </columns>
  </archive>
  <!--Other providers and there default columns-->
</archives>
```

This adds 2 columns (projectAssociate/firstName and projectAssociate/contactName) to the `contactprojectsarchive`. How? We removed the 2 columns from the ignore column list and added them to the default column list.

**Before:**

![02][img1]

**After:**

![03][img2]

> [!NOTE]
> If the user has customized the columns in this archive, the default no longer applies, and the new columns won’t appear automatically. However, the new columns will appear in the archive customization dialog so that the user can add them to the customized view.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/image002.jpg
[img2]: media/image003.jpg
