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

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 440,
  "Name": "Schinner LLC",
  "ProjectNumber": "1723081",
  "ProjectMembers": [
    {
      "ProjectmemberId": 476,
      "ContactId": 580,
      "ProjectId": 565,
      "ContactName": "Ratke Group",
      "ContactDepartment": "",
      "ProjectName": "Jacobson, Bailey and Haag",
      "EmailId": 866,
      "EmailAddress": "willa@runte.biz",
      "CountryId": 846,
      "Firstname": "Mable",
      "MiddleName": "Kris LLC",
      "Lastname": "Windler",
      "PersonId": 859,
      "Mrmrs": "sequi",
      "ProjectMemberTypeName": "Rippin, Pfeffer and Aufderhar",
      "Phone": "(226)191-2555",
      "PhoneId": 17,
      "ProjectMemberTypeId": 81,
      "EmailAddressName": "makenna@treutellesch.us",
      "Comment": "dicta",
      "FullName": "Mrs. Tommie Kilback I"
    }
  ],
  "Urls": [
    {
      "Value": "optio",
      "StrippedValue": "vel",
      "Description": "Digitized methodical circuit"
    },
    {
      "Value": "optio",
      "StrippedValue": "vel",
      "Description": "Digitized methodical circuit"
    }
  ],
  "CreatedDate": "1998-04-23T14:32:03.4679728+02:00",
  "UpdatedDate": "2022-08-26T14:32:03.4679728+02:00",
  "Description": "Re-engineered optimizing customer loyalty",
  "Postit": "cum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Seamless mobile system engine",
  "ActiveStatusMonitorId": 869,
  "Links": [
    {
      "EntityName": "Lubowitz-Altenwerth",
      "Id": 683,
      "Description": "Organized cohesive time-frame",
      "ExtraInfo": "voluptatem",
      "LinkId": 926
    },
    {
      "EntityName": "Lubowitz-Altenwerth",
      "Id": 683,
      "Description": "Organized cohesive time-frame",
      "ExtraInfo": "voluptatem",
      "LinkId": 926
    }
  ],
  "ActiveLinks": 107,
  "Completed": false,
  "NextMilestoneDate": "2014-04-01T14:32:03.4679728+02:00",
  "NmdAppointmentId": 185,
  "EndDate": "1999-07-12T14:32:03.4679728+02:00",
  "ActiveErpLinks": 999,
  "UserDefinedFields": {
    "SuperOffice:1": "1763845609",
    "SuperOffice:2": "Lucas Rath"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "occaecati"
  },
  "CustomFields": {
    "CustomFields1": "tempore",
    "CustomFields2": "quia"
  },
  "PublishEventDate": "2001-01-05T14:32:03.4679728+01:00",
  "PublishTo": "2022-08-03T14:32:03.4679728+02:00",
  "PublishFrom": "2016-05-22T14:32:03.4679728+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 901,
  "Name": "Bednar LLC",
  "ProjectNumber": "1757239",
  "ProjectMembers": [
    {
      "ProjectmemberId": 658,
      "ContactId": 954,
      "ProjectId": 302,
      "ContactName": "Friesen LLC",
      "ContactDepartment": "",
      "ProjectName": "Johns, Smitham and Keebler",
      "EmailId": 726,
      "EmailAddress": "janie.metz@schamberger.ca",
      "CountryId": 535,
      "Firstname": "Claire",
      "MiddleName": "Feil-Buckridge",
      "Lastname": "Cremin",
      "PersonId": 976,
      "Mrmrs": "dolore",
      "ProjectMemberTypeName": "Goodwin Inc and Sons",
      "Phone": "(856)429-5399",
      "PhoneId": 491,
      "ProjectMemberTypeId": 941,
      "EmailAddressName": "cecile.eichmann@hayes.com",
      "Comment": "cumque",
      "FullName": "Mckenzie Sporer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 451
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "occaecati",
      "StrippedValue": "aliquid",
      "Description": "Re-engineered multi-tasking budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "aliquid",
      "Description": "Re-engineered multi-tasking budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "CreatedDate": "2013-02-21T14:32:03.4679728+01:00",
  "UpdatedDate": "2022-09-23T14:32:03.4679728+02:00",
  "Description": "Quality-focused composite implementation",
  "Postit": "vitae",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Public-key 5th generation capability",
  "ActiveStatusMonitorId": 561,
  "Links": [
    {
      "EntityName": "Lehner Group",
      "Id": 108,
      "Description": "Horizontal web-enabled software",
      "ExtraInfo": "cumque",
      "LinkId": 241,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    }
  ],
  "ActiveLinks": 947,
  "Completed": false,
  "NextMilestoneDate": "2011-10-05T14:32:03.4679728+02:00",
  "NmdAppointmentId": 960,
  "EndDate": "2022-11-13T14:32:03.4679728+01:00",
  "ActiveErpLinks": 191,
  "UserDefinedFields": {
    "SuperOffice:1": "240331004",
    "SuperOffice:2": "Ana Jacobs"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "excepturi"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "quisquam"
  },
  "PublishEventDate": "2009-12-12T14:32:03.4679728+01:00",
  "PublishTo": "2020-05-24T14:32:03.4679728+02:00",
  "PublishFrom": "2011-04-30T14:32:03.4679728+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 402
    }
  }
}
```