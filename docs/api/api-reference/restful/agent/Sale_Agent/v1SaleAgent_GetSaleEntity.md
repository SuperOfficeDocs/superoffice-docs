---
title: GetSaleEntity
id: v1SaleAgent_GetSaleEntity
---

# GetSaleEntity

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
POST /api/v1/Agents/Sale/GetSaleEntity?saleEntityId=22
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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 949,
    "StartDate": "2017-09-09T14:58:05.1716231+02:00",
    "EndDate": "1999-09-03T14:58:05.1716231+02:00",
    "Type": "BookingForChecklist",
    "Task": "reprehenderit",
    "AssociateFullName": "Dahlia Satterfield",
    "ContactName": "Miller-Hessel",
    "Description": "Function-based client-driven function",
    "PersonFullName": "Violette Swift",
    "PersonId": 994,
    "ContactId": 948,
    "ProjectId": 574,
    "ProjectName": "Kutch, Cruickshank and Morar",
    "IsPublished": true,
    "AssociateId": 158,
    "ColorIndex": 31,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 800,
    "PriorityName": "Kub-Hartmann",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "1995-02-14T14:58:05.1716231+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2002-07-07T14:58:05.1716231+02:00",
    "RecurringEndDate": "2011-05-09T14:58:05.1716231+02:00",
    "MotherId": 976,
    "AssignedBy": 308,
    "AssignedByFullName": "Hoyt Spencer",
    "RejectReason": "",
    "Location": "doloremque",
    "AlarmLeadTime": "rerum",
    "SaleId": 380,
    "SaleName": "Feil-Kshlerin",
    "AssociateName": "Balistreri, Morissette and Friesen",
    "CreatedDate": "2006-03-24T14:58:05.1726253+01:00",
    "CreatedBy": "est",
    "CreatedByFullName": "Ms. Gust Anderson",
    "CreatedByAssociateId": 179,
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
        "FieldLength": 701
      }
    }
  },
  "Associate": {
    "AssociateId": 127,
    "Name": "Satterfield-Bednar",
    "PersonId": 930,
    "Rank": 422,
    "Tooltip": "molestias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 140,
    "FullName": "Matilde Jast",
    "FormalName": "Funk LLC",
    "Deleted": true,
    "EjUserId": 853,
    "UserName": "Mohr-Eichmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 930
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 755,
    "Name": "Johnston, Ondricka and Lowe",
    "PersonId": 782,
    "Rank": 526,
    "Tooltip": "itaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 124,
    "FullName": "Hilma Bednar",
    "FormalName": "Blick-Ritchie",
    "Deleted": true,
    "EjUserId": 534,
    "UserName": "Herman Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 494
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 886,
    "Name": "Orn LLC",
    "PersonId": 203,
    "Rank": 458,
    "Tooltip": "consequuntur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 494,
    "FullName": "Dr. Michelle Hermiston",
    "FormalName": "Hansen, Konopelski and Walter",
    "Deleted": true,
    "EjUserId": 124,
    "UserName": "Schimmel Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 498
      }
    }
  },
  "Contact": {
    "ContactId": 455,
    "Name": "Monahan-Prohaska",
    "OrgNr": "729912",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "in",
    "DirectPhone": "(405)327-1885 x1206",
    "AssociateId": 299,
    "CountryId": 630,
    "EmailAddress": "ian@hegmann.co.uk",
    "Kananame": "a",
    "EmailAddressName": "katlyn_schamberger@satterfieldokon.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lonie Armstrong",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "laudantium",
    "FullName": "Nettie Veum",
    "IsOwnerContact": false,
    "ActiveErpLinks": 571,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 150
      }
    }
  },
  "Project": {
    "ProjectId": 551,
    "Name": "Jacobson, Barton and McKenzie",
    "Description": "Pre-emptive scalable analyzer",
    "URL": "http://www.example.com/",
    "Type": "dignissimos",
    "AssociateId": 481,
    "AssociateFullName": "Moises Rolfson",
    "TypeId": 320,
    "Updated": "2012-11-06T14:58:05.1746238+01:00",
    "StatusId": 510,
    "Status": "et",
    "TextId": 714,
    "PublishTo": "2000-06-03T14:58:05.1746238+02:00",
    "PublishFrom": "2010-11-19T14:58:05.1746238+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "584011",
    "ActiveErpLinks": 719,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 570
      }
    }
  },
  "SaleText": "occaecati",
  "Person": {
    "Position": "corrupti",
    "PersonId": 3,
    "Mrmrs": "iure",
    "Firstname": "Hayden",
    "Lastname": "Dickens",
    "MiddleName": "O'Kon LLC",
    "Title": "sunt",
    "Description": "Integrated radical algorithm",
    "Email": "lauriane.beier@christiansenmonahan.us",
    "FullName": "Dusty Wyman PhD",
    "DirectPhone": "(853)808-0266 x80870",
    "FormalName": "Hamill Inc and Sons",
    "CountryId": 23,
    "ContactId": 408,
    "ContactName": "Pfeffer, McClure and Hayes",
    "Retired": 509,
    "Rank": 964,
    "ActiveInterests": 393,
    "ContactDepartment": "",
    "ContactCountryId": 118,
    "ContactOrgNr": "1193024",
    "FaxPhone": "420-000-4367 x283",
    "MobilePhone": "424.071.8412 x00405",
    "ContactPhone": "183-445-7012",
    "AssociateName": "McClure-Raynor",
    "AssociateId": 891,
    "UsePersonAddress": true,
    "ContactFax": "recusandae",
    "Kanafname": "nihil",
    "Kanalname": "rem",
    "Post1": "aut",
    "Post2": "odio",
    "Post3": "consequuntur",
    "EmailName": "wilfred.mills@swaniawskioberbrunner.biz",
    "ContactFullName": "Keely Swaniawski",
    "ActiveErpLinks": 424,
    "TicketPriorityId": 933,
    "SupportLanguageId": 458,
    "SupportAssociateId": 526,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 382
      }
    }
  },
  "Currency": {
    "Id": 749,
    "Value": "consequatur",
    "Tooltip": "aspernatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 570
      }
    }
  },
  "Competitor": {
    "Id": 77,
    "Value": "consectetur",
    "Tooltip": "totam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 129
      }
    }
  },
  "Credited": {
    "Id": 636,
    "Value": "impedit",
    "Tooltip": "numquam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "streamline leading-edge supply-chains"
        },
        "FieldType": "System.String",
        "FieldLength": 951
      }
    }
  },
  "Rating": {
    "Id": 173,
    "Value": "quos",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 974
      }
    }
  },
  "Reason": {
    "Id": 660,
    "Value": "qui",
    "Tooltip": "animi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 956
      }
    }
  },
  "Source": {
    "Id": 452,
    "Value": "rem",
    "Tooltip": "delectus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 87
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2014-10-07T14:58:05.1766228+02:00",
  "Amount": 1197.1879999999999,
  "SaleId": 830,
  "Earning": 4415.806,
  "EarningPercent": 22765.376,
  "Heading": "ut",
  "Number": "1182673",
  "Probability": 36,
  "CreatedDate": "2017-12-09T14:58:05.1766228+01:00",
  "UpdatedDate": "2003-10-26T14:58:05.1766228+01:00",
  "Completed": "Completed",
  "ActiveLinks": 444,
  "Links": [
    {
      "EntityName": "Wolf Inc and Sons",
      "Id": 258,
      "Description": "Vision-oriented mission-critical model",
      "ExtraInfo": "veniam",
      "LinkId": 162,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 428
        }
      }
    }
  ],
  "NextDueDate": "2009-06-09T14:58:05.1766228+02:00",
  "Postit": "iure",
  "SaleType": {
    "Id": 658,
    "Value": "sit",
    "Tooltip": "recusandae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 460
      }
    }
  },
  "ReasonSold": {
    "Id": 698,
    "Value": "libero",
    "Tooltip": "illum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 591
      }
    }
  },
  "ReasonStalled": {
    "Id": 991,
    "Value": "esse",
    "Tooltip": "rem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 669
      }
    }
  },
  "ReopenDate": "2018-11-19T14:58:05.1776242+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Conroy-Krajcik",
      "Comment": "nulla",
      "StakeholderRoleId": 647,
      "CountryId": 482,
      "PersonId": 910,
      "EmailDescription": "arvilla.considine@lefflerlesch.name",
      "EmailId": 670,
      "EmailAddress": "kaitlin@ferryleffler.uk",
      "PhoneId": 838,
      "ContactName": "Hodkiewicz-Wiza",
      "ContactId": 977,
      "SaleId": 274,
      "Mrmrs": "at",
      "Firstname": "Charlie",
      "MiddleName": "Murazik Inc and Sons",
      "Lastname": "Haley",
      "SaleStakeholderId": 221,
      "Rank": 937,
      "Phone": "038-083-7071 x43312",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 642
        }
      }
    }
  ],
  "ActiveErpLinks": 579,
  "UserDefinedFields": {
    "SuperOffice:1": "1441559480",
    "SuperOffice:2": "1365446596"
  },
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "optio"
  },
  "PublishEventDate": "2001-08-06T14:58:05.1776242+02:00",
  "PublishTo": "2014-07-23T14:58:05.1776242+02:00",
  "PublishFrom": "2009-08-28T14:58:05.1776242+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 351,
      "Visibility": "All",
      "DisplayValue": "totam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 833
        }
      }
    },
    {
      "VisibleId": 351,
      "Visibility": "All",
      "DisplayValue": "totam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 833
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
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 769
    }
  }
}
```