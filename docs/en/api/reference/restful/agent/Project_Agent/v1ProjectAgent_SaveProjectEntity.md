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
  "ProjectId": 717,
  "Name": "Collier-Beatty",
  "ProjectNumber": "602508",
  "ProjectMembers": [
    {
      "ProjectmemberId": 393,
      "ContactId": 157,
      "ProjectId": 810,
      "ContactName": "Schuster, Altenwerth and Waelchi",
      "ContactDepartment": "",
      "ProjectName": "Baumbach, Veum and Rowe",
      "EmailId": 65,
      "EmailAddress": "kurtis@watsica.info",
      "CountryId": 806,
      "Firstname": "Jason",
      "MiddleName": "Hoeger-Prosacco",
      "Lastname": "Ondricka",
      "PersonId": 418,
      "Mrmrs": "quis",
      "ProjectMemberTypeName": "Goodwin, Wuckert and Douglas",
      "Phone": "1-655-588-8682",
      "PhoneId": 759,
      "ProjectMemberTypeId": 734,
      "EmailAddressName": "silas.lindgren@wiegand.info",
      "Comment": "provident",
      "FullName": "Minnie Friesen"
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "placeat",
      "Description": "Seamless non-volatile moratorium"
    },
    {
      "Value": "est",
      "StrippedValue": "placeat",
      "Description": "Seamless non-volatile moratorium"
    }
  ],
  "CreatedDate": "2019-09-12T02:38:21.7138796+02:00",
  "UpdatedDate": "2008-03-15T02:38:21.7138796+01:00",
  "Description": "Grass-roots zero tolerance implementation",
  "Postit": "fugiat",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Enterprise-wide radical open architecture",
  "ActiveStatusMonitorId": 737,
  "Links": [
    {
      "EntityName": "Wehner-Abbott",
      "Id": 751,
      "Description": "Quality-focused tertiary paradigm",
      "ExtraInfo": "et",
      "LinkId": 201
    },
    {
      "EntityName": "Wehner-Abbott",
      "Id": 751,
      "Description": "Quality-focused tertiary paradigm",
      "ExtraInfo": "et",
      "LinkId": 201
    }
  ],
  "ActiveLinks": 54,
  "Completed": false,
  "NextMilestoneDate": "2019-02-05T02:38:21.7138796+01:00",
  "NmdAppointmentId": 367,
  "EndDate": "2012-05-06T02:38:21.7138796+02:00",
  "ActiveErpLinks": 651,
  "UserDefinedFields": {
    "SuperOffice:1": "Sam Harber",
    "SuperOffice:2": "1511039759"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "facere",
    "CustomFields2": "rerum"
  },
  "PublishEventDate": "2014-09-10T02:38:21.7138796+02:00",
  "PublishTo": "2014-02-11T02:38:21.7138796+01:00",
  "PublishFrom": "2004-12-16T02:38:21.7138796+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 417,
  "Name": "DuBuque, Gleichner and Hettinger",
  "ProjectNumber": "1312686",
  "ProjectMembers": [
    {
      "ProjectmemberId": 171,
      "ContactId": 313,
      "ProjectId": 800,
      "ContactName": "Reichel, Beer and Hand",
      "ContactDepartment": "",
      "ProjectName": "Krajcik Group",
      "EmailId": 649,
      "EmailAddress": "manuel@schultzsipes.name",
      "CountryId": 611,
      "Firstname": "Elissa",
      "MiddleName": "Bashirian Inc and Sons",
      "Lastname": "Johns",
      "PersonId": 612,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Muller-McKenzie",
      "Phone": "(754)581-3087 x969",
      "PhoneId": 612,
      "ProjectMemberTypeId": 549,
      "EmailAddressName": "ralph.schowalter@oharahalvorson.uk",
      "Comment": "recusandae",
      "FullName": "Prof. Arjun Gleason DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "culpa",
      "Description": "Synchronised client-driven emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "culpa",
      "Description": "Synchronised client-driven emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    }
  ],
  "CreatedDate": "2008-03-06T02:38:21.7138796+01:00",
  "UpdatedDate": "2004-02-20T02:38:21.7138796+01:00",
  "Description": "Assimilated 24 hour local area network",
  "Postit": "vitae",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Robust heuristic neural-net",
  "ActiveStatusMonitorId": 46,
  "Links": [
    {
      "EntityName": "Williamson-Ernser",
      "Id": 295,
      "Description": "Compatible next generation model",
      "ExtraInfo": "voluptatem",
      "LinkId": 32,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    }
  ],
  "ActiveLinks": 528,
  "Completed": true,
  "NextMilestoneDate": "2001-01-19T02:38:21.7138796+01:00",
  "NmdAppointmentId": 329,
  "EndDate": "2009-08-13T02:38:21.7138796+02:00",
  "ActiveErpLinks": 337,
  "UserDefinedFields": {
    "SuperOffice:1": "1429157180",
    "SuperOffice:2": "Garnet Hermiston"
  },
  "ExtraFields": {
    "ExtraFields1": "delectus",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "sequi"
  },
  "PublishEventDate": "2014-08-30T02:38:21.7138796+02:00",
  "PublishTo": "2002-06-06T02:38:21.7138796+02:00",
  "PublishFrom": "2005-04-14T02:38:21.7138796+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 743
    }
  }
}
```