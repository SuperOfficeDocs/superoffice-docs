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
  "ProjectId": 584,
  "Name": "Cruickshank, Leffler and Labadie",
  "ProjectNumber": "1305577",
  "ProjectMembers": [
    {
      "ProjectmemberId": 396,
      "ContactId": 23,
      "ProjectId": 917,
      "ContactName": "Huel, Barton and Gutkowski",
      "ContactDepartment": "",
      "ProjectName": "Crooks-Durgan",
      "EmailId": 137,
      "EmailAddress": "garrett@hintzjast.biz",
      "CountryId": 754,
      "Firstname": "Fanny",
      "MiddleName": "Fisher-Gaylord",
      "Lastname": "Doyle",
      "PersonId": 610,
      "Mrmrs": "officiis",
      "ProjectMemberTypeName": "Douglas-Olson",
      "Phone": "061-208-6198 x1987",
      "PhoneId": 772,
      "ProjectMemberTypeId": 620,
      "EmailAddressName": "ryley@mante.us",
      "Comment": "explicabo",
      "FullName": "Mr. Lurline Mills PhD"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "nemo",
      "Description": "Fundamental bandwidth-monitored info-mediaries"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "nemo",
      "Description": "Fundamental bandwidth-monitored info-mediaries"
    }
  ],
  "CreatedDate": "2022-09-20T13:13:31.9175657+02:00",
  "UpdatedDate": "2023-06-08T13:13:31.9175657+02:00",
  "Description": "Secured cohesive extranet",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Implemented hybrid hub",
  "ActiveStatusMonitorId": 462,
  "Links": [
    {
      "EntityName": "Russel-Thiel",
      "Id": 769,
      "Description": "Innovative well-modulated hub",
      "ExtraInfo": "labore",
      "LinkId": 946
    },
    {
      "EntityName": "Russel-Thiel",
      "Id": 769,
      "Description": "Innovative well-modulated hub",
      "ExtraInfo": "labore",
      "LinkId": 946
    }
  ],
  "ActiveLinks": 541,
  "Completed": false,
  "NextMilestoneDate": "2023-12-12T13:13:31.9175657+01:00",
  "NmdAppointmentId": 719,
  "EndDate": "2017-12-26T13:13:31.9175657+01:00",
  "ActiveErpLinks": 902,
  "UserDefinedFields": {
    "SuperOffice:1": "Laurianne Sipes III",
    "SuperOffice:2": "1076926266"
  },
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "consectetur"
  },
  "PublishEventDate": "2021-03-13T13:13:31.9175657+01:00",
  "PublishTo": "2021-03-13T13:13:31.9175657+01:00",
  "PublishFrom": "2011-03-10T13:13:31.9175657+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 852,
  "Name": "Greenholt, Gutmann and Osinski",
  "ProjectNumber": "1176684",
  "ProjectMembers": [
    {
      "ProjectmemberId": 471,
      "ContactId": 298,
      "ProjectId": 582,
      "ContactName": "Kozey, Kessler and Bernhard",
      "ContactDepartment": "",
      "ProjectName": "Howell LLC",
      "EmailId": 231,
      "EmailAddress": "cortez.mcclure@tromp.name",
      "CountryId": 500,
      "Firstname": "Santina",
      "MiddleName": "Wolf LLC",
      "Lastname": "Heathcote",
      "PersonId": 208,
      "Mrmrs": "ipsam",
      "ProjectMemberTypeName": "Jaskolski-Crona",
      "Phone": "956-646-9963 x72024",
      "PhoneId": 175,
      "ProjectMemberTypeId": 249,
      "EmailAddressName": "carolanne@kirlin.info",
      "Comment": "quam",
      "FullName": "Ned Jaylen Shields Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 863
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "labore",
      "Description": "Object-based mobile hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 574
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "labore",
      "Description": "Object-based mobile hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 574
        }
      }
    }
  ],
  "CreatedDate": "2023-04-23T13:13:31.933185+02:00",
  "UpdatedDate": "2018-03-03T13:13:31.933185+01:00",
  "Description": "Organic human-resource initiative",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Assimilated web-enabled Graphical User Interface",
  "ActiveStatusMonitorId": 485,
  "Links": [
    {
      "EntityName": "Corkery-Satterfield",
      "Id": 196,
      "Description": "Customer-focused responsive migration",
      "ExtraInfo": "modi",
      "LinkId": 122,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 46
        }
      }
    }
  ],
  "ActiveLinks": 999,
  "Completed": true,
  "NextMilestoneDate": "2015-07-28T13:13:31.933185+02:00",
  "NmdAppointmentId": 698,
  "EndDate": "2012-04-06T13:13:31.933185+02:00",
  "ActiveErpLinks": 204,
  "UserDefinedFields": {
    "SuperOffice:1": "Bettie Kub",
    "SuperOffice:2": "Deron Phyllis Lesch IV"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "eligendi",
    "CustomFields2": "impedit"
  },
  "PublishEventDate": "2003-08-30T13:13:31.933185+02:00",
  "PublishTo": "2009-04-02T13:13:31.933185+02:00",
  "PublishFrom": "2006-07-10T13:13:31.933185+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 741
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```