---
title: GetContactWithPersons
id: v1ContactAgent_GetContactWithPersons
---

# GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
```


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

## Request Body: request  

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |


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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 805
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 840,
  "Name": "Bartell-Howell",
  "Department": "",
  "OrgNr": "86201",
  "Number1": "1182575",
  "Number2": "1506171",
  "UpdatedDate": "2016-07-23T14:58:03.6003104+02:00",
  "CreatedDate": "2001-01-22T14:58:03.6003104+01:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "esse",
      "Description": "Reduced eco-centric flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "synergize back-end synergies"
          },
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "esse",
      "Description": "Reduced eco-centric flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "synergize back-end synergies"
          },
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 78,
      "Name": "Fadel-Zboncak",
      "ToolTip": "Inventore commodi veniam quidem in.",
      "Deleted": true,
      "Rank": 424,
      "Type": "provident",
      "ColorBlock": 556,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2001-01-24T14:58:03.6013102+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "delectus",
      "Hidden": false,
      "FullName": "Cielo Hintz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "saepe",
      "StrippedValue": "doloribus",
      "Description": "Synergistic holistic synergy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "disintermediate cross-platform convergence"
          },
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "doloribus",
      "Description": "Synergistic holistic synergy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "disintermediate cross-platform convergence"
          },
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "dolor",
      "Description": "Synergistic transitional circuit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "dolor",
      "Description": "Synergistic transitional circuit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iusto",
      "StrippedValue": "ipsam",
      "Description": "Public-key composite matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 531
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "ipsam",
      "Description": "Public-key composite matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 531
        }
      }
    }
  ],
  "Description": "Managed intermediate open architecture",
  "UpdatedBy": {
    "AssociateId": 812,
    "Name": "Gerhold-Muller",
    "PersonId": 708,
    "Rank": 491,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 105,
    "FullName": "Korbin Wintheiser",
    "FormalName": "Funk, Hamill and Braun",
    "Deleted": true,
    "EjUserId": 121,
    "UserName": "DuBuque, Barton and Herzog",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 104
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 35,
    "Name": "Hoppe Group",
    "PersonId": 488,
    "Rank": 252,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 922,
    "FullName": "Odell Hilpert",
    "FormalName": "Stark-Stracke",
    "Deleted": true,
    "EjUserId": 42,
    "UserName": "Friesen Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 113
      }
    }
  },
  "Associate": {
    "AssociateId": 308,
    "Name": "Kub-Ryan",
    "PersonId": 222,
    "Rank": 482,
    "Tooltip": "provident",
    "Type": "AnonymousAssociate",
    "GroupIdx": 509,
    "FullName": "Cindy Haag",
    "FormalName": "Harber, Kozey and Satterfield",
    "Deleted": false,
    "EjUserId": 400,
    "UserName": "O'Connell-Rogahn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 906
      }
    }
  },
  "Business": {
    "Id": 739,
    "Value": "et",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 181
      }
    }
  },
  "Category": {
    "Id": 672,
    "Value": "ad",
    "Tooltip": "odio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 977
      }
    }
  },
  "Country": {
    "CountryId": 129,
    "Name": "Cormier, Fritsch and Ryan",
    "CurrencyId": 776,
    "EnglishName": "Greenfelder, Hessel and Gislason",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Multi-lateral leading edge artificial intelligence",
    "OrgNrText": "736062",
    "InterAreaPrefix": "maxime",
    "DialInPrefix": "laborum",
    "ZipPrefix": "cumque",
    "DomainName": "Leffler-Mosciski",
    "AddressLayoutId": 610,
    "DomesticAddressLayoutId": 660,
    "ForeignAddressLayoutId": 475,
    "Rank": 504,
    "Tooltip": "a",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 228
      }
    }
  },
  "Persons": [
    {
      "Position": "possimus",
      "PersonId": 486,
      "Mrmrs": "ratione",
      "Firstname": "Fredrick",
      "Lastname": "Langworth",
      "MiddleName": "Huel, Ernser and Mraz",
      "Title": "officiis",
      "Description": "Progressive regional open system",
      "Email": "lindsey_goodwin@corkery.co.uk",
      "FullName": "Jaron Klocko",
      "DirectPhone": "207-580-5224 x613",
      "FormalName": "Hyatt Group",
      "CountryId": 86,
      "ContactId": 603,
      "ContactName": "Beatty, Gibson and Homenick",
      "Retired": 791,
      "Rank": 822,
      "ActiveInterests": 235,
      "ContactDepartment": "",
      "ContactCountryId": 352,
      "ContactOrgNr": "1065787",
      "FaxPhone": "780-511-7885 x233",
      "MobilePhone": "202.015.0653",
      "ContactPhone": "1-728-336-3375",
      "AssociateName": "Christiansen, Terry and Abshire",
      "AssociateId": 224,
      "UsePersonAddress": true,
      "ContactFax": "harum",
      "Kanafname": "dolorem",
      "Kanalname": "ipsa",
      "Post1": "omnis",
      "Post2": "quia",
      "Post3": "explicabo",
      "EmailName": "hayden@friesen.uk",
      "ContactFullName": "Taylor Stanton",
      "ActiveErpLinks": 633,
      "TicketPriorityId": 562,
      "SupportLanguageId": 807,
      "SupportAssociateId": 891,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "consequatur",
  "Xstop": false,
  "ActiveInterests": 497,
  "GroupId": 934,
  "ActiveStatusMonitorId": 67,
  "SupportAssociate": {
    "AssociateId": 377,
    "Name": "Hahn-Smith",
    "PersonId": 633,
    "Rank": 425,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 242,
    "FullName": "Harmony Kohler IV",
    "FormalName": "Klein-Romaguera",
    "Deleted": true,
    "EjUserId": 314,
    "UserName": "Bins-Koelpin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 85
      }
    }
  },
  "TicketPriority": {
    "Id": 66,
    "Value": "autem",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 875
      }
    }
  },
  "CustomerLanguage": {
    "Id": 61,
    "Value": "esse",
    "Tooltip": "molestiae",
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
  "Deleted": 782,
  "DbiAgentId": 98,
  "DbiLastSyncronized": "2019-07-25T14:58:03.6053153+02:00",
  "DbiKey": "voluptatum",
  "DbiLastModified": "1995-05-10T14:58:03.6053153+02:00",
  "SupportPerson": {
    "Position": "id",
    "PersonId": 185,
    "Mrmrs": "asperiores",
    "Firstname": "Tate",
    "Lastname": "O'Conner",
    "MiddleName": "Gusikowski-Little",
    "Title": "doloremque",
    "Description": "Intuitive assymetric analyzer",
    "Email": "tobin.okuneva@hegmannhauck.co.uk",
    "FullName": "Alyson Rath",
    "DirectPhone": "(203)006-7054",
    "FormalName": "Borer Group",
    "CountryId": 409,
    "ContactId": 602,
    "ContactName": "Rippin Inc and Sons",
    "Retired": 393,
    "Rank": 955,
    "ActiveInterests": 309,
    "ContactDepartment": "",
    "ContactCountryId": 231,
    "ContactOrgNr": "857429",
    "FaxPhone": "(058)523-2734",
    "MobilePhone": "(422)584-0826 x06227",
    "ContactPhone": "(666)722-7511 x8157",
    "AssociateName": "Bauch Inc and Sons",
    "AssociateId": 251,
    "UsePersonAddress": true,
    "ContactFax": "quasi",
    "Kanafname": "enim",
    "Kanalname": "sit",
    "Post1": "reprehenderit",
    "Post2": "aperiam",
    "Post3": "nobis",
    "EmailName": "javier@lebsack.biz",
    "ContactFullName": "Danial Keebler",
    "ActiveErpLinks": 667,
    "TicketPriorityId": 362,
    "SupportLanguageId": 826,
    "SupportAssociateId": 479,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 580
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 30590.974,
    "Wgs84Longitude": 19659.582,
    "LocalizedAddress": [
      [
        {
          "Name": "Bosco, Zulauf and McGlynn",
          "Value": "blanditiis",
          "Tooltip": "et",
          "Label": "et",
          "ValueLength": 221,
          "AddressType": "ut",
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
              "FieldLength": 47
            }
          }
        }
      ],
      [
        {
          "Name": "Kemmer-O'Kon",
          "Value": "iure",
          "Tooltip": "perferendis",
          "Label": "quidem",
          "ValueLength": 339,
          "AddressType": "et",
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
              "FieldLength": 481
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "optimize front-end e-tailers"
        },
        "FieldType": "System.Int32",
        "FieldLength": 45
      }
    }
  },
  "Source": 13,
  "ActiveErpLinks": 340,
  "BounceEmails": [
    "bill.dubuque@monahandicki.us",
    "leopold@hettinger.name"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Kendall Brekke",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "beatae",
    "CustomFields2": "quia"
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
      "FieldLength": 481
    }
  }
}
```