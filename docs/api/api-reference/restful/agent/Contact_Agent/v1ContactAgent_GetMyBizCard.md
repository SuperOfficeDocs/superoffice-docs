---
title: POST Agents/Contact/GetMyBizCard
id: v1ContactAgent_GetMyBizCard
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.

That is company, person, and company interest data.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 242,
  "Name": "Leffler, Gutkowski and Kutch",
  "Department": "",
  "OrgNr": "1435876",
  "Number1": "1037952",
  "Number2": "892767",
  "UpdatedDate": "2018-06-18T16:48:29.1448954+02:00",
  "CreatedDate": "2002-10-20T16:48:29.1448954+02:00",
  "Emails": [
    {
      "Value": "error",
      "StrippedValue": "eos",
      "Description": "Organized intermediate knowledge base",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "eos",
      "Description": "Organized intermediate knowledge base",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 370,
      "Name": "D'Amore-Turner",
      "ToolTip": "Dolorem commodi eos maiores enim.",
      "Deleted": true,
      "Rank": 732,
      "Type": "possimus",
      "ColorBlock": 407,
      "IconHint": "iure",
      "Selected": true,
      "LastChanged": "1998-04-23T16:48:29.1448954+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "temporibus",
      "StyleHint": "veniam",
      "Hidden": true,
      "FullName": "Glenna Mohr",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "placeat",
      "StrippedValue": "dolores",
      "Description": "Quality-focused eco-centric algorithm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "utilize world-class infrastructures"
          },
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "dolores",
      "Description": "Quality-focused eco-centric algorithm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "utilize world-class infrastructures"
          },
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "corrupti",
      "StrippedValue": "dolorem",
      "Description": "Ameliorated client-driven matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 942
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "dolorem",
      "Description": "Ameliorated client-driven matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 942
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "accusamus",
      "StrippedValue": "eos",
      "Description": "Down-sized bi-directional infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 983
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "eos",
      "Description": "Down-sized bi-directional infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 983
        }
      }
    }
  ],
  "Description": "Digitized mobile orchestration",
  "UpdatedBy": {
    "AssociateId": 196,
    "Name": "Kertzmann-Reinger",
    "PersonId": 60,
    "Rank": 140,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 21,
    "FullName": "Dana Beer",
    "FormalName": "Weimann-Bahringer",
    "Deleted": true,
    "EjUserId": 49,
    "UserName": "Dietrich LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 894
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 884,
    "Name": "Frami Group",
    "PersonId": 609,
    "Rank": 855,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 832,
    "FullName": "Casandra Pacocha",
    "FormalName": "Kohler-Murazik",
    "Deleted": true,
    "EjUserId": 161,
    "UserName": "Feeney Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "cultivate open-source functionalities"
        },
        "FieldType": "System.String",
        "FieldLength": 883
      }
    }
  },
  "Associate": {
    "AssociateId": 426,
    "Name": "Robel LLC",
    "PersonId": 10,
    "Rank": 837,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 251,
    "FullName": "Mr. Lavon Klocko",
    "FormalName": "Larson-Carter",
    "Deleted": false,
    "EjUserId": 394,
    "UserName": "Skiles-Mann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 200
      }
    }
  },
  "Business": {
    "Id": 901,
    "Value": "doloremque",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 342
      }
    }
  },
  "Category": {
    "Id": 229,
    "Value": "ducimus",
    "Tooltip": "voluptas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 44
      }
    }
  },
  "Country": {
    "CountryId": 56,
    "Name": "Nader, Lehner and Kozey",
    "CurrencyId": 616,
    "EnglishName": "Schoen, Leannon and Leffler",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Automated systematic algorithm",
    "OrgNrText": "862378",
    "InterAreaPrefix": "recusandae",
    "DialInPrefix": "earum",
    "ZipPrefix": "et",
    "DomainName": "Frami-Dare",
    "AddressLayoutId": 120,
    "DomesticAddressLayoutId": 378,
    "ForeignAddressLayoutId": 432,
    "Rank": 671,
    "Tooltip": "omnis",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 242
      }
    }
  },
  "Persons": [
    {
      "Position": "error",
      "PersonId": 368,
      "Mrmrs": "esse",
      "Firstname": "Joanne",
      "Lastname": "Douglas",
      "MiddleName": "Howell LLC",
      "Title": "consectetur",
      "Description": "Profit-focused 4th generation focus group",
      "Email": "aurelie_schulist@nitzsche.uk",
      "FullName": "Mr. Bryce Braun",
      "DirectPhone": "567.812.2504 x20277",
      "FormalName": "Dibbert-Schaden",
      "CountryId": 639,
      "ContactId": 360,
      "ContactName": "Sporer-Schaden",
      "Retired": 192,
      "Rank": 349,
      "ActiveInterests": 599,
      "ContactDepartment": "",
      "ContactCountryId": 107,
      "ContactOrgNr": "1181709",
      "FaxPhone": "301-765-2360",
      "MobilePhone": "1-005-636-5783",
      "ContactPhone": "1-626-854-5715 x727",
      "AssociateName": "Bauch, Bednar and Christiansen",
      "AssociateId": 7,
      "UsePersonAddress": false,
      "ContactFax": "recusandae",
      "Kanafname": "ipsam",
      "Kanalname": "possimus",
      "Post1": "officia",
      "Post2": "quo",
      "Post3": "ipsum",
      "EmailName": "roberto@heller.biz",
      "ContactFullName": "Nigel Sipes",
      "ActiveErpLinks": 853,
      "TicketPriorityId": 958,
      "SupportLanguageId": 718,
      "SupportAssociateId": 240,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 361
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": true,
  "ActiveInterests": 53,
  "GroupId": 574,
  "ActiveStatusMonitorId": 486,
  "SupportAssociate": {
    "AssociateId": 8,
    "Name": "Cummings, Bauch and Wilkinson",
    "PersonId": 411,
    "Rank": 144,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 458,
    "FullName": "Ms. Carrie Abbott",
    "FormalName": "Bashirian-Cole",
    "Deleted": false,
    "EjUserId": 82,
    "UserName": "Metz LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 839
      }
    }
  },
  "TicketPriority": {
    "Id": 8,
    "Value": "qui",
    "Tooltip": "repellendus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 105
      }
    }
  },
  "CustomerLanguage": {
    "Id": 581,
    "Value": "et",
    "Tooltip": "impedit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 283
      }
    }
  },
  "Deleted": 663,
  "DbiAgentId": 224,
  "DbiLastSyncronized": "2015-11-03T16:48:29.1498947+01:00",
  "DbiKey": "ratione",
  "DbiLastModified": "2001-01-18T16:48:29.1498947+01:00",
  "SupportPerson": {
    "Position": "sed",
    "PersonId": 493,
    "Mrmrs": "velit",
    "Firstname": "Golden",
    "Lastname": "Cormier",
    "MiddleName": "Deckow LLC",
    "Title": "dolor",
    "Description": "Automated coherent moratorium",
    "Email": "moises.treutel@brown.us",
    "FullName": "Mrs. Ramon Rippin",
    "DirectPhone": "(452)653-2764",
    "FormalName": "Keebler, Schuppe and Morissette",
    "CountryId": 853,
    "ContactId": 575,
    "ContactName": "Erdman-Little",
    "Retired": 610,
    "Rank": 923,
    "ActiveInterests": 498,
    "ContactDepartment": "",
    "ContactCountryId": 808,
    "ContactOrgNr": "969677",
    "FaxPhone": "411.053.7587 x037",
    "MobilePhone": "807-132-6275 x021",
    "ContactPhone": "064.307.7643",
    "AssociateName": "Auer Group",
    "AssociateId": 986,
    "UsePersonAddress": false,
    "ContactFax": "totam",
    "Kanafname": "possimus",
    "Kanalname": "aut",
    "Post1": "beatae",
    "Post2": "ut",
    "Post3": "pariatur",
    "EmailName": "emmitt@wolffhammes.us",
    "ContactFullName": "Korbin Donnelly",
    "ActiveErpLinks": 337,
    "TicketPriorityId": 591,
    "SupportLanguageId": 357,
    "SupportAssociateId": 949,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 449
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 2049.636,
    "Wgs84Longitude": 11125.699999999999,
    "LocalizedAddress": [
      [
        {
          "Name": "Rempel Inc and Sons",
          "Value": "explicabo",
          "Tooltip": "molestias",
          "Label": "autem",
          "ValueLength": 599,
          "AddressType": "aut",
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
              "FieldLength": 976
            }
          }
        }
      ],
      [
        {
          "Name": "Schmidt-Rice",
          "Value": "ea",
          "Tooltip": "ea",
          "Label": "voluptatum",
          "ValueLength": 811,
          "AddressType": "cumque",
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
              "FieldLength": 121
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 339
      }
    }
  },
  "Source": 109,
  "ActiveErpLinks": 984,
  "BounceEmails": [
    "jackson.okeefe@bartoletti.co.uk",
    "liliane@hand.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mariana Murray",
    "SuperOffice:2": "Margarett Thiel"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "nihil"
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
      "FieldType": "System.String",
      "FieldLength": 526
    }
  }
}
```