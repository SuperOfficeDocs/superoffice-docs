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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 132,
  "Name": "Weber Inc and Sons",
  "ProjectNumber": "1309913",
  "ProjectMembers": [
    {
      "ProjectmemberId": 903,
      "ContactId": 933,
      "ProjectId": 345,
      "ContactName": "Kertzmann-Kohler",
      "ContactDepartment": "",
      "ProjectName": "Gutmann-Ullrich",
      "EmailId": 915,
      "EmailAddress": "cicero.rau@bayer.co.uk",
      "CountryId": 970,
      "Firstname": "Tess",
      "MiddleName": "Bode-Kassulke",
      "Lastname": "Jaskolski",
      "PersonId": 634,
      "Mrmrs": "asperiores",
      "ProjectMemberTypeName": "Crona-Johnston",
      "Phone": "(336)866-9444 x6974",
      "PhoneId": 966,
      "ProjectMemberTypeId": 856,
      "EmailAddressName": "libbie.wisoky@konopelskicole.info",
      "Comment": "numquam",
      "FullName": "Miss Wava Klein Jr."
    }
  ],
  "Urls": [
    {
      "Value": "possimus",
      "StrippedValue": "placeat",
      "Description": "Adaptive eco-centric pricing structure"
    },
    {
      "Value": "possimus",
      "StrippedValue": "placeat",
      "Description": "Adaptive eco-centric pricing structure"
    }
  ],
  "CreatedDate": "1996-07-15T12:15:27.1536335+02:00",
  "UpdatedDate": "2011-03-21T12:15:27.1536335+01:00",
  "Description": "Multi-layered high-level workforce",
  "Postit": "voluptatem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Optimized dynamic functionalities",
  "ActiveStatusMonitorId": 266,
  "Links": [
    {
      "EntityName": "Legros-Harber",
      "Id": 668,
      "Description": "Right-sized disintermediate hardware",
      "ExtraInfo": "qui",
      "LinkId": 499
    },
    {
      "EntityName": "Legros-Harber",
      "Id": 668,
      "Description": "Right-sized disintermediate hardware",
      "ExtraInfo": "qui",
      "LinkId": 499
    }
  ],
  "ActiveLinks": 703,
  "Completed": true,
  "NextMilestoneDate": "2018-12-10T12:15:27.1546329+01:00",
  "NmdAppointmentId": 997,
  "EndDate": "2019-11-28T12:15:27.1546329+01:00",
  "ActiveErpLinks": 593,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "245989587"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "soluta"
  },
  "CustomFields": {
    "CustomFields1": "maiores",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2013-01-06T12:15:27.1556325+01:00",
  "PublishTo": "2001-08-03T12:15:27.1556325+02:00",
  "PublishFrom": "2015-01-05T12:15:27.1556325+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 437,
  "Name": "Koss Group",
  "ProjectNumber": "1023885",
  "ProjectMembers": [
    {
      "ProjectmemberId": 735,
      "ContactId": 879,
      "ProjectId": 312,
      "ContactName": "Halvorson-Barrows",
      "ContactDepartment": "",
      "ProjectName": "Pfeffer Inc and Sons",
      "EmailId": 604,
      "EmailAddress": "mohammad_pouros@cummerata.biz",
      "CountryId": 31,
      "Firstname": "Maribel",
      "MiddleName": "Eichmann LLC",
      "Lastname": "Schoen",
      "PersonId": 435,
      "Mrmrs": "id",
      "ProjectMemberTypeName": "Okuneva-Schinner",
      "Phone": "017-824-6946",
      "PhoneId": 57,
      "ProjectMemberTypeId": 745,
      "EmailAddressName": "kaleb_waelchi@blick.biz",
      "Comment": "voluptatibus",
      "FullName": "Ross Howe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fugit",
      "StrippedValue": "et",
      "Description": "Versatile local contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 565
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "et",
      "Description": "Versatile local contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 565
        }
      }
    }
  ],
  "CreatedDate": "2021-06-28T12:15:27.1596327+02:00",
  "UpdatedDate": "2014-11-06T12:15:27.1596327+01:00",
  "Description": "Diverse 24/7 initiative",
  "Postit": "aut",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Horizontal intermediate core",
  "ActiveStatusMonitorId": 706,
  "Links": [
    {
      "EntityName": "Quigley, Hane and Bergstrom",
      "Id": 542,
      "Description": "Multi-layered optimal knowledge base",
      "ExtraInfo": "beatae",
      "LinkId": 568,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 624
        }
      }
    }
  ],
  "ActiveLinks": 713,
  "Completed": true,
  "NextMilestoneDate": "1996-08-13T12:15:27.1616331+02:00",
  "NmdAppointmentId": 900,
  "EndDate": "2018-12-08T12:15:27.1616331+01:00",
  "ActiveErpLinks": 606,
  "UserDefinedFields": {
    "SuperOffice:1": "315516838",
    "SuperOffice:2": "552572350"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "voluptates"
  },
  "PublishEventDate": "2012-10-12T12:15:27.1616331+02:00",
  "PublishTo": "2017-10-24T12:15:27.1616331+02:00",
  "PublishFrom": "2012-08-21T12:15:27.1616331+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 45
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```