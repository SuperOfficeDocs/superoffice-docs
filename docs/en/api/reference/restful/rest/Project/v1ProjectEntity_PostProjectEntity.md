---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
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

## Request Body: newEntity 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 141,
  "Name": "Goodwin-Quigley",
  "ProjectNumber": "1490780",
  "ProjectMembers": [
    {
      "ProjectmemberId": 567,
      "ContactId": 455,
      "ProjectId": 24,
      "ContactName": "Stanton LLC",
      "ContactDepartment": "",
      "ProjectName": "Wuckert-Raynor",
      "EmailId": 53,
      "EmailAddress": "jessika@rohanfritsch.biz",
      "CountryId": 960,
      "Firstname": "Jaeden",
      "MiddleName": "Kreiger-Heller",
      "Lastname": "Dare",
      "PersonId": 399,
      "Mrmrs": "vitae",
      "ProjectMemberTypeName": "Hayes, Cremin and Barton",
      "Phone": "(624)242-8110 x92776",
      "PhoneId": 517,
      "ProjectMemberTypeId": 59,
      "EmailAddressName": "stefanie@koepp.uk",
      "Comment": "sequi",
      "FullName": "Dr. Dariana Klein"
    }
  ],
  "Urls": [
    {
      "Value": "libero",
      "StrippedValue": "consequatur",
      "Description": "Proactive systematic extranet"
    },
    {
      "Value": "libero",
      "StrippedValue": "consequatur",
      "Description": "Proactive systematic extranet"
    }
  ],
  "CreatedDate": "2006-12-31T13:57:18.9684384+01:00",
  "UpdatedDate": "1998-02-24T13:57:18.9684384+01:00",
  "Description": "Distributed eco-centric middleware",
  "Postit": "sequi",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Switchable zero administration ability",
  "ActiveStatusMonitorId": 733,
  "Links": [
    {
      "EntityName": "Corwin-Jewess",
      "Id": 545,
      "Description": "Pre-emptive scalable pricing structure",
      "ExtraInfo": "ducimus",
      "LinkId": 57
    },
    {
      "EntityName": "Corwin-Jewess",
      "Id": 545,
      "Description": "Pre-emptive scalable pricing structure",
      "ExtraInfo": "ducimus",
      "LinkId": 57
    }
  ],
  "ActiveLinks": 437,
  "Completed": false,
  "NextMilestoneDate": "2006-01-28T13:57:18.9684384+01:00",
  "NmdAppointmentId": 461,
  "EndDate": "2003-02-10T13:57:18.9684384+01:00",
  "ActiveErpLinks": 636,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Mckenna Jacobi",
    "SuperOffice:2": "Mrs. Lorenz Hettinger"
  },
  "ExtraFields": {
    "ExtraFields1": "quidem",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "alias"
  },
  "PublishEventDate": "1998-04-06T13:57:18.9684384+02:00",
  "PublishTo": "2015-03-30T13:57:18.9684384+02:00",
  "PublishFrom": "2010-07-14T13:57:18.9684384+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 465,
  "Name": "D'Amore-Hintz",
  "ProjectNumber": "895086",
  "ProjectMembers": [
    {
      "ProjectmemberId": 667,
      "ContactId": 379,
      "ProjectId": 34,
      "ContactName": "Gulgowski, Bergnaum and Pagac",
      "ContactDepartment": "",
      "ProjectName": "Boyer Inc and Sons",
      "EmailId": 259,
      "EmailAddress": "fred@hayes.co.uk",
      "CountryId": 730,
      "Firstname": "Ambrose",
      "MiddleName": "Deckow-Wiza",
      "Lastname": "Goyette",
      "PersonId": 903,
      "Mrmrs": "tempora",
      "ProjectMemberTypeName": "Altenwerth, Morar and Upton",
      "Phone": "(816)577-1837 x670",
      "PhoneId": 230,
      "ProjectMemberTypeId": 143,
      "EmailAddressName": "estevan_hauck@bahringer.info",
      "Comment": "ipsam",
      "FullName": "Michael Halvorson Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 858
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "tempore",
      "Description": "Function-based logistical hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "tempore",
      "Description": "Function-based logistical hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    }
  ],
  "CreatedDate": "2005-03-07T13:57:19.0309025+01:00",
  "UpdatedDate": "2019-03-11T13:57:19.0309025+01:00",
  "Description": "Fully-configurable empowering model",
  "Postit": "necessitatibus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Open-source disintermediate internet solution",
  "ActiveStatusMonitorId": 306,
  "Links": [
    {
      "EntityName": "Sawayn-Wilderman",
      "Id": 267,
      "Description": "Self-enabling regional capacity",
      "ExtraInfo": "et",
      "LinkId": 186,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 709
        }
      }
    }
  ],
  "ActiveLinks": 976,
  "Completed": false,
  "NextMilestoneDate": "2013-05-30T13:57:19.0621524+02:00",
  "NmdAppointmentId": 342,
  "EndDate": "2004-11-05T13:57:19.0621524+01:00",
  "ActiveErpLinks": 829,
  "UserDefinedFields": {
    "SuperOffice:1": "820927330",
    "SuperOffice:2": "Ms. Kristopher Lessie Greenfelder"
  },
  "ExtraFields": {
    "ExtraFields1": "eveniet",
    "ExtraFields2": "debitis"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "eius"
  },
  "PublishEventDate": "2012-01-10T13:57:19.0621524+01:00",
  "PublishTo": "2016-09-17T13:57:19.0621524+02:00",
  "PublishFrom": "2000-12-15T13:57:19.0621524+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 828
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```