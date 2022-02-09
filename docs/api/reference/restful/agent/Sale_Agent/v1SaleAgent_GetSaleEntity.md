---
title: POST Agents/Sale/GetSaleEntity
id: v1SaleAgent_GetSaleEntity
---

# POST Agents/Sale/GetSaleEntity

```http
POST /api/v1/Agents/Sale/GetSaleEntity
```

Gets a SaleEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| saleEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/GetSaleEntity?saleEntityId=622
POST /api/v1/Agents/Sale/GetSaleEntity?$select=name,department,category/id
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

Partial SaleEntity class associating the generated SaleEntity with an interface.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Sale/GetSaleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 944,
    "StartDate": "2009-10-28T18:28:50.1617762+01:00",
    "EndDate": "1997-09-14T18:28:50.1617762+02:00",
    "Type": "BookingForChecklist",
    "Task": "necessitatibus",
    "AssociateFullName": "Oswaldo Cartwright",
    "ContactName": "McKenzie, Rohan and Hansen",
    "Description": "Grass-roots incremental product",
    "PersonFullName": "Larue Corwin",
    "PersonId": 913,
    "ContactId": 182,
    "ProjectId": 956,
    "ProjectName": "Mosciski LLC",
    "IsPublished": true,
    "AssociateId": 227,
    "ColorIndex": 699,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 999,
    "PriorityName": "Mitchell, Spinka and Blanda",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "1999-09-07T18:28:50.1617762+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1999-12-01T18:28:50.16278+01:00",
    "RecurringEndDate": "2009-07-01T18:28:50.16278+02:00",
    "MotherId": 64,
    "AssignedBy": 589,
    "AssignedByFullName": "Antonette Huels",
    "RejectReason": "",
    "Location": "autem",
    "AlarmLeadTime": "praesentium",
    "SaleId": 944,
    "SaleName": "Rosenbaum-Gulgowski",
    "AssociateName": "Sanford, Hilpert and Rolfson",
    "CreatedDate": "2012-06-21T18:28:50.16278+02:00",
    "CreatedBy": "cum",
    "CreatedByFullName": "Claud Hudson",
    "CreatedByAssociateId": 515,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 31
      }
    }
  },
  "Associate": {
    "AssociateId": 286,
    "Name": "Johnston, Flatley and Johnson",
    "PersonId": 586,
    "Rank": 663,
    "Tooltip": "animi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 619,
    "FullName": "Raina Mills",
    "FormalName": "Wiza Group",
    "Deleted": false,
    "EjUserId": 90,
    "UserName": "Emard LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 367
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 398,
    "Name": "Luettgen, Windler and Swift",
    "PersonId": 71,
    "Rank": 187,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 242,
    "FullName": "Seth Hettinger",
    "FormalName": "Fahey Inc and Sons",
    "Deleted": false,
    "EjUserId": 139,
    "UserName": "Torphy LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 858
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 831,
    "Name": "Schulist Group",
    "PersonId": 924,
    "Rank": 376,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 800,
    "FullName": "Luciano Stroman",
    "FormalName": "Goyette-Marvin",
    "Deleted": true,
    "EjUserId": 180,
    "UserName": "DuBuque, Nader and Reilly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 337
      }
    }
  },
  "Contact": {
    "ContactId": 913,
    "Name": "Krajcik-Schowalter",
    "OrgNr": "750244",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "labore",
    "DirectPhone": "(321)707-1254",
    "AssociateId": 737,
    "CountryId": 591,
    "EmailAddress": "emanuel.wilderman@labadie.co.uk",
    "Kananame": "quidem",
    "EmailAddressName": "jalen_mayert@bergstrommante.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Elna Dibbert",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "eos",
    "FullName": "Dr. Carole Schulist",
    "IsOwnerContact": false,
    "ActiveErpLinks": 665,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 323
      }
    }
  },
  "Project": {
    "ProjectId": 638,
    "Name": "O'Connell Group",
    "Description": "Down-sized optimal project",
    "URL": "http://www.example.com/",
    "Type": "maiores",
    "AssociateId": 601,
    "AssociateFullName": "Kiarra Jacobson",
    "TypeId": 142,
    "Updated": "2015-03-23T18:28:50.1647783+01:00",
    "StatusId": 799,
    "Status": "quasi",
    "TextId": 121,
    "PublishTo": "1997-08-24T18:28:50.1647783+02:00",
    "PublishFrom": "2014-02-22T18:28:50.1647783+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "185688",
    "ActiveErpLinks": 936,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 560
      }
    }
  },
  "SaleText": "voluptatum",
  "Person": {
    "Position": "maiores",
    "PersonId": 143,
    "Mrmrs": "esse",
    "Firstname": "Morris",
    "Lastname": "Grant",
    "MiddleName": "O'Connell-Becker",
    "Title": "sed",
    "Description": "Optional homogeneous hierarchy",
    "Email": "aiyana@rohanjenkins.us",
    "FullName": "Micaela Batz",
    "DirectPhone": "(057)233-5416 x52770",
    "FormalName": "Ratke, Konopelski and Sipes",
    "CountryId": 114,
    "ContactId": 540,
    "ContactName": "Leuschke-Kuhic",
    "Retired": 478,
    "Rank": 329,
    "ActiveInterests": 841,
    "ContactDepartment": "",
    "ContactCountryId": 34,
    "ContactOrgNr": "476075",
    "FaxPhone": "(033)030-2655",
    "MobilePhone": "671-166-4517 x833",
    "ContactPhone": "(370)464-8421",
    "AssociateName": "Jewess-Willms",
    "AssociateId": 522,
    "UsePersonAddress": false,
    "ContactFax": "dolorem",
    "Kanafname": "officiis",
    "Kanalname": "consequatur",
    "Post1": "ad",
    "Post2": "aut",
    "Post3": "qui",
    "EmailName": "brandt.dare@bahringer.co.uk",
    "ContactFullName": "Claude Carter",
    "ActiveErpLinks": 827,
    "TicketPriorityId": 157,
    "SupportLanguageId": 504,
    "SupportAssociateId": 254,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 324
      }
    }
  },
  "Currency": {
    "Id": 723,
    "Value": "recusandae",
    "Tooltip": "porro",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 280
      }
    }
  },
  "Competitor": {
    "Id": 728,
    "Value": "rerum",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 922
      }
    }
  },
  "Credited": {
    "Id": 984,
    "Value": "qui",
    "Tooltip": "iusto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 694
      }
    }
  },
  "Rating": {
    "Id": 721,
    "Value": "iste",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 654
      }
    }
  },
  "Reason": {
    "Id": 706,
    "Value": "tempore",
    "Tooltip": "provident",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 772
      }
    }
  },
  "Source": {
    "Id": 307,
    "Value": "sit",
    "Tooltip": "numquam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 167
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2000-07-25T18:28:50.1667742+02:00",
  "Amount": 15535.238,
  "SaleId": 594,
  "Earning": 28694.904,
  "EarningPercent": 21063.613999999998,
  "Heading": "voluptas",
  "Number": "1250430",
  "Probability": 646,
  "CreatedDate": "2014-01-23T18:28:50.1667742+01:00",
  "UpdatedDate": "2012-02-21T18:28:50.1667742+01:00",
  "Completed": "Completed",
  "ActiveLinks": 239,
  "Links": [
    {
      "EntityName": "McCullough Inc and Sons",
      "Id": 248,
      "Description": "Down-sized web-enabled leverage",
      "ExtraInfo": "architecto",
      "LinkId": 570,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    }
  ],
  "NextDueDate": "2009-02-23T18:28:50.1667742+01:00",
  "Postit": "blanditiis",
  "SaleType": {
    "Id": 175,
    "Value": "pariatur",
    "Tooltip": "nesciunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 54
      }
    }
  },
  "ReasonSold": {
    "Id": 771,
    "Value": "sit",
    "Tooltip": "atque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 961
      }
    }
  },
  "ReasonStalled": {
    "Id": 632,
    "Value": "vel",
    "Tooltip": "numquam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 25
      }
    }
  },
  "ReopenDate": "2016-06-12T18:28:50.1667742+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Durgan Inc and Sons",
      "Comment": "quasi",
      "StakeholderRoleId": 190,
      "CountryId": 114,
      "PersonId": 994,
      "EmailDescription": "leopoldo.kovacek@flatley.us",
      "EmailId": 186,
      "EmailAddress": "arturo@hilll.info",
      "PhoneId": 915,
      "ContactName": "Hansen Inc and Sons",
      "ContactId": 507,
      "SaleId": 50,
      "Mrmrs": "dicta",
      "Firstname": "Araceli",
      "MiddleName": "Sporer, Kuhn and Fadel",
      "Lastname": "White",
      "SaleStakeholderId": 529,
      "Rank": 373,
      "Phone": "137.171.6003 x08385",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    }
  ],
  "ActiveErpLinks": 787,
  "UserDefinedFields": {
    "SuperOffice:1": "Genevieve Hoppe",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "tempora"
  },
  "PublishEventDate": "2003-03-03T18:28:50.1678993+01:00",
  "PublishTo": "2003-04-30T18:28:50.1678993+02:00",
  "PublishFrom": "2020-04-02T18:28:50.1678993+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 643,
      "Visibility": "All",
      "DisplayValue": "expedita",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "expedite integrated channels"
          },
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    },
    {
      "VisibleId": 643,
      "Visibility": "All",
      "DisplayValue": "expedita",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "expedite integrated channels"
          },
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "transition integrated vortals"
      },
      "FieldType": "System.String",
      "FieldLength": 42
    }
  }
}
```