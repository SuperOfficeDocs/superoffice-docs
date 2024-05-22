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
  "ProjectId": 769,
  "Name": "Dooley, Wolf and Emard",
  "ProjectNumber": "1050776",
  "ProjectMembers": [
    {
      "ProjectmemberId": 258,
      "ContactId": 634,
      "ProjectId": 765,
      "ContactName": "Walker, Ankunding and Considine",
      "ContactDepartment": "",
      "ProjectName": "Mohr, Hane and Huel",
      "EmailId": 605,
      "EmailAddress": "jaeden.kozey@treutel.biz",
      "CountryId": 734,
      "Firstname": "Rashad",
      "MiddleName": "Wunsch Group",
      "Lastname": "Paucek",
      "PersonId": 566,
      "Mrmrs": "fugit",
      "ProjectMemberTypeName": "Veum Inc and Sons",
      "Phone": "(461)364-6875 x886",
      "PhoneId": 729,
      "ProjectMemberTypeId": 345,
      "EmailAddressName": "abby@pacocha.biz",
      "Comment": "sequi",
      "FullName": "Catharine Hessel"
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "aliquid",
      "Description": "Balanced homogeneous support"
    },
    {
      "Value": "non",
      "StrippedValue": "aliquid",
      "Description": "Balanced homogeneous support"
    }
  ],
  "CreatedDate": "1997-11-22T12:57:42.6044701+01:00",
  "UpdatedDate": "2005-12-07T12:57:42.6044701+01:00",
  "Description": "Focused contextually-based Graphical User Interface",
  "Postit": "sequi",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "User-centric heuristic paradigm",
  "ActiveStatusMonitorId": 641,
  "Links": [
    {
      "EntityName": "Heathcote-Waelchi",
      "Id": 281,
      "Description": "Phased national monitoring",
      "ExtraInfo": "id",
      "LinkId": 456
    },
    {
      "EntityName": "Heathcote-Waelchi",
      "Id": 281,
      "Description": "Phased national monitoring",
      "ExtraInfo": "id",
      "LinkId": 456
    }
  ],
  "ActiveLinks": 650,
  "Completed": false,
  "NextMilestoneDate": "2019-08-19T12:57:42.6044701+02:00",
  "NmdAppointmentId": 491,
  "EndDate": "2000-04-01T12:57:42.6044701+02:00",
  "ActiveErpLinks": 320,
  "UserDefinedFields": {
    "SuperOffice:1": "Kirsten Douglas",
    "SuperOffice:2": "1808132621"
  },
  "ExtraFields": {
    "ExtraFields1": "inventore",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "ea"
  },
  "PublishEventDate": "2002-02-28T12:57:42.6044701+01:00",
  "PublishTo": "2009-12-29T12:57:42.6044701+01:00",
  "PublishFrom": "2012-11-30T12:57:42.6044701+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 506,
  "Name": "Boehm, Spencer and Jaskolski",
  "ProjectNumber": "930591",
  "ProjectMembers": [
    {
      "ProjectmemberId": 327,
      "ContactId": 937,
      "ProjectId": 619,
      "ContactName": "Schumm-Walsh",
      "ContactDepartment": "",
      "ProjectName": "Macejkovic Inc and Sons",
      "EmailId": 982,
      "EmailAddress": "larry_walter@heller.biz",
      "CountryId": 553,
      "Firstname": "Gaylord",
      "MiddleName": "Zemlak-Hilpert",
      "Lastname": "Jakubowski",
      "PersonId": 106,
      "Mrmrs": "non",
      "ProjectMemberTypeName": "Beier, Kunde and Keebler",
      "Phone": "1-952-538-3027",
      "PhoneId": 439,
      "ProjectMemberTypeId": 854,
      "EmailAddressName": "jaylan@beahan.info",
      "Comment": "expedita",
      "FullName": "Judge O'Hara",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 135
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "vitae",
      "Description": "Diverse actuating parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 184
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "vitae",
      "Description": "Diverse actuating parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 184
        }
      }
    }
  ],
  "CreatedDate": "2008-07-30T12:57:42.6200918+02:00",
  "UpdatedDate": "2022-01-04T12:57:42.6200918+01:00",
  "Description": "Centralized tangible success",
  "Postit": "est",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Operative non-volatile utilisation",
  "ActiveStatusMonitorId": 907,
  "Links": [
    {
      "EntityName": "Hamill LLC",
      "Id": 29,
      "Description": "Implemented client-server algorithm",
      "ExtraInfo": "alias",
      "LinkId": 756,
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
  "ActiveLinks": 908,
  "Completed": false,
  "NextMilestoneDate": "2023-07-07T12:57:42.6200918+02:00",
  "NmdAppointmentId": 121,
  "EndDate": "2021-05-29T12:57:42.6200918+02:00",
  "ActiveErpLinks": 146,
  "UserDefinedFields": {
    "SuperOffice:1": "Hubert Swift",
    "SuperOffice:2": "Rowland Collins"
  },
  "ExtraFields": {
    "ExtraFields1": "alias",
    "ExtraFields2": "voluptate"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "dicta"
  },
  "PublishEventDate": "2023-05-12T12:57:42.6200918+02:00",
  "PublishTo": "2015-12-31T12:57:42.6200918+01:00",
  "PublishFrom": "2003-11-20T12:57:42.6200918+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 642
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```