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
  "ProjectId": 916,
  "Name": "Feil Group",
  "ProjectNumber": "1399737",
  "ProjectMembers": [
    {
      "ProjectmemberId": 463,
      "ContactId": 218,
      "ProjectId": 801,
      "ContactName": "Becker Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "DuBuque-Koepp",
      "EmailId": 316,
      "EmailAddress": "willow@lind.us",
      "CountryId": 794,
      "Firstname": "Alphonso",
      "MiddleName": "Lockman-Bogisich",
      "Lastname": "Pagac",
      "PersonId": 808,
      "Mrmrs": "sunt",
      "ProjectMemberTypeName": "Keeling LLC",
      "Phone": "168.795.2019 x815",
      "PhoneId": 828,
      "ProjectMemberTypeId": 607,
      "EmailAddressName": "erwin@runolfsson.biz",
      "Comment": "inventore",
      "FullName": "Pearlie Wintheiser"
    }
  ],
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "ut",
      "Description": "Quality-focused didactic productivity"
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "ut",
      "Description": "Quality-focused didactic productivity"
    }
  ],
  "CreatedDate": "2006-06-16T23:04:04.4005145+02:00",
  "UpdatedDate": "2016-03-30T23:04:04.4005145+02:00",
  "Description": "Vision-oriented multimedia Graphic Interface",
  "Postit": "molestias",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Switchable bandwidth-monitored leverage",
  "ActiveStatusMonitorId": 1000,
  "Links": [
    {
      "EntityName": "King, Bergnaum and Haley",
      "Id": 426,
      "Description": "Organic static frame",
      "ExtraInfo": "voluptatem",
      "LinkId": 228
    },
    {
      "EntityName": "King, Bergnaum and Haley",
      "Id": 426,
      "Description": "Organic static frame",
      "ExtraInfo": "voluptatem",
      "LinkId": 228
    }
  ],
  "ActiveLinks": 274,
  "Completed": true,
  "NextMilestoneDate": "2019-04-26T23:04:04.4025167+02:00",
  "NmdAppointmentId": 159,
  "EndDate": "2019-03-05T23:04:04.4025167+01:00",
  "ActiveErpLinks": 9,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Rae Ernser"
  },
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "iste",
    "CustomFields2": "quae"
  },
  "PublishEventDate": "2010-08-31T23:04:04.4030193+02:00",
  "PublishTo": "2023-03-23T23:04:04.4030193+01:00",
  "PublishFrom": "2013-06-12T23:04:04.4030193+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 168,
  "Name": "Fisher-Hudson",
  "ProjectNumber": "824726",
  "ProjectMembers": [
    {
      "ProjectmemberId": 281,
      "ContactId": 665,
      "ProjectId": 955,
      "ContactName": "Dickinson LLC",
      "ContactDepartment": "",
      "ProjectName": "Tremblay, Welch and Crooks",
      "EmailId": 769,
      "EmailAddress": "alexie@oreilly.biz",
      "CountryId": 12,
      "Firstname": "Bartholome",
      "MiddleName": "Lind-Denesik",
      "Lastname": "Stroman",
      "PersonId": 972,
      "Mrmrs": "incidunt",
      "ProjectMemberTypeName": "Haag, Adams and Padberg",
      "Phone": "1-357-013-7216 x4862",
      "PhoneId": 527,
      "ProjectMemberTypeId": 660,
      "EmailAddressName": "laurine_abernathy@monahanschuster.com",
      "Comment": "fuga",
      "FullName": "Eileen Hamill",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "iste",
      "Description": "Fundamental dedicated support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 583
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "iste",
      "Description": "Fundamental dedicated support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 583
        }
      }
    }
  ],
  "CreatedDate": "2019-02-15T23:04:04.407515+01:00",
  "UpdatedDate": "1999-07-28T23:04:04.407515+02:00",
  "Description": "Focused client-driven workforce",
  "Postit": "quis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Re-engineered uniform paradigm",
  "ActiveStatusMonitorId": 858,
  "Links": [
    {
      "EntityName": "Gleason-Kuvalis",
      "Id": 417,
      "Description": "User-centric exuding alliance",
      "ExtraInfo": "tempora",
      "LinkId": 943,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 239
        }
      }
    }
  ],
  "ActiveLinks": 595,
  "Completed": false,
  "NextMilestoneDate": "2018-06-14T23:04:04.4085141+02:00",
  "NmdAppointmentId": 418,
  "EndDate": "2013-01-16T23:04:04.4085141+01:00",
  "ActiveErpLinks": 647,
  "UserDefinedFields": {
    "SuperOffice:1": "1037625976",
    "SuperOffice:2": "Janie Bergstrom"
  },
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "accusantium",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "2003-04-08T23:04:04.4090145+02:00",
  "PublishTo": "2019-06-20T23:04:04.4090145+02:00",
  "PublishFrom": "1998-07-06T23:04:04.4090145+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 762
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```