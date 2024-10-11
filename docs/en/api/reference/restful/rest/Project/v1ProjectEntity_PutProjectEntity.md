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
  "ProjectId": 832,
  "Name": "O'Hara LLC",
  "ProjectNumber": "1185332",
  "ProjectMembers": [
    {
      "ProjectmemberId": 220,
      "ContactId": 333,
      "ProjectId": 652,
      "ContactName": "Schowalter LLC",
      "ContactDepartment": "",
      "ProjectName": "Rowe, Bauch and Dooley",
      "EmailId": 337,
      "EmailAddress": "hank.lemke@streich.us",
      "CountryId": 739,
      "Firstname": "Felicia",
      "MiddleName": "Bernier, Bechtelar and Cronin",
      "Lastname": "Ferry",
      "PersonId": 179,
      "Mrmrs": "earum",
      "ProjectMemberTypeName": "Predovic-Dare",
      "Phone": "584.603.2633",
      "PhoneId": 178,
      "ProjectMemberTypeId": 269,
      "EmailAddressName": "hugh_mueller@konopelski.co.uk",
      "Comment": "culpa",
      "FullName": "Miss Savanah Jakubowski DDS"
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "adipisci",
      "Description": "Optional 24/7 knowledge base"
    },
    {
      "Value": "enim",
      "StrippedValue": "adipisci",
      "Description": "Optional 24/7 knowledge base"
    }
  ],
  "CreatedDate": "2020-07-16T03:44:57.4688121+02:00",
  "UpdatedDate": "1997-06-09T03:44:57.4688121+02:00",
  "Description": "Cross-group radical application",
  "Postit": "ipsum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Focused clear-thinking policy",
  "ActiveStatusMonitorId": 89,
  "Links": [
    {
      "EntityName": "Mante LLC",
      "Id": 59,
      "Description": "Vision-oriented intangible process improvement",
      "ExtraInfo": "voluptate",
      "LinkId": 61
    },
    {
      "EntityName": "Mante LLC",
      "Id": 59,
      "Description": "Vision-oriented intangible process improvement",
      "ExtraInfo": "voluptate",
      "LinkId": 61
    }
  ],
  "ActiveLinks": 234,
  "Completed": true,
  "NextMilestoneDate": "2009-09-12T03:44:57.4688121+02:00",
  "NmdAppointmentId": 939,
  "EndDate": "2010-03-08T03:44:57.4688121+01:00",
  "ActiveErpLinks": 921,
  "UserDefinedFields": {
    "SuperOffice:1": "Dangelo Block V",
    "SuperOffice:2": "Ms. Ima Larson MD"
  },
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2017-10-15T03:44:57.4688121+02:00",
  "PublishTo": "2002-07-21T03:44:57.4688121+02:00",
  "PublishFrom": "2016-03-03T03:44:57.4688121+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 717,
  "Name": "Hudson-Goldner",
  "ProjectNumber": "909937",
  "ProjectMembers": [
    {
      "ProjectmemberId": 563,
      "ContactId": 792,
      "ProjectId": 568,
      "ContactName": "Parker, Kris and Kessler",
      "ContactDepartment": "",
      "ProjectName": "Collier-Lebsack",
      "EmailId": 340,
      "EmailAddress": "daisy@hammes.co.uk",
      "CountryId": 408,
      "Firstname": "Mya",
      "MiddleName": "Schulist LLC",
      "Lastname": "Adams",
      "PersonId": 419,
      "Mrmrs": "ea",
      "ProjectMemberTypeName": "Walter, Boyer and Connelly",
      "Phone": "1-995-084-4223",
      "PhoneId": 619,
      "ProjectMemberTypeId": 124,
      "EmailAddressName": "mauricio@donnelly.info",
      "Comment": "nostrum",
      "FullName": "Ezekiel Cremin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 772
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "facilis",
      "StrippedValue": "optio",
      "Description": "Cloned zero tolerance definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "optio",
      "Description": "Cloned zero tolerance definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    }
  ],
  "CreatedDate": "2007-10-07T03:44:57.4688121+02:00",
  "UpdatedDate": "2022-06-06T03:44:57.4688121+02:00",
  "Description": "Polarised intermediate migration",
  "Postit": "aut",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Assimilated multi-state groupware",
  "ActiveStatusMonitorId": 810,
  "Links": [
    {
      "EntityName": "Gibson Inc and Sons",
      "Id": 82,
      "Description": "Cross-group zero administration alliance",
      "ExtraInfo": "soluta",
      "LinkId": 902,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 65
        }
      }
    }
  ],
  "ActiveLinks": 636,
  "Completed": true,
  "NextMilestoneDate": "2023-10-13T03:44:57.4688121+02:00",
  "NmdAppointmentId": 23,
  "EndDate": "2011-10-23T03:44:57.4688121+02:00",
  "ActiveErpLinks": 821,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Missouri Dooley"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2015-05-28T03:44:57.4688121+02:00",
  "PublishTo": "2010-12-31T03:44:57.4688121+01:00",
  "PublishFrom": "2023-12-12T03:44:57.4688121+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 96
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```