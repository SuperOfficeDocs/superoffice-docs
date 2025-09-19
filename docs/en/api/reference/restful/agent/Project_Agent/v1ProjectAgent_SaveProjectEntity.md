---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
content_type: reference
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is 0.








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

## Request Body: projectEntity 

The ProjectEntity that is saved 

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
  "ProjectId": 403,
  "Name": "Kuhn Group",
  "ProjectNumber": "1131539",
  "ProjectMembers": [
    {
      "ProjectmemberId": 761,
      "ContactId": 376,
      "ProjectId": 808,
      "ContactName": "Wunsch, Von and Langworth",
      "ContactDepartment": "",
      "ProjectName": "Christiansen-Rau",
      "EmailId": 82,
      "EmailAddress": "adele_johnston@cummings.biz",
      "CountryId": 151,
      "Firstname": "Norbert",
      "MiddleName": "Mann Inc and Sons",
      "Lastname": "Macejkovic",
      "PersonId": 341,
      "Mrmrs": "magni",
      "ProjectMemberTypeName": "Kerluke LLC",
      "Phone": "233.124.0636 x46175",
      "PhoneId": 139,
      "ProjectMemberTypeId": 521,
      "EmailAddressName": "arnaldo@oconnellcasper.us",
      "Comment": "quis",
      "FullName": "Bethel Spinka",
      "Registered": "2004-04-18T03:41:53.886968+02:00",
      "Updated": "2021-10-20T03:41:53.886968+02:00"
    }
  ],
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "dignissimos",
      "Description": "Synchronised analyzing alliance"
    },
    {
      "Value": "fuga",
      "StrippedValue": "dignissimos",
      "Description": "Synchronised analyzing alliance"
    }
  ],
  "CreatedDate": "2015-05-15T03:41:53.886968+02:00",
  "UpdatedDate": "2010-02-12T03:41:53.886968+01:00",
  "Description": "Optimized interactive groupware",
  "Postit": "totam",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Multi-layered national encryption",
  "ActiveStatusMonitorId": 20,
  "Links": [
    {
      "EntityName": "Collier Group",
      "Id": 956,
      "Description": "Function-based secondary implementation",
      "ExtraInfo": "officiis",
      "LinkId": 818
    },
    {
      "EntityName": "Collier Group",
      "Id": 956,
      "Description": "Function-based secondary implementation",
      "ExtraInfo": "officiis",
      "LinkId": 818
    }
  ],
  "ActiveLinks": 558,
  "Completed": true,
  "NextMilestoneDate": "2009-10-20T03:41:53.886968+02:00",
  "NmdAppointmentId": 206,
  "EndDate": "2021-09-09T03:41:53.886968+02:00",
  "ActiveErpLinks": 616,
  "UserDefinedFields": {
    "SuperOffice:1": "2099153899",
    "SuperOffice:2": "1285398046"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "sint"
  },
  "PublishEventDate": "2019-07-07T03:41:53.886968+02:00",
  "PublishTo": "2022-11-25T03:41:53.886968+01:00",
  "PublishFrom": "2003-01-10T03:41:53.886968+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 410,
  "Name": "Braun, Labadie and Zieme",
  "ProjectNumber": "1150857",
  "ProjectMembers": [
    {
      "ProjectmemberId": 207,
      "ContactId": 483,
      "ProjectId": 670,
      "ContactName": "Schumm Group",
      "ContactDepartment": "",
      "ProjectName": "Larson, Paucek and Dickinson",
      "EmailId": 677,
      "EmailAddress": "emmitt@lang.ca",
      "CountryId": 995,
      "Firstname": "Raul",
      "MiddleName": "Osinski Group",
      "Lastname": "Donnelly",
      "PersonId": 835,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "VonRueden-Murazik",
      "Phone": "1-842-411-7398 x691",
      "PhoneId": 152,
      "ProjectMemberTypeId": 831,
      "EmailAddressName": "madelyn@wolff.uk",
      "Comment": "vitae",
      "FullName": "Natalia Upton",
      "Registered": "2001-10-01T03:41:53.886968+02:00",
      "Updated": "2008-06-24T03:41:53.886968+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nulla",
      "StrippedValue": "quod",
      "Description": "Enhanced uniform framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 437
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "quod",
      "Description": "Enhanced uniform framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 437
        }
      }
    }
  ],
  "CreatedDate": "2011-03-19T03:41:53.886968+01:00",
  "UpdatedDate": "2000-05-20T03:41:53.886968+02:00",
  "Description": "Sharable bi-directional firmware",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Virtual background parallelism",
  "ActiveStatusMonitorId": 666,
  "Links": [
    {
      "EntityName": "Emard LLC",
      "Id": 265,
      "Description": "Robust logistical customer loyalty",
      "ExtraInfo": "nisi",
      "LinkId": 976,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    }
  ],
  "ActiveLinks": 199,
  "Completed": true,
  "NextMilestoneDate": "2022-07-27T03:41:53.886968+02:00",
  "NmdAppointmentId": 381,
  "EndDate": "2018-01-14T03:41:53.886968+01:00",
  "ActiveErpLinks": 104,
  "UserDefinedFields": {
    "SuperOffice:1": "1759469272",
    "SuperOffice:2": "2084184695"
  },
  "ExtraFields": {
    "ExtraFields1": "necessitatibus",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "saepe",
    "CustomFields2": "quas"
  },
  "PublishEventDate": "2021-08-27T03:41:53.886968+02:00",
  "PublishTo": "2001-10-10T03:41:53.886968+02:00",
  "PublishFrom": "2011-10-29T03:41:53.886968+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 803
    }
  }
}
```