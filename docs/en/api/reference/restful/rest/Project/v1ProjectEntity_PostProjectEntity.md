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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 180,
  "Name": "Swaniawski Group",
  "ProjectNumber": "1933280",
  "ProjectMembers": [
    {
      "ProjectmemberId": 527,
      "ContactId": 377,
      "ProjectId": 692,
      "ContactName": "Balistreri LLC",
      "ContactDepartment": "",
      "ProjectName": "Davis Inc and Sons",
      "EmailId": 451,
      "EmailAddress": "burley@anderson.co.uk",
      "CountryId": 411,
      "Firstname": "Colin",
      "MiddleName": "Stamm-Boyle",
      "Lastname": "Funk",
      "PersonId": 201,
      "Mrmrs": "aliquid",
      "ProjectMemberTypeName": "Bernhard-Waelchi",
      "Phone": "1-929-487-1074",
      "PhoneId": 21,
      "ProjectMemberTypeId": 322,
      "EmailAddressName": "kane_schuppe@breitenbergreichel.com",
      "Comment": "eveniet",
      "FullName": "Adonis Wolff"
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "dolorem",
      "Description": "Upgradable encompassing portal"
    },
    {
      "Value": "enim",
      "StrippedValue": "dolorem",
      "Description": "Upgradable encompassing portal"
    }
  ],
  "CreatedDate": "2014-03-08T03:24:51.7089392+01:00",
  "UpdatedDate": "2000-12-03T03:24:51.7089392+01:00",
  "Description": "Pre-emptive holistic circuit",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Assimilated multi-state neural-net",
  "ActiveStatusMonitorId": 995,
  "Links": [
    {
      "EntityName": "Smitham Inc and Sons",
      "Id": 287,
      "Description": "Ergonomic scalable framework",
      "ExtraInfo": "ullam",
      "LinkId": 367
    },
    {
      "EntityName": "Smitham Inc and Sons",
      "Id": 287,
      "Description": "Ergonomic scalable framework",
      "ExtraInfo": "ullam",
      "LinkId": 367
    }
  ],
  "ActiveLinks": 919,
  "Completed": false,
  "NextMilestoneDate": "2015-09-21T03:24:51.7089392+02:00",
  "NmdAppointmentId": 558,
  "EndDate": "2018-11-16T03:24:51.7089392+01:00",
  "ActiveErpLinks": 133,
  "UserDefinedFields": {
    "SuperOffice:1": "Francesca Stracke",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "laboriosam",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "perferendis"
  },
  "PublishEventDate": "1997-06-24T03:24:51.7089392+02:00",
  "PublishTo": "2022-08-17T03:24:51.7089392+02:00",
  "PublishFrom": "2021-01-16T03:24:51.7089392+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 951,
  "Name": "Rowe-Kautzer",
  "ProjectNumber": "1009188",
  "ProjectMembers": [
    {
      "ProjectmemberId": 884,
      "ContactId": 347,
      "ProjectId": 546,
      "ContactName": "Swift, Bins and Schamberger",
      "ContactDepartment": "",
      "ProjectName": "Wunsch LLC",
      "EmailId": 126,
      "EmailAddress": "donavon@stoltenberg.name",
      "CountryId": 369,
      "Firstname": "Rico",
      "MiddleName": "Corkery LLC",
      "Lastname": "Harber",
      "PersonId": 706,
      "Mrmrs": "aut",
      "ProjectMemberTypeName": "Schaden Inc and Sons",
      "Phone": "(952)354-3843 x93347",
      "PhoneId": 134,
      "ProjectMemberTypeId": 221,
      "EmailAddressName": "gerardo@wuckert.us",
      "Comment": "qui",
      "FullName": "Malcolm Grimes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 761
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "soluta",
      "StrippedValue": "omnis",
      "Description": "Organic scalable parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "omnis",
      "Description": "Organic scalable parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    }
  ],
  "CreatedDate": "2001-07-13T03:24:51.7089392+02:00",
  "UpdatedDate": "2023-08-14T03:24:51.7089392+02:00",
  "Description": "Future-proofed didactic toolset",
  "Postit": "repudiandae",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Inverse stable Graphic Interface",
  "ActiveStatusMonitorId": 564,
  "Links": [
    {
      "EntityName": "Walsh Inc and Sons",
      "Id": 379,
      "Description": "Advanced needs-based analyzer",
      "ExtraInfo": "quis",
      "LinkId": 264,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    }
  ],
  "ActiveLinks": 120,
  "Completed": false,
  "NextMilestoneDate": "2004-10-03T03:24:51.7089392+02:00",
  "NmdAppointmentId": 373,
  "EndDate": "2011-02-20T03:24:51.7089392+01:00",
  "ActiveErpLinks": 574,
  "UserDefinedFields": {
    "SuperOffice:1": "Georgiana Krajcik",
    "SuperOffice:2": "Rubye Zemlak"
  },
  "ExtraFields": {
    "ExtraFields1": "laborum",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "modi",
    "CustomFields2": "ipsam"
  },
  "PublishEventDate": "1998-12-03T03:24:51.7089392+01:00",
  "PublishTo": "2008-05-01T03:24:51.7089392+02:00",
  "PublishFrom": "2019-06-10T03:24:51.7089392+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 282
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```