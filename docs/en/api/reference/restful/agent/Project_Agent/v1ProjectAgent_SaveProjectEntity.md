---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
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

### Response body: ProjectEntity

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

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 654,
  "Name": "VonRueden Group",
  "ProjectNumber": "619769",
  "ProjectMembers": [
    {
      "ProjectmemberId": 775,
      "ContactId": 5,
      "ProjectId": 331,
      "ContactName": "Kuhlman, Durgan and Ritchie",
      "ContactDepartment": "",
      "ProjectName": "Effertz-Bednar",
      "EmailId": 956,
      "EmailAddress": "marcos_gulgowski@ryanbechtelar.ca",
      "CountryId": 525,
      "Firstname": "Sigrid",
      "MiddleName": "Durgan Inc and Sons",
      "Lastname": "Miller",
      "PersonId": 188,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Willms-Weber",
      "Phone": "821.243.1942 x97582",
      "PhoneId": 741,
      "ProjectMemberTypeId": 255,
      "EmailAddressName": "jalyn@funkchristiansen.us",
      "Comment": "ut",
      "FullName": "Darien Reilly"
    }
  ],
  "Urls": [
    {
      "Value": "facilis",
      "StrippedValue": "eligendi",
      "Description": "Re-engineered solution-oriented instruction set"
    },
    {
      "Value": "facilis",
      "StrippedValue": "eligendi",
      "Description": "Re-engineered solution-oriented instruction set"
    }
  ],
  "CreatedDate": "2016-09-27T16:00:41.5238361+02:00",
  "UpdatedDate": "1996-06-14T16:00:41.5238361+02:00",
  "Description": "Right-sized exuding project",
  "Postit": "omnis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Re-engineered heuristic pricing structure",
  "ActiveStatusMonitorId": 498,
  "Links": [
    {
      "EntityName": "Welch, Watsica and Runolfsson",
      "Id": 462,
      "Description": "Face to face high-level structure",
      "ExtraInfo": "iusto",
      "LinkId": 796
    },
    {
      "EntityName": "Welch, Watsica and Runolfsson",
      "Id": 462,
      "Description": "Face to face high-level structure",
      "ExtraInfo": "iusto",
      "LinkId": 796
    }
  ],
  "ActiveLinks": 865,
  "Completed": false,
  "NextMilestoneDate": "2014-01-26T16:00:41.5238361+01:00",
  "NmdAppointmentId": 184,
  "EndDate": "2011-02-09T16:00:41.5238361+01:00",
  "ActiveErpLinks": 671,
  "UserDefinedFields": {
    "SuperOffice:1": "593268372",
    "SuperOffice:2": "1364762754"
  },
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "architecto"
  },
  "PublishEventDate": "2017-10-04T16:00:41.5238361+02:00",
  "PublishTo": "2007-06-26T16:00:41.5238361+02:00",
  "PublishFrom": "2017-10-13T16:00:41.5238361+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 1002,
  "Name": "Daugherty Inc and Sons",
  "ProjectNumber": "917335",
  "ProjectMembers": [
    {
      "ProjectmemberId": 182,
      "ContactId": 310,
      "ProjectId": 126,
      "ContactName": "Breitenberg-Gottlieb",
      "ContactDepartment": "",
      "ProjectName": "Graham-Shields",
      "EmailId": 272,
      "EmailAddress": "jeromy@turcotte.uk",
      "CountryId": 97,
      "Firstname": "Amanda",
      "MiddleName": "Stiedemann-Wilderman",
      "Lastname": "Runolfsson",
      "PersonId": 305,
      "Mrmrs": "dolore",
      "ProjectMemberTypeName": "Gutmann-Lockman",
      "Phone": "(529)374-3905",
      "PhoneId": 827,
      "ProjectMemberTypeId": 669,
      "EmailAddressName": "jaquan.rogahn@bednar.co.uk",
      "Comment": "exercitationem",
      "FullName": "Dr. Bartholome Bobbie Cormier PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 287
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequuntur",
      "StrippedValue": "unde",
      "Description": "Ergonomic incremental intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "unde",
      "Description": "Ergonomic incremental intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    }
  ],
  "CreatedDate": "2010-12-20T16:00:41.5238361+01:00",
  "UpdatedDate": "2019-05-19T16:00:41.5238361+02:00",
  "Description": "Decentralized real-time pricing structure",
  "Postit": "ut",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Multi-layered full-range open system",
  "ActiveStatusMonitorId": 375,
  "Links": [
    {
      "EntityName": "Wunsch Group",
      "Id": 928,
      "Description": "Re-contextualized actuating analyzer",
      "ExtraInfo": "distinctio",
      "LinkId": 543,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 570
        }
      }
    }
  ],
  "ActiveLinks": 774,
  "Completed": false,
  "NextMilestoneDate": "2015-01-12T16:00:41.5238361+01:00",
  "NmdAppointmentId": 378,
  "EndDate": "2017-12-24T16:00:41.5238361+01:00",
  "ActiveErpLinks": 141,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "310300845"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "a"
  },
  "PublishEventDate": "2001-11-27T16:00:41.5238361+01:00",
  "PublishTo": "2016-07-09T16:00:41.5238361+02:00",
  "PublishFrom": "2001-08-02T16:00:41.5238361+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 570
    }
  }
}
```