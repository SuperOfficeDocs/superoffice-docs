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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 694,
  "Name": "Kshlerin-Wiza",
  "ProjectNumber": "664051",
  "ProjectMembers": [
    {
      "ProjectmemberId": 146,
      "ContactId": 251,
      "ProjectId": 364,
      "ContactName": "Kassulke, Terry and McClure",
      "ContactDepartment": "",
      "ProjectName": "Gerlach-Legros",
      "EmailId": 210,
      "EmailAddress": "dustin_doyle@prohaskagorczany.name",
      "CountryId": 566,
      "Firstname": "Giovani",
      "MiddleName": "Nienow LLC",
      "Lastname": "Pagac",
      "PersonId": 357,
      "Mrmrs": "debitis",
      "ProjectMemberTypeName": "Rosenbaum Inc and Sons",
      "Phone": "681-079-6722",
      "PhoneId": 539,
      "ProjectMemberTypeId": 265,
      "EmailAddressName": "annamae_berge@jacobsonwindler.biz",
      "Comment": "numquam",
      "FullName": "Prof. Madie Woodrow Luettgen IV"
    }
  ],
  "Urls": [
    {
      "Value": "dolores",
      "StrippedValue": "minus",
      "Description": "Ameliorated well-modulated pricing structure"
    },
    {
      "Value": "dolores",
      "StrippedValue": "minus",
      "Description": "Ameliorated well-modulated pricing structure"
    }
  ],
  "CreatedDate": "2013-05-08T14:45:12.9431644+02:00",
  "UpdatedDate": "2004-09-08T14:45:12.9431644+02:00",
  "Description": "Diverse zero administration architecture",
  "Postit": "saepe",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Distributed coherent productivity",
  "ActiveStatusMonitorId": 292,
  "Links": [
    {
      "EntityName": "Toy-Bashirian",
      "Id": 629,
      "Description": "Proactive bandwidth-monitored encryption",
      "ExtraInfo": "nihil",
      "LinkId": 193
    },
    {
      "EntityName": "Toy-Bashirian",
      "Id": 629,
      "Description": "Proactive bandwidth-monitored encryption",
      "ExtraInfo": "nihil",
      "LinkId": 193
    }
  ],
  "ActiveLinks": 961,
  "Completed": true,
  "NextMilestoneDate": "2020-09-28T14:45:12.9431644+02:00",
  "NmdAppointmentId": 651,
  "EndDate": "2016-03-11T14:45:12.9431644+01:00",
  "ActiveErpLinks": 39,
  "UserDefinedFields": {
    "SuperOffice:1": "1329325157",
    "SuperOffice:2": "Joe Fisher IV"
  },
  "ExtraFields": {
    "ExtraFields1": "esse",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "veniam"
  },
  "PublishEventDate": "2005-03-08T14:45:12.9431644+01:00",
  "PublishTo": "2020-03-10T14:45:12.9431644+01:00",
  "PublishFrom": "2010-09-21T14:45:12.9431644+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 333,
  "Name": "Ward, Rath and Heaney",
  "ProjectNumber": "1448261",
  "ProjectMembers": [
    {
      "ProjectmemberId": 531,
      "ContactId": 835,
      "ProjectId": 185,
      "ContactName": "Kuhlman-Leannon",
      "ContactDepartment": "",
      "ProjectName": "Braun Group",
      "EmailId": 13,
      "EmailAddress": "creola.rath@osinski.biz",
      "CountryId": 262,
      "Firstname": "Vicky",
      "MiddleName": "Keebler, Quitzon and O'Hara",
      "Lastname": "Bailey",
      "PersonId": 620,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Raynor, Trantow and Tremblay",
      "Phone": "156.018.1001",
      "PhoneId": 900,
      "ProjectMemberTypeId": 454,
      "EmailAddressName": "shanelle.stiedemann@purdy.uk",
      "Comment": "reiciendis",
      "FullName": "Harmon Arvid Kemmer IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 209
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "sed",
      "Description": "Phased executive initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 145
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "sed",
      "Description": "Phased executive initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 145
        }
      }
    }
  ],
  "CreatedDate": "2018-09-12T14:45:12.9587882+02:00",
  "UpdatedDate": "2022-12-27T14:45:12.9587882+01:00",
  "Description": "Networked holistic framework",
  "Postit": "ab",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Implemented intangible open architecture",
  "ActiveStatusMonitorId": 182,
  "Links": [
    {
      "EntityName": "Dicki, Bradtke and Labadie",
      "Id": 880,
      "Description": "Automated directional contingency",
      "ExtraInfo": "ex",
      "LinkId": 693,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 961
        }
      }
    }
  ],
  "ActiveLinks": 841,
  "Completed": false,
  "NextMilestoneDate": "2010-11-04T14:45:12.9587882+01:00",
  "NmdAppointmentId": 662,
  "EndDate": "2003-10-13T14:45:12.9587882+02:00",
  "ActiveErpLinks": 367,
  "UserDefinedFields": {
    "SuperOffice:1": "Layne Kling",
    "SuperOffice:2": "Maximillian Anderson III"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "eveniet"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "ipsum"
  },
  "PublishEventDate": "2020-03-06T14:45:12.9587882+01:00",
  "PublishTo": "2005-03-24T14:45:12.9587882+01:00",
  "PublishFrom": "2015-06-20T14:45:12.9587882+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 530
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```