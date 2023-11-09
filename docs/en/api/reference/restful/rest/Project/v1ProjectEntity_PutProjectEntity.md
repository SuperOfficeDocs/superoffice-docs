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
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
  "ProjectId": 931,
  "Name": "Daniel-Weber",
  "ProjectNumber": "1380050",
  "ProjectMembers": [
    {
      "ProjectmemberId": 325,
      "ContactId": 119,
      "ProjectId": 500,
      "ContactName": "Muller, Kerluke and Bosco",
      "ContactDepartment": "",
      "ProjectName": "Brakus Group",
      "EmailId": 883,
      "EmailAddress": "hanna@willupton.name",
      "CountryId": 53,
      "Firstname": "Mallie",
      "MiddleName": "Hoeger, Cummerata and Ortiz",
      "Lastname": "Klocko",
      "PersonId": 791,
      "Mrmrs": "incidunt",
      "ProjectMemberTypeName": "Koch Inc and Sons",
      "Phone": "235-891-7268 x65153",
      "PhoneId": 71,
      "ProjectMemberTypeId": 516,
      "EmailAddressName": "tate.lehner@bogisich.info",
      "Comment": "possimus",
      "FullName": "Antonetta O'Hara"
    }
  ],
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "ea",
      "Description": "Reverse-engineered discrete emulation"
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "ea",
      "Description": "Reverse-engineered discrete emulation"
    }
  ],
  "CreatedDate": "2006-11-13T11:06:42.0353528+01:00",
  "UpdatedDate": "2005-07-21T11:06:42.0353528+02:00",
  "Description": "Pre-emptive 24 hour strategy",
  "Postit": "autem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Devolved disintermediate challenge",
  "ActiveStatusMonitorId": 878,
  "Links": [
    {
      "EntityName": "Gorczany LLC",
      "Id": 753,
      "Description": "Customizable modular definition",
      "ExtraInfo": "aut",
      "LinkId": 23
    },
    {
      "EntityName": "Gorczany LLC",
      "Id": 753,
      "Description": "Customizable modular definition",
      "ExtraInfo": "aut",
      "LinkId": 23
    }
  ],
  "ActiveLinks": 388,
  "Completed": false,
  "NextMilestoneDate": "2019-03-02T11:06:42.0353528+01:00",
  "NmdAppointmentId": 55,
  "EndDate": "2022-05-04T11:06:42.0353528+02:00",
  "ActiveErpLinks": 840,
  "UserDefinedFields": {
    "SuperOffice:1": "855768370",
    "SuperOffice:2": "Marianna Marvin"
  },
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "debitis",
    "CustomFields2": "quae"
  },
  "PublishEventDate": "2008-01-12T11:06:42.0353528+01:00",
  "PublishTo": "2011-03-11T11:06:42.0353528+01:00",
  "PublishFrom": "1996-06-17T11:06:42.0353528+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 869,
  "Name": "Veum, Hackett and Legros",
  "ProjectNumber": "671281",
  "ProjectMembers": [
    {
      "ProjectmemberId": 969,
      "ContactId": 38,
      "ProjectId": 284,
      "ContactName": "Balistreri Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Dibbert, Weimann and Kunze",
      "EmailId": 924,
      "EmailAddress": "cora@leannon.com",
      "CountryId": 547,
      "Firstname": "Zachariah",
      "MiddleName": "Grady, Bergnaum and Howe",
      "Lastname": "Wehner",
      "PersonId": 201,
      "Mrmrs": "voluptatem",
      "ProjectMemberTypeName": "Murphy LLC",
      "Phone": "(560)091-2239 x5550",
      "PhoneId": 916,
      "ProjectMemberTypeId": 381,
      "EmailAddressName": "jovanny.friesen@swift.info",
      "Comment": "facilis",
      "FullName": "Prof. Florence Huel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "rem",
      "Description": "Multi-layered background migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 44
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "rem",
      "Description": "Multi-layered background migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 44
        }
      }
    }
  ],
  "CreatedDate": "2002-08-06T11:06:42.0353528+02:00",
  "UpdatedDate": "2016-10-21T11:06:42.0353528+02:00",
  "Description": "Triple-buffered non-volatile knowledge base",
  "Postit": "soluta",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Programmable upward-trending open architecture",
  "ActiveStatusMonitorId": 63,
  "Links": [
    {
      "EntityName": "Corkery-Rice",
      "Id": 753,
      "Description": "Monitored local synergy",
      "ExtraInfo": "labore",
      "LinkId": 88,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 210
        }
      }
    }
  ],
  "ActiveLinks": 635,
  "Completed": false,
  "NextMilestoneDate": "2009-07-23T11:06:42.050976+02:00",
  "NmdAppointmentId": 236,
  "EndDate": "2001-06-02T11:06:42.050976+02:00",
  "ActiveErpLinks": 271,
  "UserDefinedFields": {
    "SuperOffice:1": "Catherine Rohan",
    "SuperOffice:2": "Maya West"
  },
  "ExtraFields": {
    "ExtraFields1": "adipisci",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "quis"
  },
  "PublishEventDate": "2014-02-15T11:06:42.050976+01:00",
  "PublishTo": "2005-01-26T11:06:42.050976+01:00",
  "PublishFrom": "2001-11-27T11:06:42.050976+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 150
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```