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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 386,
  "Name": "Reilly-Gleichner",
  "ProjectNumber": "935367",
  "ProjectMembers": [
    {
      "ProjectmemberId": 499,
      "ContactId": 60,
      "ProjectId": 876,
      "ContactName": "Dickens LLC",
      "ContactDepartment": "",
      "ProjectName": "Olson LLC",
      "EmailId": 819,
      "EmailAddress": "hank_baumbach@von.biz",
      "CountryId": 535,
      "Firstname": "Elinor",
      "MiddleName": "Daniel, Bogan and Armstrong",
      "Lastname": "Trantow",
      "PersonId": 946,
      "Mrmrs": "libero",
      "ProjectMemberTypeName": "Hamill Group",
      "Phone": "1-033-432-3467",
      "PhoneId": 22,
      "ProjectMemberTypeId": 474,
      "EmailAddressName": "lydia@konopelski.com",
      "Comment": "ipsa",
      "FullName": "Natasha Kassulke"
    }
  ],
  "Urls": [
    {
      "Value": "recusandae",
      "StrippedValue": "qui",
      "Description": "Enterprise-wide bandwidth-monitored capacity"
    },
    {
      "Value": "recusandae",
      "StrippedValue": "qui",
      "Description": "Enterprise-wide bandwidth-monitored capacity"
    }
  ],
  "CreatedDate": "2006-12-24T14:28:27.0239403+01:00",
  "UpdatedDate": "2000-02-09T14:28:27.0239403+01:00",
  "Description": "Enterprise-wide 4th generation approach",
  "Postit": "facere",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Cloned didactic productivity",
  "ActiveStatusMonitorId": 476,
  "Links": [
    {
      "EntityName": "Flatley-Turner",
      "Id": 817,
      "Description": "Customizable transitional capability",
      "ExtraInfo": "sed",
      "LinkId": 383
    },
    {
      "EntityName": "Flatley-Turner",
      "Id": 817,
      "Description": "Customizable transitional capability",
      "ExtraInfo": "sed",
      "LinkId": 383
    }
  ],
  "ActiveLinks": 918,
  "Completed": false,
  "NextMilestoneDate": "2003-03-05T14:28:27.0239403+01:00",
  "NmdAppointmentId": 271,
  "EndDate": "2023-03-17T14:28:27.0239403+01:00",
  "ActiveErpLinks": 358,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Mable Wyman II",
    "SuperOffice:2": "1167581472"
  },
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "incidunt"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "quae"
  },
  "PublishEventDate": "2019-11-13T14:28:27.0239403+01:00",
  "PublishTo": "2002-02-23T14:28:27.0239403+01:00",
  "PublishFrom": "1998-05-28T14:28:27.0239403+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 52,
  "Name": "Streich, Wunsch and O'Hara",
  "ProjectNumber": "1806797",
  "ProjectMembers": [
    {
      "ProjectmemberId": 462,
      "ContactId": 3,
      "ProjectId": 423,
      "ContactName": "Anderson, Flatley and Lesch",
      "ContactDepartment": "",
      "ProjectName": "Jerde, Lakin and Cormier",
      "EmailId": 601,
      "EmailAddress": "cynthia_mohr@kutch.info",
      "CountryId": 463,
      "Firstname": "Wilford",
      "MiddleName": "Koepp, Legros and Moore",
      "Lastname": "Parker",
      "PersonId": 888,
      "Mrmrs": "in",
      "ProjectMemberTypeName": "Quigley-Dooley",
      "Phone": "1-178-283-5120",
      "PhoneId": 823,
      "ProjectMemberTypeId": 539,
      "EmailAddressName": "cody@gutmann.ca",
      "Comment": "sequi",
      "FullName": "Coleman Ullrich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 816
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "rem",
      "StrippedValue": "tenetur",
      "Description": "Stand-alone mission-critical moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "tenetur",
      "Description": "Stand-alone mission-critical moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    }
  ],
  "CreatedDate": "2001-07-06T14:28:27.0239403+02:00",
  "UpdatedDate": "2015-02-05T14:28:27.0239403+01:00",
  "Description": "Reduced zero tolerance project",
  "Postit": "dolorem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Managed neutral benchmark",
  "ActiveStatusMonitorId": 760,
  "Links": [
    {
      "EntityName": "Hermann, Stehr and Bartell",
      "Id": 423,
      "Description": "Down-sized assymetric emulation",
      "ExtraInfo": "omnis",
      "LinkId": 845,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "ActiveLinks": 282,
  "Completed": true,
  "NextMilestoneDate": "2013-02-10T14:28:27.0239403+01:00",
  "NmdAppointmentId": 493,
  "EndDate": "2000-09-01T14:28:27.0239403+02:00",
  "ActiveErpLinks": 197,
  "UserDefinedFields": {
    "SuperOffice:1": "426550603",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "vero",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "quis"
  },
  "PublishEventDate": "2008-06-17T14:28:27.0239403+02:00",
  "PublishTo": "1999-04-06T14:28:27.0239403+02:00",
  "PublishFrom": "2009-06-10T14:28:27.0239403+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 227
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```