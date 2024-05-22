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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 987,
  "Name": "Bradtke Inc and Sons",
  "ProjectNumber": "1169048",
  "ProjectMembers": [
    {
      "ProjectmemberId": 834,
      "ContactId": 51,
      "ProjectId": 190,
      "ContactName": "Kreiger LLC",
      "ContactDepartment": "",
      "ProjectName": "Rath LLC",
      "EmailId": 914,
      "EmailAddress": "sabrina@jaskolski.info",
      "CountryId": 682,
      "Firstname": "Ilene",
      "MiddleName": "Kreiger-Krajcik",
      "Lastname": "Stracke",
      "PersonId": 314,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Skiles-Feeney",
      "Phone": "1-326-670-2033 x441",
      "PhoneId": 795,
      "ProjectMemberTypeId": 536,
      "EmailAddressName": "emmalee.will@herzog.name",
      "Comment": "omnis",
      "FullName": "Viola Reilly"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "sed",
      "Description": "Re-contextualized upward-trending hardware"
    },
    {
      "Value": "qui",
      "StrippedValue": "sed",
      "Description": "Re-contextualized upward-trending hardware"
    }
  ],
  "CreatedDate": "2017-12-24T12:57:42.6044701+01:00",
  "UpdatedDate": "2000-08-03T12:57:42.6044701+02:00",
  "Description": "Focused multi-tasking attitude",
  "Postit": "quis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Switchable eco-centric data-warehouse",
  "ActiveStatusMonitorId": 192,
  "Links": [
    {
      "EntityName": "Nader LLC",
      "Id": 73,
      "Description": "Devolved executive help-desk",
      "ExtraInfo": "sint",
      "LinkId": 882
    },
    {
      "EntityName": "Nader LLC",
      "Id": 73,
      "Description": "Devolved executive help-desk",
      "ExtraInfo": "sint",
      "LinkId": 882
    }
  ],
  "ActiveLinks": 526,
  "Completed": true,
  "NextMilestoneDate": "2009-01-18T12:57:42.6044701+01:00",
  "NmdAppointmentId": 650,
  "EndDate": "2003-10-13T12:57:42.6044701+02:00",
  "ActiveErpLinks": 564,
  "UserDefinedFields": {
    "SuperOffice:1": "Aaron Oswald Schowalter DVM",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "corporis"
  },
  "PublishEventDate": "2005-05-20T12:57:42.6044701+02:00",
  "PublishTo": "2009-10-20T12:57:42.6044701+02:00",
  "PublishFrom": "1998-07-16T12:57:42.6044701+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 339,
  "Name": "Kuvalis, Blanda and Schowalter",
  "ProjectNumber": "1471937",
  "ProjectMembers": [
    {
      "ProjectmemberId": 275,
      "ContactId": 293,
      "ProjectId": 479,
      "ContactName": "Mitchell, Leffler and Lind",
      "ContactDepartment": "",
      "ProjectName": "Willms-Baumbach",
      "EmailId": 830,
      "EmailAddress": "viola@breitenbergtowne.ca",
      "CountryId": 160,
      "Firstname": "Melvin",
      "MiddleName": "Cole, Bednar and Thiel",
      "Lastname": "Ullrich",
      "PersonId": 394,
      "Mrmrs": "praesentium",
      "ProjectMemberTypeName": "Schowalter Group",
      "Phone": "834-076-6225 x6576",
      "PhoneId": 250,
      "ProjectMemberTypeId": 677,
      "EmailAddressName": "rosalia@kuphal.info",
      "Comment": "voluptas",
      "FullName": "Guido Cronin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 968
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "doloremque",
      "StrippedValue": "numquam",
      "Description": "Public-key cohesive knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "numquam",
      "Description": "Public-key cohesive knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    }
  ],
  "CreatedDate": "2004-07-04T12:57:42.6044701+02:00",
  "UpdatedDate": "2003-01-09T12:57:42.6044701+01:00",
  "Description": "Horizontal secondary encryption",
  "Postit": "est",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Organic neutral project",
  "ActiveStatusMonitorId": 915,
  "Links": [
    {
      "EntityName": "Considine, Walker and Hermann",
      "Id": 514,
      "Description": "Compatible regional model",
      "ExtraInfo": "repellendus",
      "LinkId": 901,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 260
        }
      }
    }
  ],
  "ActiveLinks": 159,
  "Completed": false,
  "NextMilestoneDate": "2010-01-05T12:57:42.6044701+01:00",
  "NmdAppointmentId": 786,
  "EndDate": "2022-07-25T12:57:42.6044701+02:00",
  "ActiveErpLinks": 830,
  "UserDefinedFields": {
    "SuperOffice:1": "Norberto West",
    "SuperOffice:2": "943916925"
  },
  "ExtraFields": {
    "ExtraFields1": "nisi",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "tempore",
    "CustomFields2": "sit"
  },
  "PublishEventDate": "2001-08-06T12:57:42.6044701+02:00",
  "PublishTo": "2008-01-13T12:57:42.6044701+01:00",
  "PublishFrom": "2008-10-24T12:57:42.6044701+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 880
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```