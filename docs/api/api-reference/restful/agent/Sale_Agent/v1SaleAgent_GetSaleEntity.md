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
POST /api/v1/Agents/Sale/GetSaleEntity?saleEntityId=628
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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 613,
    "StartDate": "1996-11-25T16:48:30.6059386+01:00",
    "EndDate": "2006-09-05T16:48:30.6059386+02:00",
    "Type": "BookingForChecklist",
    "Task": "et",
    "AssociateFullName": "Dejon Harris",
    "ContactName": "Jaskolski, Gusikowski and Maggio",
    "Description": "Persevering object-oriented knowledge user",
    "PersonFullName": "Constantin Willms",
    "PersonId": 469,
    "ContactId": 300,
    "ProjectId": 487,
    "ProjectName": "Bauch-Upton",
    "IsPublished": false,
    "AssociateId": 55,
    "ColorIndex": 767,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 507,
    "PriorityName": "King Group",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "2016-10-22T16:48:30.6059386+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2004-05-01T16:48:30.6059386+02:00",
    "RecurringEndDate": "2014-05-17T16:48:30.6059386+02:00",
    "MotherId": 648,
    "AssignedBy": 448,
    "AssignedByFullName": "Bernadine Zemlak",
    "RejectReason": "",
    "Location": "consequuntur",
    "AlarmLeadTime": "corrupti",
    "SaleId": 148,
    "SaleName": "Hodkiewicz Inc and Sons",
    "AssociateName": "Wilderman Group",
    "CreatedDate": "1994-08-12T16:48:30.6069388+02:00",
    "CreatedBy": "ea",
    "CreatedByFullName": "Pamela Roberts IV",
    "CreatedByAssociateId": 565,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 546
      }
    }
  },
  "Associate": {
    "AssociateId": 800,
    "Name": "Feeney, Schmitt and Carter",
    "PersonId": 594,
    "Rank": 628,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 462,
    "FullName": "Mabel Hand",
    "FormalName": "Konopelski Group",
    "Deleted": true,
    "EjUserId": 758,
    "UserName": "Grant, Glover and Grimes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "exploit cross-media eyeballs"
        },
        "FieldType": "System.String",
        "FieldLength": 244
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 150,
    "Name": "Hagenes-Rodriguez",
    "PersonId": 692,
    "Rank": 331,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 615,
    "FullName": "Vern Ledner",
    "FormalName": "Weissnat, Schoen and Collins",
    "Deleted": true,
    "EjUserId": 318,
    "UserName": "Von Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incentivize back-end convergence"
        },
        "FieldType": "System.Int32",
        "FieldLength": 685
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 260,
    "Name": "Jenkins, Gislason and Douglas",
    "PersonId": 905,
    "Rank": 95,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 895,
    "FullName": "Deshawn Block",
    "FormalName": "Hudson Inc and Sons",
    "Deleted": false,
    "EjUserId": 553,
    "UserName": "Hagenes Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 328
      }
    }
  },
  "Contact": {
    "ContactId": 904,
    "Name": "Eichmann, Kuhic and Cruickshank",
    "OrgNr": "1731497",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "est",
    "DirectPhone": "1-627-772-7355 x13687",
    "AssociateId": 970,
    "CountryId": 745,
    "EmailAddress": "kaia@langworthschulist.name",
    "Kananame": "corporis",
    "EmailAddressName": "hassan.boehm@hettingerhermann.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Loyce Johns",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nihil",
    "FullName": "Jennifer Kunze",
    "IsOwnerContact": true,
    "ActiveErpLinks": 889,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 510
      }
    }
  },
  "Project": {
    "ProjectId": 564,
    "Name": "Spinka-Daugherty",
    "Description": "Open-source client-server attitude",
    "URL": "http://www.example.com/",
    "Type": "debitis",
    "AssociateId": 451,
    "AssociateFullName": "Karianne Zulauf",
    "TypeId": 819,
    "Updated": "2012-08-12T16:48:30.608949+02:00",
    "StatusId": 341,
    "Status": "exercitationem",
    "TextId": 813,
    "PublishTo": "2020-10-31T16:48:30.608949+01:00",
    "PublishFrom": "2015-01-14T16:48:30.608949+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "621489",
    "ActiveErpLinks": 320,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 43
      }
    }
  },
  "SaleText": "quia",
  "Person": {
    "Position": "hic",
    "PersonId": 291,
    "Mrmrs": "sunt",
    "Firstname": "Dean",
    "Lastname": "Keebler",
    "MiddleName": "Cummings, Gutkowski and Boehm",
    "Title": "ut",
    "Description": "Synergized tangible instruction set",
    "Email": "christelle.watsica@walkerhayes.us",
    "FullName": "Aglae McCullough",
    "DirectPhone": "(510)382-5568 x20445",
    "FormalName": "Conroy, Ledner and Huel",
    "CountryId": 389,
    "ContactId": 438,
    "ContactName": "Hilpert-Walsh",
    "Retired": 908,
    "Rank": 996,
    "ActiveInterests": 838,
    "ContactDepartment": "",
    "ContactCountryId": 612,
    "ContactOrgNr": "584368",
    "FaxPhone": "(551)026-7622",
    "MobilePhone": "680-382-5165 x13260",
    "ContactPhone": "832-863-1382 x533",
    "AssociateName": "O'Reilly, Bosco and Cormier",
    "AssociateId": 532,
    "UsePersonAddress": false,
    "ContactFax": "accusamus",
    "Kanafname": "sint",
    "Kanalname": "voluptatibus",
    "Post1": "eum",
    "Post2": "praesentium",
    "Post3": "at",
    "EmailName": "coty@stehr.co.uk",
    "ContactFullName": "Bennett Hand",
    "ActiveErpLinks": 810,
    "TicketPriorityId": 600,
    "SupportLanguageId": 461,
    "SupportAssociateId": 642,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 35
      }
    }
  },
  "Currency": {
    "Id": 959,
    "Value": "ad",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 486
      }
    }
  },
  "Competitor": {
    "Id": 172,
    "Value": "fugiat",
    "Tooltip": "optio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 364
      }
    }
  },
  "Credited": {
    "Id": 206,
    "Value": "eos",
    "Tooltip": "doloremque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 159
      }
    }
  },
  "Rating": {
    "Id": 271,
    "Value": "minima",
    "Tooltip": "assumenda",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 358
      }
    }
  },
  "Reason": {
    "Id": 875,
    "Value": "ratione",
    "Tooltip": "cumque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 304
      }
    }
  },
  "Source": {
    "Id": 273,
    "Value": "aut",
    "Tooltip": "expedita",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 590
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2004-05-01T16:48:30.6109386+02:00",
  "Amount": 2353.634,
  "SaleId": 434,
  "Earning": 11592.666,
  "EarningPercent": 24138.068,
  "Heading": "enim",
  "Number": "454863",
  "Probability": 772,
  "CreatedDate": "2014-11-03T16:48:30.6109386+01:00",
  "UpdatedDate": "2002-04-26T16:48:30.6109386+02:00",
  "Completed": "Completed",
  "ActiveLinks": 206,
  "Links": [
    {
      "EntityName": "Ward-Hilll",
      "Id": 217,
      "Description": "Cross-group global function",
      "ExtraInfo": "eos",
      "LinkId": 542,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 652
        }
      }
    }
  ],
  "NextDueDate": "2008-06-25T16:48:30.6109386+02:00",
  "Postit": "aspernatur",
  "SaleType": {
    "Id": 762,
    "Value": "fuga",
    "Tooltip": "veniam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 135
      }
    }
  },
  "ReasonSold": {
    "Id": 391,
    "Value": "harum",
    "Tooltip": "quasi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 998
      }
    }
  },
  "ReasonStalled": {
    "Id": 731,
    "Value": "dicta",
    "Tooltip": "sequi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "matrix visionary eyeballs"
        },
        "FieldType": "System.Int32",
        "FieldLength": 915
      }
    }
  },
  "ReopenDate": "2003-02-28T16:48:30.6109386+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Conroy, Ortiz and Kovacek",
      "Comment": "eos",
      "StakeholderRoleId": 329,
      "CountryId": 343,
      "PersonId": 489,
      "EmailDescription": "roger_beahan@streich.uk",
      "EmailId": 574,
      "EmailAddress": "bruce_rice@armstrong.uk",
      "PhoneId": 838,
      "ContactName": "Heaney, Lockman and Koss",
      "ContactId": 181,
      "SaleId": 222,
      "Mrmrs": "ducimus",
      "Firstname": "Jerald",
      "MiddleName": "Mertz-Kiehn",
      "Lastname": "Stoltenberg",
      "SaleStakeholderId": 579,
      "Rank": 657,
      "Phone": "128-052-8355",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "ActiveErpLinks": 657,
  "UserDefinedFields": {
    "SuperOffice:1": "1576745120",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "possimus"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "error"
  },
  "PublishEventDate": "1997-04-01T16:48:30.6119386+02:00",
  "PublishTo": "2017-09-26T16:48:30.6119386+02:00",
  "PublishFrom": "2001-10-21T16:48:30.6119386+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 1000,
      "Visibility": "All",
      "DisplayValue": "assumenda",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    },
    {
      "VisibleId": 1000,
      "Visibility": "All",
      "DisplayValue": "assumenda",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "revolutionize efficient content"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 798
    }
  }
}
```