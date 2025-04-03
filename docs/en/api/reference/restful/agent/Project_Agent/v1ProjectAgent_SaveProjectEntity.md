---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The ProjectEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 514,
  "Name": "O'Kon, Hartmann and Hudson",
  "ProjectNumber": "1302525",
  "ProjectMembers": [
    {
      "ProjectmemberId": 650,
      "ContactId": 956,
      "ProjectId": 638,
      "ContactName": "Becker, D'Amore and Terry",
      "ContactDepartment": "",
      "ProjectName": "Swift LLC",
      "EmailId": 711,
      "EmailAddress": "vernice@kohler.name",
      "CountryId": 688,
      "Firstname": "Myles",
      "MiddleName": "Morissette, Koss and Jacobson",
      "Lastname": "Haley",
      "PersonId": 764,
      "Mrmrs": "quos",
      "ProjectMemberTypeName": "Bednar-Renner",
      "Phone": "1-638-865-7422 x67832",
      "PhoneId": 591,
      "ProjectMemberTypeId": 754,
      "EmailAddressName": "colin_krajcik@corkery.name",
      "Comment": "autem",
      "FullName": "Kianna Ryan"
    }
  ],
  "Urls": [
    {
      "Value": "ducimus",
      "StrippedValue": "porro",
      "Description": "Enhanced uniform encryption"
    },
    {
      "Value": "ducimus",
      "StrippedValue": "porro",
      "Description": "Enhanced uniform encryption"
    }
  ],
  "CreatedDate": "2014-11-01T14:28:22.242884+01:00",
  "UpdatedDate": "2016-03-20T14:28:22.242884+01:00",
  "Description": "Synchronised global function",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Function-based fresh-thinking internet solution",
  "ActiveStatusMonitorId": 76,
  "Links": [
    {
      "EntityName": "Kutch Group",
      "Id": 466,
      "Description": "Multi-tiered demand-driven intranet",
      "ExtraInfo": "ipsa",
      "LinkId": 979
    },
    {
      "EntityName": "Kutch Group",
      "Id": 466,
      "Description": "Multi-tiered demand-driven intranet",
      "ExtraInfo": "ipsa",
      "LinkId": 979
    }
  ],
  "ActiveLinks": 753,
  "Completed": false,
  "NextMilestoneDate": "2007-11-02T14:28:22.242884+01:00",
  "NmdAppointmentId": 152,
  "EndDate": "2021-07-15T14:28:22.242884+02:00",
  "ActiveErpLinks": 394,
  "UserDefinedFields": {
    "SuperOffice:1": "303926926",
    "SuperOffice:2": "Louvenia Larson"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "ipsam",
    "CustomFields2": "est"
  },
  "PublishEventDate": "2003-09-22T14:28:22.242884+02:00",
  "PublishTo": "1999-09-25T14:28:22.242884+02:00",
  "PublishFrom": "2021-05-13T14:28:22.242884+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 596,
  "Name": "Zemlak-Buckridge",
  "ProjectNumber": "1000366",
  "ProjectMembers": [
    {
      "ProjectmemberId": 216,
      "ContactId": 573,
      "ProjectId": 22,
      "ContactName": "Konopelski Inc and Sons",
      "ContactDepartment": "mesh sticky deliverables",
      "ProjectName": "Lowe Group",
      "EmailId": 167,
      "EmailAddress": "henderson@mosciskicollier.us",
      "CountryId": 111,
      "Firstname": "Ariel",
      "MiddleName": "Luettgen, Carroll and Deckow",
      "Lastname": "Feil",
      "PersonId": 389,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Muller-Daniel",
      "Phone": "503.907.6813",
      "PhoneId": 143,
      "ProjectMemberTypeId": 263,
      "EmailAddressName": "cary_lebsack@sauer.uk",
      "Comment": "voluptas",
      "FullName": "Mr. Timmy Hauck",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 760
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "et",
      "Description": "Organized intermediate instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 798
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "et",
      "Description": "Organized intermediate instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 798
        }
      }
    }
  ],
  "CreatedDate": "2025-02-23T14:28:22.242884+01:00",
  "UpdatedDate": "2013-12-13T14:28:22.242884+01:00",
  "Description": "Grass-roots uniform intranet",
  "Postit": "cupiditate",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Multi-lateral real-time alliance",
  "ActiveStatusMonitorId": 252,
  "Links": [
    {
      "EntityName": "Balistreri-Ratke",
      "Id": 358,
      "Description": "Focused multi-state budgetary management",
      "ExtraInfo": "recusandae",
      "LinkId": 449,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 735
        }
      }
    }
  ],
  "ActiveLinks": 393,
  "Completed": false,
  "NextMilestoneDate": "2003-05-23T14:28:22.242884+02:00",
  "NmdAppointmentId": 257,
  "EndDate": "2014-03-28T14:28:22.242884+01:00",
  "ActiveErpLinks": 176,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1161175676"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "quas"
  },
  "PublishEventDate": "2004-04-28T14:28:22.242884+02:00",
  "PublishTo": "2010-04-05T14:28:22.242884+02:00",
  "PublishFrom": "2022-05-20T14:28:22.242884+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 65
    }
  }
}
```