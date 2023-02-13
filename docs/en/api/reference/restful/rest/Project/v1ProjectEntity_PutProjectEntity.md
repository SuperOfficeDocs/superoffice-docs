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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 55,
  "Name": "Jast, Connelly and Altenwerth",
  "ProjectNumber": "1132901",
  "ProjectMembers": [
    {
      "ProjectmemberId": 931,
      "ContactId": 644,
      "ProjectId": 678,
      "ContactName": "Bruen LLC",
      "ContactDepartment": "",
      "ProjectName": "Robel-Flatley",
      "EmailId": 391,
      "EmailAddress": "obie@padberg.name",
      "CountryId": 850,
      "Firstname": "Jannie",
      "MiddleName": "Effertz-Schumm",
      "Lastname": "Hilpert",
      "PersonId": 64,
      "Mrmrs": "maxime",
      "ProjectMemberTypeName": "McCullough Group",
      "Phone": "(675)952-1169",
      "PhoneId": 316,
      "ProjectMemberTypeId": 169,
      "EmailAddressName": "orval@okeefemosciski.ca",
      "Comment": "velit",
      "FullName": "Ms. Albin Hessel"
    }
  ],
  "Urls": [
    {
      "Value": "facilis",
      "StrippedValue": "voluptatibus",
      "Description": "Public-key well-modulated secured line"
    },
    {
      "Value": "facilis",
      "StrippedValue": "voluptatibus",
      "Description": "Public-key well-modulated secured line"
    }
  ],
  "CreatedDate": "2017-08-17T11:22:45.0225151+02:00",
  "UpdatedDate": "2004-02-15T11:22:45.0225151+01:00",
  "Description": "Persevering human-resource throughput",
  "Postit": "excepturi",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Advanced well-modulated standardization",
  "ActiveStatusMonitorId": 366,
  "Links": [
    {
      "EntityName": "Dickinson, Cartwright and Bogisich",
      "Id": 785,
      "Description": "Seamless transitional support",
      "ExtraInfo": "qui",
      "LinkId": 212
    },
    {
      "EntityName": "Dickinson, Cartwright and Bogisich",
      "Id": 785,
      "Description": "Seamless transitional support",
      "ExtraInfo": "qui",
      "LinkId": 212
    }
  ],
  "ActiveLinks": 941,
  "Completed": true,
  "NextMilestoneDate": "2007-07-20T11:22:45.0225151+02:00",
  "NmdAppointmentId": 806,
  "EndDate": "2018-08-12T11:22:45.0225151+02:00",
  "ActiveErpLinks": 268,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1523006868"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "dignissimos",
    "CustomFields2": "nihil"
  },
  "PublishEventDate": "2005-03-03T11:22:45.0225151+01:00",
  "PublishTo": "2019-09-07T11:22:45.0225151+02:00",
  "PublishFrom": "2005-09-29T11:22:45.0225151+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 466,
  "Name": "Fay Inc and Sons",
  "ProjectNumber": "1623161",
  "ProjectMembers": [
    {
      "ProjectmemberId": 656,
      "ContactId": 560,
      "ProjectId": 730,
      "ContactName": "Schoen-Goldner",
      "ContactDepartment": "",
      "ProjectName": "Kemmer-Wilkinson",
      "EmailId": 233,
      "EmailAddress": "annamae@batz.ca",
      "CountryId": 426,
      "Firstname": "Abbigail",
      "MiddleName": "Hoeger Group",
      "Lastname": "Rosenbaum",
      "PersonId": 173,
      "Mrmrs": "vitae",
      "ProjectMemberTypeName": "Sanford-Schmitt",
      "Phone": "325.405.2603 x81166",
      "PhoneId": 228,
      "ProjectMemberTypeId": 722,
      "EmailAddressName": "ezequiel_corwin@boehmschimmel.name",
      "Comment": "quia",
      "FullName": "Josefa Hessel III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "omnis",
      "Description": "Synergized dynamic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "omnis",
      "Description": "Synergized dynamic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    }
  ],
  "CreatedDate": "2004-06-12T11:22:45.0381374+02:00",
  "UpdatedDate": "2020-01-15T11:22:45.0381374+01:00",
  "Description": "Diverse composite challenge",
  "Postit": "quas",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Total background task-force",
  "ActiveStatusMonitorId": 87,
  "Links": [
    {
      "EntityName": "Graham Group",
      "Id": 24,
      "Description": "Monitored heuristic encryption",
      "ExtraInfo": "libero",
      "LinkId": 943,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 891
        }
      }
    }
  ],
  "ActiveLinks": 670,
  "Completed": false,
  "NextMilestoneDate": "1997-11-08T11:22:45.0381374+01:00",
  "NmdAppointmentId": 160,
  "EndDate": "2000-06-09T11:22:45.0381374+02:00",
  "ActiveErpLinks": 84,
  "UserDefinedFields": {
    "SuperOffice:1": "33156743",
    "SuperOffice:2": "244802961"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "quaerat",
    "CustomFields2": "ex"
  },
  "PublishEventDate": "2009-06-29T11:22:45.0381374+02:00",
  "PublishTo": "2007-02-27T11:22:45.0381374+01:00",
  "PublishFrom": "2012-12-29T11:22:45.0381374+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 209
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```