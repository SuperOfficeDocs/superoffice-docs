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
  "ProjectId": 387,
  "Name": "Beer Group",
  "ProjectNumber": "923137",
  "ProjectMembers": [
    {
      "ProjectmemberId": 992,
      "ContactId": 470,
      "ProjectId": 623,
      "ContactName": "Labadie-Collier",
      "ContactDepartment": "",
      "ProjectName": "Kerluke-Hayes",
      "EmailId": 579,
      "EmailAddress": "joaquin@kunzeziemann.ca",
      "CountryId": 617,
      "Firstname": "Art",
      "MiddleName": "Prohaska-Anderson",
      "Lastname": "Beatty",
      "PersonId": 950,
      "Mrmrs": "fugit",
      "ProjectMemberTypeName": "Greenholt Group",
      "Phone": "(019)814-4206 x402",
      "PhoneId": 928,
      "ProjectMemberTypeId": 492,
      "EmailAddressName": "zola.wehner@ebertfeest.com",
      "Comment": "molestiae",
      "FullName": "Kaylie West"
    }
  ],
  "Urls": [
    {
      "Value": "odit",
      "StrippedValue": "aliquid",
      "Description": "Advanced client-driven database"
    },
    {
      "Value": "odit",
      "StrippedValue": "aliquid",
      "Description": "Advanced client-driven database"
    }
  ],
  "CreatedDate": "2023-04-16T03:44:52.902049+02:00",
  "UpdatedDate": "2009-07-13T03:44:52.902049+02:00",
  "Description": "Versatile bottom-line matrices",
  "Postit": "nihil",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "User-centric stable moderator",
  "ActiveStatusMonitorId": 871,
  "Links": [
    {
      "EntityName": "Windler-Hodkiewicz",
      "Id": 240,
      "Description": "Automated neutral complexity",
      "ExtraInfo": "expedita",
      "LinkId": 754
    },
    {
      "EntityName": "Windler-Hodkiewicz",
      "Id": 240,
      "Description": "Automated neutral complexity",
      "ExtraInfo": "expedita",
      "LinkId": 754
    }
  ],
  "ActiveLinks": 13,
  "Completed": false,
  "NextMilestoneDate": "2010-11-15T03:44:52.902049+01:00",
  "NmdAppointmentId": 988,
  "EndDate": "1998-12-02T03:44:52.902049+01:00",
  "ActiveErpLinks": 571,
  "UserDefinedFields": {
    "SuperOffice:1": "Otha Leannon I",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "possimus"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "ad"
  },
  "PublishEventDate": "2019-07-21T03:44:52.902049+02:00",
  "PublishTo": "2015-01-08T03:44:52.902049+01:00",
  "PublishFrom": "2007-12-05T03:44:52.902049+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 359,
  "Name": "Fadel, Marvin and Bode",
  "ProjectNumber": "838950",
  "ProjectMembers": [
    {
      "ProjectmemberId": 929,
      "ContactId": 385,
      "ProjectId": 580,
      "ContactName": "Boehm, McDermott and Kreiger",
      "ContactDepartment": "",
      "ProjectName": "Casper, Grimes and Rempel",
      "EmailId": 254,
      "EmailAddress": "dejon.gaylord@lynch.info",
      "CountryId": 753,
      "Firstname": "Maxime",
      "MiddleName": "Flatley-Mayert",
      "Lastname": "Kunze",
      "PersonId": 488,
      "Mrmrs": "numquam",
      "ProjectMemberTypeName": "Bartell, Donnelly and Tillman",
      "Phone": "1-625-983-1379 x0756",
      "PhoneId": 365,
      "ProjectMemberTypeId": 246,
      "EmailAddressName": "sierra@sanfordstroman.co.uk",
      "Comment": "ut",
      "FullName": "Luciano Rowe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 140
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "corrupti",
      "Description": "Secured uniform instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "corrupti",
      "Description": "Secured uniform instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    }
  ],
  "CreatedDate": "2017-03-26T03:44:52.9177081+02:00",
  "UpdatedDate": "2017-03-23T03:44:52.9177081+01:00",
  "Description": "Centralized bandwidth-monitored contingency",
  "Postit": "laborum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Quality-focused zero administration circuit",
  "ActiveStatusMonitorId": 116,
  "Links": [
    {
      "EntityName": "Conn Group",
      "Id": 100,
      "Description": "Expanded holistic leverage",
      "ExtraInfo": "veniam",
      "LinkId": 287,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 234
        }
      }
    }
  ],
  "ActiveLinks": 162,
  "Completed": false,
  "NextMilestoneDate": "1999-04-19T03:44:52.9177081+02:00",
  "NmdAppointmentId": 248,
  "EndDate": "2007-12-06T03:44:52.9177081+01:00",
  "ActiveErpLinks": 23,
  "UserDefinedFields": {
    "SuperOffice:1": "193707073",
    "SuperOffice:2": "Cora Sanford"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorum",
    "ExtraFields2": "placeat"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "sed"
  },
  "PublishEventDate": "2016-10-03T03:44:52.9177081+02:00",
  "PublishTo": "2023-05-19T03:44:52.9177081+02:00",
  "PublishFrom": "2008-05-26T03:44:52.9177081+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 119
    }
  }
}
```