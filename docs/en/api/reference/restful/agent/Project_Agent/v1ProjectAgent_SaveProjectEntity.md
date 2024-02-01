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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 13,
  "Name": "Ward-Anderson",
  "ProjectNumber": "877793",
  "ProjectMembers": [
    {
      "ProjectmemberId": 468,
      "ContactId": 722,
      "ProjectId": 204,
      "ContactName": "Emmerich-Rosenbaum",
      "ContactDepartment": "",
      "ProjectName": "Rice-Denesik",
      "EmailId": 657,
      "EmailAddress": "nicole@doylemedhurst.name",
      "CountryId": 997,
      "Firstname": "Chet",
      "MiddleName": "Hills-Grant",
      "Lastname": "Boyer",
      "PersonId": 731,
      "Mrmrs": "facilis",
      "ProjectMemberTypeName": "Jakubowski-Nader",
      "Phone": "793.258.9167",
      "PhoneId": 657,
      "ProjectMemberTypeId": 256,
      "EmailAddressName": "jarret_kessler@predovic.co.uk",
      "Comment": "maiores",
      "FullName": "Tevin Langworth"
    }
  ],
  "Urls": [
    {
      "Value": "blanditiis",
      "StrippedValue": "placeat",
      "Description": "Configurable didactic superstructure"
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "placeat",
      "Description": "Configurable didactic superstructure"
    }
  ],
  "CreatedDate": "2006-07-26T23:03:56.6231198+02:00",
  "UpdatedDate": "2010-03-16T23:03:56.6231198+01:00",
  "Description": "Cross-group local monitoring",
  "Postit": "ducimus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Multi-tiered bifurcated parallelism",
  "ActiveStatusMonitorId": 203,
  "Links": [
    {
      "EntityName": "Pouros-Ruecker",
      "Id": 979,
      "Description": "Front-line web-enabled product",
      "ExtraInfo": "eveniet",
      "LinkId": 423
    },
    {
      "EntityName": "Pouros-Ruecker",
      "Id": 979,
      "Description": "Front-line web-enabled product",
      "ExtraInfo": "eveniet",
      "LinkId": 423
    }
  ],
  "ActiveLinks": 848,
  "Completed": false,
  "NextMilestoneDate": "2004-06-03T23:03:56.6251261+02:00",
  "NmdAppointmentId": 617,
  "EndDate": "1999-05-10T23:03:56.6251261+02:00",
  "ActiveErpLinks": 130,
  "UserDefinedFields": {
    "SuperOffice:1": "Estefania Denesik",
    "SuperOffice:2": "1168810397"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "doloribus"
  },
  "PublishEventDate": "2023-02-12T23:03:56.625624+01:00",
  "PublishTo": "2012-04-20T23:03:56.625624+02:00",
  "PublishFrom": "1996-10-29T23:03:56.625624+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 660,
  "Name": "D'Amore-Hauck",
  "ProjectNumber": "995199",
  "ProjectMembers": [
    {
      "ProjectmemberId": 233,
      "ContactId": 688,
      "ProjectId": 101,
      "ContactName": "Dicki-Oberbrunner",
      "ContactDepartment": "",
      "ProjectName": "Frami LLC",
      "EmailId": 525,
      "EmailAddress": "shaun_gibson@gutkowskireichel.info",
      "CountryId": 471,
      "Firstname": "Maybell",
      "MiddleName": "Mayert-Frami",
      "Lastname": "Donnelly",
      "PersonId": 894,
      "Mrmrs": "ea",
      "ProjectMemberTypeName": "Rodriguez-Stoltenberg",
      "Phone": "536.013.0576",
      "PhoneId": 212,
      "ProjectMemberTypeId": 427,
      "EmailAddressName": "maxine_torphy@jenkins.us",
      "Comment": "veritatis",
      "FullName": "Linnie Vicenta Adams V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 646
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "odio",
      "StrippedValue": "eius",
      "Description": "Reduced web-enabled analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "eius",
      "Description": "Reduced web-enabled analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    }
  ],
  "CreatedDate": "2016-10-29T23:03:56.6301203+02:00",
  "UpdatedDate": "2016-08-28T23:03:56.6301203+02:00",
  "Description": "Robust composite conglomeration",
  "Postit": "quis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Optimized solution-oriented projection",
  "ActiveStatusMonitorId": 757,
  "Links": [
    {
      "EntityName": "Wilkinson-Schroeder",
      "Id": 250,
      "Description": "Expanded background matrix",
      "ExtraInfo": "autem",
      "LinkId": 650,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    }
  ],
  "ActiveLinks": 976,
  "Completed": true,
  "NextMilestoneDate": "2010-05-31T23:03:56.6316196+02:00",
  "NmdAppointmentId": 620,
  "EndDate": "2003-09-25T23:03:56.6316196+02:00",
  "ActiveErpLinks": 196,
  "UserDefinedFields": {
    "SuperOffice:1": "Jaleel Satterfield",
    "SuperOffice:2": "Prof. Elaina Jerrold Hegmann"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "vero",
    "CustomFields2": "delectus"
  },
  "PublishEventDate": "2020-12-15T23:03:56.6321225+01:00",
  "PublishTo": "2021-07-02T23:03:56.6321225+02:00",
  "PublishFrom": "2019-02-21T23:03:56.6321225+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 393
    }
  }
}
```