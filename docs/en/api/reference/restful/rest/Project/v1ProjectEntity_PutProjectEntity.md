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
  "ProjectId": 429,
  "Name": "Shanahan-Dickinson",
  "ProjectNumber": "502057",
  "ProjectMembers": [
    {
      "ProjectmemberId": 593,
      "ContactId": 341,
      "ProjectId": 800,
      "ContactName": "Schumm LLC",
      "ContactDepartment": "",
      "ProjectName": "Lakin-Rogahn",
      "EmailId": 420,
      "EmailAddress": "leila.bergnaum@ledner.uk",
      "CountryId": 772,
      "Firstname": "Jack",
      "MiddleName": "Wintheiser, Kihn and Grady",
      "Lastname": "Streich",
      "PersonId": 947,
      "Mrmrs": "sit",
      "ProjectMemberTypeName": "Mertz, Orn and Stracke",
      "Phone": "157.739.9378 x211",
      "PhoneId": 561,
      "ProjectMemberTypeId": 431,
      "EmailAddressName": "felix.hamill@hickle.com",
      "Comment": "et",
      "FullName": "Miss Marjorie Stamm"
    }
  ],
  "Urls": [
    {
      "Value": "suscipit",
      "StrippedValue": "quod",
      "Description": "Secured modular migration"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "quod",
      "Description": "Secured modular migration"
    }
  ],
  "CreatedDate": "2008-10-18T14:19:10.5061021+02:00",
  "UpdatedDate": "2006-04-08T14:19:10.5061021+02:00",
  "Description": "Multi-layered zero administration secured line",
  "Postit": "est",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "User-centric national encryption",
  "ActiveStatusMonitorId": 557,
  "Links": [
    {
      "EntityName": "Rippin-Emard",
      "Id": 51,
      "Description": "Synergized optimizing archive",
      "ExtraInfo": "aut",
      "LinkId": 694
    },
    {
      "EntityName": "Rippin-Emard",
      "Id": 51,
      "Description": "Synergized optimizing archive",
      "ExtraInfo": "aut",
      "LinkId": 694
    }
  ],
  "ActiveLinks": 981,
  "Completed": false,
  "NextMilestoneDate": "2006-02-25T14:19:10.5061021+01:00",
  "NmdAppointmentId": 286,
  "EndDate": "2000-03-14T14:19:10.5061021+01:00",
  "ActiveErpLinks": 866,
  "UserDefinedFields": {
    "SuperOffice:1": "906505847",
    "SuperOffice:2": "1438345675"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "quisquam",
    "CustomFields2": "nesciunt"
  },
  "PublishEventDate": "1998-09-05T14:19:10.5061021+02:00",
  "PublishTo": "2017-11-07T14:19:10.5061021+01:00",
  "PublishFrom": "2006-09-01T14:19:10.5061021+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 695,
  "Name": "Block Inc and Sons",
  "ProjectNumber": "1530487",
  "ProjectMembers": [
    {
      "ProjectmemberId": 883,
      "ContactId": 696,
      "ProjectId": 352,
      "ContactName": "Wuckert-Cormier",
      "ContactDepartment": "",
      "ProjectName": "Flatley Group",
      "EmailId": 370,
      "EmailAddress": "burnice.lindgren@bodelang.co.uk",
      "CountryId": 138,
      "Firstname": "Faustino",
      "MiddleName": "Kirlin-Schmeler",
      "Lastname": "Glover",
      "PersonId": 558,
      "Mrmrs": "enim",
      "ProjectMemberTypeName": "Jenkins, O'Hara and Mueller",
      "Phone": "058.245.6420",
      "PhoneId": 689,
      "ProjectMemberTypeId": 578,
      "EmailAddressName": "valentine@mueller.co.uk",
      "Comment": "asperiores",
      "FullName": "Prof. Bernadine Champlin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "laborum",
      "Description": "Seamless logistical knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "laborum",
      "Description": "Seamless logistical knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    }
  ],
  "CreatedDate": "2006-05-23T14:19:10.5061021+02:00",
  "UpdatedDate": "2021-05-23T14:19:10.5061021+02:00",
  "Description": "Innovative human-resource encryption",
  "Postit": "id",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Sharable motivating paradigm",
  "ActiveStatusMonitorId": 999,
  "Links": [
    {
      "EntityName": "Frami-Herzog",
      "Id": 311,
      "Description": "Stand-alone optimizing interface",
      "ExtraInfo": "est",
      "LinkId": 888,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 268
        }
      }
    }
  ],
  "ActiveLinks": 122,
  "Completed": false,
  "NextMilestoneDate": "2002-06-28T14:19:10.5061021+02:00",
  "NmdAppointmentId": 290,
  "EndDate": "2007-02-17T14:19:10.5061021+01:00",
  "ActiveErpLinks": 155,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mrs. Junius Leora White I"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "fugit"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "quae"
  },
  "PublishEventDate": "1996-07-02T14:19:10.5061021+02:00",
  "PublishTo": "2008-09-25T14:19:10.5061021+02:00",
  "PublishFrom": "2002-06-15T14:19:10.5061021+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 755
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```