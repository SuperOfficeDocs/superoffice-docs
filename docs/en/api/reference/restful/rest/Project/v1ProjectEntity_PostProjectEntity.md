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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 136,
  "Name": "Fritsch, Kreiger and Kunde",
  "ProjectNumber": "887688",
  "ProjectMembers": [
    {
      "ProjectmemberId": 654,
      "ContactId": 327,
      "ProjectId": 999,
      "ContactName": "Keebler-Fisher",
      "ContactDepartment": "",
      "ProjectName": "Jones-Wolff",
      "EmailId": 808,
      "EmailAddress": "kaylin.wisozk@legros.biz",
      "CountryId": 985,
      "Firstname": "Madeline",
      "MiddleName": "Monahan-Strosin",
      "Lastname": "Fahey",
      "PersonId": 820,
      "Mrmrs": "accusantium",
      "ProjectMemberTypeName": "Weimann-Monahan",
      "Phone": "1-732-297-1764 x02151",
      "PhoneId": 52,
      "ProjectMemberTypeId": 619,
      "EmailAddressName": "kathlyn_hoeger@mcglynn.uk",
      "Comment": "in",
      "FullName": "Malachi Olson"
    }
  ],
  "Urls": [
    {
      "Value": "harum",
      "StrippedValue": "explicabo",
      "Description": "Stand-alone fault-tolerant methodology"
    },
    {
      "Value": "harum",
      "StrippedValue": "explicabo",
      "Description": "Stand-alone fault-tolerant methodology"
    }
  ],
  "CreatedDate": "2021-05-23T11:16:14.0269512+02:00",
  "UpdatedDate": "2020-10-24T11:16:14.0269512+02:00",
  "Description": "Enhanced clear-thinking system engine",
  "Postit": "voluptas",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Face to face composite matrices",
  "ActiveStatusMonitorId": 873,
  "Links": [
    {
      "EntityName": "Johnston-Trantow",
      "Id": 233,
      "Description": "Synergistic uniform knowledge base",
      "ExtraInfo": "sint",
      "LinkId": 221
    },
    {
      "EntityName": "Johnston-Trantow",
      "Id": 233,
      "Description": "Synergistic uniform knowledge base",
      "ExtraInfo": "sint",
      "LinkId": 221
    }
  ],
  "ActiveLinks": 815,
  "Completed": true,
  "NextMilestoneDate": "2014-11-15T11:16:14.0269512+01:00",
  "NmdAppointmentId": 509,
  "EndDate": "2014-07-28T11:16:14.0269512+02:00",
  "ActiveErpLinks": 889,
  "UserDefinedFields": {
    "SuperOffice:1": "Zackery Lavina Walsh DVM",
    "SuperOffice:2": "Dandre Zulauf"
  },
  "ExtraFields": {
    "ExtraFields1": "fugiat",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "atque"
  },
  "PublishEventDate": "2017-04-06T11:16:14.0269512+02:00",
  "PublishTo": "1999-11-17T11:16:14.0269512+01:00",
  "PublishFrom": "2017-01-20T11:16:14.0269512+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 412,
  "Name": "Boyle, Rutherford and Adams",
  "ProjectNumber": "683996",
  "ProjectMembers": [
    {
      "ProjectmemberId": 774,
      "ContactId": 466,
      "ProjectId": 563,
      "ContactName": "Feeney, Feest and Pouros",
      "ContactDepartment": "",
      "ProjectName": "Hills-Schowalter",
      "EmailId": 182,
      "EmailAddress": "linwood@pagac.info",
      "CountryId": 510,
      "Firstname": "Aubrey",
      "MiddleName": "O'Hara-Wuckert",
      "Lastname": "Mueller",
      "PersonId": 468,
      "Mrmrs": "odio",
      "ProjectMemberTypeName": "Kiehn, Schiller and McGlynn",
      "Phone": "497-905-1141 x6089",
      "PhoneId": 361,
      "ProjectMemberTypeId": 542,
      "EmailAddressName": "madaline_waters@miller.uk",
      "Comment": "id",
      "FullName": "Ernest McCullough",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 797
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "corrupti",
      "StrippedValue": "harum",
      "Description": "Decentralized 6th generation orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "harum",
      "Description": "Decentralized 6th generation orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    }
  ],
  "CreatedDate": "2013-11-26T11:16:14.0269512+01:00",
  "UpdatedDate": "2015-02-04T11:16:14.0269512+01:00",
  "Description": "Expanded scalable orchestration",
  "Postit": "optio",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Future-proofed content-based frame",
  "ActiveStatusMonitorId": 34,
  "Links": [
    {
      "EntityName": "Cassin-Crooks",
      "Id": 313,
      "Description": "Monitored modular implementation",
      "ExtraInfo": "iure",
      "LinkId": 132,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 48
        }
      }
    }
  ],
  "ActiveLinks": 767,
  "Completed": false,
  "NextMilestoneDate": "2011-04-16T11:16:14.0269512+02:00",
  "NmdAppointmentId": 365,
  "EndDate": "2011-07-07T11:16:14.0269512+02:00",
  "ActiveErpLinks": 385,
  "UserDefinedFields": {
    "SuperOffice:1": "Annabell Rosenbaum",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "voluptatibus"
  },
  "PublishEventDate": "1997-11-08T11:16:14.0269512+01:00",
  "PublishTo": "2003-05-09T11:16:14.0269512+02:00",
  "PublishFrom": "2018-02-21T11:16:14.0269512+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 236
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```