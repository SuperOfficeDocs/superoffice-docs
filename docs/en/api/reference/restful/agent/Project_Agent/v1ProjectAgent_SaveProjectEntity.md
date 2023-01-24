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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 286,
  "Name": "Rolfson-Douglas",
  "ProjectNumber": "1171982",
  "ProjectMembers": [
    {
      "ProjectmemberId": 262,
      "ContactId": 859,
      "ProjectId": 845,
      "ContactName": "Ryan, Bogan and Hauck",
      "ContactDepartment": "",
      "ProjectName": "Johnson LLC",
      "EmailId": 767,
      "EmailAddress": "danielle_hamill@osinski.name",
      "CountryId": 878,
      "Firstname": "Clifton",
      "MiddleName": "Kohler LLC",
      "Lastname": "Carroll",
      "PersonId": 8,
      "Mrmrs": "vero",
      "ProjectMemberTypeName": "Parker Group",
      "Phone": "591.510.8893 x77837",
      "PhoneId": 560,
      "ProjectMemberTypeId": 608,
      "EmailAddressName": "stephen.becker@gutmann.ca",
      "Comment": "consectetur",
      "FullName": "Amber Tressa Metz III"
    }
  ],
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "nostrum",
      "Description": "Decentralized needs-based circuit"
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "nostrum",
      "Description": "Decentralized needs-based circuit"
    }
  ],
  "CreatedDate": "2022-09-05T11:22:38.8052199+02:00",
  "UpdatedDate": "2020-02-14T11:22:38.8052199+01:00",
  "Description": "Assimilated mission-critical standardization",
  "Postit": "aliquam",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Vision-oriented heuristic infrastructure",
  "ActiveStatusMonitorId": 914,
  "Links": [
    {
      "EntityName": "Conn Group",
      "Id": 984,
      "Description": "Progressive coherent product",
      "ExtraInfo": "soluta",
      "LinkId": 391
    },
    {
      "EntityName": "Conn Group",
      "Id": 984,
      "Description": "Progressive coherent product",
      "ExtraInfo": "soluta",
      "LinkId": 391
    }
  ],
  "ActiveLinks": 798,
  "Completed": false,
  "NextMilestoneDate": "2020-12-12T11:22:38.8052199+01:00",
  "NmdAppointmentId": 855,
  "EndDate": "1996-08-29T11:22:38.8052199+02:00",
  "ActiveErpLinks": 800,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "467095137"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "officia"
  },
  "PublishEventDate": "2013-05-25T11:22:38.8052199+02:00",
  "PublishTo": "2006-08-19T11:22:38.8052199+02:00",
  "PublishFrom": "2018-05-03T11:22:38.8052199+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 196,
  "Name": "Hodkiewicz LLC",
  "ProjectNumber": "405181",
  "ProjectMembers": [
    {
      "ProjectmemberId": 38,
      "ContactId": 577,
      "ProjectId": 846,
      "ContactName": "Koepp-Breitenberg",
      "ContactDepartment": "",
      "ProjectName": "Kutch LLC",
      "EmailId": 697,
      "EmailAddress": "melisa@dare.us",
      "CountryId": 89,
      "Firstname": "Celine",
      "MiddleName": "Heller-Crooks",
      "Lastname": "Schuster",
      "PersonId": 162,
      "Mrmrs": "quasi",
      "ProjectMemberTypeName": "Upton, Cummings and Jacobson",
      "Phone": "(468)169-9847 x7614",
      "PhoneId": 475,
      "ProjectMemberTypeId": 469,
      "EmailAddressName": "baby@conroy.name",
      "Comment": "impedit",
      "FullName": "Ludie Kessler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quibusdam",
      "StrippedValue": "id",
      "Description": "Team-oriented maximized attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "id",
      "Description": "Team-oriented maximized attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "CreatedDate": "2019-07-26T11:22:38.8052199+02:00",
  "UpdatedDate": "2006-12-16T11:22:38.8052199+01:00",
  "Description": "Grass-roots bi-directional data-warehouse",
  "Postit": "facere",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Re-contextualized zero defect success",
  "ActiveStatusMonitorId": 419,
  "Links": [
    {
      "EntityName": "Murray Inc and Sons",
      "Id": 498,
      "Description": "User-friendly discrete website",
      "ExtraInfo": "minus",
      "LinkId": 987,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 577
        }
      }
    }
  ],
  "ActiveLinks": 443,
  "Completed": false,
  "NextMilestoneDate": "2020-05-04T11:22:38.8052199+02:00",
  "NmdAppointmentId": 933,
  "EndDate": "2009-02-21T11:22:38.8052199+01:00",
  "ActiveErpLinks": 97,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Callie McCullough"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "ducimus",
    "CustomFields2": "est"
  },
  "PublishEventDate": "2018-02-15T11:22:38.8052199+01:00",
  "PublishTo": "2013-09-22T11:22:38.8052199+02:00",
  "PublishFrom": "2009-09-19T11:22:38.8052199+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 83
    }
  }
}
```