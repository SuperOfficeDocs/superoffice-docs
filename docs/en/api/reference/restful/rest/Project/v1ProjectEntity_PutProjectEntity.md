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


NsApiSlow threshold: 2000 ms.





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
  "ProjectId": 355,
  "Name": "Howell, Rutherford and Sauer",
  "ProjectNumber": "962910",
  "ProjectMembers": [
    {
      "ProjectmemberId": 565,
      "ContactId": 861,
      "ProjectId": 657,
      "ContactName": "Ritchie, Lesch and Kris",
      "ContactDepartment": "",
      "ProjectName": "Dietrich-Schiller",
      "EmailId": 101,
      "EmailAddress": "misael_waters@torp.info",
      "CountryId": 805,
      "Firstname": "Anabel",
      "MiddleName": "Hayes-Walter",
      "Lastname": "Kuvalis",
      "PersonId": 214,
      "Mrmrs": "quae",
      "ProjectMemberTypeName": "Quitzon-Reichert",
      "Phone": "729.356.8811",
      "PhoneId": 889,
      "ProjectMemberTypeId": 296,
      "EmailAddressName": "adelbert_schoen@brekkecollins.co.uk",
      "Comment": "officiis",
      "FullName": "Madelynn Wilkinson",
      "Registered": "2008-01-01T02:30:52.8036637+01:00",
      "Updated": "2017-06-10T02:30:52.8036637+02:00"
    }
  ],
  "Urls": [
    {
      "Value": "quos",
      "StrippedValue": "veritatis",
      "Description": "Down-sized mobile frame"
    },
    {
      "Value": "quos",
      "StrippedValue": "veritatis",
      "Description": "Down-sized mobile frame"
    }
  ],
  "CreatedDate": "2025-03-30T02:30:52.8036637+01:00",
  "UpdatedDate": "2019-11-17T02:30:52.8036637+01:00",
  "Description": "Progressive attitude-oriented hierarchy",
  "Postit": "magni",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Compatible full-range structure",
  "ActiveStatusMonitorId": 385,
  "Links": [
    {
      "EntityName": "Mann-Rau",
      "Id": 949,
      "Description": "Reverse-engineered human-resource alliance",
      "ExtraInfo": "quasi",
      "LinkId": 835
    },
    {
      "EntityName": "Mann-Rau",
      "Id": 949,
      "Description": "Reverse-engineered human-resource alliance",
      "ExtraInfo": "quasi",
      "LinkId": 835
    }
  ],
  "ActiveLinks": 472,
  "Completed": true,
  "NextMilestoneDate": "2021-03-31T02:30:52.8036637+02:00",
  "NmdAppointmentId": 853,
  "EndDate": "2000-11-23T02:30:52.8036637+01:00",
  "ActiveErpLinks": 156,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Eula Olson I"
  },
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "iure"
  },
  "PublishEventDate": "2004-03-22T02:30:52.8036637+01:00",
  "PublishTo": "2010-06-13T02:30:52.8036637+02:00",
  "PublishFrom": "2022-07-06T02:30:52.8036637+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 958,
  "Name": "Hoeger, Murphy and Wehner",
  "ProjectNumber": "1070157",
  "ProjectMembers": [
    {
      "ProjectmemberId": 733,
      "ContactId": 395,
      "ProjectId": 64,
      "ContactName": "Fadel, Jast and Weimann",
      "ContactDepartment": "",
      "ProjectName": "Lind-Ratke",
      "EmailId": 683,
      "EmailAddress": "bradly@schultznicolas.name",
      "CountryId": 178,
      "Firstname": "Odessa",
      "MiddleName": "Welch-Bahringer",
      "Lastname": "Herman",
      "PersonId": 534,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Kuvalis-Yost",
      "Phone": "1-432-098-3809 x12014",
      "PhoneId": 404,
      "ProjectMemberTypeId": 725,
      "EmailAddressName": "unique@langmann.us",
      "Comment": "officia",
      "FullName": "Ms. Jolie Torp DVM",
      "Registered": "2005-10-14T02:30:52.8036637+02:00",
      "Updated": "2011-01-10T02:30:52.8036637+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "maxime",
      "StrippedValue": "quae",
      "Description": "Business-focused analyzing instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "quae",
      "Description": "Business-focused analyzing instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "CreatedDate": "2021-03-11T02:30:52.8036637+01:00",
  "UpdatedDate": "2015-10-15T02:30:52.8036637+02:00",
  "Description": "Face to face real-time firmware",
  "Postit": "omnis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Front-line context-sensitive core",
  "ActiveStatusMonitorId": 507,
  "Links": [
    {
      "EntityName": "Bergstrom, Rippin and Ullrich",
      "Id": 989,
      "Description": "Programmable intangible open architecture",
      "ExtraInfo": "et",
      "LinkId": 173,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    }
  ],
  "ActiveLinks": 394,
  "Completed": false,
  "NextMilestoneDate": "2023-05-15T02:30:52.8036637+02:00",
  "NmdAppointmentId": 246,
  "EndDate": "2004-10-25T02:30:52.8036637+02:00",
  "ActiveErpLinks": 792,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Joe Jazmyn Von",
    "SuperOffice:2": "Raoul Wilkinson"
  },
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "neque"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "ipsa"
  },
  "PublishEventDate": "2005-05-24T02:30:52.8036637+02:00",
  "PublishTo": "2018-09-12T02:30:52.8036637+02:00",
  "PublishFrom": "2020-08-06T02:30:52.8036637+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 687
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```