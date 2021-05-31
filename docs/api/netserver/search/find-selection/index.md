---
title: New Selection
uid: find_selection_intro
description: Details what new selections are, and how to work with them in code.
author: {AnthonyYates}
keywords: NewSelection, Selection, Find
so.topic: article
# so.envir:
so.client: web
so.version: 9.2
---

# Find and Selection

SuperOffice [Find][1] is a unification of the **Find dialog** and **Selections**: two legacy approaches to search for specific information. SuperOffice provides new APIs to perform searches, used by both Find and Selections, and for you to easily implement the same search capability for integrations.

This section covers the terms and concepts needed to understand how to programmatically work with Find just like in SuperOffice.

> [!NOTE]
> The API details provided apply to SuperOffice v.9.2 and higher.

## Getting started

The way a search begins today is by clicking the **Find** option.

![Header Find][img1]

When clicked, the **Find** panel appears and all of the primary business entities are listed on the page. By default, one dynamic selection is created and maintained per user, per entity. When a user selects one of the **Find [Entity]** links, SuperOffice retrieves the previously-saved dynamic selection criteria for the selected entity, or loads the default criteria for that entity, and populates the Selection search find panel.

### Find Panel

![Find panel][img2]

Alternatively, a pre-defined typical search option is chosen from an entity [Typical searches][4] drop-down menu. When selected, the pre-defined typical search criteria populate the Selection search find panel.

### Selection search panel

![Selection panel][img3]

Each search is functionally equivalent to a **dynamic selection**. Once the search criteria have been set and saved, the Find becomes a Selection and is available for future reference.

The remainder of this section will highlight the key types and methods used to construct, persist, and invoke a selection.

## SelectionEntity

A `SelectionEntity` contains only a handful of properties, most of which appear in the **Selection details** tab, and have the following considerations:

* Selection entity
* Type of selection
* Owner
* Category
* Who can see it.
* Description

The corresponding properties are:

| Name | Description |
|---|---|
| Name | Selection name. |
| MainProviderName | Name of the archive provider responsible for populating the selection. |
| SelectionType | Defines whether this is a dynamic, static, or combined selection. |
| Owner | The associate responsible for the selection. |
| SelectionCategory | List item that describes the type of selection. |
| VisibleFor | Define the user or groups with access rights to this selection. |
| Description | A short description of the selection list. |

### Get a selection entity

#### [REST](#tab/get-selection-entity-1)

```http
GET /api/v1/Selection/18 HTTP/1.1
Authorization: Bearer {access_token}
Content-Type: application/json
Accept: application/json
```

#### [Agent](#tab/get-selection-entity-2)

```http
POST /api/v1/Agents/Selection/GetSelectionEntity?selectionEntityId=18 HTTP/1.1
Authorization: Bearer {access_token}
Accept: application/json; charset=utf-8
Accept-Language: en
```

#### [WebApi Client](#tab/get-selection-entity-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

int selectionId = 18;
// perform the request
var selectionAgent = new SelectionAgent(options);
SelectionEntity selectionEntity = await selectionAgent.GetSelectionEntity(selectionId);
```

___

> [!NOTE]
> It is important to not hard-code the selection provider names. Future support may include selections of more entities.

## Selection criteria

Archive provider columns are the core of selection. Just like a SQL SELECT statement, where there are any number of select fields and any number of WHERE clause criteria, selections use archive provider columns as select fields and criteria.

Selection criteria are established using **criteria groups**.

![CriteriaGroup][img4]

`CriteriaGroups` contain an array of `ArchiveRestrictionInfo`. This array is encapsulated in an `ArchiveRestrictionGroup` and referred to as one `CriteriaGroup`.

* Each `ArchiveRestrictionInfo` in an `ArchiveRestrictionGroup` is implicitly joined by an AND operator.
* Each `ArchiveRestrictionGroup` is implicitly joined by an OR operator.

![Selection CriteriaGroups][img5]

The grouping and use of the operator as such means it's simple to define, maintain and comprehend how groups of criteria are applied to selection search routines.

### Example

Take the following SQL, for example:

```sql
SELECT firstName, lastName 
FROM CONTACT AS C
WHERE (C.name LIKE 'Super%' AND C.business_idx = 2) 
   OR (C.name LIKE 'Duper%' AND C.category_idx = 12)
```

The first WHERE criteria, `(C.name LIKE 'Super%' AND C.business_idx = 2)`, is a criteria group, comprised of 2 distinct criteria. To build the equivalent into an `ArchiveRestrictionGroup`, it looks like this:

```csharp
var criteriaGroup = new ArchiveRestrictionGroup()
{
    Name = "0",
    Rank = 0,
    Description = "Hidden Description",
    Restrictions = new []
    {
        new ArchiveRestrictionInfo()
        {
            Name = "name",
            Operator = "begins",
            Values = new[] { "Super" },
            IsActive = true,
            ColumnInfo = new ArchiveColumnInfo()
            {
                Name = "name",
                RestrictionType = "stringorPK",
                RestrictionListName = "locateContact_new",
                //... left out for brevity
            },
            InterOperator = InterRestrictionOperator.And
        },
        new ArchiveRestrictionInfo()
        {
            Name = "name",
            Operator = "begins",
            Values = new[] { "Duper" },
            IsActive = true,
            ColumnInfo = new ArchiveColumnInfo()
            {
                Name = "name",
                RestrictionType = "stringorPK",
                RestrictionListName = "locateContact_new",
                //... left out for brevity
            },
            InterOperator = InterRestrictionOperator.And
        }
    }
};
```

As seen in the C# example above, the `Name` and `Rank` share the same numerical value, represent the order they appear in SuperOffice. The `Name` and `Rank` for the next `ArchiveRestrictionGroup` in the array are 1, and any subsequent group would increment one more than the one before it.

Read more about [how to populate selectable columns][5] and [using date range as criteria][6].

## Working with selections

There are a couple of different ways to create a selection. While you can manually craft a `SelectionEntity`, save it, and then populate the `CriteriaGroups`, the recommended approach is to use the APIs to assembly the required information:

1. Get the available entities.
2. Get the SelectionForFind to get the archive provider name or selection ID.
3. Create default selection.
4. Get the available display columns for the archive provider
5. Get the available restriction columns for the archive provider
6. Get the available entities for the archive provider

Below, we address how to create and save a selection. For more details, check out our tutorial on [how to search using Find Selections][9].

### Get the Find entities

The **Find** page dynamically displays all entities that support the new Find system.

> [!NOTE]
> Available entities depend on the current user's license.

[Learn how to do it in code][7].

### Get the SelectionForFind type

After getting the available entities, you can use the entity name to get the appropriate `SelectionForFind` result, which not only specifies the correct archive provider name for this search type, it specifies the default selection ID associated with the entity type. This ID can then be used to get the default criteria groups for that selection type.

The **selection ID** indicates the associates personalized dynamic selection primary key, containing a default list of criteria used to pre-populate a new selection of this entity type. This is updated each time a user creates a new dynamic selection.

[Learn how to do it in code][8].

> [!NOTE]
> All Find Selections use an archive provider whose name ends with the "V2" suffix, for example, [AppointmentDynamicSelectionV2][2] and [ContactPersonDynamicSelectionV2][3].

### Create a Selection

Once you have the `SelectionForFind`, use the MainArchiveProvider to set the Selection property of the same name.

#### [REST](#tab/create-selection-entity-1)

```http
GET /api/v1/Selection/default HTTP/1.1
Authorization: Bearer {access_token}
Content-Type: application/json
Accept: application/json
```

#### [Agent](#tab/create-selection-entity-2)

```http
POST /api/v1/Agents/Selection/CreateDefaultSelectionEntity HTTP/1.1
Authorization: Bearer {access_token}
Accept: application/json; charset=utf-8
Accept-Language: en
```

#### [WebApi Client](#tab/create-selection-entity-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

int selectionId = 18;
// perform the request
var selectionAgent = new SelectionAgent(options);
SelectionEntity selectionEntity = await selectionAgent.CreateDefaultSelectionEntity();
```

___

### Save the SelectionEntity

Only a subset of selection properties must be set to save a selection. The main properties are `Name`, `MainProviderName`, and `SelectionCategory`.

#### [REST](#tab/save-selection-entity-1)

```http
POST /api/v1/Selection HTTP/1.1
Authorization: Bearer {access_token}
Content-Type: application/json
Accept: application/json

{
  "Description": "Testing Selections (Description)",
  "Postit": "",
  "SelectionCategory": {
    "Id": 2,
  },
  "IncludePerson": 0,
  "Name": "Selections from API (Name)",
  "SelectionType": "Dynamic",
  "CompanyUnique": false,
  "TargetTableNumber": 5,
  "TargetTableName": "contact",
  "Completed": false,
  "LeftSelectionId": 0,
  "RightSelectionId": 0,
  "SelectionUnionType": "Unknown",
  "MainProviderName": "ContactPersonDynamicSelectionV2",
  "ShadowProviderName": "",
  "MainHeading": "[SR_SELECTION_DYNAMICSELECTION_OF] [SR_COMPANY_AND_PERSON] (MainHeading)",
  "MemberTabHeading": "[SR_COMPANY_AND_PERSON] (MemberTabeHeading)",
  "VisibleFor": [
    {
      "VisibleId": 0,
      "Visibility": "All",
    }
  ]
}
```

#### [Agent](#tab/save-selection-entity-2)

```http
POST /api/v1/Agents/Selection/SaveSelectionEntity HTTP/1.1
Authorization: Bearer {access_token}
Accept: application/json; charset=utf-8
Accept-Language: en

{
  "Description": "Testing Selections (Description)",
  "Postit": "",
  "SelectionCategory": {
    "Id": 2,
  },
  "IncludePerson": 0,
  "Name": "Selections from API (Name)",
  "SelectionType": "Dynamic",
  "CompanyUnique": false,
  "TargetTableNumber": 5,
  "TargetTableName": "contact",
  "Completed": false,
  "LeftSelectionId": 0,
  "RightSelectionId": 0,
  "SelectionUnionType": "Unknown",
  "MainProviderName": "ContactPersonDynamicSelectionV2",
  "ShadowProviderName": "",
  "MainHeading": "[SR_SELECTION_DYNAMICSELECTION_OF] [SR_COMPANY_AND_PERSON] (MainHeading)",
  "MemberTabHeading": "[SR_COMPANY_AND_PERSON] (MemberTabeHeading)",
  "VisibleFor": [
    {
      "VisibleId": 0,
      "Visibility": "All",
    }
  ]
}
```

#### [WebApi Client](#tab/save-selection-entity-3)

```csharp
// setup access credentials
var authorization = new AuthorizationAccessToken("{access_token}", OnlineEnvironment.SOD);
var options = new WebApiOptions("https://sod.superoffice.com/Cust12345/api", authorization);

var selectionAgent = new SelectionAgent(config);
selectionEntity = await selectionAgent.CreateDefaultSelectionEntityAsync();
selectionEntity.Name = "Selections from API (Name)";
selectionEntity.Description = "Testing Selections (Description)";
selectionEntity.MailingsProviderName = "ContactPersonDynamicSelectionV2";
selectionEntity.SelectionCategory = new SelectionCategory() { Id = 2 };
selectionEntity.SelectionType = SelectionType.Dynamic;
selectionEntity.VisibleFor = new[] 
{
    new VisibleFor()
    {
        Visibility = Visibility.All,
        VisibleId = 0
    }
};

selectionEntity = await selectionAgent.SaveSelectionEntityAsync(selectionEntity);
```

___

> [!NOTE]
> When saving a selection, the default setting for populating the `VisibleFor` property looks at the user preferences. Section `Defaults` and key `DefaultSelectionVisibleFor`.
>
> The default value is 0 (All). Other options: 1 (Associate); 2 (Group). See the default preferences in Settings and maintenance for **Visibility for selections**.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/customer/news/product/9-2-find-selection/
[2]: ../../archive-providers/reference/appointmentdynamicselectionv2.md
[3]: ../../archive-providers/reference/contactpersondynamicselectionv2.md
[4]: typical-search.md
[5]: populate-selectable-columns.md
[6]: date-range-as-criteria.md
[7]: how-to-search.md#get-sr-find
[8]: how-to-search.md#get-data-source
[9]: how-to-search.md

<!-- Referenced images -->
[img1]: media/client-header-find.png
[img2]: media/selection-find-panel.png
[img3]: media/selection-search-panel.png
[img4]: media/selection-criteria-group-conceptual.png
[img5]: media/selection-criteria-groups-conceptual.png
