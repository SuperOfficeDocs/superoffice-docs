---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
content_type: reference
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.
NsApiSlow threshold: 2000 ms.






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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 950,
  "Name": "Boyer, Luettgen and McDermott",
  "ProjectNumber": "667239",
  "ProjectMembers": [
    {
      "ProjectmemberId": 742,
      "ContactId": 924,
      "ProjectId": 42,
      "ContactName": "Abernathy, Hills and Braun",
      "ContactDepartment": "",
      "ProjectName": "Dicki Inc and Sons",
      "EmailId": 969,
      "EmailAddress": "ova_hermann@mitchellskiles.ca",
      "CountryId": 619,
      "Firstname": "Austin",
      "MiddleName": "Russel, Jakubowski and Nienow",
      "Lastname": "Lindgren",
      "PersonId": 461,
      "Mrmrs": "explicabo",
      "ProjectMemberTypeName": "Doyle, Green and Waelchi",
      "Phone": "1-704-224-9510",
      "PhoneId": 744,
      "ProjectMemberTypeId": 907,
      "EmailAddressName": "retta_mills@zboncakadams.info",
      "Comment": "eum",
      "FullName": "Miss Xavier Laura Blick",
      "Registered": "2024-08-26T02:30:52.8036637+02:00",
      "Updated": "2018-07-12T02:30:52.8036637+02:00"
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "ipsum",
      "Description": "De-engineered methodical open system"
    },
    {
      "Value": "quo",
      "StrippedValue": "ipsum",
      "Description": "De-engineered methodical open system"
    }
  ],
  "CreatedDate": "2013-04-08T02:30:52.8036637+02:00",
  "UpdatedDate": "2019-03-12T02:30:52.8036637+01:00",
  "Description": "Organic asynchronous budgetary management",
  "Postit": "vel",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Reduced 3rd generation knowledge base",
  "ActiveStatusMonitorId": 979,
  "Links": [
    {
      "EntityName": "Ferry Inc and Sons",
      "Id": 864,
      "Description": "Optimized neutral core",
      "ExtraInfo": "debitis",
      "LinkId": 673
    },
    {
      "EntityName": "Ferry Inc and Sons",
      "Id": 864,
      "Description": "Optimized neutral core",
      "ExtraInfo": "debitis",
      "LinkId": 673
    }
  ],
  "ActiveLinks": 350,
  "Completed": false,
  "NextMilestoneDate": "2024-12-25T02:30:52.8036637+01:00",
  "NmdAppointmentId": 303,
  "EndDate": "2004-10-09T02:30:52.8036637+02:00",
  "ActiveErpLinks": 529,
  "UserDefinedFields": {
    "SuperOffice:1": "Asia Kulas",
    "SuperOffice:2": "Dovie Carroll"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "numquam"
  },
  "PublishEventDate": "2017-02-27T02:30:52.8036637+01:00",
  "PublishTo": "2022-02-24T02:30:52.8036637+01:00",
  "PublishFrom": "2014-10-12T02:30:52.8036637+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 658,
  "Name": "Hilpert-Nolan",
  "ProjectNumber": "1003451",
  "ProjectMembers": [
    {
      "ProjectmemberId": 609,
      "ContactId": 264,
      "ProjectId": 455,
      "ContactName": "Hilll Group",
      "ContactDepartment": "disintermediate one-to-one partnerships",
      "ProjectName": "McClure-Kirlin",
      "EmailId": 733,
      "EmailAddress": "laurie@runolfsson.com",
      "CountryId": 643,
      "Firstname": "Cali",
      "MiddleName": "Purdy-Klein",
      "Lastname": "Waters",
      "PersonId": 425,
      "Mrmrs": "eaque",
      "ProjectMemberTypeName": "Robel Group",
      "Phone": "1-351-904-3953",
      "PhoneId": 254,
      "ProjectMemberTypeId": 196,
      "EmailAddressName": "bret.goldner@lubowitznader.co.uk",
      "Comment": "unde",
      "FullName": "Elouise Adell Sporer DVM",
      "Registered": "2010-09-25T02:30:52.8036637+02:00",
      "Updated": "2002-03-18T02:30:52.8036637+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 215
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ducimus",
      "StrippedValue": "quisquam",
      "Description": "Realigned maximized secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "quisquam",
      "Description": "Realigned maximized secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    }
  ],
  "CreatedDate": "2000-11-10T02:30:52.8036637+01:00",
  "UpdatedDate": "2018-05-31T02:30:52.8036637+02:00",
  "Description": "Customer-focused 4th generation neural-net",
  "Postit": "consequuntur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Implemented systemic Graphical User Interface",
  "ActiveStatusMonitorId": 211,
  "Links": [
    {
      "EntityName": "Kreiger, Raynor and McKenzie",
      "Id": 798,
      "Description": "Decentralized interactive focus group",
      "ExtraInfo": "voluptas",
      "LinkId": 993,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "ActiveLinks": 60,
  "Completed": false,
  "NextMilestoneDate": "2000-05-15T02:30:52.8036637+02:00",
  "NmdAppointmentId": 484,
  "EndDate": "2016-11-30T02:30:52.8036637+01:00",
  "ActiveErpLinks": 856,
  "UserDefinedFields": {
    "SuperOffice:1": "1057575468",
    "SuperOffice:2": "44559160"
  },
  "ExtraFields": {
    "ExtraFields1": "esse",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "veritatis",
    "CustomFields2": "illum"
  },
  "PublishEventDate": "2016-06-20T02:30:52.8036637+02:00",
  "PublishTo": "2013-12-24T02:30:52.8036637+01:00",
  "PublishFrom": "2021-10-26T02:30:52.8036637+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 262
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```