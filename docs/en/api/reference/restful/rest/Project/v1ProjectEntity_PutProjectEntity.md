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
  "ProjectId": 518,
  "Name": "Dicki, Smitham and Kassulke",
  "ProjectNumber": "648017",
  "ProjectMembers": [
    {
      "ProjectmemberId": 85,
      "ContactId": 483,
      "ProjectId": 172,
      "ContactName": "Macejkovic-Frami",
      "ContactDepartment": "",
      "ProjectName": "Witting-Sporer",
      "EmailId": 635,
      "EmailAddress": "alejandrin.koelpin@hanemurray.co.uk",
      "CountryId": 776,
      "Firstname": "Jamey",
      "MiddleName": "Osinski, Hansen and Raynor",
      "Lastname": "Huels",
      "PersonId": 716,
      "Mrmrs": "suscipit",
      "ProjectMemberTypeName": "D'Amore, Abshire and Hahn",
      "Phone": "782-259-1880 x722",
      "PhoneId": 146,
      "ProjectMemberTypeId": 719,
      "EmailAddressName": "jakayla_wolf@lubowitz.name",
      "Comment": "perferendis",
      "FullName": "Miss Sean Beatty DDS"
    }
  ],
  "Urls": [
    {
      "Value": "saepe",
      "StrippedValue": "aut",
      "Description": "Polarised multi-tasking encoding"
    },
    {
      "Value": "saepe",
      "StrippedValue": "aut",
      "Description": "Polarised multi-tasking encoding"
    }
  ],
  "CreatedDate": "2006-05-12T17:37:38.9943046+02:00",
  "UpdatedDate": "2019-12-25T17:37:38.9943046+01:00",
  "Description": "Customizable motivating middleware",
  "Postit": "repellendus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Progressive modular intranet",
  "ActiveStatusMonitorId": 320,
  "Links": [
    {
      "EntityName": "Casper, Schamberger and Smith",
      "Id": 617,
      "Description": "Diverse even-keeled data-warehouse",
      "ExtraInfo": "ipsam",
      "LinkId": 461
    },
    {
      "EntityName": "Casper, Schamberger and Smith",
      "Id": 617,
      "Description": "Diverse even-keeled data-warehouse",
      "ExtraInfo": "ipsam",
      "LinkId": 461
    }
  ],
  "ActiveLinks": 894,
  "Completed": false,
  "NextMilestoneDate": "2021-01-08T17:37:38.9953156+01:00",
  "NmdAppointmentId": 113,
  "EndDate": "1997-05-05T17:37:38.9953156+02:00",
  "ActiveErpLinks": 367,
  "UserDefinedFields": {
    "SuperOffice:1": "71157661",
    "SuperOffice:2": "59497044"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "vero"
  },
  "PublishEventDate": "2013-05-03T17:37:38.9963272+02:00",
  "PublishTo": "1998-11-30T17:37:38.9963272+01:00",
  "PublishFrom": "2004-11-19T17:37:38.9963272+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 221,
  "Name": "Spinka, Halvorson and Toy",
  "ProjectNumber": "744463",
  "ProjectMembers": [
    {
      "ProjectmemberId": 203,
      "ContactId": 316,
      "ProjectId": 976,
      "ContactName": "Brakus, Balistreri and Schaden",
      "ContactDepartment": "",
      "ProjectName": "Welch Inc and Sons",
      "EmailId": 979,
      "EmailAddress": "marcellus@feil.name",
      "CountryId": 972,
      "Firstname": "Derrick",
      "MiddleName": "Hermann-Barton",
      "Lastname": "Mante",
      "PersonId": 762,
      "Mrmrs": "nesciunt",
      "ProjectMemberTypeName": "Pollich-Shields",
      "Phone": "1-317-201-2891 x836",
      "PhoneId": 753,
      "ProjectMemberTypeId": 274,
      "EmailAddressName": "oral.aufderhar@jacobs.biz",
      "Comment": "repudiandae",
      "FullName": "Ashly Corwin V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 501
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "maiores",
      "Description": "Optional radical project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "maiores",
      "Description": "Optional radical project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "CreatedDate": "2022-12-02T17:37:39.0013033+01:00",
  "UpdatedDate": "2007-07-12T17:37:39.0013033+02:00",
  "Description": "Exclusive intermediate methodology",
  "Postit": "provident",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Organized user-facing moderator",
  "ActiveStatusMonitorId": 14,
  "Links": [
    {
      "EntityName": "Johns Group",
      "Id": 647,
      "Description": "Upgradable client-server middleware",
      "ExtraInfo": "quam",
      "LinkId": 944,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 622
        }
      }
    }
  ],
  "ActiveLinks": 976,
  "Completed": false,
  "NextMilestoneDate": "2010-05-29T17:37:39.0023035+02:00",
  "NmdAppointmentId": 916,
  "EndDate": "2003-03-18T17:37:39.0023035+01:00",
  "ActiveErpLinks": 225,
  "UserDefinedFields": {
    "SuperOffice:1": "Cody Bechtelar",
    "SuperOffice:2": "Marlon Schuster"
  },
  "ExtraFields": {
    "ExtraFields1": "maiores",
    "ExtraFields2": "eaque"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "quam"
  },
  "PublishEventDate": "2003-05-25T17:37:39.0023035+02:00",
  "PublishTo": "2018-03-23T17:37:39.0023035+01:00",
  "PublishFrom": "2003-01-13T17:37:39.0023035+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 805
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```