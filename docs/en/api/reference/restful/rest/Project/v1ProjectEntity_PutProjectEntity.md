---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
---

# PUT Project/{id}

```http
PUT /api/v1/Project/{id}
```

Updates the existing ProjectEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Project/{id}?$select=name,department,category/id
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

ProjectEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 62,
  "Name": "Cruickshank-Jakubowski",
  "ProjectNumber": "794508",
  "ProjectMembers": [
    {
      "ProjectmemberId": 8,
      "ContactId": 209,
      "ProjectId": 158,
      "ContactName": "Simonis, Wunsch and Stark",
      "ContactDepartment": "",
      "ProjectName": "Wolf Inc and Sons",
      "EmailId": 432,
      "EmailAddress": "luna_botsford@gradykihn.name",
      "CountryId": 490,
      "Firstname": "Ford",
      "MiddleName": "Bradtke-Leuschke",
      "Lastname": "Beer",
      "PersonId": 541,
      "Mrmrs": "voluptas",
      "ProjectMemberTypeName": "Sipes LLC",
      "Phone": "425.561.9127 x69185",
      "PhoneId": 758,
      "ProjectMemberTypeId": 252,
      "EmailAddressName": "ansel_effertz@durgan.us",
      "Comment": "aliquam",
      "FullName": "Kavon Borer"
    }
  ],
  "Urls": [
    {
      "Value": "quisquam",
      "StrippedValue": "iste",
      "Description": "Innovative web-enabled challenge"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "iste",
      "Description": "Innovative web-enabled challenge"
    }
  ],
  "CreatedDate": "2017-09-07T14:13:49.0556434+02:00",
  "UpdatedDate": "2015-06-21T14:13:49.0556434+02:00",
  "Description": "Profit-focused hybrid orchestration",
  "Postit": "dignissimos",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Vision-oriented intermediate database",
  "ActiveStatusMonitorId": 15,
  "Links": [
    {
      "EntityName": "Parker-Larson",
      "Id": 396,
      "Description": "Grass-roots multi-state circuit",
      "ExtraInfo": "odit",
      "LinkId": 291
    },
    {
      "EntityName": "Parker-Larson",
      "Id": 396,
      "Description": "Grass-roots multi-state circuit",
      "ExtraInfo": "odit",
      "LinkId": 291
    }
  ],
  "ActiveLinks": 365,
  "Completed": false,
  "NextMilestoneDate": "2009-08-27T14:13:49.0556434+02:00",
  "NmdAppointmentId": 286,
  "EndDate": "2000-10-12T14:13:49.0556434+02:00",
  "ActiveErpLinks": 187,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Verda Larson",
    "SuperOffice:2": "Maureen Konopelski"
  },
  "ExtraFields": {
    "ExtraFields1": "minus",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "iure",
    "CustomFields2": "veritatis"
  },
  "PublishEventDate": "2000-06-12T14:13:49.0556434+02:00",
  "PublishTo": "2011-03-13T14:13:49.0556434+01:00",
  "PublishFrom": "2011-05-21T14:13:49.0556434+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 493,
  "Name": "Casper, Sporer and Gaylord",
  "ProjectNumber": "1380879",
  "ProjectMembers": [
    {
      "ProjectmemberId": 804,
      "ContactId": 273,
      "ProjectId": 577,
      "ContactName": "Harris-Stoltenberg",
      "ContactDepartment": "",
      "ProjectName": "Murphy, Wiza and Bernhard",
      "EmailId": 794,
      "EmailAddress": "coralie@kulas.biz",
      "CountryId": 372,
      "Firstname": "Emma",
      "MiddleName": "Becker Group",
      "Lastname": "Howell",
      "PersonId": 62,
      "Mrmrs": "rem",
      "ProjectMemberTypeName": "Mosciski Inc and Sons",
      "Phone": "324.740.8245",
      "PhoneId": 249,
      "ProjectMemberTypeId": 867,
      "EmailAddressName": "reginald@daniel.name",
      "Comment": "quia",
      "FullName": "Danyka Wehner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 161
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "quia",
      "Description": "Cross-platform solution-oriented internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "quia",
      "Description": "Cross-platform solution-oriented internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    }
  ],
  "CreatedDate": "2012-08-28T14:13:49.0556434+02:00",
  "UpdatedDate": "2003-07-15T14:13:49.0556434+02:00",
  "Description": "Secured foreground solution",
  "Postit": "id",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Monitored 6th generation internet solution",
  "ActiveStatusMonitorId": 374,
  "Links": [
    {
      "EntityName": "Jewess LLC",
      "Id": 990,
      "Description": "Fundamental eco-centric toolset",
      "ExtraInfo": "ratione",
      "LinkId": 653,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 928
        }
      }
    }
  ],
  "ActiveLinks": 380,
  "Completed": false,
  "NextMilestoneDate": "2014-10-30T14:13:49.0556434+01:00",
  "NmdAppointmentId": 883,
  "EndDate": "2000-11-28T14:13:49.0556434+01:00",
  "ActiveErpLinks": 976,
  "UserDefinedFields": {
    "SuperOffice:1": "Royce Lubowitz",
    "SuperOffice:2": "Miss Lonie Johnson"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "perspiciatis"
  },
  "CustomFields": {
    "CustomFields1": "facere",
    "CustomFields2": "voluptatem"
  },
  "PublishEventDate": "1998-06-05T14:13:49.0556434+02:00",
  "PublishTo": "2009-04-06T14:13:49.0556434+02:00",
  "PublishFrom": "2010-11-08T14:13:49.0556434+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 21
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```