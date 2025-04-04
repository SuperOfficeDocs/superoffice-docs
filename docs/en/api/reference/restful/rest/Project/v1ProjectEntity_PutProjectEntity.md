---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
---

# PUT Project/{id}

```http
PUT /api/v1/Project/{id}
```

Updates the existing ProjectEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Project/{id}?$select=name,department,category/id
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

ProjectEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 519,
  "Name": "Miller-Yundt",
  "ProjectNumber": "259590",
  "ProjectMembers": [
    {
      "ProjectmemberId": 124,
      "ContactId": 523,
      "ProjectId": 648,
      "ContactName": "Williamson, Nitzsche and Green",
      "ContactDepartment": "",
      "ProjectName": "Bashirian-Will",
      "EmailId": 337,
      "EmailAddress": "montana_hegmann@johns.us",
      "CountryId": 808,
      "Firstname": "Lennie",
      "MiddleName": "Stokes, Bradtke and Bergstrom",
      "Lastname": "Denesik",
      "PersonId": 454,
      "Mrmrs": "soluta",
      "ProjectMemberTypeName": "Nolan-Witting",
      "Phone": "1-549-634-8434 x77713",
      "PhoneId": 913,
      "ProjectMemberTypeId": 888,
      "EmailAddressName": "carolyn@koepp.uk",
      "Comment": "eum",
      "FullName": "Ms. Lorena Mraz"
    }
  ],
  "Urls": [
    {
      "Value": "tenetur",
      "StrippedValue": "corrupti",
      "Description": "Open-architected eco-centric capacity"
    },
    {
      "Value": "tenetur",
      "StrippedValue": "corrupti",
      "Description": "Open-architected eco-centric capacity"
    }
  ],
  "CreatedDate": "2015-07-31T13:14:08.9148773+02:00",
  "UpdatedDate": "2021-05-22T13:14:08.9148773+02:00",
  "Description": "Reverse-engineered client-server artificial intelligence",
  "Postit": "impedit",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Synchronised empowering projection",
  "ActiveStatusMonitorId": 418,
  "Links": [
    {
      "EntityName": "Zulauf Inc and Sons",
      "Id": 299,
      "Description": "Proactive demand-driven function",
      "ExtraInfo": "rem",
      "LinkId": 524
    },
    {
      "EntityName": "Zulauf Inc and Sons",
      "Id": 299,
      "Description": "Proactive demand-driven function",
      "ExtraInfo": "rem",
      "LinkId": 524
    }
  ],
  "ActiveLinks": 859,
  "Completed": false,
  "NextMilestoneDate": "2004-12-18T13:14:08.9148773+01:00",
  "NmdAppointmentId": 942,
  "EndDate": "2010-12-07T13:14:08.9148773+01:00",
  "ActiveErpLinks": 590,
  "UserDefinedFields": {
    "SuperOffice:1": "913530662",
    "SuperOffice:2": "868545419"
  },
  "ExtraFields": {
    "ExtraFields1": "eveniet",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "recusandae"
  },
  "PublishEventDate": "2014-08-17T13:14:08.9148773+02:00",
  "PublishTo": "2000-11-12T13:14:08.9148773+01:00",
  "PublishFrom": "2002-05-15T13:14:08.9148773+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 676,
  "Name": "Kutch, Kassulke and Barrows",
  "ProjectNumber": "1043338",
  "ProjectMembers": [
    {
      "ProjectmemberId": 973,
      "ContactId": 856,
      "ProjectId": 826,
      "ContactName": "Hirthe Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Connelly Group",
      "EmailId": 749,
      "EmailAddress": "anderson_lockman@robel.co.uk",
      "CountryId": 217,
      "Firstname": "Omer",
      "MiddleName": "Haley Inc and Sons",
      "Lastname": "Hodkiewicz",
      "PersonId": 592,
      "Mrmrs": "aut",
      "ProjectMemberTypeName": "Gibson-Von",
      "Phone": "337-410-4289 x103",
      "PhoneId": 106,
      "ProjectMemberTypeId": 423,
      "EmailAddressName": "gabriella_collins@wildermancarroll.com",
      "Comment": "qui",
      "FullName": "Lew Brekke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 879
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "esse",
      "StrippedValue": "error",
      "Description": "Quality-focused value-added extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 2
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "error",
      "Description": "Quality-focused value-added extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 2
        }
      }
    }
  ],
  "CreatedDate": "2008-11-02T13:14:08.9148773+01:00",
  "UpdatedDate": "2003-11-27T13:14:08.9148773+01:00",
  "Description": "Mandatory secondary protocol",
  "Postit": "non",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "User-centric asynchronous intranet",
  "ActiveStatusMonitorId": 545,
  "Links": [
    {
      "EntityName": "Hills LLC",
      "Id": 913,
      "Description": "Organized modular infrastructure",
      "ExtraInfo": "molestiae",
      "LinkId": 684,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "ActiveLinks": 145,
  "Completed": false,
  "NextMilestoneDate": "2004-12-11T13:14:08.9148773+01:00",
  "NmdAppointmentId": 509,
  "EndDate": "2003-05-28T13:14:08.9148773+02:00",
  "ActiveErpLinks": 901,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "285843844"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "vero"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "nesciunt"
  },
  "PublishEventDate": "2001-05-24T13:14:08.9148773+02:00",
  "PublishTo": "2003-07-22T13:14:08.9148773+02:00",
  "PublishFrom": "2004-07-31T13:14:08.9148773+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 723
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```