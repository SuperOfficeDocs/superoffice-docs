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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 765,
  "Name": "Orn LLC",
  "ProjectNumber": "393769",
  "ProjectMembers": [
    {
      "ProjectmemberId": 247,
      "ContactId": 436,
      "ProjectId": 228,
      "ContactName": "Schowalter LLC",
      "ContactDepartment": "",
      "ProjectName": "Lebsack, Bogisich and Flatley",
      "EmailId": 505,
      "EmailAddress": "jayson_bechtelar@stiedemann.name",
      "CountryId": 301,
      "Firstname": "Kristin",
      "MiddleName": "Bogisich, White and Schmeler",
      "Lastname": "Hoppe",
      "PersonId": 231,
      "Mrmrs": "quidem",
      "ProjectMemberTypeName": "Hermann Group",
      "Phone": "998-117-4358 x174",
      "PhoneId": 410,
      "ProjectMemberTypeId": 413,
      "EmailAddressName": "yadira@leffler.name",
      "Comment": "sed",
      "FullName": "Sylvan Maggio"
    }
  ],
  "Urls": [
    {
      "Value": "expedita",
      "StrippedValue": "ipsam",
      "Description": "Multi-layered web-enabled emulation"
    },
    {
      "Value": "expedita",
      "StrippedValue": "ipsam",
      "Description": "Multi-layered web-enabled emulation"
    }
  ],
  "CreatedDate": "2012-08-29T17:54:08.3980739+02:00",
  "UpdatedDate": "2013-11-15T17:54:08.3980739+01:00",
  "Description": "Customizable homogeneous access",
  "Postit": "ex",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Streamlined value-added encoding",
  "ActiveStatusMonitorId": 844,
  "Links": [
    {
      "EntityName": "Crooks-Trantow",
      "Id": 606,
      "Description": "Self-enabling disintermediate capability",
      "ExtraInfo": "nostrum",
      "LinkId": 165
    },
    {
      "EntityName": "Crooks-Trantow",
      "Id": 606,
      "Description": "Self-enabling disintermediate capability",
      "ExtraInfo": "nostrum",
      "LinkId": 165
    }
  ],
  "ActiveLinks": 597,
  "Completed": false,
  "NextMilestoneDate": "2004-06-11T17:54:08.3980739+02:00",
  "NmdAppointmentId": 905,
  "EndDate": "2023-07-27T17:54:08.3980739+02:00",
  "ActiveErpLinks": 676,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Ole Thurman Crist MD",
    "SuperOffice:2": "Mr. Serenity Walsh"
  },
  "ExtraFields": {
    "ExtraFields1": "sapiente",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "quis"
  },
  "PublishEventDate": "2013-04-09T17:54:08.3980739+02:00",
  "PublishTo": "2005-04-19T17:54:08.3980739+02:00",
  "PublishFrom": "1998-07-09T17:54:08.3980739+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 139,
  "Name": "Morissette Group",
  "ProjectNumber": "832734",
  "ProjectMembers": [
    {
      "ProjectmemberId": 783,
      "ContactId": 674,
      "ProjectId": 699,
      "ContactName": "Boyer, White and Hahn",
      "ContactDepartment": "",
      "ProjectName": "Prohaska-Lesch",
      "EmailId": 528,
      "EmailAddress": "alysson.batz@kerlukeschinner.biz",
      "CountryId": 137,
      "Firstname": "Belle",
      "MiddleName": "Casper, Little and Balistreri",
      "Lastname": "Keeling",
      "PersonId": 656,
      "Mrmrs": "sapiente",
      "ProjectMemberTypeName": "Volkman-Greenholt",
      "Phone": "344.326.5937 x03942",
      "PhoneId": 107,
      "ProjectMemberTypeId": 623,
      "EmailAddressName": "coleman_windler@welch.us",
      "Comment": "voluptate",
      "FullName": "Mrs. Laurine Beverly Paucek",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 439
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "voluptatem",
      "Description": "Polarised dynamic hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 770
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "voluptatem",
      "Description": "Polarised dynamic hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 770
        }
      }
    }
  ],
  "CreatedDate": "2024-07-16T17:54:08.3980739+02:00",
  "UpdatedDate": "2013-09-07T17:54:08.3980739+02:00",
  "Description": "Ameliorated empowering knowledge user",
  "Postit": "minima",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Devolved analyzing challenge",
  "ActiveStatusMonitorId": 364,
  "Links": [
    {
      "EntityName": "Nolan LLC",
      "Id": 283,
      "Description": "Synergized 4th generation strategy",
      "ExtraInfo": "pariatur",
      "LinkId": 434,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 751
        }
      }
    }
  ],
  "ActiveLinks": 15,
  "Completed": false,
  "NextMilestoneDate": "2024-12-28T17:54:08.3980739+01:00",
  "NmdAppointmentId": 836,
  "EndDate": "2019-08-21T17:54:08.3980739+02:00",
  "ActiveErpLinks": 775,
  "UserDefinedFields": {
    "SuperOffice:1": "Johnpaul Ritchie",
    "SuperOffice:2": "Richie Bernier"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "in"
  },
  "PublishEventDate": "2022-06-06T17:54:08.3980739+02:00",
  "PublishTo": "2023-07-01T17:54:08.3980739+02:00",
  "PublishFrom": "2011-03-16T17:54:08.3980739+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 596
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```