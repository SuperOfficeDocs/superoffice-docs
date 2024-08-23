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
  "ProjectId": 375,
  "Name": "Ernser-Pacocha",
  "ProjectNumber": "968190",
  "ProjectMembers": [
    {
      "ProjectmemberId": 35,
      "ContactId": 838,
      "ProjectId": 450,
      "ContactName": "Torp, Schiller and Harvey",
      "ContactDepartment": "",
      "ProjectName": "Corkery, Hartmann and Bruen",
      "EmailId": 9,
      "EmailAddress": "geovanni_reichel@haag.uk",
      "CountryId": 151,
      "Firstname": "Marilou",
      "MiddleName": "Thompson, Dach and Hartmann",
      "Lastname": "Ruecker",
      "PersonId": 64,
      "Mrmrs": "provident",
      "ProjectMemberTypeName": "Padberg Group",
      "Phone": "1-823-468-0548 x0780",
      "PhoneId": 857,
      "ProjectMemberTypeId": 417,
      "EmailAddressName": "blaise.lesch@reinger.us",
      "Comment": "similique",
      "FullName": "Vivianne Welch"
    }
  ],
  "Urls": [
    {
      "Value": "deleniti",
      "StrippedValue": "delectus",
      "Description": "Down-sized reciprocal focus group"
    },
    {
      "Value": "deleniti",
      "StrippedValue": "delectus",
      "Description": "Down-sized reciprocal focus group"
    }
  ],
  "CreatedDate": "1998-05-23T13:28:31.8667032+02:00",
  "UpdatedDate": "1998-12-28T13:28:31.8667032+01:00",
  "Description": "Enterprise-wide neutral superstructure",
  "Postit": "deserunt",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Adaptive content-based core",
  "ActiveStatusMonitorId": 84,
  "Links": [
    {
      "EntityName": "Waelchi, Kreiger and McCullough",
      "Id": 350,
      "Description": "Configurable mobile success",
      "ExtraInfo": "molestias",
      "LinkId": 431
    },
    {
      "EntityName": "Waelchi, Kreiger and McCullough",
      "Id": 350,
      "Description": "Configurable mobile success",
      "ExtraInfo": "molestias",
      "LinkId": 431
    }
  ],
  "ActiveLinks": 255,
  "Completed": true,
  "NextMilestoneDate": "2023-03-19T13:28:31.8667032+01:00",
  "NmdAppointmentId": 968,
  "EndDate": "2002-06-21T13:28:31.8667032+02:00",
  "ActiveErpLinks": 556,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Margaretta Hackett",
    "SuperOffice:2": "Prof. Kasey Ferry DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "quaerat"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "libero"
  },
  "PublishEventDate": "2001-02-03T13:28:31.8667032+01:00",
  "PublishTo": "2023-02-08T13:28:31.8667032+01:00",
  "PublishFrom": "2013-10-08T13:28:31.8667032+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 927,
  "Name": "Zieme, Ledner and Carroll",
  "ProjectNumber": "1728104",
  "ProjectMembers": [
    {
      "ProjectmemberId": 93,
      "ContactId": 870,
      "ProjectId": 755,
      "ContactName": "McLaughlin-Farrell",
      "ContactDepartment": "",
      "ProjectName": "Jacobi, Christiansen and Beatty",
      "EmailId": 874,
      "EmailAddress": "charlie_collier@shieldshintz.name",
      "CountryId": 760,
      "Firstname": "Stephen",
      "MiddleName": "Windler Inc and Sons",
      "Lastname": "Ernser",
      "PersonId": 15,
      "Mrmrs": "accusamus",
      "ProjectMemberTypeName": "Collier-Stracke",
      "Phone": "700.667.1502",
      "PhoneId": 188,
      "ProjectMemberTypeId": 617,
      "EmailAddressName": "tyson.pfeffer@kemmer.biz",
      "Comment": "magni",
      "FullName": "Dr. Lera Finn Will II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 205
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "laudantium",
      "StrippedValue": "harum",
      "Description": "Synergized optimizing Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "harum",
      "Description": "Synergized optimizing Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    }
  ],
  "CreatedDate": "2011-05-14T13:28:31.8667032+02:00",
  "UpdatedDate": "2007-03-01T13:28:31.8667032+01:00",
  "Description": "Object-based 4th generation frame",
  "Postit": "blanditiis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Visionary background conglomeration",
  "ActiveStatusMonitorId": 361,
  "Links": [
    {
      "EntityName": "Dickinson Group",
      "Id": 522,
      "Description": "Team-oriented 3rd generation strategy",
      "ExtraInfo": "voluptas",
      "LinkId": 72,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 977
        }
      }
    }
  ],
  "ActiveLinks": 714,
  "Completed": true,
  "NextMilestoneDate": "2010-04-08T13:28:31.8667032+02:00",
  "NmdAppointmentId": 45,
  "EndDate": "2011-01-30T13:28:31.8667032+01:00",
  "ActiveErpLinks": 317,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Elna Stephon Cummings",
    "SuperOffice:2": "613485607"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "odio"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "vel"
  },
  "PublishEventDate": "2006-01-09T13:28:31.8667032+01:00",
  "PublishTo": "2021-07-07T13:28:31.8667032+02:00",
  "PublishFrom": "2017-11-03T13:28:31.8667032+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 502
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```