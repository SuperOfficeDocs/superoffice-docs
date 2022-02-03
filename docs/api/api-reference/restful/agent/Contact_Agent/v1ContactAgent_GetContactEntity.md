---
title: POST Agents/Contact/GetContactEntity
id: v1ContactAgent_GetContactEntity
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=12
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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

The Contact Service. The service implements all services working with the Contact object



Carrier object for ContactEntity.
Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 229,
  "Name": "Kuphal LLC",
  "Department": "",
  "OrgNr": "1278838",
  "Number1": "1008685",
  "Number2": "1031115",
  "UpdatedDate": "2011-02-03T18:28:48.4726264+01:00",
  "CreatedDate": "2006-01-23T18:28:48.4726264+01:00",
  "Emails": [
    {
      "Value": "reiciendis",
      "StrippedValue": "fugiat",
      "Description": "Grass-roots exuding software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "fugiat",
      "Description": "Grass-roots exuding software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 947,
      "Name": "Dietrich Group",
      "ToolTip": "Beatae nesciunt neque vel rem est.",
      "Deleted": false,
      "Rank": 139,
      "Type": "quo",
      "ColorBlock": 169,
      "IconHint": "quam",
      "Selected": true,
      "LastChanged": "1996-11-27T18:28:48.4726264+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "nam",
      "Hidden": true,
      "FullName": "Sven Collier II",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 645
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "unde",
      "StrippedValue": "nostrum",
      "Description": "Triple-buffered global service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "nostrum",
      "Description": "Triple-buffered global service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aperiam",
      "StrippedValue": "vero",
      "Description": "Profit-focused composite orchestration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "vero",
      "Description": "Profit-focused composite orchestration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "eum",
      "Description": "Networked client-driven adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 554
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "eum",
      "Description": "Networked client-driven adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 554
        }
      }
    }
  ],
  "Description": "Front-line real-time hardware",
  "UpdatedBy": {
    "AssociateId": 471,
    "Name": "Farrell, Ziemann and Kessler",
    "PersonId": 872,
    "Rank": 862,
    "Tooltip": "tenetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 22,
    "FullName": "Amari Kuhlman",
    "FormalName": "Zulauf LLC",
    "Deleted": true,
    "EjUserId": 89,
    "UserName": "Kutch, Fay and Ruecker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 20
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 861,
    "Name": "Borer-Wintheiser",
    "PersonId": 736,
    "Rank": 2,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 476,
    "FullName": "Mrs. Marlene Roberts",
    "FormalName": "Beer LLC",
    "Deleted": false,
    "EjUserId": 87,
    "UserName": "Lemke LLC",
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
  },
  "Associate": {
    "AssociateId": 6,
    "Name": "Ferry, Bruen and Cormier",
    "PersonId": 62,
    "Rank": 781,
    "Tooltip": "alias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 865,
    "FullName": "Edgardo Jaskolski V",
    "FormalName": "Schneider LLC",
    "Deleted": true,
    "EjUserId": 53,
    "UserName": "Aufderhar-Heathcote",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 849
      }
    }
  },
  "Business": {
    "Id": 543,
    "Value": "velit",
    "Tooltip": "excepturi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 509
      }
    }
  },
  "Category": {
    "Id": 936,
    "Value": "quia",
    "Tooltip": "natus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 196
      }
    }
  },
  "Country": {
    "CountryId": 195,
    "Name": "Pagac-Kutch",
    "CurrencyId": 219,
    "EnglishName": "Crist, Crona and Brown",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Self-enabling zero defect leverage",
    "OrgNrText": "795304",
    "InterAreaPrefix": "numquam",
    "DialInPrefix": "consequatur",
    "ZipPrefix": "saepe",
    "DomainName": "Homenick-Runolfsdottir",
    "AddressLayoutId": 413,
    "DomesticAddressLayoutId": 112,
    "ForeignAddressLayoutId": 383,
    "Rank": 580,
    "Tooltip": "laudantium",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 979
      }
    }
  },
  "Persons": [
    {
      "Position": "placeat",
      "PersonId": 172,
      "Mrmrs": "ut",
      "Firstname": "Eunice",
      "Lastname": "Kuphal",
      "MiddleName": "Pollich-Rath",
      "Title": "non",
      "Description": "Synergistic hybrid hierarchy",
      "Email": "emmitt.weimann@spinka.us",
      "FullName": "Rocio Gorczany",
      "DirectPhone": "652.670.4101 x04386",
      "FormalName": "Jacobi Inc and Sons",
      "CountryId": 516,
      "ContactId": 83,
      "ContactName": "Raynor, D'Amore and Breitenberg",
      "Retired": 340,
      "Rank": 27,
      "ActiveInterests": 137,
      "ContactDepartment": "",
      "ContactCountryId": 992,
      "ContactOrgNr": "1553548",
      "FaxPhone": "045-042-0782 x613",
      "MobilePhone": "(271)671-2118 x413",
      "ContactPhone": "811-146-3735 x50061",
      "AssociateName": "Armstrong-Beatty",
      "AssociateId": 746,
      "UsePersonAddress": false,
      "ContactFax": "exercitationem",
      "Kanafname": "veniam",
      "Kanalname": "odio",
      "Post1": "et",
      "Post2": "soluta",
      "Post3": "laboriosam",
      "EmailName": "doris_schmitt@mann.biz",
      "ContactFullName": "Ms. Jessyca Kunze",
      "ActiveErpLinks": 126,
      "TicketPriorityId": 774,
      "SupportLanguageId": 118,
      "SupportAssociateId": 588,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 401
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "odit",
  "Xstop": false,
  "ActiveInterests": 898,
  "GroupId": 855,
  "ActiveStatusMonitorId": 99,
  "SupportAssociate": {
    "AssociateId": 113,
    "Name": "Leuschke-Labadie",
    "PersonId": 664,
    "Rank": 996,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 912,
    "FullName": "Dena Kilback",
    "FormalName": "Bednar-Schamberger",
    "Deleted": true,
    "EjUserId": 795,
    "UserName": "Crooks, Gleason and Hammes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 718
      }
    }
  },
  "TicketPriority": {
    "Id": 227,
    "Value": "et",
    "Tooltip": "dolorem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 461
      }
    }
  },
  "CustomerLanguage": {
    "Id": 128,
    "Value": "sapiente",
    "Tooltip": "quas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 677
      }
    }
  },
  "Deleted": 757,
  "DbiAgentId": 521,
  "DbiLastSyncronized": "2007-10-31T18:28:48.4786261+01:00",
  "DbiKey": "suscipit",
  "DbiLastModified": "2002-04-26T18:28:48.4786261+02:00",
  "SupportPerson": {
    "Position": "et",
    "PersonId": 137,
    "Mrmrs": "eum",
    "Firstname": "Patsy",
    "Lastname": "Bauch",
    "MiddleName": "Wehner, West and Runte",
    "Title": "est",
    "Description": "Profound optimizing Graphical User Interface",
    "Email": "will.ward@goldner.us",
    "FullName": "Macey Bailey",
    "DirectPhone": "001-256-2265 x56070",
    "FormalName": "Rice, McKenzie and Trantow",
    "CountryId": 647,
    "ContactId": 931,
    "ContactName": "Medhurst-Lehner",
    "Retired": 906,
    "Rank": 407,
    "ActiveInterests": 461,
    "ContactDepartment": "",
    "ContactCountryId": 911,
    "ContactOrgNr": "1293301",
    "FaxPhone": "616.864.6034",
    "MobilePhone": "233-742-0466 x3864",
    "ContactPhone": "(312)638-1488 x0112",
    "AssociateName": "Torp, Graham and Kris",
    "AssociateId": 697,
    "UsePersonAddress": true,
    "ContactFax": "iste",
    "Kanafname": "doloribus",
    "Kanalname": "voluptas",
    "Post1": "est",
    "Post2": "iure",
    "Post3": "accusantium",
    "EmailName": "anya@koepp.biz",
    "ContactFullName": "Miss Antonette Tillman",
    "ActiveErpLinks": 447,
    "TicketPriorityId": 950,
    "SupportLanguageId": 404,
    "SupportAssociateId": 116,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 874
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 2892.682,
    "Wgs84Longitude": 13679.91,
    "LocalizedAddress": [
      [
        {
          "Name": "Corwin, Krajcik and Spencer",
          "Value": "ut",
          "Tooltip": "perspiciatis",
          "Label": "quos",
          "ValueLength": 41,
          "AddressType": "dolorum",
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
              "FieldType": "System.Int32",
              "FieldLength": 138
            }
          }
        }
      ],
      [
        {
          "Name": "Johnston-Weissnat",
          "Value": "nemo",
          "Tooltip": "et",
          "Label": "ut",
          "ValueLength": 925,
          "AddressType": "hic",
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
              "FieldType": "System.Int32",
              "FieldLength": 597
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "illum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 222
      }
    }
  },
  "Source": 579,
  "ActiveErpLinks": 845,
  "BounceEmails": [
    "ernesto.jenkins@bechtelar.uk",
    "amos@dach.biz"
  ],
  "Domains": [
    "fuga",
    "perspiciatis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "468221173",
    "SuperOffice:2": "Jasper Wiza"
  },
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "expedita",
    "CustomFields2": "dolor"
  },
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
      "FieldType": "System.Int32",
      "FieldLength": 624
    }
  }
}
```