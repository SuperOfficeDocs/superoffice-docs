---
title: GetMyContact
id: v1ContactAgent_GetMyContact
---

# GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 750,
  "Name": "Cronin-Predovic",
  "Department": "",
  "OrgNr": "1156479",
  "Number1": "1374679",
  "Number2": "1091874",
  "UpdatedDate": "1995-09-14T14:58:03.6142835+02:00",
  "CreatedDate": "2001-06-17T14:58:03.6142835+02:00",
  "Emails": [
    {
      "Value": "dolor",
      "StrippedValue": "voluptatem",
      "Description": "Organic zero administration project",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 581
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "voluptatem",
      "Description": "Organic zero administration project",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 581
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 426,
      "Name": "Price, Batz and Price",
      "ToolTip": "Veritatis ipsa cum earum sit.",
      "Deleted": false,
      "Rank": 478,
      "Type": "labore",
      "ColorBlock": 248,
      "IconHint": "deleniti",
      "Selected": true,
      "LastChanged": "2000-12-29T14:58:03.6142835+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Raheem Nicolas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 78
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "culpa",
      "StrippedValue": "animi",
      "Description": "Polarised scalable time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 272
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "animi",
      "Description": "Polarised scalable time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 272
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Cloned empowering parallelism",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 162
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Cloned empowering parallelism",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 162
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "cupiditate",
      "StrippedValue": "aliquid",
      "Description": "Business-focused directional process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "aliquid",
      "Description": "Business-focused directional process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    }
  ],
  "Description": "Configurable directional superstructure",
  "UpdatedBy": {
    "AssociateId": 671,
    "Name": "Nader-Schaefer",
    "PersonId": 522,
    "Rank": 990,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 706,
    "FullName": "Joel Davis",
    "FormalName": "Haag, Halvorson and Boehm",
    "Deleted": true,
    "EjUserId": 545,
    "UserName": "Ondricka Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 681
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 391,
    "Name": "McClure, Thiel and Lehner",
    "PersonId": 506,
    "Rank": 183,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 92,
    "FullName": "Alexander Littel",
    "FormalName": "Smith, Toy and Rodriguez",
    "Deleted": false,
    "EjUserId": 561,
    "UserName": "Barton Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 562
      }
    }
  },
  "Associate": {
    "AssociateId": 12,
    "Name": "Waelchi LLC",
    "PersonId": 375,
    "Rank": 49,
    "Tooltip": "animi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 502,
    "FullName": "Celia Feest",
    "FormalName": "Skiles Inc and Sons",
    "Deleted": false,
    "EjUserId": 229,
    "UserName": "Boyle, Zulauf and Koch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 651
      }
    }
  },
  "Business": {
    "Id": 182,
    "Value": "ex",
    "Tooltip": "eveniet",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 172
      }
    }
  },
  "Category": {
    "Id": 115,
    "Value": "sed",
    "Tooltip": "consequatur",
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
  "Country": {
    "CountryId": 140,
    "Name": "Hirthe-Feest",
    "CurrencyId": 266,
    "EnglishName": "Kutch, Kling and Nienow",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Assimilated leading edge knowledge user",
    "OrgNrText": "464818",
    "InterAreaPrefix": "est",
    "DialInPrefix": "quaerat",
    "ZipPrefix": "molestias",
    "DomainName": "Deckow-Ryan",
    "AddressLayoutId": 292,
    "DomesticAddressLayoutId": 156,
    "ForeignAddressLayoutId": 722,
    "Rank": 824,
    "Tooltip": "excepturi",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 495
      }
    }
  },
  "Persons": [
    {
      "Position": "eum",
      "PersonId": 273,
      "Mrmrs": "voluptatem",
      "Firstname": "Lou",
      "Lastname": "Hermiston",
      "MiddleName": "Watsica-Herzog",
      "Title": "dolorum",
      "Description": "Realigned global attitude",
      "Email": "jessyca_prohaska@renner.co.uk",
      "FullName": "Ms. Sophie Borer",
      "DirectPhone": "1-314-483-2488 x51123",
      "FormalName": "Lemke, Altenwerth and Hudson",
      "CountryId": 297,
      "ContactId": 520,
      "ContactName": "Wolff, Herman and Borer",
      "Retired": 763,
      "Rank": 765,
      "ActiveInterests": 33,
      "ContactDepartment": "",
      "ContactCountryId": 868,
      "ContactOrgNr": "1513463",
      "FaxPhone": "(452)707-0745",
      "MobilePhone": "065.631.4447 x34113",
      "ContactPhone": "1-522-017-7551",
      "AssociateName": "Kiehn Inc and Sons",
      "AssociateId": 304,
      "UsePersonAddress": true,
      "ContactFax": "modi",
      "Kanafname": "quaerat",
      "Kanalname": "consectetur",
      "Post1": "est",
      "Post2": "quia",
      "Post3": "ut",
      "EmailName": "ansley@block.biz",
      "ContactFullName": "Johnson Nienow",
      "ActiveErpLinks": 272,
      "TicketPriorityId": 527,
      "SupportLanguageId": 820,
      "SupportAssociateId": 228,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 197
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quia",
  "Xstop": true,
  "ActiveInterests": 364,
  "GroupId": 449,
  "ActiveStatusMonitorId": 309,
  "SupportAssociate": {
    "AssociateId": 160,
    "Name": "Christiansen, Will and Leannon",
    "PersonId": 576,
    "Rank": 266,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 417,
    "FullName": "Kurtis Breitenberg",
    "FormalName": "Schmeler LLC",
    "Deleted": false,
    "EjUserId": 796,
    "UserName": "Price, D'Amore and Bartoletti",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 455
      }
    }
  },
  "TicketPriority": {
    "Id": 855,
    "Value": "sint",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 830
      }
    }
  },
  "CustomerLanguage": {
    "Id": 519,
    "Value": "doloribus",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 477
      }
    }
  },
  "Deleted": 308,
  "DbiAgentId": 473,
  "DbiLastSyncronized": "2019-03-24T14:58:03.6192832+01:00",
  "DbiKey": "corporis",
  "DbiLastModified": "2000-10-17T14:58:03.6192832+02:00",
  "SupportPerson": {
    "Position": "similique",
    "PersonId": 740,
    "Mrmrs": "maiores",
    "Firstname": "Saige",
    "Lastname": "Quitzon",
    "MiddleName": "Leannon, Cartwright and Jast",
    "Title": "aut",
    "Description": "Persistent disintermediate utilisation",
    "Email": "christopher.gottlieb@schmidt.name",
    "FullName": "Ian West",
    "DirectPhone": "430.815.4718 x87048",
    "FormalName": "Goyette-Tillman",
    "CountryId": 997,
    "ContactId": 171,
    "ContactName": "Nolan Group",
    "Retired": 368,
    "Rank": 24,
    "ActiveInterests": 897,
    "ContactDepartment": "",
    "ContactCountryId": 840,
    "ContactOrgNr": "737980",
    "FaxPhone": "1-366-863-5786 x0624",
    "MobilePhone": "(727)053-3657 x458",
    "ContactPhone": "(067)424-0341",
    "AssociateName": "Pfeffer Inc and Sons",
    "AssociateId": 21,
    "UsePersonAddress": true,
    "ContactFax": "ut",
    "Kanafname": "at",
    "Kanalname": "ab",
    "Post1": "ab",
    "Post2": "beatae",
    "Post3": "voluptatibus",
    "EmailName": "alice.grimes@powlowski.co.uk",
    "ContactFullName": "Daniella Auer DVM",
    "ActiveErpLinks": 429,
    "TicketPriorityId": 510,
    "SupportLanguageId": 856,
    "SupportAssociateId": 601,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 425
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 11674.15,
    "Wgs84Longitude": 12789.854,
    "LocalizedAddress": [
      [
        {
          "Name": "Schoen, Schaefer and Heathcote",
          "Value": "minus",
          "Tooltip": "sint",
          "Label": "non",
          "ValueLength": 563,
          "AddressType": "ullam",
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
              "FieldLength": 59
            }
          }
        }
      ],
      [
        {
          "Name": "Zulauf-Roberts",
          "Value": "rerum",
          "Tooltip": "perspiciatis",
          "Label": "qui",
          "ValueLength": 17,
          "AddressType": "recusandae",
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
              "FieldLength": 971
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "eum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 856
      }
    }
  },
  "Source": 93,
  "ActiveErpLinks": 409,
  "BounceEmails": [
    "cornell@quigleykreiger.name",
    "freddy.jast@daniel.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "664712106",
    "SuperOffice:2": "Zechariah Abshire III"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsum",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "non"
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
      "FieldLength": 335
    }
  }
}
```