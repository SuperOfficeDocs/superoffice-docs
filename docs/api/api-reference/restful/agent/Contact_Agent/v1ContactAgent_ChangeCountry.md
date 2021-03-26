---
title: POST Agents/Contact/ChangeCountry
id: v1ContactAgent_ChangeCountry
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity |  | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | int32 |  |


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
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": {
    "ContactId": 779,
    "Name": "McGlynn-Grant",
    "Department": "",
    "OrgNr": "1017414",
    "Number1": "903048",
    "Number2": "1165560",
    "UpdatedDate": "2017-12-27T16:48:29.1528943+01:00",
    "CreatedDate": "1995-04-21T16:48:29.1528943+02:00",
    "Emails": [
      {},
      {}
    ],
    "Interests": [
      {},
      {}
    ],
    "Urls": [
      {},
      {}
    ],
    "Phones": [
      {},
      {}
    ],
    "Faxes": [
      {},
      {}
    ],
    "Description": "Mandatory even-keeled interface",
    "UpdatedBy": {},
    "CreatedBy": {},
    "Associate": {},
    "Business": {},
    "Category": {},
    "Country": {},
    "Persons": [
      {},
      {}
    ],
    "NoMailing": true,
    "Kananame": "voluptatibus",
    "Xstop": true,
    "ActiveInterests": 328,
    "GroupId": 835,
    "ActiveStatusMonitorId": 23,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "Deleted": 345,
    "DbiAgentId": 279,
    "DbiLastSyncronized": "2015-02-17T16:48:29.1528943+01:00",
    "DbiKey": "ut",
    "DbiLastModified": "2009-11-25T16:48:29.1528943+01:00",
    "SupportPerson": {},
    "Address": {},
    "Source": 706,
    "ActiveErpLinks": 479,
    "BounceEmails": [
      "rodrick_tromp@keeling.info",
      "arno@kreigerfeeney.info"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "False",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "quo",
      "ExtraFields2": "velit"
    },
    "CustomFields": {
      "CustomFields1": "molestiae",
      "CustomFields2": "aut"
    }
  },
  "ToCountryId": 774
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 31,
  "Name": "Green Inc and Sons",
  "Department": "",
  "OrgNr": "1676295",
  "Number1": "1087994",
  "Number2": "739394",
  "UpdatedDate": "1996-04-12T16:48:29.1608947+02:00",
  "CreatedDate": "2010-12-28T16:48:29.1608947+01:00",
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "aut",
      "Description": "Public-key solution-oriented moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 122
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "aut",
      "Description": "Public-key solution-oriented moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 122
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 149,
      "Name": "Shields-Bergnaum",
      "ToolTip": "A laudantium sed.",
      "Deleted": false,
      "Rank": 209,
      "Type": "veniam",
      "ColorBlock": 559,
      "IconHint": "delectus",
      "Selected": false,
      "LastChanged": "2011-01-01T16:48:29.1608947+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Dr. Tobin Runolfsdottir",
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
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "ipsum",
      "Description": "User-friendly multi-tasking archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "ipsum",
      "Description": "User-friendly multi-tasking archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "tempora",
      "StrippedValue": "rem",
      "Description": "Self-enabling interactive artificial intelligence",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "rem",
      "Description": "Self-enabling interactive artificial intelligence",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "pariatur",
      "StrippedValue": "ab",
      "Description": "Optimized system-worthy budgetary management",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "expedite compelling infrastructures"
          },
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "ab",
      "Description": "Optimized system-worthy budgetary management",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "expedite compelling infrastructures"
          },
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    }
  ],
  "Description": "Synchronised fault-tolerant synergy",
  "UpdatedBy": {
    "AssociateId": 303,
    "Name": "Pagac-Rohan",
    "PersonId": 828,
    "Rank": 278,
    "Tooltip": "accusamus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 482,
    "FullName": "Mrs. Micheal Breitenberg",
    "FormalName": "Green, Schuster and Davis",
    "Deleted": false,
    "EjUserId": 193,
    "UserName": "Cartwright, Eichmann and Lynch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 474
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 104,
    "Name": "Kuhlman-Wilkinson",
    "PersonId": 151,
    "Rank": 192,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 918,
    "FullName": "Ms. Donna Daugherty",
    "FormalName": "Huels, Ankunding and Flatley",
    "Deleted": true,
    "EjUserId": 534,
    "UserName": "Smith Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 12
      }
    }
  },
  "Associate": {
    "AssociateId": 181,
    "Name": "Carter LLC",
    "PersonId": 822,
    "Rank": 191,
    "Tooltip": "assumenda",
    "Type": "AnonymousAssociate",
    "GroupIdx": 991,
    "FullName": "Arjun Lebsack MD",
    "FormalName": "Predovic Group",
    "Deleted": true,
    "EjUserId": 9,
    "UserName": "Reinger, Kertzmann and Schuppe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 556
      }
    }
  },
  "Business": {
    "Id": 381,
    "Value": "omnis",
    "Tooltip": "nobis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 604
      }
    }
  },
  "Category": {
    "Id": 476,
    "Value": "nostrum",
    "Tooltip": "aperiam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 848
      }
    }
  },
  "Country": {
    "CountryId": 166,
    "Name": "Sporer, Bergnaum and Conn",
    "CurrencyId": 993,
    "EnglishName": "Gibson, Goodwin and Grady",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Re-engineered full-range local area network",
    "OrgNrText": "678774",
    "InterAreaPrefix": "vero",
    "DialInPrefix": "eos",
    "ZipPrefix": "atque",
    "DomainName": "Heathcote LLC",
    "AddressLayoutId": 429,
    "DomesticAddressLayoutId": 224,
    "ForeignAddressLayoutId": 464,
    "Rank": 776,
    "Tooltip": "rerum",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 868
      }
    }
  },
  "Persons": [
    {
      "Position": "impedit",
      "PersonId": 317,
      "Mrmrs": "natus",
      "Firstname": "Vicenta",
      "Lastname": "Johnson",
      "MiddleName": "Trantow, Kunze and Denesik",
      "Title": "alias",
      "Description": "Balanced optimizing circuit",
      "Email": "gussie.hettinger@lowe.biz",
      "FullName": "June Will",
      "DirectPhone": "385-075-4843 x2304",
      "FormalName": "Wilderman-Fisher",
      "CountryId": 321,
      "ContactId": 464,
      "ContactName": "Terry, Prosacco and Jast",
      "Retired": 768,
      "Rank": 308,
      "ActiveInterests": 337,
      "ContactDepartment": "",
      "ContactCountryId": 137,
      "ContactOrgNr": "994889",
      "FaxPhone": "007-288-1034",
      "MobilePhone": "540-625-0335 x02665",
      "ContactPhone": "646-357-1232 x14002",
      "AssociateName": "Effertz Inc and Sons",
      "AssociateId": 66,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "incidunt",
      "Kanalname": "officiis",
      "Post1": "laborum",
      "Post2": "voluptas",
      "Post3": "id",
      "EmailName": "breana@kundepadberg.co.uk",
      "ContactFullName": "Orlo Hilll PhD",
      "ActiveErpLinks": 436,
      "TicketPriorityId": 26,
      "SupportLanguageId": 440,
      "SupportAssociateId": 576,
      "CategoryName": "VIP Customer",
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
    }
  ],
  "NoMailing": true,
  "Kananame": "dolorum",
  "Xstop": false,
  "ActiveInterests": 139,
  "GroupId": 162,
  "ActiveStatusMonitorId": 505,
  "SupportAssociate": {
    "AssociateId": 518,
    "Name": "Rippin-Marvin",
    "PersonId": 552,
    "Rank": 312,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 156,
    "FullName": "Kiarra Schamberger",
    "FormalName": "Cartwright-Spencer",
    "Deleted": true,
    "EjUserId": 513,
    "UserName": "Brakus, Adams and Schimmel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 305
      }
    }
  },
  "TicketPriority": {
    "Id": 935,
    "Value": "enim",
    "Tooltip": "eligendi",
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
  "CustomerLanguage": {
    "Id": 716,
    "Value": "sed",
    "Tooltip": "occaecati",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 422
      }
    }
  },
  "Deleted": 531,
  "DbiAgentId": 763,
  "DbiLastSyncronized": "2007-01-07T16:48:29.1648947+01:00",
  "DbiKey": "et",
  "DbiLastModified": "1997-06-19T16:48:29.1648947+02:00",
  "SupportPerson": {
    "Position": "dolorem",
    "PersonId": 304,
    "Mrmrs": "dolores",
    "Firstname": "Misael",
    "Lastname": "Von",
    "MiddleName": "Mueller Inc and Sons",
    "Title": "fugiat",
    "Description": "User-friendly local implementation",
    "Email": "delilah_dooley@hickleboehm.biz",
    "FullName": "Davon Flatley",
    "DirectPhone": "1-081-727-3546 x24371",
    "FormalName": "Marks-Conroy",
    "CountryId": 31,
    "ContactId": 814,
    "ContactName": "Will LLC",
    "Retired": 516,
    "Rank": 724,
    "ActiveInterests": 472,
    "ContactDepartment": "",
    "ContactCountryId": 503,
    "ContactOrgNr": "725578",
    "FaxPhone": "727.733.4104 x88182",
    "MobilePhone": "514.111.3502 x6073",
    "ContactPhone": "1-306-425-8710 x00230",
    "AssociateName": "Lemke-Johnston",
    "AssociateId": 711,
    "UsePersonAddress": false,
    "ContactFax": "placeat",
    "Kanafname": "consequatur",
    "Kanalname": "illum",
    "Post1": "autem",
    "Post2": "omnis",
    "Post3": "voluptatem",
    "EmailName": "kevon_torp@lemkebechtelar.com",
    "ContactFullName": "Faustino Herzog",
    "ActiveErpLinks": 13,
    "TicketPriorityId": 148,
    "SupportLanguageId": 182,
    "SupportAssociateId": 131,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 143
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 20035.662,
    "Wgs84Longitude": 2585.5499999999997,
    "LocalizedAddress": [
      [
        {
          "Name": "Morar-Nolan",
          "Value": "saepe",
          "Tooltip": "molestiae",
          "Label": "magni",
          "ValueLength": 760,
          "AddressType": "quo",
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
              "FieldLength": 921
            }
          }
        }
      ],
      [
        {
          "Name": "Hilpert LLC",
          "Value": "reiciendis",
          "Tooltip": "laboriosam",
          "Label": "et",
          "ValueLength": 691,
          "AddressType": "qui",
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
              "FieldLength": 957
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "amet",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 731
      }
    }
  },
  "Source": 557,
  "ActiveErpLinks": 592,
  "BounceEmails": [
    "elisabeth.schumm@herzogward.name",
    "dolores@ferrynienow.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "491264276",
    "SuperOffice:2": "1585025859"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "totam",
    "CustomFields2": "omnis"
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
      "FieldLength": 845
    }
  }
}
```