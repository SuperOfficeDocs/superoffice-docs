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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 835,
  "Name": "Boehm Group",
  "ProjectNumber": "1037808",
  "ProjectMembers": [
    {
      "ProjectmemberId": 567,
      "ContactId": 192,
      "ProjectId": 299,
      "ContactName": "Jones Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Dach, Fritsch and Langworth",
      "EmailId": 170,
      "EmailAddress": "darrell.wintheiser@bahringerkulas.name",
      "CountryId": 846,
      "Firstname": "Rudolph",
      "MiddleName": "Harris, Weimann and Parker",
      "Lastname": "McCullough",
      "PersonId": 695,
      "Mrmrs": "quam",
      "ProjectMemberTypeName": "Dickens-Lang",
      "Phone": "666.124.0809",
      "PhoneId": 446,
      "ProjectMemberTypeId": 77,
      "EmailAddressName": "sean@boscotreutel.uk",
      "Comment": "impedit",
      "FullName": "Ashlynn Altenwerth"
    }
  ],
  "Urls": [
    {
      "Value": "hic",
      "StrippedValue": "animi",
      "Description": "Front-line scalable artificial intelligence"
    },
    {
      "Value": "hic",
      "StrippedValue": "animi",
      "Description": "Front-line scalable artificial intelligence"
    }
  ],
  "CreatedDate": "2012-06-29T02:38:26.2141814+02:00",
  "UpdatedDate": "2022-05-22T02:38:26.2141814+02:00",
  "Description": "Re-engineered optimizing hierarchy",
  "Postit": "quis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Configurable stable support",
  "ActiveStatusMonitorId": 294,
  "Links": [
    {
      "EntityName": "Krajcik, Hirthe and Marks",
      "Id": 884,
      "Description": "Implemented discrete time-frame",
      "ExtraInfo": "non",
      "LinkId": 308
    },
    {
      "EntityName": "Krajcik, Hirthe and Marks",
      "Id": 884,
      "Description": "Implemented discrete time-frame",
      "ExtraInfo": "non",
      "LinkId": 308
    }
  ],
  "ActiveLinks": 155,
  "Completed": false,
  "NextMilestoneDate": "2010-02-13T02:38:26.2141814+01:00",
  "NmdAppointmentId": 318,
  "EndDate": "2017-12-15T02:38:26.2141814+01:00",
  "ActiveErpLinks": 163,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Estefania Matt Dickinson DVM",
    "SuperOffice:2": "1290829848"
  },
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "neque"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "fuga"
  },
  "PublishEventDate": "2002-10-28T02:38:26.2141814+01:00",
  "PublishTo": "2002-11-18T02:38:26.2141814+01:00",
  "PublishFrom": "2013-09-11T02:38:26.2141814+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 102,
  "Name": "Shanahan Inc and Sons",
  "ProjectNumber": "1115747",
  "ProjectMembers": [
    {
      "ProjectmemberId": 394,
      "ContactId": 976,
      "ProjectId": 401,
      "ContactName": "Steuber-Green",
      "ContactDepartment": "",
      "ProjectName": "Koepp, Raynor and Wolf",
      "EmailId": 849,
      "EmailAddress": "ellen@kulas.info",
      "CountryId": 698,
      "Firstname": "Floyd",
      "MiddleName": "Schneider Group",
      "Lastname": "Cummings",
      "PersonId": 264,
      "Mrmrs": "natus",
      "ProjectMemberTypeName": "Simonis Inc and Sons",
      "Phone": "954-461-5538 x9422",
      "PhoneId": 983,
      "ProjectMemberTypeId": 768,
      "EmailAddressName": "dalton.balistreri@gulgowski.name",
      "Comment": "hic",
      "FullName": "Bailee Gerlach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 309
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nemo",
      "StrippedValue": "ad",
      "Description": "Devolved responsive secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "ad",
      "Description": "Devolved responsive secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    }
  ],
  "CreatedDate": "2020-12-01T02:38:26.2141814+01:00",
  "UpdatedDate": "2022-11-05T02:38:26.2141814+01:00",
  "Description": "Persevering system-worthy project",
  "Postit": "pariatur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Operative local benchmark",
  "ActiveStatusMonitorId": 883,
  "Links": [
    {
      "EntityName": "Howe-Kuhn",
      "Id": 471,
      "Description": "Profound value-added benchmark",
      "ExtraInfo": "minima",
      "LinkId": 81,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "ActiveLinks": 387,
  "Completed": true,
  "NextMilestoneDate": "1999-10-07T02:38:26.2141814+02:00",
  "NmdAppointmentId": 810,
  "EndDate": "2001-10-15T02:38:26.2141814+02:00",
  "ActiveErpLinks": 414,
  "UserDefinedFields": {
    "SuperOffice:1": "Kiara Funk",
    "SuperOffice:2": "Katarina O'Hara"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "ullam"
  },
  "PublishEventDate": "2025-03-05T02:38:26.2141814+01:00",
  "PublishTo": "2020-10-14T02:38:26.2141814+02:00",
  "PublishFrom": "2018-04-19T02:38:26.2141814+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 478
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```