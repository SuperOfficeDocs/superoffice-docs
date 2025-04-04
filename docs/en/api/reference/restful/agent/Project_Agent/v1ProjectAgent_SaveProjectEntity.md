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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 209,
  "Name": "Mraz-Kulas",
  "ProjectNumber": "1383410",
  "ProjectMembers": [
    {
      "ProjectmemberId": 49,
      "ContactId": 63,
      "ProjectId": 492,
      "ContactName": "Gerhold LLC",
      "ContactDepartment": "",
      "ProjectName": "Huels Inc and Sons",
      "EmailId": 65,
      "EmailAddress": "janick.auer@treutel.uk",
      "CountryId": 192,
      "Firstname": "Roselyn",
      "MiddleName": "Erdman Group",
      "Lastname": "Prohaska",
      "PersonId": 347,
      "Mrmrs": "dignissimos",
      "ProjectMemberTypeName": "Lind Group",
      "Phone": "126.408.8226 x95576",
      "PhoneId": 461,
      "ProjectMemberTypeId": 338,
      "EmailAddressName": "burdette@franecki.uk",
      "Comment": "odit",
      "FullName": "Tyrell Schroeder"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "sunt",
      "Description": "Multi-lateral asynchronous task-force"
    },
    {
      "Value": "qui",
      "StrippedValue": "sunt",
      "Description": "Multi-lateral asynchronous task-force"
    }
  ],
  "CreatedDate": "2016-12-20T13:14:00.8919565+01:00",
  "UpdatedDate": "2010-11-05T13:14:00.8919565+01:00",
  "Description": "Multi-layered leading edge challenge",
  "Postit": "temporibus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Balanced hybrid infrastructure",
  "ActiveStatusMonitorId": 614,
  "Links": [
    {
      "EntityName": "Dooley-Schultz",
      "Id": 531,
      "Description": "Balanced executive open architecture",
      "ExtraInfo": "ea",
      "LinkId": 345
    },
    {
      "EntityName": "Dooley-Schultz",
      "Id": 531,
      "Description": "Balanced executive open architecture",
      "ExtraInfo": "ea",
      "LinkId": 345
    }
  ],
  "ActiveLinks": 414,
  "Completed": true,
  "NextMilestoneDate": "2003-04-17T13:14:00.8919565+02:00",
  "NmdAppointmentId": 520,
  "EndDate": "2014-03-19T13:14:00.8919565+01:00",
  "ActiveErpLinks": 938,
  "UserDefinedFields": {
    "SuperOffice:1": "982226209",
    "SuperOffice:2": "622208260"
  },
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "quos"
  },
  "PublishEventDate": "2007-05-25T13:14:00.8919565+02:00",
  "PublishTo": "2014-04-13T13:14:00.8919565+02:00",
  "PublishFrom": "2023-10-26T13:14:00.8919565+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 188,
  "Name": "Klocko-Carter",
  "ProjectNumber": "1724646",
  "ProjectMembers": [
    {
      "ProjectmemberId": 495,
      "ContactId": 230,
      "ProjectId": 741,
      "ContactName": "Sauer-Rogahn",
      "ContactDepartment": "benchmark rich e-commerce",
      "ProjectName": "Conroy, Von and Marvin",
      "EmailId": 33,
      "EmailAddress": "payton.hand@ruecker.biz",
      "CountryId": 488,
      "Firstname": "Francisca",
      "MiddleName": "Langosh LLC",
      "Lastname": "Kutch",
      "PersonId": 574,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Von Group",
      "Phone": "523.776.1175",
      "PhoneId": 410,
      "ProjectMemberTypeId": 337,
      "EmailAddressName": "ebony@beer.name",
      "Comment": "quisquam",
      "FullName": "Kaleigh Schmeler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 276
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Programmable zero tolerance pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Programmable zero tolerance pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    }
  ],
  "CreatedDate": "2003-11-16T13:14:00.8919565+01:00",
  "UpdatedDate": "2011-04-05T13:14:00.8919565+02:00",
  "Description": "Expanded demand-driven orchestration",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Reverse-engineered client-server support",
  "ActiveStatusMonitorId": 458,
  "Links": [
    {
      "EntityName": "Rohan, Crooks and Ernser",
      "Id": 219,
      "Description": "Seamless scalable task-force",
      "ExtraInfo": "voluptatem",
      "LinkId": 557,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    }
  ],
  "ActiveLinks": 755,
  "Completed": false,
  "NextMilestoneDate": "2010-02-15T13:14:00.8919565+01:00",
  "NmdAppointmentId": 521,
  "EndDate": "2004-02-03T13:14:00.8919565+01:00",
  "ActiveErpLinks": 322,
  "UserDefinedFields": {
    "SuperOffice:1": "Haskell Collins",
    "SuperOffice:2": "Santina Arthur Corwin MD"
  },
  "ExtraFields": {
    "ExtraFields1": "hic",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "dolorum"
  },
  "PublishEventDate": "2002-09-18T13:14:00.8919565+02:00",
  "PublishTo": "2018-12-11T13:14:00.8919565+01:00",
  "PublishFrom": "2023-07-10T13:14:00.8919565+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 685
    }
  }
}
```