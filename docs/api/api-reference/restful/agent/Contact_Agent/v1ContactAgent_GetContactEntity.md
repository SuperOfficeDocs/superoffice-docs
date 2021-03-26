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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=681
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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 275,
  "Name": "Witting, Kuhn and Sauer",
  "Department": "",
  "OrgNr": "1347809",
  "Number1": "998774",
  "Number2": "909807",
  "UpdatedDate": "2009-12-21T16:48:29.0609294+01:00",
  "CreatedDate": "1996-07-09T16:48:29.0609294+02:00",
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Proactive object-oriented frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Proactive object-oriented frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 8,
      "Name": "Collins Group",
      "ToolTip": "Nesciunt porro at dolor magni ea.",
      "Deleted": true,
      "Rank": 510,
      "Type": "aperiam",
      "ColorBlock": 900,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "2006-12-22T16:48:29.0609294+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "accusamus",
      "Hidden": false,
      "FullName": "Pamela Roberts",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vero",
      "StrippedValue": "autem",
      "Description": "Profit-focused methodical groupware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 236
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "autem",
      "Description": "Profit-focused methodical groupware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 236
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "fugiat",
      "StrippedValue": "eum",
      "Description": "Object-based methodical service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 806
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "eum",
      "Description": "Object-based methodical service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 806
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eligendi",
      "StrippedValue": "ut",
      "Description": "Enhanced empowering framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 674
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "ut",
      "Description": "Enhanced empowering framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 674
        }
      }
    }
  ],
  "Description": "Switchable holistic moderator",
  "UpdatedBy": {
    "AssociateId": 792,
    "Name": "Friesen LLC",
    "PersonId": 402,
    "Rank": 142,
    "Tooltip": "nam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 180,
    "FullName": "Dr. Athena Graham",
    "FormalName": "Franecki Inc and Sons",
    "Deleted": true,
    "EjUserId": 943,
    "UserName": "Runolfsson, Bode and McClure",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 262
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 486,
    "Name": "Hackett Inc and Sons",
    "PersonId": 990,
    "Rank": 307,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 581,
    "FullName": "Leilani Keebler",
    "FormalName": "Jones, Morar and Bartoletti",
    "Deleted": true,
    "EjUserId": 255,
    "UserName": "Bogan Group",
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
  "Associate": {
    "AssociateId": 626,
    "Name": "Quitzon, Olson and Stroman",
    "PersonId": 228,
    "Rank": 320,
    "Tooltip": "culpa",
    "Type": "AnonymousAssociate",
    "GroupIdx": 772,
    "FullName": "Mr. Malcolm Herzog",
    "FormalName": "Schimmel-Ortiz",
    "Deleted": false,
    "EjUserId": 849,
    "UserName": "Brakus-Hayes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 124
      }
    }
  },
  "Business": {
    "Id": 847,
    "Value": "distinctio",
    "Tooltip": "deleniti",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "whiteboard next-generation synergies"
        },
        "FieldType": "System.String",
        "FieldLength": 714
      }
    }
  },
  "Category": {
    "Id": 327,
    "Value": "omnis",
    "Tooltip": "accusamus",
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
  "Country": {
    "CountryId": 879,
    "Name": "Barrows-Stokes",
    "CurrencyId": 288,
    "EnglishName": "Huel-Leannon",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Optimized content-based array",
    "OrgNrText": "821568",
    "InterAreaPrefix": "nihil",
    "DialInPrefix": "reiciendis",
    "ZipPrefix": "sed",
    "DomainName": "Wyman, Langosh and Marquardt",
    "AddressLayoutId": 104,
    "DomesticAddressLayoutId": 958,
    "ForeignAddressLayoutId": 220,
    "Rank": 563,
    "Tooltip": "earum",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 534
      }
    }
  },
  "Persons": [
    {
      "Position": "nam",
      "PersonId": 634,
      "Mrmrs": "consectetur",
      "Firstname": "Joaquin",
      "Lastname": "Pollich",
      "MiddleName": "Gutkowski Group",
      "Title": "asperiores",
      "Description": "Enhanced secondary solution",
      "Email": "simone@rolfsonerdman.ca",
      "FullName": "Tremaine Walter",
      "DirectPhone": "1-073-505-4654 x02206",
      "FormalName": "Senger Inc and Sons",
      "CountryId": 816,
      "ContactId": 527,
      "ContactName": "Zieme, Rogahn and Bruen",
      "Retired": 703,
      "Rank": 581,
      "ActiveInterests": 70,
      "ContactDepartment": "",
      "ContactCountryId": 746,
      "ContactOrgNr": "1530565",
      "FaxPhone": "1-671-625-2102 x5278",
      "MobilePhone": "408-711-3800 x2744",
      "ContactPhone": "(058)253-8002 x8646",
      "AssociateName": "Kerluke-Gutkowski",
      "AssociateId": 748,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "ratione",
      "Kanalname": "est",
      "Post1": "debitis",
      "Post2": "harum",
      "Post3": "cumque",
      "EmailName": "kylee.feil@jast.us",
      "ContactFullName": "Jasper Beer DVM",
      "ActiveErpLinks": 537,
      "TicketPriorityId": 172,
      "SupportLanguageId": 446,
      "SupportAssociateId": 934,
      "CategoryName": "VIP Customer",
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
    }
  ],
  "NoMailing": true,
  "Kananame": "itaque",
  "Xstop": false,
  "ActiveInterests": 211,
  "GroupId": 502,
  "ActiveStatusMonitorId": 450,
  "SupportAssociate": {
    "AssociateId": 699,
    "Name": "Maggio Group",
    "PersonId": 371,
    "Rank": 84,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 94,
    "FullName": "Evie Barrows",
    "FormalName": "Hilpert, Rohan and Conn",
    "Deleted": false,
    "EjUserId": 868,
    "UserName": "Goyette-Cruickshank",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 8
      }
    }
  },
  "TicketPriority": {
    "Id": 917,
    "Value": "amet",
    "Tooltip": "deleniti",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 808
      }
    }
  },
  "CustomerLanguage": {
    "Id": 100,
    "Value": "iste",
    "Tooltip": "pariatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 841
      }
    }
  },
  "Deleted": 745,
  "DbiAgentId": 380,
  "DbiLastSyncronized": "2004-11-20T16:48:29.0649292+01:00",
  "DbiKey": "omnis",
  "DbiLastModified": "1999-05-06T16:48:29.0649292+02:00",
  "SupportPerson": {
    "Position": "ipsum",
    "PersonId": 345,
    "Mrmrs": "dolorem",
    "Firstname": "Kaci",
    "Lastname": "Turner",
    "MiddleName": "McLaughlin, Hettinger and Cummings",
    "Title": "veritatis",
    "Description": "Monitored mission-critical hub",
    "Email": "annabelle_goldner@mcclure.co.uk",
    "FullName": "Florence Schowalter",
    "DirectPhone": "1-883-673-7265 x721",
    "FormalName": "Windler, Hand and Parisian",
    "CountryId": 18,
    "ContactId": 865,
    "ContactName": "Farrell, Green and Lesch",
    "Retired": 532,
    "Rank": 229,
    "ActiveInterests": 488,
    "ContactDepartment": "",
    "ContactCountryId": 218,
    "ContactOrgNr": "456898",
    "FaxPhone": "(763)058-4165",
    "MobilePhone": "1-622-603-5635",
    "ContactPhone": "(825)374-2651 x338",
    "AssociateName": "Schuppe-Quitzon",
    "AssociateId": 325,
    "UsePersonAddress": true,
    "ContactFax": "at",
    "Kanafname": "quia",
    "Kanalname": "cupiditate",
    "Post1": "quaerat",
    "Post2": "voluptate",
    "Post3": "mollitia",
    "EmailName": "wyatt@haley.uk",
    "ContactFullName": "Archibald Abernathy PhD",
    "ActiveErpLinks": 968,
    "TicketPriorityId": 956,
    "SupportLanguageId": 126,
    "SupportAssociateId": 411,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 260
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 21756.228,
    "Wgs84Longitude": 9235.898,
    "LocalizedAddress": [
      [
        {
          "Name": "Champlin-Rohan",
          "Value": "sunt",
          "Tooltip": "explicabo",
          "Label": "dolorum",
          "ValueLength": 961,
          "AddressType": "iusto",
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
              "FieldLength": 725
            }
          }
        }
      ],
      [
        {
          "Name": "Hammes, Boyer and Greenholt",
          "Value": "perferendis",
          "Tooltip": "quis",
          "Label": "fugit",
          "ValueLength": 418,
          "AddressType": "laboriosam",
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
              "FieldLength": 922
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "aliquam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 456
      }
    }
  },
  "Source": 45,
  "ActiveErpLinks": 924,
  "BounceEmails": [
    "terrance.bashirian@mraz.ca",
    "clovis@walker.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "totam"
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
      "FieldLength": 92
    }
  }
}
```