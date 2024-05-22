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
  "ProjectId": 753,
  "Name": "Gaylord-Bogan",
  "ProjectNumber": "285077",
  "ProjectMembers": [
    {
      "ProjectmemberId": 5,
      "ContactId": 762,
      "ProjectId": 376,
      "ContactName": "Smith, Nitzsche and Jakubowski",
      "ContactDepartment": "synergize best-of-breed interfaces",
      "ProjectName": "Medhurst, Abbott and O'Kon",
      "EmailId": 384,
      "EmailAddress": "floy_lindgren@lockman.co.uk",
      "CountryId": 39,
      "Firstname": "Neva",
      "MiddleName": "Ernser-Johns",
      "Lastname": "Turcotte",
      "PersonId": 539,
      "Mrmrs": "vel",
      "ProjectMemberTypeName": "Kerluke, Welch and Ratke",
      "Phone": "(014)595-9117 x42411",
      "PhoneId": 774,
      "ProjectMemberTypeId": 80,
      "EmailAddressName": "abigale.jenkins@kuvalis.us",
      "Comment": "et",
      "FullName": "Rosendo Mante"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "voluptatibus",
      "Description": "Persistent solution-oriented structure"
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptatibus",
      "Description": "Persistent solution-oriented structure"
    }
  ],
  "CreatedDate": "2007-09-06T12:57:34.6178406+02:00",
  "UpdatedDate": "1997-10-21T12:57:34.6178406+02:00",
  "Description": "Pre-emptive methodical encoding",
  "Postit": "voluptatem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Monitored zero tolerance model",
  "ActiveStatusMonitorId": 351,
  "Links": [
    {
      "EntityName": "Crona-Pacocha",
      "Id": 603,
      "Description": "Focused neutral pricing structure",
      "ExtraInfo": "nam",
      "LinkId": 882
    },
    {
      "EntityName": "Crona-Pacocha",
      "Id": 603,
      "Description": "Focused neutral pricing structure",
      "ExtraInfo": "nam",
      "LinkId": 882
    }
  ],
  "ActiveLinks": 868,
  "Completed": false,
  "NextMilestoneDate": "2008-07-21T12:57:34.6178406+02:00",
  "NmdAppointmentId": 359,
  "EndDate": "2011-12-13T12:57:34.6178406+01:00",
  "ActiveErpLinks": 398,
  "UserDefinedFields": {
    "SuperOffice:1": "2119415110",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "illo"
  },
  "PublishEventDate": "2009-08-14T12:57:34.6178406+02:00",
  "PublishTo": "2024-01-10T12:57:34.6178406+01:00",
  "PublishFrom": "2015-02-23T12:57:34.6178406+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 60,
  "Name": "Bayer, Hackett and Gottlieb",
  "ProjectNumber": "902118",
  "ProjectMembers": [
    {
      "ProjectmemberId": 924,
      "ContactId": 757,
      "ProjectId": 160,
      "ContactName": "Okuneva LLC",
      "ContactDepartment": "",
      "ProjectName": "Kub-Buckridge",
      "EmailId": 249,
      "EmailAddress": "jana@sipesbreitenberg.co.uk",
      "CountryId": 386,
      "Firstname": "Khalil",
      "MiddleName": "Willms, Spencer and Jerde",
      "Lastname": "Dicki",
      "PersonId": 464,
      "Mrmrs": "voluptas",
      "ProjectMemberTypeName": "Sauer-Tromp",
      "Phone": "(508)796-4648",
      "PhoneId": 763,
      "ProjectMemberTypeId": 1001,
      "EmailAddressName": "johnathan@wintheiser.info",
      "Comment": "dicta",
      "FullName": "Rosetta Barrows",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fugiat",
      "StrippedValue": "dolorum",
      "Description": "Assimilated incremental core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 678
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "dolorum",
      "Description": "Assimilated incremental core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 678
        }
      }
    }
  ],
  "CreatedDate": "2021-10-27T12:57:34.6178406+02:00",
  "UpdatedDate": "2016-12-08T12:57:34.6178406+01:00",
  "Description": "Streamlined system-worthy open architecture",
  "Postit": "blanditiis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Versatile demand-driven instruction set",
  "ActiveStatusMonitorId": 896,
  "Links": [
    {
      "EntityName": "Schimmel-Brown",
      "Id": 782,
      "Description": "Synergistic 24 hour policy",
      "ExtraInfo": "aut",
      "LinkId": 190,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 500
        }
      }
    }
  ],
  "ActiveLinks": 967,
  "Completed": false,
  "NextMilestoneDate": "2006-02-11T12:57:34.6178406+01:00",
  "NmdAppointmentId": 572,
  "EndDate": "2001-01-11T12:57:34.6178406+01:00",
  "ActiveErpLinks": 14,
  "UserDefinedFields": {
    "SuperOffice:1": "1082697788",
    "SuperOffice:2": "Danielle Haag"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "vero"
  },
  "PublishEventDate": "2016-05-21T12:57:34.6178406+02:00",
  "PublishTo": "2003-05-04T12:57:34.6178406+02:00",
  "PublishFrom": "2015-11-30T12:57:34.6178406+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 906
    }
  }
}
```