---
title: POST Agents/Selection/GetSelectionEntity
id: v1SelectionAgent_GetSelectionEntity
---

# POST Agents/Selection/GetSelectionEntity

```http
POST /api/v1/Agents/Selection/GetSelectionEntity
```

Gets a SelectionEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| selectionEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/GetSelectionEntity?selectionEntityId=256
POST /api/v1/Agents/Selection/GetSelectionEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Carrier object for SelectionEntity.
Services for the SelectionEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ISelectionAgent">Selection Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Associate |  | Owner of the selection |
| CreatedBy |  | Who created the selection |
| UpdatedBy |  | Who last modified the selection |
| SelectionCategory |  | Selection category type (list item)  <para>Use MDO List name "searchCat" to get list items.</para> |
| GroupIdx | int32 | Original primary user group of associate |
| IncludePerson | int32 | 0 = Include first person, 1 = Include all persons, 2 = Include no persons |
| MemberCount | int32 | How many selectionmembers (for progress bar calculations) - estimate, -1 (or 4294967295) means we don't know |
| Name | string | Name of selection, freetext indexed |
| PostitTextId | int32 | Postit text record id. |
| CreatedDate | date-time | Registered when  in UTC. |
| SelectionId | int32 | Primary key |
| SoundEx | string | What the name sounds like, for duplicate detection |
| Source | int32 | How did we get this selection? For future integration needs |
| TextId | int32 | Description text record id |
| UpdatedDate | date-time | Last updated when  in UTC. |
| UpdatedCount | int32 | Number of updates made to this record |
| Visibility | int32 | Obsolete, but still maintained denormalization of visiblefor |
| SelectionType | string | Static/Dynamic/Combined? |
| CompanyUnique | bool | Filter out duplicate members based on company? |
| TargetTableNumber | int32 | TargetTableNumber defines the type of selection members this selection contains. e.g. the table number for 'contact', or 'project' or 'sale' |
| TargetTableName | string | TargetTableName contains the name of the table in lowercase. defines the type of selection members this selection contains. e.g. 'contact', or 'project' or 'sale' |
| Completed | bool | The Completed state. |
| LeftSelectionId | int32 | LeftSelectionId is used in combination with RightSelectionId and CombinationType to define an union of two selections when SelectionType=Combined. |
| RightSelectionId | int32 | RightSelectionId  is used in combination with LeftSelectionId and CombinationType to define an union of two selections when SelectionType=Combined. |
| SelectionUnionType | string | How to combine the two selections when SelectionType = Combined. |
| MainProviderName | string | The name of the Archive Provider that will deliver the content of the archive - the actual entity rows |
| ShadowProviderName | string | The name, if relevant, of the Archive Provider that will deliver the Shadow rows: contact/person rows related to the actual entity. Can be blank, indicating that there is no shadow archive |
| ChartKey | string | ID/key of the last-used chart tile on this selection |
| LastLoaded | date-time | The date/time this selection was last loaded (selectionentity fetched) |
| LastLoadedBy | int32 | Who last loaded this selection |
| LastLoadedByAssociate |  | Associate that last looked at the selection members; only date (not time) is valid |
| LastMembershipChange | date-time | The date/time the membership the selection last changed. Dynamic: change of criteria; Static: add/remove members; Combined: change of algorithm |
| LastMembershipChangeBy | int32 | Who last changed the membership |
| LastMembershipChangeByAssociate |  | Associate that last changed the selection membership (static members, dynamic criteria, combined parameters); only date (not time) is valid |
| MainHeading | string | 'Static selection of Companies', or whatever else is appropriate, made by combining text resources for the type and the entity (plural form); this string will contain resource references |
| MemberTabHeading | string | 'Companies', or whatever else is appropriate - the plural form of the entity name; this string will contain resource references |
| MailingsProviderName | string | The name of the provider for the Mailings tab, if relevant; this string will contain resource references |
| DashboardTileDefinitionId | int32 | The associated tile definition |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/GetSelectionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Adaptive optimal installation",
  "Postit": "eum",
  "Associate": {
    "AssociateId": 949,
    "Name": "Pouros Inc and Sons",
    "PersonId": 79,
    "Rank": 146,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 239,
    "FullName": "Rebeka Haley",
    "FormalName": "Murphy-Strosin",
    "Deleted": false,
    "EjUserId": 796,
    "UserName": "Mayer-Ebert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 61
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 717,
    "Name": "Hodkiewicz-Fadel",
    "PersonId": 689,
    "Rank": 763,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 612,
    "FullName": "Ole Metz",
    "FormalName": "Fisher Inc and Sons",
    "Deleted": true,
    "EjUserId": 311,
    "UserName": "Schowalter LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 550
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 125,
    "Name": "Anderson, Terry and D'Amore",
    "PersonId": 907,
    "Rank": 860,
    "Tooltip": "adipisci",
    "Type": "AnonymousAssociate",
    "GroupIdx": 721,
    "FullName": "Bruce Wisoky",
    "FormalName": "Lowe-Hoppe",
    "Deleted": true,
    "EjUserId": 829,
    "UserName": "Bradtke, Grady and Kshlerin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 735
      }
    }
  },
  "SelectionCategory": {
    "Id": 293,
    "Value": "molestias",
    "Tooltip": "vel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 822
      }
    }
  },
  "GroupIdx": 228,
  "IncludePerson": 558,
  "MemberCount": 52,
  "Name": "Volkman, Jacobson and Jacobs",
  "PostitTextId": 949,
  "CreatedDate": "2007-08-12T18:28:50.2284467+02:00",
  "SelectionId": 502,
  "SoundEx": "nisi",
  "Source": 550,
  "TextId": 260,
  "UpdatedDate": "2017-05-18T18:28:50.2284467+02:00",
  "UpdatedCount": 576,
  "Visibility": 783,
  "SelectionType": "Combined",
  "CompanyUnique": true,
  "TargetTableNumber": 840,
  "TargetTableName": "Rosenbaum-Klocko",
  "Completed": true,
  "LeftSelectionId": 173,
  "RightSelectionId": 568,
  "SelectionUnionType": "Intersect",
  "MainProviderName": "Haley, Turner and Daniel",
  "ShadowProviderName": "Jacobs-O'Keefe",
  "ChartKey": "eum",
  "LastLoaded": "2020-09-30T18:28:50.2284467+02:00",
  "LastLoadedBy": 124,
  "LastLoadedByAssociate": {
    "AssociateId": 946,
    "Name": "Tillman, Lesch and Renner",
    "PersonId": 920,
    "Rank": 790,
    "Tooltip": "maxime",
    "Type": "AnonymousAssociate",
    "GroupIdx": 346,
    "FullName": "Alexis Kihn",
    "FormalName": "Reilly LLC",
    "Deleted": true,
    "EjUserId": 100,
    "UserName": "Lehner, Hegmann and Lowe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 327
      }
    }
  },
  "LastMembershipChange": "2003-06-05T18:28:50.2294485+02:00",
  "LastMembershipChangeBy": 942,
  "LastMembershipChangeByAssociate": {
    "AssociateId": 895,
    "Name": "Harvey, Lehner and Okuneva",
    "PersonId": 95,
    "Rank": 754,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 541,
    "FullName": "Oscar Senger",
    "FormalName": "Heaney-Spencer",
    "Deleted": false,
    "EjUserId": 730,
    "UserName": "Padberg Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 591
      }
    }
  },
  "MainHeading": "qui",
  "MemberTabHeading": "et",
  "MailingsProviderName": "Medhurst Inc and Sons",
  "DashboardTileDefinitionId": 452,
  "VisibleFor": [
    {
      "VisibleId": 851,
      "Visibility": "All",
      "DisplayValue": "earum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 772
        }
      }
    },
    {
      "VisibleId": 851,
      "Visibility": "All",
      "DisplayValue": "earum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 772
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 526
    }
  }
}
```