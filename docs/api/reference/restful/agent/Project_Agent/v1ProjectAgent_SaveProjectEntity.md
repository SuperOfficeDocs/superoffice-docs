---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
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
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 4,
  "Name": "Lueilwitz, Hoppe and Schimmel",
  "ProjectNumber": "1927960",
  "ProjectMembers": [
    {
      "ProjectmemberId": 986,
      "ContactId": 260,
      "ProjectId": 576,
      "ContactName": "Kub, Christiansen and Wisoky",
      "ContactDepartment": "",
      "ProjectName": "Jewess, Orn and Beatty",
      "EmailId": 156,
      "EmailAddress": "edwin.gutmann@parisian.biz",
      "CountryId": 337,
      "Firstname": "Josue",
      "MiddleName": "Kessler, Parker and Bogan",
      "Lastname": "Leffler",
      "PersonId": 73,
      "Mrmrs": "autem",
      "ProjectMemberTypeName": "Windler, Brekke and Sawayn",
      "Phone": "1-338-585-4915 x8901",
      "PhoneId": 169,
      "ProjectMemberTypeId": 264,
      "EmailAddressName": "aurore@jast.biz",
      "Comment": "libero",
      "FullName": "Ms. Doyle Prohaska"
    }
  ],
  "Urls": [
    {
      "Value": "ullam",
      "StrippedValue": "eius",
      "Description": "Devolved impactful database"
    },
    {
      "Value": "ullam",
      "StrippedValue": "eius",
      "Description": "Devolved impactful database"
    }
  ],
  "CreatedDate": "2002-12-11T11:10:27.565453+01:00",
  "UpdatedDate": "2005-08-16T11:10:27.565453+02:00",
  "Description": "Function-based eco-centric initiative",
  "Postit": "unde",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Optimized local local area network",
  "ActiveStatusMonitorId": 273,
  "Links": [
    {
      "EntityName": "Bogisich-Stanton",
      "Id": 199,
      "Description": "Intuitive didactic concept",
      "ExtraInfo": "voluptatem",
      "LinkId": 446
    },
    {
      "EntityName": "Bogisich-Stanton",
      "Id": 199,
      "Description": "Intuitive didactic concept",
      "ExtraInfo": "voluptatem",
      "LinkId": 446
    }
  ],
  "ActiveLinks": 363,
  "Completed": true,
  "NextMilestoneDate": "2014-07-23T11:10:27.5674548+02:00",
  "NmdAppointmentId": 77,
  "EndDate": "2001-10-23T11:10:27.5674548+02:00",
  "ActiveErpLinks": 833,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "hic",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "modi",
    "CustomFields2": "adipisci"
  },
  "PublishEventDate": "2019-10-22T11:10:27.5674548+02:00",
  "PublishTo": "2000-10-24T11:10:27.5674548+02:00",
  "PublishFrom": "2000-09-04T11:10:27.5674548+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 576,
  "Name": "Blick-Hettinger",
  "ProjectNumber": "647939",
  "ProjectMembers": [
    {
      "ProjectmemberId": 374,
      "ContactId": 528,
      "ProjectId": 497,
      "ContactName": "Collier Group",
      "ContactDepartment": "",
      "ProjectName": "Olson-Gulgowski",
      "EmailId": 506,
      "EmailAddress": "frank_wolf@orn.uk",
      "CountryId": 244,
      "Firstname": "Shyann",
      "MiddleName": "Abshire, Larson and Runolfsson",
      "Lastname": "Spencer",
      "PersonId": 376,
      "Mrmrs": "non",
      "ProjectMemberTypeName": "Grant, Bahringer and Bednar",
      "Phone": "(826)603-7375 x076",
      "PhoneId": 677,
      "ProjectMemberTypeId": 195,
      "EmailAddressName": "pansy_gutmann@blanda.co.uk",
      "Comment": "hic",
      "FullName": "Stacey Marks",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 792
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "in",
      "Description": "Enterprise-wide exuding circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "in",
      "Description": "Enterprise-wide exuding circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    }
  ],
  "CreatedDate": "2015-12-20T11:10:27.5714526+01:00",
  "UpdatedDate": "1995-08-09T11:10:27.5714526+02:00",
  "Description": "Multi-layered upward-trending pricing structure",
  "Postit": "natus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Organic leading edge superstructure",
  "ActiveStatusMonitorId": 908,
  "Links": [
    {
      "EntityName": "Huels LLC",
      "Id": 17,
      "Description": "User-friendly cohesive capability",
      "ExtraInfo": "et",
      "LinkId": 170,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 545
        }
      }
    }
  ],
  "ActiveLinks": 639,
  "Completed": true,
  "NextMilestoneDate": "2008-08-14T11:10:27.5744521+02:00",
  "NmdAppointmentId": 376,
  "EndDate": "2021-07-31T11:10:27.5744521+02:00",
  "ActiveErpLinks": 188,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Mabelle Treutel MD",
    "SuperOffice:2": "Cortez Braun"
  },
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "blanditiis"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "consequuntur"
  },
  "PublishEventDate": "2006-01-21T11:10:27.5744521+01:00",
  "PublishTo": "2020-02-12T11:10:27.5744521+01:00",
  "PublishFrom": "2007-05-30T11:10:27.5744521+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 211
    }
  }
}
```
