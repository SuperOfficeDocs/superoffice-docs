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
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
Accept-Language: *
```

```http_
HTTP/1.1 200 ProjectEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 18 Aug 2014 15:05:42 G8T

{
  "ProjectId": 573,
  "Name": "Daniel LLC",
  "ProjectNumber": "1298528",
  "ProjectMembers": [
    {
      "ProjectmemberId": 200,
      "ContactId": 538,
      "ProjectId": 699,
      "ContactName": "Considine LLC",
      "ContactDepartment": "",
      "ProjectName": "Hartmann-Hilpert",
      "EmailId": 560,
      "EmailAddress": "harley.nicolas@ankunding.com",
      "CountryId": 856,
      "Firstname": "Elwin",
      "MiddleName": "Bins-Jerde",
      "Lastname": "Funk",
      "PersonId": 463,
      "Mrmrs": "quod",
      "ProjectMemberTypeName": "Herzog LLC",
      "Phone": "(576)588-5500 x8217",
      "PhoneId": 444,
      "ProjectMemberTypeId": 176,
      "EmailAddressName": "janick@gusikowski.info",
      "Comment": "est",
      "FullName": "Ebba Schimmel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Operative grid-enabled access",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "aggregate turn-key deliverables"
          },
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Operative grid-enabled access",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "aggregate turn-key deliverables"
          },
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "CreatedDate": "1998-08-25T15:05:42.4596715+02:00",
  "UpdatedDate": "2014-08-18T15:05:42.4596715+02:00",
  "Description": "Multi-lateral 24/7 conglomeration",
  "Postit": "nulla",
  "CreatedBy": {
    "AssociateId": 84,
    "Name": "Krajcik Group",
    "PersonId": 555,
    "Rank": 994,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 981,
    "FullName": "Vance Treutel",
    "FormalName": "Hackett, Goldner and Moore",
    "Deleted": false,
    "EjUserId": 733,
    "UserName": "Gleason, Denesik and Bosco",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 201
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 624,
    "Name": "Harris LLC",
    "PersonId": 8,
    "Rank": 411,
    "Tooltip": "saepe",
    "Type": "AnonymousAssociate",
    "GroupIdx": 407,
    "FullName": "Wilford King",
    "FormalName": "McLaughlin, Wisoky and Farrell",
    "Deleted": true,
    "EjUserId": 807,
    "UserName": "Lubowitz LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 484
      }
    }
  },
  "Associate": {
    "AssociateId": 739,
    "Name": "Treutel-Bednar",
    "PersonId": 917,
    "Rank": 809,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 589,
    "FullName": "Emerald Hermiston",
    "FormalName": "Legros-Block",
    "Deleted": false,
    "EjUserId": 870,
    "UserName": "Waters Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 865
      }
    }
  },
  "ProjectStatus": {
    "Id": 291,
    "Value": "illum",
    "Tooltip": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 525
      }
    }
  },
  "ProjectType": {
    "Id": 673,
    "Value": "asperiores",
    "Tooltip": "quos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 307
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Devolved uniform synergy",
  "ActiveStatusMonitorId": 265,
  "Links": [
    {
      "EntityName": "Kovacek, Ziemann and Buckridge",
      "Id": 560,
      "Description": "Devolved cohesive leverage",
      "ExtraInfo": "soluta",
      "LinkId": 194,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 147
        }
      }
    }
  ],
  "ActiveLinks": 451,
  "Completed": false,
  "NextMilestoneDate": "2013-03-05T15:05:42.4606733+01:00",
  "NmdAppointmentId": 761,
  "EndDate": "1998-10-27T15:05:42.4606733+01:00",
  "ActiveErpLinks": 873,
  "UserDefinedFields": {
    "SuperOffice:1": "Gayle Ryan",
    "SuperOffice:2": "1338456080"
  },
  "ExtraFields": {
    "ExtraFields1": "tempore",
    "ExtraFields2": "hic"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "quia"
  },
  "PublishEventDate": "2019-01-14T15:05:42.4616676+01:00",
  "PublishTo": "1996-03-26T15:05:42.4616676+01:00",
  "PublishFrom": "1996-05-03T15:05:42.4616676+02:00",
  "IsPublished": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "transition granular relationships"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 513
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```