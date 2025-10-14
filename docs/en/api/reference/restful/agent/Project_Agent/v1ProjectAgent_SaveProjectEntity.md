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


NsApiSlow threshold: 2000 ms.







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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 195,
  "Name": "Jast-Trantow",
  "ProjectNumber": "864783",
  "ProjectMembers": [
    {
      "ProjectmemberId": 974,
      "ContactId": 74,
      "ProjectId": 1001,
      "ContactName": "Leannon-Thompson",
      "ContactDepartment": "",
      "ProjectName": "Shanahan Group",
      "EmailId": 539,
      "EmailAddress": "lempi@kassulke.us",
      "CountryId": 717,
      "Firstname": "Stewart",
      "MiddleName": "Renner, Rodriguez and Strosin",
      "Lastname": "Schinner",
      "PersonId": 886,
      "Mrmrs": "in",
      "ProjectMemberTypeName": "Kuhic-Emard",
      "Phone": "830.275.4592 x757",
      "PhoneId": 947,
      "ProjectMemberTypeId": 790,
      "EmailAddressName": "rosalind_schaefer@bayer.name",
      "Comment": "nesciunt",
      "FullName": "Raoul Savion Hammes III",
      "Registered": "2020-09-26T03:40:47.4531039+02:00",
      "Updated": "2003-02-12T03:40:47.4531039+01:00"
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "est",
      "Description": "Polarised encompassing internet solution"
    },
    {
      "Value": "non",
      "StrippedValue": "est",
      "Description": "Polarised encompassing internet solution"
    }
  ],
  "CreatedDate": "2019-01-15T03:40:47.4531039+01:00",
  "UpdatedDate": "2014-03-28T03:40:47.4531039+01:00",
  "Description": "Implemented context-sensitive challenge",
  "Postit": "blanditiis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Quality-focused multi-tasking synergy",
  "ActiveStatusMonitorId": 426,
  "Links": [
    {
      "EntityName": "Jewess-Jewess",
      "Id": 414,
      "Description": "Profit-focused high-level implementation",
      "ExtraInfo": "consequatur",
      "LinkId": 12
    },
    {
      "EntityName": "Jewess-Jewess",
      "Id": 414,
      "Description": "Profit-focused high-level implementation",
      "ExtraInfo": "consequatur",
      "LinkId": 12
    }
  ],
  "ActiveLinks": 221,
  "Completed": false,
  "NextMilestoneDate": "2020-08-04T03:40:47.4687299+02:00",
  "NmdAppointmentId": 347,
  "EndDate": "2014-07-27T03:40:47.4687299+02:00",
  "ActiveErpLinks": 558,
  "UserDefinedFields": {
    "SuperOffice:1": "Martina Rosenbaum",
    "SuperOffice:2": "Veda Sporer"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "nisi"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "minus"
  },
  "PublishEventDate": "2015-01-10T03:40:47.4687299+01:00",
  "PublishTo": "2025-10-02T03:40:47.4687299+02:00",
  "PublishFrom": "2025-09-20T03:40:47.4687299+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 639,
  "Name": "Fadel-Kiehn",
  "ProjectNumber": "1318170",
  "ProjectMembers": [
    {
      "ProjectmemberId": 414,
      "ContactId": 85,
      "ProjectId": 105,
      "ContactName": "Kilback, Cormier and Doyle",
      "ContactDepartment": "target seamless synergies",
      "ProjectName": "Rutherford Inc and Sons",
      "EmailId": 971,
      "EmailAddress": "astrid@gottlieb.us",
      "CountryId": 949,
      "Firstname": "Bulah",
      "MiddleName": "Baumbach-Grimes",
      "Lastname": "Hickle",
      "PersonId": 547,
      "Mrmrs": "ex",
      "ProjectMemberTypeName": "Botsford-Greenholt",
      "Phone": "938-587-8404",
      "PhoneId": 803,
      "ProjectMemberTypeId": 828,
      "EmailAddressName": "linwood_runolfsdottir@breitenbergschmeler.com",
      "Comment": "voluptatem",
      "FullName": "Gwendolyn Labadie",
      "Registered": "2021-10-14T03:40:47.4687299+02:00",
      "Updated": "2018-10-28T03:40:47.4687299+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 112
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "soluta",
      "StrippedValue": "reprehenderit",
      "Description": "Fully-configurable interactive Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "reprehenderit",
      "Description": "Fully-configurable interactive Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    }
  ],
  "CreatedDate": "2006-02-07T03:40:47.4687299+01:00",
  "UpdatedDate": "2024-11-19T03:40:47.4687299+01:00",
  "Description": "Multi-tiered object-oriented forecast",
  "Postit": "ex",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Expanded responsive capability",
  "ActiveStatusMonitorId": 40,
  "Links": [
    {
      "EntityName": "Raynor-Denesik",
      "Id": 608,
      "Description": "Multi-lateral incremental definition",
      "ExtraInfo": "quidem",
      "LinkId": 634,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 327
        }
      }
    }
  ],
  "ActiveLinks": 91,
  "Completed": true,
  "NextMilestoneDate": "2000-08-21T03:40:47.4687299+02:00",
  "NmdAppointmentId": 24,
  "EndDate": "2017-05-18T03:40:47.4687299+02:00",
  "ActiveErpLinks": 902,
  "UserDefinedFields": {
    "SuperOffice:1": "1695364886",
    "SuperOffice:2": "Ms. Marvin Dean Upton"
  },
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "saepe"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "iure"
  },
  "PublishEventDate": "2005-04-17T03:40:47.4687299+02:00",
  "PublishTo": "2012-09-18T03:40:47.4687299+02:00",
  "PublishFrom": "2000-11-24T03:40:47.4687299+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 585
    }
  }
}
```