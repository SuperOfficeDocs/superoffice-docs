---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 783,
  "Name": "Farrell Group",
  "ProjectNumber": "1287473",
  "ProjectMembers": [
    {
      "ProjectmemberId": 492,
      "ContactId": 192,
      "ProjectId": 547,
      "ContactName": "Ferry, Heller and Gottlieb",
      "ContactDepartment": "incubate one-to-one metrics",
      "ProjectName": "Gleason Group",
      "EmailId": 424,
      "EmailAddress": "sister_emmerich@roobblick.info",
      "CountryId": 44,
      "Firstname": "Meaghan",
      "MiddleName": "Rippin, Emmerich and Berge",
      "Lastname": "Cassin",
      "PersonId": 751,
      "Mrmrs": "sed",
      "ProjectMemberTypeName": "Gibson, Torphy and Blick",
      "Phone": "570-463-8063 x8358",
      "PhoneId": 949,
      "ProjectMemberTypeId": 17,
      "EmailAddressName": "wiley@borer.biz",
      "Comment": "harum",
      "FullName": "Dr. Ozella Tomas Crooks I"
    }
  ],
  "Urls": [
    {
      "Value": "nulla",
      "StrippedValue": "culpa",
      "Description": "Automated hybrid secured line"
    },
    {
      "Value": "nulla",
      "StrippedValue": "culpa",
      "Description": "Automated hybrid secured line"
    }
  ],
  "CreatedDate": "2018-03-12T15:29:29.9431625+01:00",
  "UpdatedDate": "2016-11-27T15:29:29.9431625+01:00",
  "Description": "Public-key system-worthy leverage",
  "Postit": "nesciunt",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Realigned multimedia data-warehouse",
  "ActiveStatusMonitorId": 542,
  "Links": [
    {
      "EntityName": "Nader-Dickinson",
      "Id": 155,
      "Description": "Realigned cohesive solution",
      "ExtraInfo": "beatae",
      "LinkId": 128
    },
    {
      "EntityName": "Nader-Dickinson",
      "Id": 155,
      "Description": "Realigned cohesive solution",
      "ExtraInfo": "beatae",
      "LinkId": 128
    }
  ],
  "ActiveLinks": 703,
  "Completed": false,
  "NextMilestoneDate": "2000-07-19T15:29:29.9441655+02:00",
  "NmdAppointmentId": 248,
  "EndDate": "2005-05-17T15:29:29.9441655+02:00",
  "ActiveErpLinks": 290,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Juvenal Jerde IV",
    "SuperOffice:2": "1635852434"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "mollitia"
  },
  "PublishEventDate": "2019-07-02T15:29:29.9446616+02:00",
  "PublishTo": "2009-02-23T15:29:29.9446616+01:00",
  "PublishFrom": "1995-12-05T15:29:29.9446616+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 790,
  "Name": "Fay LLC",
  "ProjectNumber": "1867161",
  "ProjectMembers": [
    {
      "ProjectmemberId": 660,
      "ContactId": 300,
      "ProjectId": 991,
      "ContactName": "Ernser Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Grady Inc and Sons",
      "EmailId": 596,
      "EmailAddress": "ian.beer@jones.name",
      "CountryId": 845,
      "Firstname": "Karina",
      "MiddleName": "Stiedemann, Gorczany and Johnson",
      "Lastname": "Krajcik",
      "PersonId": 274,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Greenfelder Group",
      "Phone": "075-266-0742",
      "PhoneId": 490,
      "ProjectMemberTypeId": 474,
      "EmailAddressName": "helga@turcotte.info",
      "Comment": "molestiae",
      "FullName": "Deanna Schmitt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 333
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Multi-layered uniform definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 26
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Multi-layered uniform definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 26
        }
      }
    }
  ],
  "CreatedDate": "1999-11-06T15:29:29.949662+01:00",
  "UpdatedDate": "2002-07-30T15:29:29.949662+02:00",
  "Description": "Proactive non-volatile toolset",
  "Postit": "nemo",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Robust background array",
  "ActiveStatusMonitorId": 283,
  "Links": [
    {
      "EntityName": "Sipes Group",
      "Id": 405,
      "Description": "Robust zero administration utilisation",
      "ExtraInfo": "architecto",
      "LinkId": 523,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 957
        }
      }
    }
  ],
  "ActiveLinks": 334,
  "Completed": false,
  "NextMilestoneDate": "2002-01-10T15:29:29.9521958+01:00",
  "NmdAppointmentId": 955,
  "EndDate": "2000-08-17T15:29:29.9521958+02:00",
  "ActiveErpLinks": 79,
  "UserDefinedFields": {
    "SuperOffice:1": "445583567",
    "SuperOffice:2": "Ethyl Weimann"
  },
  "ExtraFields": {
    "ExtraFields1": "similique",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "facilis",
    "CustomFields2": "laboriosam"
  },
  "PublishEventDate": "2010-12-25T15:29:29.9521958+01:00",
  "PublishTo": "1998-10-26T15:29:29.9521958+01:00",
  "PublishFrom": "2007-03-30T15:29:29.9521958+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 797
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```