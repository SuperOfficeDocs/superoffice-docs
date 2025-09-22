---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
content_type: reference
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
  "ProjectId": 722,
  "Name": "Nikolaus-Erdman",
  "ProjectNumber": "546299",
  "ProjectMembers": [
    {
      "ProjectmemberId": 369,
      "ContactId": 335,
      "ProjectId": 564,
      "ContactName": "Brakus Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Bogan-Haley",
      "EmailId": 958,
      "EmailAddress": "joana_zieme@pfeffer.info",
      "CountryId": 488,
      "Firstname": "Bell",
      "MiddleName": "Kuhn, Predovic and Hartmann",
      "Lastname": "Zboncak",
      "PersonId": 202,
      "Mrmrs": "commodi",
      "ProjectMemberTypeName": "Strosin Inc and Sons",
      "Phone": "(293)528-2356 x81636",
      "PhoneId": 323,
      "ProjectMemberTypeId": 130,
      "EmailAddressName": "doug.rempel@ward.us",
      "Comment": "deleniti",
      "FullName": "Janie Leannon",
      "Registered": "2007-01-11T11:24:53.4530638+01:00",
      "Updated": "2015-05-27T11:24:53.4530638+02:00"
    }
  ],
  "Urls": [
    {
      "Value": "placeat",
      "StrippedValue": "ut",
      "Description": "Diverse object-oriented system engine"
    },
    {
      "Value": "placeat",
      "StrippedValue": "ut",
      "Description": "Diverse object-oriented system engine"
    }
  ],
  "CreatedDate": "2025-01-27T11:24:53.4530638+01:00",
  "UpdatedDate": "2010-09-15T11:24:53.4530638+02:00",
  "Description": "Multi-lateral mission-critical utilisation",
  "Postit": "ex",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Proactive executive encoding",
  "ActiveStatusMonitorId": 312,
  "Links": [
    {
      "EntityName": "Hessel, Krajcik and Kassulke",
      "Id": 66,
      "Description": "Synergized bandwidth-monitored monitoring",
      "ExtraInfo": "explicabo",
      "LinkId": 217
    },
    {
      "EntityName": "Hessel, Krajcik and Kassulke",
      "Id": 66,
      "Description": "Synergized bandwidth-monitored monitoring",
      "ExtraInfo": "explicabo",
      "LinkId": 217
    }
  ],
  "ActiveLinks": 31,
  "Completed": false,
  "NextMilestoneDate": "2012-12-23T11:24:53.4530638+01:00",
  "NmdAppointmentId": 362,
  "EndDate": "2003-09-21T11:24:53.4530638+02:00",
  "ActiveErpLinks": 354,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Juvenal Syble Roberts III",
    "SuperOffice:2": "Mr. Christina Beier"
  },
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "ullam"
  },
  "PublishEventDate": "2003-04-13T11:24:53.4530638+02:00",
  "PublishTo": "2008-03-14T11:24:53.4530638+01:00",
  "PublishFrom": "2000-08-08T11:24:53.4530638+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 930,
  "Name": "Sauer-Ankunding",
  "ProjectNumber": "914569",
  "ProjectMembers": [
    {
      "ProjectmemberId": 538,
      "ContactId": 400,
      "ProjectId": 553,
      "ContactName": "Greenholt, Grimes and Dietrich",
      "ContactDepartment": "",
      "ProjectName": "Davis-Langworth",
      "EmailId": 352,
      "EmailAddress": "kevin_cummerata@kling.info",
      "CountryId": 565,
      "Firstname": "Garry",
      "MiddleName": "Schmitt-Quigley",
      "Lastname": "Herman",
      "PersonId": 89,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Howell LLC",
      "Phone": "(779)194-1052",
      "PhoneId": 246,
      "ProjectMemberTypeId": 506,
      "EmailAddressName": "garret@lang.uk",
      "Comment": "cupiditate",
      "FullName": "Ms. Zachery Arianna Parker PhD",
      "Registered": "2021-06-04T11:24:53.4530638+02:00",
      "Updated": "2001-01-20T11:24:53.4530638+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "dolor",
      "Description": "Switchable grid-enabled model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "dolor",
      "Description": "Switchable grid-enabled model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    }
  ],
  "CreatedDate": "2020-04-15T11:24:53.4530638+02:00",
  "UpdatedDate": "2001-11-29T11:24:53.4530638+01:00",
  "Description": "Ameliorated holistic throughput",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Optimized modular utilisation",
  "ActiveStatusMonitorId": 710,
  "Links": [
    {
      "EntityName": "Krajcik Group",
      "Id": 460,
      "Description": "Cloned optimizing neural-net",
      "ExtraInfo": "aut",
      "LinkId": 193,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 48
        }
      }
    }
  ],
  "ActiveLinks": 633,
  "Completed": true,
  "NextMilestoneDate": "2006-08-06T11:24:53.4530638+02:00",
  "NmdAppointmentId": 139,
  "EndDate": "2005-08-05T11:24:53.4530638+02:00",
  "ActiveErpLinks": 102,
  "UserDefinedFields": {
    "SuperOffice:1": "870167733",
    "SuperOffice:2": "Melba Cormier"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "quaerat"
  },
  "PublishEventDate": "2000-07-01T11:24:53.4530638+02:00",
  "PublishTo": "2015-03-21T11:24:53.4530638+01:00",
  "PublishFrom": "1999-06-13T11:24:53.4530638+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 4
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```