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
  "ProjectId": 45,
  "Name": "Howe-McDermott",
  "ProjectNumber": "386916",
  "ProjectMembers": [
    {
      "ProjectmemberId": 27,
      "ContactId": 46,
      "ProjectId": 891,
      "ContactName": "Kris, Hyatt and Hilpert",
      "ContactDepartment": "",
      "ProjectName": "O'Keefe-Kerluke",
      "EmailId": 878,
      "EmailAddress": "fermin_ullrich@ward.co.uk",
      "CountryId": 910,
      "Firstname": "Hettie",
      "MiddleName": "Cummerata LLC",
      "Lastname": "Schimmel",
      "PersonId": 290,
      "Mrmrs": "sunt",
      "ProjectMemberTypeName": "Hamill, King and Lubowitz",
      "Phone": "(558)786-4993 x98979",
      "PhoneId": 741,
      "ProjectMemberTypeId": 438,
      "EmailAddressName": "rowena@zemlak.biz",
      "Comment": "voluptatibus",
      "FullName": "Demetris Kohler"
    }
  ],
  "Urls": [
    {
      "Value": "ducimus",
      "StrippedValue": "ea",
      "Description": "Intuitive eco-centric instruction set"
    },
    {
      "Value": "ducimus",
      "StrippedValue": "ea",
      "Description": "Intuitive eco-centric instruction set"
    }
  ],
  "CreatedDate": "2004-05-13T14:45:12.9587882+02:00",
  "UpdatedDate": "2023-06-02T14:45:12.9587882+02:00",
  "Description": "Optimized grid-enabled alliance",
  "Postit": "molestiae",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Compatible content-based local area network",
  "ActiveStatusMonitorId": 748,
  "Links": [
    {
      "EntityName": "Schmeler LLC",
      "Id": 934,
      "Description": "Fully-configurable multimedia core",
      "ExtraInfo": "ut",
      "LinkId": 386
    },
    {
      "EntityName": "Schmeler LLC",
      "Id": 934,
      "Description": "Fully-configurable multimedia core",
      "ExtraInfo": "ut",
      "LinkId": 386
    }
  ],
  "ActiveLinks": 205,
  "Completed": false,
  "NextMilestoneDate": "2017-07-31T14:45:12.9587882+02:00",
  "NmdAppointmentId": 470,
  "EndDate": "2020-10-17T14:45:12.9587882+02:00",
  "ActiveErpLinks": 688,
  "UserDefinedFields": {
    "SuperOffice:1": "Oma Kreiger",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "quod"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "occaecati"
  },
  "PublishEventDate": "2015-10-28T14:45:12.9587882+01:00",
  "PublishTo": "2008-06-21T14:45:12.9587882+02:00",
  "PublishFrom": "2015-01-19T14:45:12.9587882+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 40,
  "Name": "Haag LLC",
  "ProjectNumber": "1149593",
  "ProjectMembers": [
    {
      "ProjectmemberId": 994,
      "ContactId": 535,
      "ProjectId": 292,
      "ContactName": "Yost, Walsh and Herman",
      "ContactDepartment": "",
      "ProjectName": "Ritchie-Sawayn",
      "EmailId": 966,
      "EmailAddress": "marisa@lowe.biz",
      "CountryId": 808,
      "Firstname": "Maurine",
      "MiddleName": "Frami LLC",
      "Lastname": "Douglas",
      "PersonId": 207,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Olson-McClure",
      "Phone": "124-083-8866",
      "PhoneId": 969,
      "ProjectMemberTypeId": 275,
      "EmailAddressName": "heloise_wehner@cassin.biz",
      "Comment": "expedita",
      "FullName": "Prof. Burdette Grant II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vero",
      "StrippedValue": "quo",
      "Description": "Right-sized modular standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "quo",
      "Description": "Right-sized modular standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    }
  ],
  "CreatedDate": "2012-08-08T14:45:12.9587882+02:00",
  "UpdatedDate": "2013-01-24T14:45:12.9587882+01:00",
  "Description": "Devolved client-driven service-desk",
  "Postit": "explicabo",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Intuitive methodical moratorium",
  "ActiveStatusMonitorId": 229,
  "Links": [
    {
      "EntityName": "Lehner-Bayer",
      "Id": 124,
      "Description": "Optional executive neural-net",
      "ExtraInfo": "vero",
      "LinkId": 739,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 479
        }
      }
    }
  ],
  "ActiveLinks": 164,
  "Completed": true,
  "NextMilestoneDate": "2007-08-23T14:45:12.9587882+02:00",
  "NmdAppointmentId": 1000,
  "EndDate": "2024-09-27T14:45:12.9587882+02:00",
  "ActiveErpLinks": 687,
  "UserDefinedFields": {
    "SuperOffice:1": "1891839955",
    "SuperOffice:2": "Gino Yundt"
  },
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "atque"
  },
  "CustomFields": {
    "CustomFields1": "vero",
    "CustomFields2": "ratione"
  },
  "PublishEventDate": "2003-12-30T14:45:12.9587882+01:00",
  "PublishTo": "1999-09-17T14:45:12.9587882+02:00",
  "PublishFrom": "2024-09-07T14:45:12.9587882+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 421
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```