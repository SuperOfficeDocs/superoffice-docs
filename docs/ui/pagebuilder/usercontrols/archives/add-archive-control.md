---
title: add_archive_control
description: How to add an Archive control
author: Tony Yates
so.date: 04.16.2018
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to add an Archive control

![Archive control][img1]

Archive controls are comprised of the following components:

* Configuration
* Data source
* Displayed columns
* Header context menu
* Row context menu - [how to add it][1]
* Toolbar buttons (row single-click and double-click actions, toolbar action) - [how to add it][2]

Here, we'll look at adding a new archive control with a header context menu and the requirements associated with that task.

## Configuration

Archive controls are created within a control element of type `SoArchiveControl`. The ID attribute is used to uniquely identifies this particular archive from all others in SuperOffice. A common naming practice adds the Archive suffix to the ID for easily identifying the control through the system.

In the following example, a control element declares an archive control with ID **CustomDataArchive**.

``` xml
<control id="CustomDataArchive" type="SoArchiveControl">
  ...
</control>

```

## Data source

A child config element defines the characteristics of the archive control. The `providername` element defines the archive control data source and the restrictions element controls the criteria passes to the datasource to restrict the results.

This example declared the person archive provider as the datasource. The criteria used to restrict the number of person rows shown is the `contactId`, which is one of the available columns in the person archive provider.

The current element is set to anchor the current person entity. This means that when a person row is selected in the archive control, this will set the selected person as the current person in the current system.

``` xml
<control id="CustomDataArchive" type="SoArchiveControl">
  <config>
      <providername>person</providername>
      <restrictions>
        <restriction name="contactId" operator="=" binding="current">contact</restriction>
      </restrictions>
      <current>person</current>
  </config>
</control>
```

## Displayed columns

All archive providers implement the same interfaces to ensure they have a uniform behavior. Each one defines a set of available columns to display data in an archive control, but how and which columns are displayed are managed by several mechanisms.

![Archive control architecture][img2]

Once an `SoArchiveControl` is defined in a page, the controls' `id` attribute is used as a gui-identifier, called a **guiname**. Together, the guiname and provider name defined a unique archive element in the *SoArchiveColumnList.config* file.

The combination of providername and guiname must be unique as duplicates will create odd user-experience behaviors in SuperOffice.

> [!NOTE]
> Casing is lower-case.

### Example section in SoArchiveColumnList.config

``` xml
<archive providername="person" guiname="customdataarchive">
  <columns>
    <column name="hasInfoText" default="true" mandatory="false" ignore="false" />
    <column name="hasInterests" default="true" mandatory="false" ignore="false" />
    <column name="mrMrs" default="true" mandatory="false" ignore="false" />
    <column name="firstName" default="true" mandatory="false" ignore="false" />
    <column name="middleName" default="false" mandatory="false" ignore="false" />
    <column name="lastName" default="true" mandatory="false" ignore="false" />
    <column name="title" default="true" mandatory="false" ignore="false" />
    <column name="email/emailAddress" default="true" mandatory="false" ignore="false" />
    ...
  </columns>
</archive>
```

### Configure columns

To enable the ability to use the **Customize** dialog to configure displayed column and positioning, the page hosting the archive control must declare the `ArchiveColumnConfigDataHandler` at the top of the page.

```xml
<page id="ContactPage">
  <data>
    <datahandlers>
      <datahandler id="ContactEntityDataHandler" type="ContactEntityDataHandler" />
      <datahandler id="PersonEntityDataHandler" type="PersonEntityDataHandler" />
      <datahandler id="ArchiveColumnConfigDataHandler" type="ArchiveColumnConfigDataHandler">
        <config>
          <archivecolumninfos>
            <!--guiname maps to definition in SoArchiveColumnList.config-->
            <archivecolumninfo guiname="CustomDataArchive" providername="person"/>
          </archivecolumninfos>
        </config>
      </datahandler>
    </datahandlers>
  </data>
  <panels>
  ...
  </panels>
</page>
```

With a data handler configured, add the `archivecolumninfo-datasourcename` element to the SoArchiveControl config section. This provides the personalized functionality where different users can configure different columns without affecting each other's view of the same data source.

The first time an archive control is viewed in SuperOffice, it creates a record in the database table `SuperListColumnSize`. Future changes by users in the **Customize** dialog are persisted for each user in the table.

``` xml
<control id="CustomDataArchive" type="SoArchiveControl">
  <config>
      <providername>person</providername>
      <restrictions>
        <restriction name="contactId" operator="=" binding="current">contact</restriction>
      </restrictions>
      <current>person</current>
      <archivecolumninfo-datasourcename>ArchiveColumnConfigDataHandler.CustomDataArchive</archivecolumninfo-datasourcename>
  </config>
</control>
```

> [!NOTE]
> During development that any changes to configuration or data source will not be seen in the UI until the record in SuperListColumnSize is deleted.

#### Add menu element to SoMenuConfiguration.config

![Configure columns][img3]

To show the header context menu when a header item is right-clicked (the "configure columns" menu), you must add a `<menu>` element between the `<control>` and `<config>` elements in the SoArchiveControl.

``` xml
<menu>
  <context>archive</context>
  <subcontext>customdata</subcontext>
  <id binding="none">0</id>
  <position>belowcursor</position>
  <click>right</click>
</menu>
```

The context and sub-context attributes must match a menu element defined in the *SoMenuConfiguration.config* file. These are the identifiers that distinguish this menu item from all others.

An important convention to note about the following markup. Rendered archive control names are the result of combining the ID value suffixed with *ArchiveControl*. The result, with the archive control ID *CustomDataArchive*, becomes `CustomDataArchiveArchiveControl`. Therefore, when referencing the archive control in JavaScript (as seen below), use the full term CustomDataArchiveArchiveControl.

[!code-xml[XML](includes/cust-archive-control.xml)]

### Contact page example with SoArchiveControl

[!code-xml[XML](includes/cust-contact-page.xml)]

## Result

![Customized archive control][img4]

<!-- Referenced links -->
[1]: add-row-click-actions.md
[2]: add-archive-action-button.md

<!-- Referenced images -->
[img1]: media/web-archive-control.png
[img2]: media/web-archive-control-architecture.png
[img3]: media/web-customize-archive-control.png
[img4]: media/web-archive-control-column-config.png
