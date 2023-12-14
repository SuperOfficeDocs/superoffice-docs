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
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "ProjectId": 698,
  "Name": "Murazik LLC",
  "ProjectNumber": "1394104",
  "ProjectMembers": [
    {
      "ProjectmemberId": 585,
      "ContactId": 768,
      "ProjectId": 944,
      "ContactName": "Mueller Group",
      "ContactDepartment": "",
      "ProjectName": "Koch, Trantow and Rogahn",
      "EmailId": 888,
      "EmailAddress": "emil@terryschowalter.name",
      "CountryId": 792,
      "Firstname": "Bettye",
      "MiddleName": "Johnson-Gulgowski",
      "Lastname": "Haley",
      "PersonId": 37,
      "Mrmrs": "temporibus",
      "ProjectMemberTypeName": "Deckow, Schuster and Conn",
      "Phone": "(342)944-1167",
      "PhoneId": 40,
      "ProjectMemberTypeId": 821,
      "EmailAddressName": "trey@bednarryan.name",
      "Comment": "at",
      "FullName": "Prof. Alan Klein"
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "deleniti",
      "Description": "Secured context-sensitive toolset"
    },
    {
      "Value": "et",
      "StrippedValue": "deleniti",
      "Description": "Secured context-sensitive toolset"
    }
  ],
  "CreatedDate": "2012-05-20T13:57:12.8281807+02:00",
  "UpdatedDate": "2002-09-17T13:57:12.8281807+02:00",
  "Description": "Progressive even-keeled functionalities",
  "Postit": "reprehenderit",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Integrated mission-critical matrices",
  "ActiveStatusMonitorId": 397,
  "Links": [
    {
      "EntityName": "Bednar, Ryan and Schumm",
      "Id": 637,
      "Description": "Devolved background internet solution",
      "ExtraInfo": "consequatur",
      "LinkId": 645
    },
    {
      "EntityName": "Bednar, Ryan and Schumm",
      "Id": 637,
      "Description": "Devolved background internet solution",
      "ExtraInfo": "consequatur",
      "LinkId": 645
    }
  ],
  "ActiveLinks": 986,
  "Completed": false,
  "NextMilestoneDate": "2016-08-15T13:57:12.8281807+02:00",
  "NmdAppointmentId": 592,
  "EndDate": "2002-01-14T13:57:12.8281807+01:00",
  "ActiveErpLinks": 44,
  "UserDefinedFields": {
    "SuperOffice:1": "Paige Hudson",
    "SuperOffice:2": "1035698201"
  },
  "ExtraFields": {
    "ExtraFields1": "modi",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "vero",
    "CustomFields2": "suscipit"
  },
  "PublishEventDate": "1998-11-14T13:57:12.8281807+01:00",
  "PublishTo": "2010-05-25T13:57:12.8281807+02:00",
  "PublishFrom": "2001-05-02T13:57:12.8281807+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 940,
  "Name": "Breitenberg-Herzog",
  "ProjectNumber": "786484",
  "ProjectMembers": [
    {
      "ProjectmemberId": 704,
      "ContactId": 256,
      "ProjectId": 628,
      "ContactName": "Torp LLC",
      "ContactDepartment": "",
      "ProjectName": "Toy-Langworth",
      "EmailId": 914,
      "EmailAddress": "francesco@rauprosacco.info",
      "CountryId": 694,
      "Firstname": "Caroline",
      "MiddleName": "Mante-Collier",
      "Lastname": "Willms",
      "PersonId": 454,
      "Mrmrs": "ad",
      "ProjectMemberTypeName": "Robel-Raynor",
      "Phone": "1-249-649-4753 x7331",
      "PhoneId": 814,
      "ProjectMemberTypeId": 349,
      "EmailAddressName": "miguel@nicolas.com",
      "Comment": "ex",
      "FullName": "Heaven Ruecker III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "dicta",
      "Description": "Public-key optimal middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 709
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "dicta",
      "Description": "Public-key optimal middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 709
        }
      }
    }
  ],
  "CreatedDate": "2011-03-16T13:57:12.8281807+01:00",
  "UpdatedDate": "2023-07-20T13:57:12.8281807+02:00",
  "Description": "Operative upward-trending matrix",
  "Postit": "aut",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Face to face national adapter",
  "ActiveStatusMonitorId": 426,
  "Links": [
    {
      "EntityName": "Parisian-Wehner",
      "Id": 201,
      "Description": "Cross-group system-worthy process improvement",
      "ExtraInfo": "expedita",
      "LinkId": 686,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 470
        }
      }
    }
  ],
  "ActiveLinks": 194,
  "Completed": false,
  "NextMilestoneDate": "2006-12-02T13:57:12.8281807+01:00",
  "NmdAppointmentId": 216,
  "EndDate": "2004-12-04T13:57:12.8281807+01:00",
  "ActiveErpLinks": 328,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Alexandrea Reynolds PhD",
    "SuperOffice:2": "Dulce Forest Nienow Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "totam",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "recusandae"
  },
  "PublishEventDate": "2011-03-12T13:57:12.8437627+01:00",
  "PublishTo": "2021-09-21T13:57:12.8437627+02:00",
  "PublishFrom": "2008-11-22T13:57:12.8437627+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 385
    }
  }
}
```