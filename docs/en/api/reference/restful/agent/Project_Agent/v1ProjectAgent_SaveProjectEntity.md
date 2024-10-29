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
  "ProjectId": 811,
  "Name": "Robel-Dach",
  "ProjectNumber": "791352",
  "ProjectMembers": [
    {
      "ProjectmemberId": 7,
      "ContactId": 964,
      "ProjectId": 64,
      "ContactName": "Hilpert, Barrows and Hartmann",
      "ContactDepartment": "visualize open-source solutions",
      "ProjectName": "Purdy Inc and Sons",
      "EmailId": 63,
      "EmailAddress": "carter.kuhic@monahan.name",
      "CountryId": 53,
      "Firstname": "Phoebe",
      "MiddleName": "Emard Group",
      "Lastname": "Braun",
      "PersonId": 56,
      "Mrmrs": "rerum",
      "ProjectMemberTypeName": "Connelly-Kihn",
      "Phone": "581-515-8517 x828",
      "PhoneId": 293,
      "ProjectMemberTypeId": 233,
      "EmailAddressName": "kennedy@dickens.co.uk",
      "Comment": "repellat",
      "FullName": "Karolann Hirthe"
    }
  ],
  "Urls": [
    {
      "Value": "quae",
      "StrippedValue": "excepturi",
      "Description": "Multi-tiered reciprocal hierarchy"
    },
    {
      "Value": "quae",
      "StrippedValue": "excepturi",
      "Description": "Multi-tiered reciprocal hierarchy"
    }
  ],
  "CreatedDate": "2021-01-10T13:14:06.2570472+01:00",
  "UpdatedDate": "2010-12-11T13:14:06.2570472+01:00",
  "Description": "Diverse global open architecture",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Multi-channelled neutral workforce",
  "ActiveStatusMonitorId": 720,
  "Links": [
    {
      "EntityName": "Douglas Group",
      "Id": 490,
      "Description": "Reduced asynchronous architecture",
      "ExtraInfo": "et",
      "LinkId": 681
    },
    {
      "EntityName": "Douglas Group",
      "Id": 490,
      "Description": "Reduced asynchronous architecture",
      "ExtraInfo": "et",
      "LinkId": 681
    }
  ],
  "ActiveLinks": 944,
  "Completed": false,
  "NextMilestoneDate": "2015-02-27T13:14:06.2570472+01:00",
  "NmdAppointmentId": 289,
  "EndDate": "2017-11-12T13:14:06.2570472+01:00",
  "ActiveErpLinks": 298,
  "UserDefinedFields": {
    "SuperOffice:1": "Vicenta Reese Stark IV",
    "SuperOffice:2": "Mrs. Chet Anita Thiel I"
  },
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "officia"
  },
  "PublishEventDate": "2011-10-21T13:14:06.2570472+02:00",
  "PublishTo": "2019-03-30T13:14:06.2570472+01:00",
  "PublishFrom": "2020-09-06T13:14:06.2570472+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 283,
  "Name": "Hodkiewicz, Balistreri and Morar",
  "ProjectNumber": "1532485",
  "ProjectMembers": [
    {
      "ProjectmemberId": 927,
      "ContactId": 549,
      "ProjectId": 902,
      "ContactName": "VonRueden, Harris and Watsica",
      "ContactDepartment": "",
      "ProjectName": "McKenzie LLC",
      "EmailId": 666,
      "EmailAddress": "dominic@schmeler.ca",
      "CountryId": 14,
      "Firstname": "Frieda",
      "MiddleName": "Mosciski-Schamberger",
      "Lastname": "Homenick",
      "PersonId": 251,
      "Mrmrs": "fugiat",
      "ProjectMemberTypeName": "Satterfield, Mann and Braun",
      "Phone": "308.010.8250 x90020",
      "PhoneId": 139,
      "ProjectMemberTypeId": 436,
      "EmailAddressName": "kyra@ritchie.info",
      "Comment": "aliquid",
      "FullName": "Mr. Eriberto Mertz MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 627
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aliquid",
      "StrippedValue": "omnis",
      "Description": "Phased object-oriented hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "omnis",
      "Description": "Phased object-oriented hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    }
  ],
  "CreatedDate": "2017-04-15T13:14:06.2726729+02:00",
  "UpdatedDate": "2001-03-24T13:14:06.2726729+01:00",
  "Description": "User-friendly zero defect emulation",
  "Postit": "unde",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Open-source 5th generation array",
  "ActiveStatusMonitorId": 747,
  "Links": [
    {
      "EntityName": "Crona, Lockman and Kassulke",
      "Id": 128,
      "Description": "Stand-alone analyzing solution",
      "ExtraInfo": "repellendus",
      "LinkId": 849,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "ActiveLinks": 647,
  "Completed": false,
  "NextMilestoneDate": "2014-09-10T13:14:06.2726729+02:00",
  "NmdAppointmentId": 786,
  "EndDate": "2016-08-01T13:14:06.2726729+02:00",
  "ActiveErpLinks": 158,
  "UserDefinedFields": {
    "SuperOffice:1": "Monserrat Jast",
    "SuperOffice:2": "Ms. Erick Katrina Marquardt I"
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "beatae"
  },
  "PublishEventDate": "1998-11-23T13:14:06.2726729+01:00",
  "PublishTo": "2005-10-19T13:14:06.2726729+02:00",
  "PublishFrom": "2017-06-30T13:14:06.2726729+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 445
    }
  }
}
```