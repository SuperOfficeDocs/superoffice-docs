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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 131,
  "Name": "Cummings-Collins",
  "ProjectNumber": "1443801",
  "ProjectMembers": [
    {
      "ProjectmemberId": 430,
      "ContactId": 549,
      "ProjectId": 488,
      "ContactName": "Breitenberg Group",
      "ContactDepartment": "",
      "ProjectName": "Dickens LLC",
      "EmailId": 253,
      "EmailAddress": "michael.paucek@schultz.com",
      "CountryId": 86,
      "Firstname": "Jeramy",
      "MiddleName": "Funk Inc and Sons",
      "Lastname": "Ondricka",
      "PersonId": 816,
      "Mrmrs": "nihil",
      "ProjectMemberTypeName": "Stokes LLC",
      "Phone": "402.306.4588 x377",
      "PhoneId": 843,
      "ProjectMemberTypeId": 370,
      "EmailAddressName": "maddison@kihneichmann.ca",
      "Comment": "et",
      "FullName": "Alberta Weissnat"
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "asperiores",
      "Description": "Multi-channelled next generation groupware"
    },
    {
      "Value": "ut",
      "StrippedValue": "asperiores",
      "Description": "Multi-channelled next generation groupware"
    }
  ],
  "CreatedDate": "2010-02-20T17:37:38.9773055+01:00",
  "UpdatedDate": "1995-10-21T17:37:38.9773055+02:00",
  "Description": "Programmable web-enabled hub",
  "Postit": "ex",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Customer-focused solution-oriented instruction set",
  "ActiveStatusMonitorId": 354,
  "Links": [
    {
      "EntityName": "Tillman, Nader and Konopelski",
      "Id": 678,
      "Description": "Adaptive bi-directional intranet",
      "ExtraInfo": "rem",
      "LinkId": 199
    },
    {
      "EntityName": "Tillman, Nader and Konopelski",
      "Id": 678,
      "Description": "Adaptive bi-directional intranet",
      "ExtraInfo": "rem",
      "LinkId": 199
    }
  ],
  "ActiveLinks": 583,
  "Completed": false,
  "NextMilestoneDate": "2002-04-20T17:37:38.9783035+02:00",
  "NmdAppointmentId": 281,
  "EndDate": "2022-10-07T17:37:38.9783035+02:00",
  "ActiveErpLinks": 275,
  "UserDefinedFields": {
    "SuperOffice:1": "Gregorio Ritchie",
    "SuperOffice:2": "678306811"
  },
  "ExtraFields": {
    "ExtraFields1": "facilis",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "aut"
  },
  "PublishEventDate": "1996-02-07T17:37:38.9793037+01:00",
  "PublishTo": "2010-01-27T17:37:38.9793037+01:00",
  "PublishFrom": "2000-11-28T17:37:38.9793037+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 46,
  "Name": "Leannon-Hahn",
  "ProjectNumber": "712931",
  "ProjectMembers": [
    {
      "ProjectmemberId": 988,
      "ContactId": 183,
      "ProjectId": 21,
      "ContactName": "Schmeler-Kozey",
      "ContactDepartment": "",
      "ProjectName": "Boyle, Moen and Harvey",
      "EmailId": 743,
      "EmailAddress": "bettye_nolan@jenkins.biz",
      "CountryId": 812,
      "Firstname": "Nickolas",
      "MiddleName": "Skiles Inc and Sons",
      "Lastname": "Welch",
      "PersonId": 888,
      "Mrmrs": "eaque",
      "ProjectMemberTypeName": "Feil-Sipes",
      "Phone": "193-761-1226 x2048",
      "PhoneId": 905,
      "ProjectMemberTypeId": 805,
      "EmailAddressName": "parker@braun.info",
      "Comment": "magni",
      "FullName": "Brayan Prosacco",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 680
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "illum",
      "StrippedValue": "quo",
      "Description": "Customizable 24/7 throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "quo",
      "Description": "Customizable 24/7 throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    }
  ],
  "CreatedDate": "2007-07-19T17:37:38.9823053+02:00",
  "UpdatedDate": "2002-12-12T17:37:38.9823053+01:00",
  "Description": "Reverse-engineered asynchronous matrix",
  "Postit": "quos",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Future-proofed global knowledge base",
  "ActiveStatusMonitorId": 115,
  "Links": [
    {
      "EntityName": "Boyer Group",
      "Id": 146,
      "Description": "Stand-alone full-range Graphic Interface",
      "ExtraInfo": "corporis",
      "LinkId": 606,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 825
        }
      }
    }
  ],
  "ActiveLinks": 984,
  "Completed": false,
  "NextMilestoneDate": "2021-10-13T17:37:38.985275+02:00",
  "NmdAppointmentId": 399,
  "EndDate": "2003-10-27T17:37:38.985275+01:00",
  "ActiveErpLinks": 856,
  "UserDefinedFields": {
    "SuperOffice:1": "Sammie Wehner",
    "SuperOffice:2": "1082404813"
  },
  "ExtraFields": {
    "ExtraFields1": "perferendis",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "facere"
  },
  "PublishEventDate": "2001-03-15T17:37:38.9862738+01:00",
  "PublishTo": "1997-07-03T17:37:38.9862738+02:00",
  "PublishFrom": "2017-09-07T17:37:38.9862738+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 405
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```