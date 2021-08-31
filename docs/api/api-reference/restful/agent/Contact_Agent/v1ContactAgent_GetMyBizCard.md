---
title: GetMyBizCard
id: v1ContactAgent_GetMyBizCard
---

# GetMyBizCard

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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 11,
  "Name": "Wolf, Ruecker and Koch",
  "Department": "",
  "OrgNr": "1435901",
  "Number1": "1013928",
  "Number2": "1424797",
  "UpdatedDate": "2007-04-22T14:58:03.6713189+02:00",
  "CreatedDate": "2012-08-20T14:58:03.6713189+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "sunt",
      "Description": "Centralized tertiary flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 139
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "sunt",
      "Description": "Centralized tertiary flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 139
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 682,
      "Name": "Smitham Inc and Sons",
      "ToolTip": "Quibusdam rerum minima voluptas mollitia voluptatem.",
      "Deleted": true,
      "Rank": 420,
      "Type": "et",
      "ColorBlock": 123,
      "IconHint": "alias",
      "Selected": false,
      "LastChanged": "2010-11-24T14:58:03.6713189+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "atque",
      "StyleHint": "minima",
      "Hidden": true,
      "FullName": "George Wehner",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 866
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "quia",
      "Description": "Sharable non-volatile framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 761
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "quia",
      "Description": "Sharable non-volatile framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 761
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ad",
      "StrippedValue": "aperiam",
      "Description": "Organic high-level product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "aperiam",
      "Description": "Organic high-level product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "natus",
      "Description": "Visionary non-volatile Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "natus",
      "Description": "Visionary non-volatile Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    }
  ],
  "Description": "Intuitive solution-oriented project",
  "UpdatedBy": {
    "AssociateId": 746,
    "Name": "Haag-Kohler",
    "PersonId": 631,
    "Rank": 439,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 464,
    "FullName": "Mrs. Vada Schulist",
    "FormalName": "Fahey-Homenick",
    "Deleted": false,
    "EjUserId": 597,
    "UserName": "Batz, McCullough and Deckow",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 725
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 709,
    "Name": "Lebsack LLC",
    "PersonId": 878,
    "Rank": 971,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 472,
    "FullName": "Adolfo Sipes",
    "FormalName": "Nikolaus-Kovacek",
    "Deleted": false,
    "EjUserId": 563,
    "UserName": "Russel, Mills and Koepp",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 807
      }
    }
  },
  "Associate": {
    "AssociateId": 868,
    "Name": "Crooks, Fahey and Bednar",
    "PersonId": 741,
    "Rank": 980,
    "Tooltip": "aperiam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 202,
    "FullName": "Bradley Hagenes",
    "FormalName": "Zboncak, Keebler and Roob",
    "Deleted": false,
    "EjUserId": 714,
    "UserName": "Huel, Hyatt and Brown",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 881
      }
    }
  },
  "Business": {
    "Id": 122,
    "Value": "veniam",
    "Tooltip": "repellat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "grow open-source networks"
        },
        "FieldType": "System.Int32",
        "FieldLength": 941
      }
    }
  },
  "Category": {
    "Id": 35,
    "Value": "sed",
    "Tooltip": "enim",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 61
      }
    }
  },
  "Country": {
    "CountryId": 613,
    "Name": "Greenfelder Inc and Sons",
    "CurrencyId": 795,
    "EnglishName": "Kovacek LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Balanced mission-critical framework",
    "OrgNrText": "817160",
    "InterAreaPrefix": "temporibus",
    "DialInPrefix": "non",
    "ZipPrefix": "illo",
    "DomainName": "Farrell Inc and Sons",
    "AddressLayoutId": 612,
    "DomesticAddressLayoutId": 344,
    "ForeignAddressLayoutId": 766,
    "Rank": 680,
    "Tooltip": "vero",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 625
      }
    }
  },
  "Persons": [
    {
      "Position": "molestias",
      "PersonId": 209,
      "Mrmrs": "non",
      "Firstname": "Connor",
      "Lastname": "Barrows",
      "MiddleName": "Casper-Monahan",
      "Title": "quae",
      "Description": "Enhanced user-facing interface",
      "Email": "maxwell_nitzsche@dickenssimonis.us",
      "FullName": "Vada Homenick",
      "DirectPhone": "1-358-151-0205",
      "FormalName": "Abbott-Romaguera",
      "CountryId": 26,
      "ContactId": 579,
      "ContactName": "Raynor LLC",
      "Retired": 297,
      "Rank": 545,
      "ActiveInterests": 745,
      "ContactDepartment": "transform open-source partnerships",
      "ContactCountryId": 379,
      "ContactOrgNr": "1301349",
      "FaxPhone": "270.105.0135 x81531",
      "MobilePhone": "673.565.0573",
      "ContactPhone": "(421)125-2772",
      "AssociateName": "O'Reilly, Hudson and Maggio",
      "AssociateId": 975,
      "UsePersonAddress": true,
      "ContactFax": "commodi",
      "Kanafname": "dicta",
      "Kanalname": "hic",
      "Post1": "ut",
      "Post2": "molestias",
      "Post3": "voluptatem",
      "EmailName": "nico.gutmann@hettinger.us",
      "ContactFullName": "Maritza Koepp",
      "ActiveErpLinks": 369,
      "TicketPriorityId": 582,
      "SupportLanguageId": 365,
      "SupportAssociateId": 74,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": true,
  "ActiveInterests": 422,
  "GroupId": 287,
  "ActiveStatusMonitorId": 586,
  "SupportAssociate": {
    "AssociateId": 559,
    "Name": "Russel Group",
    "PersonId": 743,
    "Rank": 840,
    "Tooltip": "adipisci",
    "Type": "AnonymousAssociate",
    "GroupIdx": 905,
    "FullName": "Uriel Balistreri",
    "FormalName": "Crooks Inc and Sons",
    "Deleted": true,
    "EjUserId": 684,
    "UserName": "Raynor, Breitenberg and McDermott",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 539
      }
    }
  },
  "TicketPriority": {
    "Id": 776,
    "Value": "quam",
    "Tooltip": "aspernatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 952
      }
    }
  },
  "CustomerLanguage": {
    "Id": 794,
    "Value": "impedit",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 171
      }
    }
  },
  "Deleted": 338,
  "DbiAgentId": 273,
  "DbiLastSyncronized": "1995-11-12T14:58:03.6763165+01:00",
  "DbiKey": "officia",
  "DbiLastModified": "2016-02-13T14:58:03.6763165+01:00",
  "SupportPerson": {
    "Position": "est",
    "PersonId": 468,
    "Mrmrs": "deleniti",
    "Firstname": "Watson",
    "Lastname": "Schaefer",
    "MiddleName": "Kihn Inc and Sons",
    "Title": "excepturi",
    "Description": "Robust leading edge projection",
    "Email": "josefina.breitenberg@lehnermurray.biz",
    "FullName": "Garrick Reichel",
    "DirectPhone": "(018)578-1543",
    "FormalName": "Gusikowski, Wolff and Abshire",
    "CountryId": 199,
    "ContactId": 263,
    "ContactName": "Macejkovic, Sipes and Moore",
    "Retired": 765,
    "Rank": 368,
    "ActiveInterests": 672,
    "ContactDepartment": "",
    "ContactCountryId": 696,
    "ContactOrgNr": "1107104",
    "FaxPhone": "(271)166-6145 x2558",
    "MobilePhone": "1-258-133-3064",
    "ContactPhone": "1-464-288-6425",
    "AssociateName": "Pacocha LLC",
    "AssociateId": 272,
    "UsePersonAddress": true,
    "ContactFax": "vel",
    "Kanafname": "minima",
    "Kanalname": "inventore",
    "Post1": "illo",
    "Post2": "aut",
    "Post3": "possimus",
    "EmailName": "esteban_stoltenberg@oconnelloconner.com",
    "ContactFullName": "Miss Constance Quigley",
    "ActiveErpLinks": 389,
    "TicketPriorityId": 884,
    "SupportLanguageId": 9,
    "SupportAssociateId": 728,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 406
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 26895.987999999998,
    "Wgs84Longitude": 2641.962,
    "LocalizedAddress": [
      [
        {
          "Name": "Luettgen Group",
          "Value": "exercitationem",
          "Tooltip": "minus",
          "Label": "doloremque",
          "ValueLength": 142,
          "AddressType": "eos",
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
              "FieldLength": 28
            }
          }
        }
      ],
      [
        {
          "Name": "Bergnaum, Franecki and Goyette",
          "Value": "quam",
          "Tooltip": "commodi",
          "Label": "ipsa",
          "ValueLength": 374,
          "AddressType": "consequuntur",
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
              "FieldLength": 988
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "aliquid",
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
  "Source": 66,
  "ActiveErpLinks": 556,
  "BounceEmails": [
    "alfonzo@hoppe.name",
    "pearlie_baumbach@klein.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Afton Schroeder",
    "SuperOffice:2": "Webster Sanford Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "vero"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "rerum"
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
      "FieldLength": 176
    }
  }
}
```