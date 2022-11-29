---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








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
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 458,
  "Name": "Blick-Kassulke",
  "ProjectNumber": "1212331",
  "ProjectMembers": [
    {
      "ProjectmemberId": 187,
      "ContactId": 788,
      "ProjectId": 613,
      "ContactName": "Jones-Breitenberg",
      "ContactDepartment": "",
      "ProjectName": "Beahan LLC",
      "EmailId": 410,
      "EmailAddress": "letitia_mclaughlin@lindgrendaugherty.com",
      "CountryId": 60,
      "Firstname": "Betty",
      "MiddleName": "Rogahn, Lueilwitz and Hirthe",
      "Lastname": "Stiedemann",
      "PersonId": 880,
      "Mrmrs": "voluptate",
      "ProjectMemberTypeName": "Dickinson Inc and Sons",
      "Phone": "1-386-659-5875",
      "PhoneId": 391,
      "ProjectMemberTypeId": 604,
      "EmailAddressName": "nathanael@willmspfannerstill.us",
      "Comment": "officiis",
      "FullName": "Kaylie Oberbrunner"
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "quo",
      "Description": "Expanded tertiary moderator"
    },
    {
      "Value": "ut",
      "StrippedValue": "quo",
      "Description": "Expanded tertiary moderator"
    }
  ],
  "CreatedDate": "1995-12-06T02:49:44.9215886+01:00",
  "UpdatedDate": "2010-10-08T02:49:44.9215886+02:00",
  "Description": "Synergistic intangible encryption",
  "Postit": "veniam",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Ameliorated bandwidth-monitored Graphical User Interface",
  "ActiveStatusMonitorId": 800,
  "Links": [
    {
      "EntityName": "Ledner LLC",
      "Id": 951,
      "Description": "Integrated eco-centric strategy",
      "ExtraInfo": "earum",
      "LinkId": 256
    },
    {
      "EntityName": "Ledner LLC",
      "Id": 951,
      "Description": "Integrated eco-centric strategy",
      "ExtraInfo": "earum",
      "LinkId": 256
    }
  ],
  "ActiveLinks": 69,
  "Completed": false,
  "NextMilestoneDate": "2021-04-26T02:49:44.9215886+02:00",
  "NmdAppointmentId": 329,
  "EndDate": "2001-01-17T02:49:44.9215886+01:00",
  "ActiveErpLinks": 323,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "reprehenderit",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "facilis",
    "CustomFields2": "necessitatibus"
  },
  "PublishEventDate": "2008-08-22T02:49:44.9215886+02:00",
  "PublishTo": "2018-06-07T02:49:44.9215886+02:00",
  "PublishFrom": "2020-07-26T02:49:44.9215886+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 297,
  "Name": "Frami Inc and Sons",
  "ProjectNumber": "1186090",
  "ProjectMembers": [
    {
      "ProjectmemberId": 732,
      "ContactId": 480,
      "ProjectId": 262,
      "ContactName": "Gerlach Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Hayes-Beatty",
      "EmailId": 534,
      "EmailAddress": "tobin@halvorson.name",
      "CountryId": 410,
      "Firstname": "Alberto",
      "MiddleName": "Shanahan-Ferry",
      "Lastname": "Mueller",
      "PersonId": 541,
      "Mrmrs": "culpa",
      "ProjectMemberTypeName": "Bradtke-Pouros",
      "Phone": "836-416-4274 x98379",
      "PhoneId": 771,
      "ProjectMemberTypeId": 993,
      "EmailAddressName": "colleen@braunbeatty.uk",
      "Comment": "tenetur",
      "FullName": "Jennyfer Morar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 627
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "optio",
      "Description": "Robust context-sensitive utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "optio",
      "Description": "Robust context-sensitive utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    }
  ],
  "CreatedDate": "2010-07-13T02:49:44.9372128+02:00",
  "UpdatedDate": "1996-12-10T02:49:44.9372128+01:00",
  "Description": "Cloned solution-oriented function",
  "Postit": "non",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Pre-emptive mission-critical methodology",
  "ActiveStatusMonitorId": 110,
  "Links": [
    {
      "EntityName": "Zemlak, Shanahan and Collier",
      "Id": 297,
      "Description": "Fundamental neutral secured line",
      "ExtraInfo": "eius",
      "LinkId": 760,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 307
        }
      }
    }
  ],
  "ActiveLinks": 295,
  "Completed": false,
  "NextMilestoneDate": "2005-06-27T02:49:44.9372128+02:00",
  "NmdAppointmentId": 477,
  "EndDate": "2010-07-15T02:49:44.9372128+02:00",
  "ActiveErpLinks": 792,
  "UserDefinedFields": {
    "SuperOffice:1": "977780355",
    "SuperOffice:2": "237523788"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quos"
  },
  "PublishEventDate": "2021-04-14T02:49:44.9372128+02:00",
  "PublishTo": "2004-09-22T02:49:44.9372128+02:00",
  "PublishFrom": "2005-04-06T02:49:44.9372128+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 901
    }
  }
}
```