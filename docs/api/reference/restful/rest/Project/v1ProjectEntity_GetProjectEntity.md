---
title: GET Project/{id}
id: v1ProjectEntity_GetProjectEntity
---

# GET Project/{id}

```http
GET /api/v1/Project/{id}
```

Gets a ProjectEntity object.

Calls the Project agent service GetProjectEntity.

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ProjectEntity to return. **Required** |

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Project/{id}?$select=name,department,category/id
GET /api/v1/Project/{id}?fk=False
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Response: object

The Project Service. The service implements all services working with the Project object

ProjectEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity found. |
| 304 | ProjectEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

Response body: object

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <br />Use MDO List name "associate" to get list items. |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <br />Use MDO List name "projectstatus" to get list items. |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <br />Use MDO List name "projecttype" to get list items. |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 ProjectEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 24 Nov 2007 18:25:50 G11T

{
  "ProjectId": 949,
  "Name": "Wintheiser, Dicki and Davis",
  "ProjectNumber": "441523",
  "ProjectMembers": [
    {
      "ProjectmemberId": 297,
      "ContactId": 798,
      "ProjectId": 48,
      "ContactName": "Brekke LLC",
      "ContactDepartment": "",
      "ProjectName": "Funk, Goldner and Sauer",
      "EmailId": 696,
      "EmailAddress": "cathryn@stoltenberg.co.uk",
      "CountryId": 302,
      "Firstname": "Maiya",
      "MiddleName": "Mraz, Bosco and Klein",
      "Lastname": "Corwin",
      "PersonId": 605,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Doyle, Bahringer and Grimes",
      "Phone": "(724)573-3146",
      "PhoneId": 894,
      "ProjectMemberTypeId": 944,
      "EmailAddressName": "arnaldo.bergstrom@stanton.ca",
      "Comment": "quia",
      "FullName": "Osvaldo Williamson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "optimize dot-com markets"
          },
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ullam",
      "StrippedValue": "vel",
      "Description": "Public-key interactive moratorium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "vel",
      "Description": "Public-key interactive moratorium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    }
  ],
  "CreatedDate": "2016-06-16T18:25:50.8108836+02:00",
  "UpdatedDate": "2007-11-24T18:25:50.8108836+01:00",
  "Description": "Organic incremental internet solution",
  "Postit": "beatae",
  "CreatedBy": {
    "AssociateId": 357,
    "Name": "Kerluke, Kertzmann and Hettinger",
    "PersonId": 83,
    "Rank": 526,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 222,
    "FullName": "Dr. Leda Cole",
    "FormalName": "Macejkovic-Sawayn",
    "Deleted": false,
    "EjUserId": 688,
    "UserName": "Hahn, Jenkins and Watsica",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 758
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 271,
    "Name": "Keebler-Mraz",
    "PersonId": 319,
    "Rank": 427,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 588,
    "FullName": "Faye Steuber",
    "FormalName": "Pfannerstill, Dietrich and Purdy",
    "Deleted": true,
    "EjUserId": 315,
    "UserName": "Bergstrom-Wisoky",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 70
      }
    }
  },
  "Associate": {
    "AssociateId": 93,
    "Name": "Leffler LLC",
    "PersonId": 313,
    "Rank": 160,
    "Tooltip": "assumenda",
    "Type": "AnonymousAssociate",
    "GroupIdx": 454,
    "FullName": "Ms. Osborne Lynch",
    "FormalName": "Hagenes, McCullough and Wolf",
    "Deleted": false,
    "EjUserId": 479,
    "UserName": "Casper, Murazik and Emard",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 883
      }
    }
  },
  "ProjectStatus": {
    "Id": 692,
    "Value": "qui",
    "Tooltip": "sint",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 294
      }
    }
  },
  "ProjectType": {
    "Id": 457,
    "Value": "omnis",
    "Tooltip": "dicta",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 107
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Reverse-engineered high-level pricing structure",
  "ActiveStatusMonitorId": 384,
  "Links": [
    {
      "EntityName": "Towne Inc and Sons",
      "Id": 239,
      "Description": "Versatile fresh-thinking extranet",
      "ExtraInfo": "in",
      "LinkId": 269,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 59
        }
      }
    }
  ],
  "ActiveLinks": 354,
  "Completed": false,
  "NextMilestoneDate": "2007-05-06T18:25:50.8118833+02:00",
  "NmdAppointmentId": 227,
  "EndDate": "2015-12-13T18:25:50.8118833+01:00",
  "ActiveErpLinks": 21,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Napoleon Schumm",
    "SuperOffice:2": "139909061"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2003-01-10T18:25:50.8118833+01:00",
  "PublishTo": "2021-08-04T18:25:50.8118833+02:00",
  "PublishFrom": "2011-11-14T18:25:50.8118833+01:00",
  "IsPublished": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 12
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
