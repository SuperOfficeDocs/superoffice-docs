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
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 571,
  "Name": "Anderson LLC",
  "ProjectNumber": "515385",
  "ProjectMembers": [
    {
      "ProjectmemberId": 262,
      "ContactId": 324,
      "ProjectId": 39,
      "ContactName": "Keeling LLC",
      "ContactDepartment": "",
      "ProjectName": "Walker, Champlin and O'Kon",
      "EmailId": 777,
      "EmailAddress": "esther@bogan.us",
      "CountryId": 329,
      "Firstname": "Demarcus",
      "MiddleName": "Mosciski-Rohan",
      "Lastname": "Effertz",
      "PersonId": 917,
      "Mrmrs": "reiciendis",
      "ProjectMemberTypeName": "Bogisich LLC",
      "Phone": "(563)838-3044 x83797",
      "PhoneId": 122,
      "ProjectMemberTypeId": 850,
      "EmailAddressName": "carter.oconnell@stehrwill.uk",
      "Comment": "error",
      "FullName": "Kiel Kunze"
    }
  ],
  "Urls": [
    {
      "Value": "dolorum",
      "StrippedValue": "ad",
      "Description": "Face to face 5th generation pricing structure"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "ad",
      "Description": "Face to face 5th generation pricing structure"
    }
  ],
  "CreatedDate": "2018-06-17T11:44:42.1483134+02:00",
  "UpdatedDate": "2003-06-09T11:44:42.1483134+02:00",
  "Description": "Universal eco-centric hardware",
  "Postit": "blanditiis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Adaptive hybrid projection",
  "ActiveStatusMonitorId": 186,
  "Links": [
    {
      "EntityName": "Heller-Daugherty",
      "Id": 633,
      "Description": "Cross-platform mission-critical Graphic Interface",
      "ExtraInfo": "et",
      "LinkId": 505
    },
    {
      "EntityName": "Heller-Daugherty",
      "Id": 633,
      "Description": "Cross-platform mission-critical Graphic Interface",
      "ExtraInfo": "et",
      "LinkId": 505
    }
  ],
  "ActiveLinks": 190,
  "Completed": false,
  "NextMilestoneDate": "2014-11-04T11:44:42.1483134+01:00",
  "NmdAppointmentId": 900,
  "EndDate": "2017-11-24T11:44:42.1483134+01:00",
  "ActiveErpLinks": 281,
  "UserDefinedFields": {
    "SuperOffice:1": "1851548497",
    "SuperOffice:2": "Mrs. Lempi Douglas Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "in"
  },
  "PublishEventDate": "1999-05-09T11:44:42.1483134+02:00",
  "PublishTo": "2004-11-05T11:44:42.1483134+01:00",
  "PublishFrom": "2009-12-27T11:44:42.1483134+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 24,
  "Name": "Schaefer-Boehm",
  "ProjectNumber": "464908",
  "ProjectMembers": [
    {
      "ProjectmemberId": 42,
      "ContactId": 782,
      "ProjectId": 78,
      "ContactName": "Beatty-Ruecker",
      "ContactDepartment": "",
      "ProjectName": "Jast, Monahan and Legros",
      "EmailId": 855,
      "EmailAddress": "chad_hudson@kingromaguera.us",
      "CountryId": 36,
      "Firstname": "Matilda",
      "MiddleName": "Kessler Group",
      "Lastname": "Willms",
      "PersonId": 403,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Berge-Ankunding",
      "Phone": "025-851-2191",
      "PhoneId": 320,
      "ProjectMemberTypeId": 286,
      "EmailAddressName": "cristal_rosenbaum@kohler.com",
      "Comment": "ut",
      "FullName": "Kianna Nolan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "nobis",
      "Description": "Reverse-engineered zero defect system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 541
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "nobis",
      "Description": "Reverse-engineered zero defect system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 541
        }
      }
    }
  ],
  "CreatedDate": "2003-07-17T11:44:42.1483134+02:00",
  "UpdatedDate": "2022-01-26T11:44:42.1483134+01:00",
  "Description": "Decentralized coherent complexity",
  "Postit": "dicta",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Centralized content-based parallelism",
  "ActiveStatusMonitorId": 31,
  "Links": [
    {
      "EntityName": "Halvorson Inc and Sons",
      "Id": 340,
      "Description": "Advanced foreground hierarchy",
      "ExtraInfo": "est",
      "LinkId": 410,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 619
        }
      }
    }
  ],
  "ActiveLinks": 887,
  "Completed": true,
  "NextMilestoneDate": "2002-08-15T11:44:42.1483134+02:00",
  "NmdAppointmentId": 807,
  "EndDate": "2000-03-30T11:44:42.1483134+02:00",
  "ActiveErpLinks": 833,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "occaecati"
  },
  "PublishEventDate": "2013-05-19T11:44:42.1483134+02:00",
  "PublishTo": "2012-09-23T11:44:42.1483134+02:00",
  "PublishFrom": "2003-02-26T11:44:42.1483134+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 441
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```