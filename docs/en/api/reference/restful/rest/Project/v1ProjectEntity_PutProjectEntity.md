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
  "ProjectId": 349,
  "Name": "Franecki, Murray and Wuckert",
  "ProjectNumber": "837179",
  "ProjectMembers": [
    {
      "ProjectmemberId": 82,
      "ContactId": 424,
      "ProjectId": 697,
      "ContactName": "Herzog-Mills",
      "ContactDepartment": "",
      "ProjectName": "Schultz, Vandervort and Marvin",
      "EmailId": 815,
      "EmailAddress": "colby.pacocha@beckerhane.com",
      "CountryId": 428,
      "Firstname": "Kelley",
      "MiddleName": "Welch-Stehr",
      "Lastname": "Doyle",
      "PersonId": 940,
      "Mrmrs": "porro",
      "ProjectMemberTypeName": "Carroll-Boyer",
      "Phone": "(308)575-5542",
      "PhoneId": 305,
      "ProjectMemberTypeId": 619,
      "EmailAddressName": "gina_wisoky@bahringer.uk",
      "Comment": "nostrum",
      "FullName": "Donavon Mayer"
    }
  ],
  "Urls": [
    {
      "Value": "sunt",
      "StrippedValue": "maiores",
      "Description": "Switchable 3rd generation secured line"
    },
    {
      "Value": "sunt",
      "StrippedValue": "maiores",
      "Description": "Switchable 3rd generation secured line"
    }
  ],
  "CreatedDate": "2009-10-24T03:45:28.5140572+02:00",
  "UpdatedDate": "2023-09-28T03:45:28.5140572+02:00",
  "Description": "Seamless multimedia firmware",
  "Postit": "sapiente",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Quality-focused fault-tolerant approach",
  "ActiveStatusMonitorId": 767,
  "Links": [
    {
      "EntityName": "Hansen, Fisher and Ortiz",
      "Id": 452,
      "Description": "Enhanced 3rd generation matrix",
      "ExtraInfo": "non",
      "LinkId": 165
    },
    {
      "EntityName": "Hansen, Fisher and Ortiz",
      "Id": 452,
      "Description": "Enhanced 3rd generation matrix",
      "ExtraInfo": "non",
      "LinkId": 165
    }
  ],
  "ActiveLinks": 471,
  "Completed": true,
  "NextMilestoneDate": "2016-10-09T03:45:28.5140572+02:00",
  "NmdAppointmentId": 915,
  "EndDate": "2013-05-25T03:45:28.5140572+02:00",
  "ActiveErpLinks": 675,
  "UserDefinedFields": {
    "SuperOffice:1": "Sandy Kutch",
    "SuperOffice:2": "Arno Wiza"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "modi",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "2023-04-10T03:45:28.5140572+02:00",
  "PublishTo": "1999-09-29T03:45:28.5140572+02:00",
  "PublishFrom": "2005-08-27T03:45:28.5140572+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 204,
  "Name": "Thiel Group",
  "ProjectNumber": "1721807",
  "ProjectMembers": [
    {
      "ProjectmemberId": 158,
      "ContactId": 383,
      "ProjectId": 454,
      "ContactName": "Beatty-Mayert",
      "ContactDepartment": "",
      "ProjectName": "Sporer-Brown",
      "EmailId": 746,
      "EmailAddress": "jerrell@hodkiewiczlegros.info",
      "CountryId": 939,
      "Firstname": "Saige",
      "MiddleName": "Zieme-Torphy",
      "Lastname": "Hane",
      "PersonId": 114,
      "Mrmrs": "consequatur",
      "ProjectMemberTypeName": "Bosco Inc and Sons",
      "Phone": "945-397-2395 x68798",
      "PhoneId": 432,
      "ProjectMemberTypeId": 33,
      "EmailAddressName": "suzanne@sipesbogan.biz",
      "Comment": "et",
      "FullName": "Dr. Winston Ernie Russel DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ipsa",
      "StrippedValue": "modi",
      "Description": "Self-enabling solution-oriented website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "modi",
      "Description": "Self-enabling solution-oriented website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    }
  ],
  "CreatedDate": "2017-02-08T03:45:28.5140572+01:00",
  "UpdatedDate": "2010-10-09T03:45:28.5140572+02:00",
  "Description": "Operative contextually-based infrastructure",
  "Postit": "commodi",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Streamlined next generation hardware",
  "ActiveStatusMonitorId": 729,
  "Links": [
    {
      "EntityName": "Johnson-Kerluke",
      "Id": 761,
      "Description": "Virtual actuating website",
      "ExtraInfo": "praesentium",
      "LinkId": 259,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 351
        }
      }
    }
  ],
  "ActiveLinks": 616,
  "Completed": false,
  "NextMilestoneDate": "2003-08-17T03:45:28.5140572+02:00",
  "NmdAppointmentId": 741,
  "EndDate": "2005-03-15T03:45:28.5140572+01:00",
  "ActiveErpLinks": 581,
  "UserDefinedFields": {
    "SuperOffice:1": "Carmella Schmitt",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "ea"
  },
  "PublishEventDate": "2016-11-19T03:45:28.5140572+01:00",
  "PublishTo": "2021-07-09T03:45:28.5140572+02:00",
  "PublishFrom": "2025-03-30T03:45:28.5140572+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 539
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```