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
  "ProjectId": 22,
  "Name": "Schroeder, Kassulke and Reichert",
  "ProjectNumber": "1488683",
  "ProjectMembers": [
    {
      "ProjectmemberId": 776,
      "ContactId": 375,
      "ProjectId": 341,
      "ContactName": "Hackett Group",
      "ContactDepartment": "",
      "ProjectName": "Russel-Ernser",
      "EmailId": 148,
      "EmailAddress": "ressie.beer@brown.uk",
      "CountryId": 360,
      "Firstname": "Una",
      "MiddleName": "McGlynn, Smith and Huel",
      "Lastname": "Harris",
      "PersonId": 3,
      "Mrmrs": "sit",
      "ProjectMemberTypeName": "Rau-Hermiston",
      "Phone": "782.025.7802",
      "PhoneId": 914,
      "ProjectMemberTypeId": 904,
      "EmailAddressName": "fae@franeckihauck.co.uk",
      "Comment": "natus",
      "FullName": "Prof. Bradley Gibson IV"
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "optio",
      "Description": "Optimized clear-thinking definition"
    },
    {
      "Value": "velit",
      "StrippedValue": "optio",
      "Description": "Optimized clear-thinking definition"
    }
  ],
  "CreatedDate": "2009-11-25T12:01:33.0113182+01:00",
  "UpdatedDate": "2011-08-17T12:01:33.0113182+02:00",
  "Description": "Managed multimedia parallelism",
  "Postit": "tempore",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Compatible mobile orchestration",
  "ActiveStatusMonitorId": 604,
  "Links": [
    {
      "EntityName": "Larkin Group",
      "Id": 513,
      "Description": "Customer-focused impactful pricing structure",
      "ExtraInfo": "rem",
      "LinkId": 941
    },
    {
      "EntityName": "Larkin Group",
      "Id": 513,
      "Description": "Customer-focused impactful pricing structure",
      "ExtraInfo": "rem",
      "LinkId": 941
    }
  ],
  "ActiveLinks": 140,
  "Completed": false,
  "NextMilestoneDate": "2017-06-14T12:01:33.0113182+02:00",
  "NmdAppointmentId": 958,
  "EndDate": "2013-07-19T12:01:33.0113182+02:00",
  "ActiveErpLinks": 661,
  "UserDefinedFields": {
    "SuperOffice:1": "38835976",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "harum"
  },
  "PublishEventDate": "2007-05-19T12:01:33.0113182+02:00",
  "PublishTo": "2015-09-08T12:01:33.0113182+02:00",
  "PublishFrom": "2000-01-07T12:01:33.0113182+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 340,
  "Name": "Champlin LLC",
  "ProjectNumber": "904561",
  "ProjectMembers": [
    {
      "ProjectmemberId": 324,
      "ContactId": 939,
      "ProjectId": 172,
      "ContactName": "Rippin-Ankunding",
      "ContactDepartment": "",
      "ProjectName": "Fritsch, Blick and Mante",
      "EmailId": 651,
      "EmailAddress": "joyce_abbott@swift.info",
      "CountryId": 258,
      "Firstname": "Rafael",
      "MiddleName": "Haag Inc and Sons",
      "Lastname": "Cronin",
      "PersonId": 723,
      "Mrmrs": "laboriosam",
      "ProjectMemberTypeName": "Hilll Inc and Sons",
      "Phone": "1-803-827-1851 x367",
      "PhoneId": 423,
      "ProjectMemberTypeId": 445,
      "EmailAddressName": "andre_miller@trompjohnson.com",
      "Comment": "quis",
      "FullName": "Felton Bailey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 593
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vitae",
      "StrippedValue": "expedita",
      "Description": "Team-oriented coherent migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "expedita",
      "Description": "Team-oriented coherent migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    }
  ],
  "CreatedDate": "2001-06-08T12:01:33.0113182+02:00",
  "UpdatedDate": "2011-09-20T12:01:33.0113182+02:00",
  "Description": "Multi-channelled assymetric archive",
  "Postit": "assumenda",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Configurable motivating artificial intelligence",
  "ActiveStatusMonitorId": 389,
  "Links": [
    {
      "EntityName": "Hodkiewicz, Johnston and McDermott",
      "Id": 945,
      "Description": "Streamlined homogeneous attitude",
      "ExtraInfo": "sunt",
      "LinkId": 899,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 647
        }
      }
    }
  ],
  "ActiveLinks": 815,
  "Completed": false,
  "NextMilestoneDate": "2012-04-06T12:01:33.0113182+02:00",
  "NmdAppointmentId": 568,
  "EndDate": "2006-02-01T12:01:33.0113182+01:00",
  "ActiveErpLinks": 469,
  "UserDefinedFields": {
    "SuperOffice:1": "Elliott Schoen",
    "SuperOffice:2": "Lavon Kunde"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "quibusdam"
  },
  "PublishEventDate": "2005-01-26T12:01:33.0113182+01:00",
  "PublishTo": "2017-05-13T12:01:33.0113182+02:00",
  "PublishFrom": "2023-07-12T12:01:33.0113182+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 741
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```