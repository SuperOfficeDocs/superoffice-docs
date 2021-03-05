---
title: usercontrol_mdo_config
description: Config file settings for an MDO control
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Config file settings for an MDO control

Typical config:

```XML
<control id="projtemp5_4" type="SoMDOControl" column="3" row="4" width="200px" >
  <caption></caption>
    <datasource>FindDataHandler.associateId.Values[0]</datasource>
    <config>
      <displaytext-datasource>
        FindDataHandler.associateId.DisplayValues[0]
      </displaytext-datasource>
    <listname>Associate</listname>
  </config>
</control>
```

## Control element

| Parameter | Description |
|--|---|
| id | gives the control a unique ID within the page |
| type | type of the control |
| column<br>row<br>width | the physical characteristics of the control |

Since this list control does not have a caption, the caption element will be empty.

See Also:

[Adding an MDO control to an existing panel of a page][1]

## Datasource element

The `datasource` element says where the data for the control will be pulled from.

> [!NOTE]
> `FindDataHandler.associateId.Values[0]`- Since the control displays a list, it should be bound against an array so this says `FindDataHandler.associateId.Values` property is holding an array and display the first element of the array.

## Displaytext-datasource element

The `displaytext-datasource` says what data should be displayed. In the above case, it is `DisplayValues`, so this is the data that users will see.

The difference between `datasource` and `displaytext-datasource` is that the former identifies the array data item used by the application and while the latter identifies what's visible to the user.

## Listname element

The `listname` element tells us the name of the MDO provider that supplies the list of values to the drop-down.

The list will be created according to the name. For example, if we have a Category, a category list will be displayed. However, when you *select* a category, the category ID will be set on the associate field. This happens because we have said in the `datasource` element that we will use the category ID for the mappings.

> [!NOTE]
> In an MDO control configuration, `datasource`, `displaytext-datasource`, and `listname` must match each other. If we have a list name that does not match the other elements, it will mess up the data.

For example, if `datasource` points to *associateid* and `listname` to *category*, it will map the category ID to associate ID field.

## MDO factory

The MDO factory will create the control for us. It will use the `listname` element to determine the list that we want.

## Alternative config

There is another type of configuration for the MDO control.

```XML
<control id="projtemp5_3" type="SoMDOControl" column="2" row="4" width="120px">
  <caption></caption>
  <datasource>FindDataHandler.associateId.Operator</datasource>
  <config>
    <list-datasource>OperatorListDataHandler.staticlistany</list-datasource>
    <propertykey>Type</propertykey>
  </config>
</control>
```

Here, 2 are different from the typical config.

### OperatorListDataHandler

The data shown to the user is fetched from the list named in the `list-datasource` element. **OperatorListDataHandler** has a pre-built static list of associates. It's typically used when the list is built from the application using static data rather than from the database.

For example, an operator list for an associate list or a category list will be "one of", "not one of", and "=". In a case like this, the OperatorListDataHandler will take the static list and pass it on to the MDO factory along with the provider name for the operator list, which is restrictionOperators.

Inside NetServer, the MDO factory finds the class `SuperOffice.CRM.ArchiveLists.OperatorProvider`, which is marked as the **restrictionOperators** list. The OperatorProvider uses this class to build a list of valid operators for *staticlistany*. The list is returned as a list of SoListItem objects.

### propertykey

`<propertykey>Type</propertykey>` tells the control what field in the SoListItem to use when setting the data source.

The static list items look like this:

```text
(id=1, name="[SR_IS_ONE_OF]", tooltip="", type="isOneOf")
(id=2, name="[SR_IS_NOT_ONE_OF]", tooltip="", type="isNotOneOf")
(id=3, name="[SR_IS_EQUAL_TO]", tooltip="", type="=")
```

The control would normally bind the ID to the data source, but we want to bind the type to the operator field on the find-data-handler, so `propertykey` is *Type*.

<!-- Referenced links -->
[1]: add-mdo-control-to-panel.md

<!-- Referenced images -->
