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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 541,
  "Name": "Tillman-Botsford",
  "ProjectNumber": "1794679",
  "ProjectMembers": [
    {
      "ProjectmemberId": 703,
      "ContactId": 278,
      "ProjectId": 812,
      "ContactName": "Upton-Marquardt",
      "ContactDepartment": "embrace dynamic synergies",
      "ProjectName": "Treutel Inc and Sons",
      "EmailId": 311,
      "EmailAddress": "giovanni.quigley@bradtke.info",
      "CountryId": 822,
      "Firstname": "Kade",
      "MiddleName": "Koepp-Skiles",
      "Lastname": "Fay",
      "PersonId": 529,
      "Mrmrs": "vel",
      "ProjectMemberTypeName": "Grimes, Kutch and Hauck",
      "Phone": "397-313-4886 x88000",
      "PhoneId": 250,
      "ProjectMemberTypeId": 285,
      "EmailAddressName": "natalie@collier.info",
      "Comment": "repudiandae",
      "FullName": "Miss Karl Christopher Wintheiser DDS"
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "eum",
      "Description": "Quality-focused demand-driven paradigm"
    },
    {
      "Value": "quo",
      "StrippedValue": "eum",
      "Description": "Quality-focused demand-driven paradigm"
    }
  ],
  "CreatedDate": "2022-03-02T11:16:14.0269512+01:00",
  "UpdatedDate": "2013-02-13T11:16:14.0269512+01:00",
  "Description": "Centralized multi-tasking array",
  "Postit": "veniam",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Down-sized actuating toolset",
  "ActiveStatusMonitorId": 97,
  "Links": [
    {
      "EntityName": "Leuschke Inc and Sons",
      "Id": 510,
      "Description": "Cloned real-time extranet",
      "ExtraInfo": "a",
      "LinkId": 700
    },
    {
      "EntityName": "Leuschke Inc and Sons",
      "Id": 510,
      "Description": "Cloned real-time extranet",
      "ExtraInfo": "a",
      "LinkId": 700
    }
  ],
  "ActiveLinks": 543,
  "Completed": false,
  "NextMilestoneDate": "2016-02-05T11:16:14.0269512+01:00",
  "NmdAppointmentId": 949,
  "EndDate": "2017-09-02T11:16:14.0269512+02:00",
  "ActiveErpLinks": 723,
  "UserDefinedFields": {
    "SuperOffice:1": "1416778432",
    "SuperOffice:2": "Miss Jayson Zemlak"
  },
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "2003-01-30T11:16:14.0269512+01:00",
  "PublishTo": "2017-02-22T11:16:14.0269512+01:00",
  "PublishFrom": "2016-04-18T11:16:14.0269512+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 73,
  "Name": "Prosacco, Labadie and Klocko",
  "ProjectNumber": "1101382",
  "ProjectMembers": [
    {
      "ProjectmemberId": 830,
      "ContactId": 36,
      "ProjectId": 668,
      "ContactName": "O'Conner Group",
      "ContactDepartment": "",
      "ProjectName": "Langworth-Feeney",
      "EmailId": 328,
      "EmailAddress": "marc@beatty.us",
      "CountryId": 845,
      "Firstname": "Mauricio",
      "MiddleName": "Berge-Wilkinson",
      "Lastname": "Waters",
      "PersonId": 811,
      "Mrmrs": "velit",
      "ProjectMemberTypeName": "Goldner, Pouros and Nader",
      "Phone": "860-801-5015 x59642",
      "PhoneId": 683,
      "ProjectMemberTypeId": 359,
      "EmailAddressName": "linnea@spinka.ca",
      "Comment": "consequatur",
      "FullName": "Ms. Estefania Cornelius Marks II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "suscipit",
      "StrippedValue": "sit",
      "Description": "Re-contextualized optimal middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "sit",
      "Description": "Re-contextualized optimal middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    }
  ],
  "CreatedDate": "2007-02-04T11:16:14.0269512+01:00",
  "UpdatedDate": "2018-12-05T11:16:14.0269512+01:00",
  "Description": "Object-based incremental challenge",
  "Postit": "consequatur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Front-line composite model",
  "ActiveStatusMonitorId": 445,
  "Links": [
    {
      "EntityName": "Ziemann, Bins and Mueller",
      "Id": 676,
      "Description": "Programmable reciprocal ability",
      "ExtraInfo": "ut",
      "LinkId": 73,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 979
        }
      }
    }
  ],
  "ActiveLinks": 384,
  "Completed": false,
  "NextMilestoneDate": "2008-05-05T11:16:14.0269512+02:00",
  "NmdAppointmentId": 461,
  "EndDate": "2013-04-05T11:16:14.0269512+02:00",
  "ActiveErpLinks": 548,
  "UserDefinedFields": {
    "SuperOffice:1": "Janelle Predovic MD",
    "SuperOffice:2": "Jillian Rempel"
  },
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2006-10-11T11:16:14.0269512+02:00",
  "PublishTo": "2024-01-19T11:16:14.0269512+01:00",
  "PublishFrom": "2011-11-10T11:16:14.0269512+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 98
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```