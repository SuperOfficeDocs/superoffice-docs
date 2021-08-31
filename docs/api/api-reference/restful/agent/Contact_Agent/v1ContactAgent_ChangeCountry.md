---
title: ChangeCountry
id: v1ContactAgent_ChangeCountry
---

# ChangeCountry

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": {
    "ContactId": 832,
    "Name": "Wehner Group",
    "Department": "",
    "OrgNr": "832145",
    "Number1": "1018898",
    "Number2": "909787",
    "UpdatedDate": "2018-04-21T14:58:03.6793165+02:00",
    "CreatedDate": "2020-05-03T14:58:03.6793165+02:00",
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
    "Description": "Reduced 24/7 time-frame",
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
    "NoMailing": false,
    "Kananame": "eos",
    "Xstop": true,
    "ActiveInterests": 277,
    "GroupId": 223,
    "ActiveStatusMonitorId": 202,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "Deleted": 980,
    "DbiAgentId": 464,
    "DbiLastSyncronized": "2010-07-05T14:58:03.6793165+02:00",
    "DbiKey": "hic",
    "DbiLastModified": "2005-02-16T14:58:03.6793165+01:00",
    "SupportPerson": {},
    "Address": {},
    "Source": 744,
    "ActiveErpLinks": 30,
    "BounceEmails": [
      "claire_wuckert@conn.ca",
      "melvin@pollich.biz"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "1061484168",
      "SuperOffice:2": "True"
    },
    "ExtraFields": {
      "ExtraFields1": "magnam",
      "ExtraFields2": "sit"
    },
    "CustomFields": {
      "CustomFields1": "est",
      "CustomFields2": "a"
    }
  },
  "ToCountryId": 503
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 240,
  "Name": "Sipes LLC",
  "Department": "",
  "OrgNr": "748987",
  "Number1": "900430",
  "Number2": "1166345",
  "UpdatedDate": "2019-10-03T14:58:03.6883155+02:00",
  "CreatedDate": "2015-07-25T14:58:03.6883155+02:00",
  "Emails": [
    {
      "Value": "commodi",
      "StrippedValue": "fugiat",
      "Description": "Versatile heuristic info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "fugiat",
      "Description": "Versatile heuristic info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 958,
      "Name": "Jacobi-Marks",
      "ToolTip": "Quasi non nobis eum.",
      "Deleted": false,
      "Rank": 772,
      "Type": "et",
      "ColorBlock": 311,
      "IconHint": "consectetur",
      "Selected": true,
      "LastChanged": "2016-01-22T14:58:03.6883155+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "dolorem",
      "Hidden": false,
      "FullName": "Tristin Kunze",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 701
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "voluptatem",
      "Description": "Open-source background utilisation",
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
    {
      "Value": "enim",
      "StrippedValue": "voluptatem",
      "Description": "Open-source background utilisation",
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
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Progressive mission-critical interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Progressive mission-critical interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "magni",
      "Description": "Reactive mobile migration",
      "TableRight": {},
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
    },
    {
      "Value": "dolores",
      "StrippedValue": "magni",
      "Description": "Reactive mobile migration",
      "TableRight": {},
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
  "Description": "Cross-platform zero tolerance hub",
  "UpdatedBy": {
    "AssociateId": 830,
    "Name": "Sauer-Carter",
    "PersonId": 218,
    "Rank": 267,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 699,
    "FullName": "Destiny Russel",
    "FormalName": "Tremblay Group",
    "Deleted": true,
    "EjUserId": 366,
    "UserName": "Hessel LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 406
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 355,
    "Name": "Borer Group",
    "PersonId": 846,
    "Rank": 16,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 847,
    "FullName": "Naomi Mohr",
    "FormalName": "Conroy Inc and Sons",
    "Deleted": false,
    "EjUserId": 141,
    "UserName": "Lockman LLC",
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
  "Associate": {
    "AssociateId": 228,
    "Name": "Skiles, Nienow and Breitenberg",
    "PersonId": 105,
    "Rank": 200,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 92,
    "FullName": "Kennith Corwin MD",
    "FormalName": "Rice-Erdman",
    "Deleted": true,
    "EjUserId": 953,
    "UserName": "Larkin Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 587
      }
    }
  },
  "Business": {
    "Id": 361,
    "Value": "tenetur",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark granular solutions"
        },
        "FieldType": "System.String",
        "FieldLength": 445
      }
    }
  },
  "Category": {
    "Id": 744,
    "Value": "ex",
    "Tooltip": "dolor",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 990
      }
    }
  },
  "Country": {
    "CountryId": 421,
    "Name": "Ratke LLC",
    "CurrencyId": 946,
    "EnglishName": "Lynch Group",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Implemented national frame",
    "OrgNrText": "787858",
    "InterAreaPrefix": "sed",
    "DialInPrefix": "ea",
    "ZipPrefix": "ipsa",
    "DomainName": "Lehner-Hessel",
    "AddressLayoutId": 190,
    "DomesticAddressLayoutId": 848,
    "ForeignAddressLayoutId": 778,
    "Rank": 679,
    "Tooltip": "vel",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate visionary e-markets"
        },
        "FieldType": "System.String",
        "FieldLength": 767
      }
    }
  },
  "Persons": [
    {
      "Position": "officiis",
      "PersonId": 868,
      "Mrmrs": "officia",
      "Firstname": "Talia",
      "Lastname": "White",
      "MiddleName": "Leffler-Daniel",
      "Title": "et",
      "Description": "Stand-alone bi-directional secured line",
      "Email": "scarlett_klein@trantow.info",
      "FullName": "Rachelle Rohan",
      "DirectPhone": "(258)388-6443",
      "FormalName": "Shanahan, Mueller and Jenkins",
      "CountryId": 593,
      "ContactId": 320,
      "ContactName": "Kirlin-Gutkowski",
      "Retired": 993,
      "Rank": 492,
      "ActiveInterests": 322,
      "ContactDepartment": "",
      "ContactCountryId": 489,
      "ContactOrgNr": "502012",
      "FaxPhone": "(730)527-7604 x72005",
      "MobilePhone": "1-386-752-4274",
      "ContactPhone": "582.406.0814 x7587",
      "AssociateName": "Mayer, Schamberger and Schowalter",
      "AssociateId": 151,
      "UsePersonAddress": true,
      "ContactFax": "officiis",
      "Kanafname": "ut",
      "Kanalname": "et",
      "Post1": "labore",
      "Post2": "dolorem",
      "Post3": "temporibus",
      "EmailName": "armando.schneider@auer.name",
      "ContactFullName": "Jannie Stoltenberg V",
      "ActiveErpLinks": 305,
      "TicketPriorityId": 719,
      "SupportLanguageId": 38,
      "SupportAssociateId": 952,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 665
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quisquam",
  "Xstop": false,
  "ActiveInterests": 283,
  "GroupId": 962,
  "ActiveStatusMonitorId": 368,
  "SupportAssociate": {
    "AssociateId": 468,
    "Name": "Hane, Hamill and Purdy",
    "PersonId": 26,
    "Rank": 838,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 816,
    "FullName": "Ali Mraz",
    "FormalName": "Schamberger LLC",
    "Deleted": true,
    "EjUserId": 426,
    "UserName": "Weber Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 325
      }
    }
  },
  "TicketPriority": {
    "Id": 126,
    "Value": "voluptatem",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 62
      }
    }
  },
  "CustomerLanguage": {
    "Id": 215,
    "Value": "sequi",
    "Tooltip": "cupiditate",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 62
      }
    }
  },
  "Deleted": 911,
  "DbiAgentId": 989,
  "DbiLastSyncronized": "2010-08-03T14:58:03.6922818+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2020-12-09T14:58:03.6922818+01:00",
  "SupportPerson": {
    "Position": "quibusdam",
    "PersonId": 859,
    "Mrmrs": "molestiae",
    "Firstname": "Claude",
    "Lastname": "Kuhn",
    "MiddleName": "Fritsch-Hoeger",
    "Title": "dolore",
    "Description": "Profit-focused 5th generation ability",
    "Email": "meta@lynchbosco.name",
    "FullName": "Walter Turcotte DDS",
    "DirectPhone": "1-728-080-6210",
    "FormalName": "Heaney-Wolf",
    "CountryId": 871,
    "ContactId": 723,
    "ContactName": "Tromp-Ryan",
    "Retired": 624,
    "Rank": 221,
    "ActiveInterests": 172,
    "ContactDepartment": "",
    "ContactCountryId": 55,
    "ContactOrgNr": "851308",
    "FaxPhone": "470.078.8232 x4147",
    "MobilePhone": "378.635.6353 x125",
    "ContactPhone": "313.715.7112 x63644",
    "AssociateName": "Reinger, Hahn and Schneider",
    "AssociateId": 658,
    "UsePersonAddress": false,
    "ContactFax": "magni",
    "Kanafname": "et",
    "Kanalname": "temporibus",
    "Post1": "dignissimos",
    "Post2": "et",
    "Post3": "autem",
    "EmailName": "adrianna@daugherty.us",
    "ContactFullName": "Mateo Farrell MD",
    "ActiveErpLinks": 663,
    "TicketPriorityId": 43,
    "SupportLanguageId": 962,
    "SupportAssociateId": 984,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 623
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 27707.694,
    "Wgs84Longitude": 14842.624,
    "LocalizedAddress": [
      [
        {
          "Name": "Dickens, Schmitt and Bauch",
          "Value": "eveniet",
          "Tooltip": "vel",
          "Label": "qui",
          "ValueLength": 409,
          "AddressType": "doloribus",
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
              "FieldLength": 358
            }
          }
        }
      ],
      [
        {
          "Name": "McKenzie, Wintheiser and Lesch",
          "Value": "totam",
          "Tooltip": "rerum",
          "Label": "in",
          "ValueLength": 531,
          "AddressType": "aspernatur",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "aggregate proactive infomediaries"
              },
              "FieldType": "System.Int32",
              "FieldLength": 293
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
        "FieldType": "System.Int32",
        "FieldLength": 51
      }
    }
  },
  "Source": 928,
  "ActiveErpLinks": 663,
  "BounceEmails": [
    "katlyn.gislason@tillman.name",
    "marcelina_torphy@treutel.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Carlos Fritsch",
    "SuperOffice:2": "Mckayla Dibbert"
  },
  "ExtraFields": {
    "ExtraFields1": "eaque",
    "ExtraFields2": "odio"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "eum"
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
      "FieldLength": 536
    }
  }
}
```