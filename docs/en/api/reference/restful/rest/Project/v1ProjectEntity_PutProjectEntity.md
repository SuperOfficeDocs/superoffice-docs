---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
content_type: reference
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
  "ProjectId": 756,
  "Name": "Brekke-Greenfelder",
  "ProjectNumber": "326748",
  "ProjectMembers": [
    {
      "ProjectmemberId": 66,
      "ContactId": 284,
      "ProjectId": 674,
      "ContactName": "Schumm LLC",
      "ContactDepartment": "",
      "ProjectName": "Wyman-Murphy",
      "EmailId": 413,
      "EmailAddress": "fredrick_bayer@hodkiewiczwiza.ca",
      "CountryId": 279,
      "Firstname": "Darrel",
      "MiddleName": "Balistreri-Stracke",
      "Lastname": "Considine",
      "PersonId": 578,
      "Mrmrs": "ea",
      "ProjectMemberTypeName": "Little-Kunze",
      "Phone": "624.221.8814 x5683",
      "PhoneId": 411,
      "ProjectMemberTypeId": 52,
      "EmailAddressName": "toby@reilly.uk",
      "Comment": "quas",
      "FullName": "Eddie Cicero Johns IV"
    }
  ],
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "voluptas",
      "Description": "Fully-configurable disintermediate protocol"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "voluptas",
      "Description": "Fully-configurable disintermediate protocol"
    }
  ],
  "CreatedDate": "2018-09-12T03:47:00.1755649+02:00",
  "UpdatedDate": "2021-04-08T03:47:00.1755649+02:00",
  "Description": "Compatible full-range monitoring",
  "Postit": "natus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Expanded executive frame",
  "ActiveStatusMonitorId": 76,
  "Links": [
    {
      "EntityName": "Jaskolski-Kautzer",
      "Id": 589,
      "Description": "Vision-oriented transitional framework",
      "ExtraInfo": "quasi",
      "LinkId": 466
    },
    {
      "EntityName": "Jaskolski-Kautzer",
      "Id": 589,
      "Description": "Vision-oriented transitional framework",
      "ExtraInfo": "quasi",
      "LinkId": 466
    }
  ],
  "ActiveLinks": 711,
  "Completed": false,
  "NextMilestoneDate": "2000-06-06T03:47:00.1755649+02:00",
  "NmdAppointmentId": 197,
  "EndDate": "2012-12-10T03:47:00.1755649+01:00",
  "ActiveErpLinks": 126,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Courtney Romaguera",
    "SuperOffice:2": "972518961"
  },
  "ExtraFields": {
    "ExtraFields1": "eveniet",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "esse"
  },
  "PublishEventDate": "2000-02-05T03:47:00.1755649+01:00",
  "PublishTo": "2011-02-11T03:47:00.1755649+01:00",
  "PublishFrom": "2004-08-13T03:47:00.1755649+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 9,
  "Name": "Jaskolski-Herzog",
  "ProjectNumber": "1197901",
  "ProjectMembers": [
    {
      "ProjectmemberId": 743,
      "ContactId": 110,
      "ProjectId": 12,
      "ContactName": "Wisozk-Casper",
      "ContactDepartment": "",
      "ProjectName": "Douglas, Brakus and Harber",
      "EmailId": 835,
      "EmailAddress": "ada@raumonahan.co.uk",
      "CountryId": 889,
      "Firstname": "Odell",
      "MiddleName": "Jones, Swift and West",
      "Lastname": "Conn",
      "PersonId": 762,
      "Mrmrs": "autem",
      "ProjectMemberTypeName": "Feil-Conn",
      "Phone": "1-043-892-2284",
      "PhoneId": 772,
      "ProjectMemberTypeId": 615,
      "EmailAddressName": "blake@hirthe.uk",
      "Comment": "fugiat",
      "FullName": "Pamela Dibbert",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 966
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quaerat",
      "StrippedValue": "cum",
      "Description": "Networked motivating encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "cum",
      "Description": "Networked motivating encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "CreatedDate": "2002-04-24T03:47:00.1755649+02:00",
  "UpdatedDate": "2005-09-08T03:47:00.1755649+02:00",
  "Description": "Reduced high-level contingency",
  "Postit": "exercitationem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Polarised system-worthy artificial intelligence",
  "ActiveStatusMonitorId": 998,
  "Links": [
    {
      "EntityName": "Adams, Sauer and Shields",
      "Id": 933,
      "Description": "Persistent intangible installation",
      "ExtraInfo": "vel",
      "LinkId": 165,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 387
        }
      }
    }
  ],
  "ActiveLinks": 81,
  "Completed": false,
  "NextMilestoneDate": "2001-02-04T03:47:00.1755649+01:00",
  "NmdAppointmentId": 608,
  "EndDate": "2011-09-22T03:47:00.1755649+02:00",
  "ActiveErpLinks": 346,
  "UserDefinedFields": {
    "SuperOffice:1": "1987542163",
    "SuperOffice:2": "Billie Runolfsson"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "nobis"
  },
  "CustomFields": {
    "CustomFields1": "iure",
    "CustomFields2": "in"
  },
  "PublishEventDate": "2023-12-29T03:47:00.1755649+01:00",
  "PublishTo": "2019-01-18T03:47:00.1755649+01:00",
  "PublishFrom": "2000-09-27T03:47:00.1755649+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 443
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```