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
  "ProjectId": 509,
  "Name": "Abernathy Inc and Sons",
  "ProjectNumber": "1369269",
  "ProjectMembers": [
    {
      "ProjectmemberId": 14,
      "ContactId": 215,
      "ProjectId": 431,
      "ContactName": "Rosenbaum Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Durgan, Jerde and Hudson",
      "EmailId": 943,
      "EmailAddress": "morton.erdman@morar.co.uk",
      "CountryId": 234,
      "Firstname": "Hallie",
      "MiddleName": "Rau-Kessler",
      "Lastname": "Lueilwitz",
      "PersonId": 444,
      "Mrmrs": "corporis",
      "ProjectMemberTypeName": "Bogan, Satterfield and Russel",
      "Phone": "1-972-479-6474 x1420",
      "PhoneId": 380,
      "ProjectMemberTypeId": 381,
      "EmailAddressName": "cesar_okuneva@champlin.us",
      "Comment": "vel",
      "FullName": "Prof. Kaela Homenick Sr."
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "laudantium",
      "Description": "Total background architecture"
    },
    {
      "Value": "nihil",
      "StrippedValue": "laudantium",
      "Description": "Total background architecture"
    }
  ],
  "CreatedDate": "2008-06-02T16:55:29.9415162+02:00",
  "UpdatedDate": "2018-08-12T16:55:29.9415162+02:00",
  "Description": "Diverse upward-trending open architecture",
  "Postit": "velit",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Object-based next generation parallelism",
  "ActiveStatusMonitorId": 477,
  "Links": [
    {
      "EntityName": "Kovacek-Johnson",
      "Id": 302,
      "Description": "Optimized fault-tolerant projection",
      "ExtraInfo": "assumenda",
      "LinkId": 943
    },
    {
      "EntityName": "Kovacek-Johnson",
      "Id": 302,
      "Description": "Optimized fault-tolerant projection",
      "ExtraInfo": "assumenda",
      "LinkId": 943
    }
  ],
  "ActiveLinks": 977,
  "Completed": false,
  "NextMilestoneDate": "2013-06-20T16:55:29.9435168+02:00",
  "NmdAppointmentId": 114,
  "EndDate": "2004-02-21T16:55:29.9435168+01:00",
  "ActiveErpLinks": 987,
  "UserDefinedFields": {
    "SuperOffice:1": "1806516616",
    "SuperOffice:2": "Ashton Cronin"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "quasi"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "perferendis"
  },
  "PublishEventDate": "2012-05-07T16:55:29.9435168+02:00",
  "PublishTo": "2010-04-10T16:55:29.9435168+02:00",
  "PublishFrom": "2006-12-24T16:55:29.9435168+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 739,
  "Name": "Wiza Group",
  "ProjectNumber": "729983",
  "ProjectMembers": [
    {
      "ProjectmemberId": 582,
      "ContactId": 460,
      "ProjectId": 930,
      "ContactName": "Murazik-Wilkinson",
      "ContactDepartment": "",
      "ProjectName": "Bauch-Bruen",
      "EmailId": 83,
      "EmailAddress": "fredy.johns@lesch.biz",
      "CountryId": 346,
      "Firstname": "Elta",
      "MiddleName": "Mayer-Yundt",
      "Lastname": "Hauck",
      "PersonId": 734,
      "Mrmrs": "non",
      "ProjectMemberTypeName": "Wisozk-Klocko",
      "Phone": "1-343-260-3627",
      "PhoneId": 602,
      "ProjectMemberTypeId": 354,
      "EmailAddressName": "pearl@sipes.name",
      "Comment": "qui",
      "FullName": "Mr. Elizabeth Herminia Okuneva",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "alias",
      "StrippedValue": "est",
      "Description": "Managed 5th generation encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "est",
      "Description": "Managed 5th generation encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "CreatedDate": "2002-01-03T16:55:29.9475441+01:00",
  "UpdatedDate": "2017-05-29T16:55:29.9475441+02:00",
  "Description": "Cross-platform intangible function",
  "Postit": "repudiandae",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Configurable attitude-oriented product",
  "ActiveStatusMonitorId": 592,
  "Links": [
    {
      "EntityName": "Considine, Witting and McKenzie",
      "Id": 1000,
      "Description": "Devolved coherent circuit",
      "ExtraInfo": "soluta",
      "LinkId": 299,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 409
        }
      }
    }
  ],
  "ActiveLinks": 821,
  "Completed": false,
  "NextMilestoneDate": "2011-08-26T16:55:29.9485437+02:00",
  "NmdAppointmentId": 168,
  "EndDate": "2001-11-14T16:55:29.9485437+01:00",
  "ActiveErpLinks": 391,
  "UserDefinedFields": {
    "SuperOffice:1": "Sonny Donnelly",
    "SuperOffice:2": "Christophe Nils Feest V"
  },
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "explicabo"
  },
  "PublishEventDate": "2011-12-13T16:55:29.9485437+01:00",
  "PublishTo": "2009-06-04T16:55:29.9485437+02:00",
  "PublishFrom": "2023-02-16T16:55:29.9485437+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 222
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```