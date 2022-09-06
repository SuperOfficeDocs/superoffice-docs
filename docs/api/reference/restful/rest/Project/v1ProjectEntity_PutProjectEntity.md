---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
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

ProjectEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 621,
  "Name": "Wiza, Reichel and Lubowitz",
  "ProjectNumber": "1055762",
  "ProjectMembers": [
    {
      "ProjectmemberId": 763,
      "ContactId": 244,
      "ProjectId": 967,
      "ContactName": "Corwin, Bogisich and Daugherty",
      "ContactDepartment": "",
      "ProjectName": "Pacocha-Friesen",
      "EmailId": 141,
      "EmailAddress": "hattie@durgan.uk",
      "CountryId": 621,
      "Firstname": "Jack",
      "MiddleName": "Kozey, Kris and Douglas",
      "Lastname": "Bode",
      "PersonId": 599,
      "Mrmrs": "adipisci",
      "ProjectMemberTypeName": "Ferry-Raynor",
      "Phone": "1-418-177-9966 x36161",
      "PhoneId": 926,
      "ProjectMemberTypeId": 93,
      "EmailAddressName": "arnold_lowe@kreiger.info",
      "Comment": "mollitia",
      "FullName": "Sandrine Kuvalis III"
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "magnam",
      "Description": "Stand-alone solution-oriented array"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "magnam",
      "Description": "Stand-alone solution-oriented array"
    }
  ],
  "CreatedDate": "2009-08-01T11:10:53.2911801+02:00",
  "UpdatedDate": "2011-01-14T11:10:53.2911801+01:00",
  "Description": "Persevering background instruction set",
  "Postit": "corrupti",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Open-architected asynchronous support",
  "ActiveStatusMonitorId": 572,
  "Links": [
    {
      "EntityName": "Dicki Inc and Sons",
      "Id": 818,
      "Description": "Adaptive actuating structure",
      "ExtraInfo": "exercitationem",
      "LinkId": 492
    },
    {
      "EntityName": "Dicki Inc and Sons",
      "Id": 818,
      "Description": "Adaptive actuating structure",
      "ExtraInfo": "exercitationem",
      "LinkId": 492
    }
  ],
  "ActiveLinks": 976,
  "Completed": true,
  "NextMilestoneDate": "2016-05-17T11:10:53.2931793+02:00",
  "NmdAppointmentId": 448,
  "EndDate": "2006-06-16T11:10:53.2931793+02:00",
  "ActiveErpLinks": 213,
  "UserDefinedFields": {
    "SuperOffice:1": "Leonel Pfannerstill",
    "SuperOffice:2": "Pinkie Schmidt"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "unde"
  },
  "PublishEventDate": "2020-12-07T11:10:53.2931793+01:00",
  "PublishTo": "2015-11-20T11:10:53.2931793+01:00",
  "PublishFrom": "2015-01-27T11:10:53.2931793+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 346,
  "Name": "Dietrich-Schuster",
  "ProjectNumber": "971732",
  "ProjectMembers": [
    {
      "ProjectmemberId": 500,
      "ContactId": 376,
      "ProjectId": 383,
      "ContactName": "Kunde Group",
      "ContactDepartment": "",
      "ProjectName": "Steuber-Hamill",
      "EmailId": 18,
      "EmailAddress": "valentine_oconner@hackettkuhlman.us",
      "CountryId": 313,
      "Firstname": "Cathrine",
      "MiddleName": "Lesch, Rogahn and Homenick",
      "Lastname": "Cole",
      "PersonId": 661,
      "Mrmrs": "est",
      "ProjectMemberTypeName": "Streich, Auer and Eichmann",
      "Phone": "(923)742-8355",
      "PhoneId": 88,
      "ProjectMemberTypeId": 326,
      "EmailAddressName": "astrid@erdman.biz",
      "Comment": "veniam",
      "FullName": "Madge Damaris Satterfield DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 752
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "neque",
      "Description": "Networked composite middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 403
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "neque",
      "Description": "Networked composite middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 403
        }
      }
    }
  ],
  "CreatedDate": "2022-07-21T11:10:53.2971798+02:00",
  "UpdatedDate": "1998-03-24T11:10:53.2971798+01:00",
  "Description": "Upgradable impactful matrix",
  "Postit": "dolore",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Function-based reciprocal process improvement",
  "ActiveStatusMonitorId": 582,
  "Links": [
    {
      "EntityName": "Wolff Group",
      "Id": 232,
      "Description": "Multi-lateral contextually-based utilisation",
      "ExtraInfo": "deleniti",
      "LinkId": 449,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 775
        }
      }
    }
  ],
  "ActiveLinks": 964,
  "Completed": false,
  "NextMilestoneDate": "2013-01-11T11:10:53.2991801+01:00",
  "NmdAppointmentId": 723,
  "EndDate": "2014-07-18T11:10:53.2991801+02:00",
  "ActiveErpLinks": 968,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "deleniti"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "autem"
  },
  "PublishEventDate": "2012-03-24T11:10:53.2991801+01:00",
  "PublishTo": "1996-12-22T11:10:53.2991801+01:00",
  "PublishFrom": "2005-12-23T11:10:53.2991801+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 108
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```
