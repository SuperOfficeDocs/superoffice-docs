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
  "ProjectId": 461,
  "Name": "Altenwerth, Watsica and Dickinson",
  "ProjectNumber": "871479",
  "ProjectMembers": [
    {
      "ProjectmemberId": 533,
      "ContactId": 577,
      "ProjectId": 411,
      "ContactName": "Lindgren, Kunde and Boyer",
      "ContactDepartment": "",
      "ProjectName": "Bailey-Willms",
      "EmailId": 323,
      "EmailAddress": "christian.hahn@friesenborer.ca",
      "CountryId": 185,
      "Firstname": "Douglas",
      "MiddleName": "Harvey, Haley and McClure",
      "Lastname": "Wintheiser",
      "PersonId": 15,
      "Mrmrs": "necessitatibus",
      "ProjectMemberTypeName": "Daugherty LLC",
      "Phone": "113.085.9294 x27045",
      "PhoneId": 492,
      "ProjectMemberTypeId": 887,
      "EmailAddressName": "adell@hyattlabadie.info",
      "Comment": "quam",
      "FullName": "Oceane Wisozk"
    }
  ],
  "Urls": [
    {
      "Value": "ipsam",
      "StrippedValue": "vel",
      "Description": "Managed 24/7 model"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "vel",
      "Description": "Managed 24/7 model"
    }
  ],
  "CreatedDate": "2000-10-09T15:29:22.4297998+02:00",
  "UpdatedDate": "1999-07-04T15:29:22.4297998+02:00",
  "Description": "Synergized disintermediate website",
  "Postit": "dolorum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "User-centric incremental concept",
  "ActiveStatusMonitorId": 866,
  "Links": [
    {
      "EntityName": "Hyatt-Wintheiser",
      "Id": 690,
      "Description": "Visionary intangible capacity",
      "ExtraInfo": "praesentium",
      "LinkId": 636
    },
    {
      "EntityName": "Hyatt-Wintheiser",
      "Id": 690,
      "Description": "Visionary intangible capacity",
      "ExtraInfo": "praesentium",
      "LinkId": 636
    }
  ],
  "ActiveLinks": 520,
  "Completed": false,
  "NextMilestoneDate": "2007-11-14T15:29:22.4308003+01:00",
  "NmdAppointmentId": 374,
  "EndDate": "2021-06-07T15:29:22.4308003+02:00",
  "ActiveErpLinks": 255,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "numquam",
    "CustomFields2": "ad"
  },
  "PublishEventDate": "2005-01-25T15:29:22.4308003+01:00",
  "PublishTo": "2008-03-20T15:29:22.4308003+01:00",
  "PublishFrom": "2017-06-13T15:29:22.4308003+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 921,
  "Name": "Quitzon-Torp",
  "ProjectNumber": "672137",
  "ProjectMembers": [
    {
      "ProjectmemberId": 258,
      "ContactId": 679,
      "ProjectId": 966,
      "ContactName": "Schoen-Hoeger",
      "ContactDepartment": "",
      "ProjectName": "Watsica Group",
      "EmailId": 165,
      "EmailAddress": "corine.sauer@harvey.us",
      "CountryId": 185,
      "Firstname": "Noe",
      "MiddleName": "Hoeger Group",
      "Lastname": "Koepp",
      "PersonId": 152,
      "Mrmrs": "neque",
      "ProjectMemberTypeName": "Bergnaum Inc and Sons",
      "Phone": "1-344-698-0821 x4687",
      "PhoneId": 781,
      "ProjectMemberTypeId": 322,
      "EmailAddressName": "logan@emmerich.biz",
      "Comment": "placeat",
      "FullName": "Eldred Schaden I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "velit",
      "Description": "Managed interactive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "velit",
      "Description": "Managed interactive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "CreatedDate": "2011-05-28T15:29:22.4349679+02:00",
  "UpdatedDate": "1998-11-29T15:29:22.4349679+01:00",
  "Description": "Pre-emptive zero defect function",
  "Postit": "ab",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Digitized national product",
  "ActiveStatusMonitorId": 506,
  "Links": [
    {
      "EntityName": "O'Connell-Mohr",
      "Id": 850,
      "Description": "Polarised attitude-oriented migration",
      "ExtraInfo": "neque",
      "LinkId": 168,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 986
        }
      }
    }
  ],
  "ActiveLinks": 43,
  "Completed": true,
  "NextMilestoneDate": "2011-10-23T15:29:22.4362998+02:00",
  "NmdAppointmentId": 63,
  "EndDate": "1996-06-09T15:29:22.4362998+02:00",
  "ActiveErpLinks": 851,
  "UserDefinedFields": {
    "SuperOffice:1": "Mariano Johns",
    "SuperOffice:2": "Martina Mohr"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsum",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "magni"
  },
  "PublishEventDate": "1996-04-17T15:29:22.4362998+02:00",
  "PublishTo": "2014-01-31T15:29:22.4362998+01:00",
  "PublishFrom": "2011-09-27T15:29:22.4362998+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 724
    }
  }
}
```