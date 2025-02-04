---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
```


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

## Request Body: newEntity 

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

### Response body: ProjectEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 81,
  "Name": "Gleason-Kuhic",
  "ProjectNumber": "272614",
  "ProjectMembers": [
    {
      "ProjectmemberId": 29,
      "ContactId": 315,
      "ProjectId": 601,
      "ContactName": "Koss, Miller and Zulauf",
      "ContactDepartment": "",
      "ProjectName": "Ruecker Group",
      "EmailId": 336,
      "EmailAddress": "alize_wolf@dare.uk",
      "CountryId": 983,
      "Firstname": "Ryleigh",
      "MiddleName": "Pollich, Bernhard and Daugherty",
      "Lastname": "Pagac",
      "PersonId": 715,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Murray Group",
      "Phone": "(561)803-7435",
      "PhoneId": 734,
      "ProjectMemberTypeId": 806,
      "EmailAddressName": "uriel@hauckmorar.us",
      "Comment": "dicta",
      "FullName": "Dorian Kuhic"
    }
  ],
  "Urls": [
    {
      "Value": "numquam",
      "StrippedValue": "aut",
      "Description": "Synergistic analyzing knowledge user"
    },
    {
      "Value": "numquam",
      "StrippedValue": "aut",
      "Description": "Synergistic analyzing knowledge user"
    }
  ],
  "CreatedDate": "2001-12-19T13:13:31.9019426+01:00",
  "UpdatedDate": "2004-08-04T13:13:31.9019426+02:00",
  "Description": "Innovative multi-state artificial intelligence",
  "Postit": "adipisci",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Enhanced hybrid functionalities",
  "ActiveStatusMonitorId": 754,
  "Links": [
    {
      "EntityName": "Grimes, O'Keefe and Hessel",
      "Id": 438,
      "Description": "Decentralized fault-tolerant forecast",
      "ExtraInfo": "neque",
      "LinkId": 939
    },
    {
      "EntityName": "Grimes, O'Keefe and Hessel",
      "Id": 438,
      "Description": "Decentralized fault-tolerant forecast",
      "ExtraInfo": "neque",
      "LinkId": 939
    }
  ],
  "ActiveLinks": 304,
  "Completed": false,
  "NextMilestoneDate": "2017-12-07T13:13:31.9019426+01:00",
  "NmdAppointmentId": 440,
  "EndDate": "2006-07-21T13:13:31.9019426+02:00",
  "ActiveErpLinks": 173,
  "UserDefinedFields": {
    "SuperOffice:1": "Katelynn Schaefer",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "sapiente"
  },
  "PublishEventDate": "2012-09-13T13:13:31.9019426+02:00",
  "PublishTo": "2003-04-06T13:13:31.9019426+02:00",
  "PublishFrom": "2007-02-23T13:13:31.9019426+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 845,
  "Name": "Wolf-Welch",
  "ProjectNumber": "1379308",
  "ProjectMembers": [
    {
      "ProjectmemberId": 367,
      "ContactId": 859,
      "ProjectId": 643,
      "ContactName": "Rippin Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Mayer, Zemlak and Steuber",
      "EmailId": 685,
      "EmailAddress": "lexi@kovacekfisher.uk",
      "CountryId": 781,
      "Firstname": "Elvie",
      "MiddleName": "Feest Group",
      "Lastname": "Miller",
      "PersonId": 842,
      "Mrmrs": "aut",
      "ProjectMemberTypeName": "Bayer-Denesik",
      "Phone": "160-515-7939 x702",
      "PhoneId": 505,
      "ProjectMemberTypeId": 622,
      "EmailAddressName": "agustin_predovic@kassulkewest.info",
      "Comment": "exercitationem",
      "FullName": "Myrl Bartoletti",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 977
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "porro",
      "Description": "Universal context-sensitive frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "porro",
      "Description": "Universal context-sensitive frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    }
  ],
  "CreatedDate": "2009-09-12T13:13:31.9175657+02:00",
  "UpdatedDate": "2016-11-03T13:13:31.9175657+01:00",
  "Description": "Ameliorated value-added toolset",
  "Postit": "dolores",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Profit-focused reciprocal matrices",
  "ActiveStatusMonitorId": 954,
  "Links": [
    {
      "EntityName": "Skiles, Gutmann and Fadel",
      "Id": 346,
      "Description": "Managed modular implementation",
      "ExtraInfo": "temporibus",
      "LinkId": 118,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    }
  ],
  "ActiveLinks": 898,
  "Completed": false,
  "NextMilestoneDate": "2002-08-07T13:13:31.9175657+02:00",
  "NmdAppointmentId": 977,
  "EndDate": "2018-06-04T13:13:31.9175657+02:00",
  "ActiveErpLinks": 637,
  "UserDefinedFields": {
    "SuperOffice:1": "1817470175",
    "SuperOffice:2": "Americo King"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2003-02-11T13:13:31.9175657+01:00",
  "PublishTo": "2014-03-27T13:13:31.9175657+01:00",
  "PublishFrom": "2010-03-05T13:13:31.9175657+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 937
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```