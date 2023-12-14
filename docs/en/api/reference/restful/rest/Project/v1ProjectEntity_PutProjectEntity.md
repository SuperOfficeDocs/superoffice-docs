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
  "ProjectId": 432,
  "Name": "Spinka Inc and Sons",
  "ProjectNumber": "1857870",
  "ProjectMembers": [
    {
      "ProjectmemberId": 521,
      "ContactId": 367,
      "ProjectId": 87,
      "ContactName": "Monahan, Weissnat and Predovic",
      "ContactDepartment": "",
      "ProjectName": "Kemmer-Lesch",
      "EmailId": 575,
      "EmailAddress": "breana.bashirian@oconnell.ca",
      "CountryId": 284,
      "Firstname": "Chance",
      "MiddleName": "Konopelski, Langosh and DuBuque",
      "Lastname": "Greenholt",
      "PersonId": 664,
      "Mrmrs": "harum",
      "ProjectMemberTypeName": "Hintz LLC",
      "Phone": "1-578-957-9416",
      "PhoneId": 66,
      "ProjectMemberTypeId": 376,
      "EmailAddressName": "britney.barrows@waters.com",
      "Comment": "voluptates",
      "FullName": "Marcellus Nader"
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "aliquid",
      "Description": "Realigned next generation extranet"
    },
    {
      "Value": "dolor",
      "StrippedValue": "aliquid",
      "Description": "Realigned next generation extranet"
    }
  ],
  "CreatedDate": "2013-12-29T13:57:19.0935194+01:00",
  "UpdatedDate": "2014-03-07T13:57:19.0935194+01:00",
  "Description": "Programmable incremental concept",
  "Postit": "dolor",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Enhanced neutral model",
  "ActiveStatusMonitorId": 434,
  "Links": [
    {
      "EntityName": "Robel LLC",
      "Id": 999,
      "Description": "Pre-emptive value-added installation",
      "ExtraInfo": "dolor",
      "LinkId": 521
    },
    {
      "EntityName": "Robel LLC",
      "Id": 999,
      "Description": "Pre-emptive value-added installation",
      "ExtraInfo": "dolor",
      "LinkId": 521
    }
  ],
  "ActiveLinks": 236,
  "Completed": false,
  "NextMilestoneDate": "2016-02-03T13:57:19.0935194+01:00",
  "NmdAppointmentId": 529,
  "EndDate": "2016-04-24T13:57:19.0935194+02:00",
  "ActiveErpLinks": 579,
  "UserDefinedFields": {
    "SuperOffice:1": "1993374440",
    "SuperOffice:2": "Dasia Beier II"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2011-08-19T13:57:19.0935194+02:00",
  "PublishTo": "2012-12-26T13:57:19.0935194+01:00",
  "PublishFrom": "1998-02-15T13:57:19.0935194+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 647,
  "Name": "Rippin, Olson and Bartell",
  "ProjectNumber": "658171",
  "ProjectMembers": [
    {
      "ProjectmemberId": 870,
      "ContactId": 182,
      "ProjectId": 89,
      "ContactName": "McLaughlin-Zboncak",
      "ContactDepartment": "",
      "ProjectName": "Barrows-Goldner",
      "EmailId": 674,
      "EmailAddress": "alexzander.williamson@orn.ca",
      "CountryId": 651,
      "Firstname": "Gretchen",
      "MiddleName": "Cummerata-Padberg",
      "Lastname": "Reinger",
      "PersonId": 400,
      "Mrmrs": "vel",
      "ProjectMemberTypeName": "Frami Inc and Sons",
      "Phone": "920.230.5027",
      "PhoneId": 707,
      "ProjectMemberTypeId": 830,
      "EmailAddressName": "neil_vandervort@walsh.uk",
      "Comment": "dolor",
      "FullName": "Fannie Ruecker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 557
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "veritatis",
      "StrippedValue": "architecto",
      "Description": "Synchronised user-facing workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 19
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "architecto",
      "Description": "Synchronised user-facing workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 19
        }
      }
    }
  ],
  "CreatedDate": "2005-06-11T13:57:19.0935194+02:00",
  "UpdatedDate": "2017-07-15T13:57:19.0935194+02:00",
  "Description": "Innovative global instruction set",
  "Postit": "aspernatur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Decentralized logistical solution",
  "ActiveStatusMonitorId": 149,
  "Links": [
    {
      "EntityName": "Bosco Group",
      "Id": 399,
      "Description": "Face to face dynamic infrastructure",
      "ExtraInfo": "provident",
      "LinkId": 59,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    }
  ],
  "ActiveLinks": 330,
  "Completed": false,
  "NextMilestoneDate": "2012-02-24T13:57:19.0935194+01:00",
  "NmdAppointmentId": 117,
  "EndDate": "2019-09-22T13:57:19.0935194+02:00",
  "ActiveErpLinks": 670,
  "UserDefinedFields": {
    "SuperOffice:1": "Liana Batz",
    "SuperOffice:2": "1306553735"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "eum"
  },
  "PublishEventDate": "2016-03-27T13:57:19.0935194+02:00",
  "PublishTo": "2004-03-27T13:57:19.0935194+01:00",
  "PublishFrom": "2018-09-17T13:57:19.0935194+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 191
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```