---
title: POST Agents/Contact/GetContactWithPersons
id: v1ContactAgent_GetContactWithPersons
---

# POST Agents/Contact/GetContactWithPersons

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 965
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 503,
  "Name": "Connelly LLC",
  "Department": "",
  "OrgNr": "1118901",
  "Number1": "741804",
  "Number2": "536289",
  "UpdatedDate": "2019-12-01T16:48:29.0779295+01:00",
  "CreatedDate": "2000-07-08T16:48:29.0779295+02:00",
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "possimus",
      "Description": "Configurable tangible software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 897
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "possimus",
      "Description": "Configurable tangible software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 897
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 779,
      "Name": "Schmeler-Raynor",
      "ToolTip": "Dignissimos ipsum magnam quibusdam.",
      "Deleted": true,
      "Rank": 804,
      "Type": "molestiae",
      "ColorBlock": 923,
      "IconHint": "vero",
      "Selected": false,
      "LastChanged": "2004-03-02T16:48:29.0779295+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Jaylon Eichmann PhD",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "possimus",
      "StrippedValue": "id",
      "Description": "Triple-buffered neutral superstructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "id",
      "Description": "Triple-buffered neutral superstructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "natus",
      "StrippedValue": "dolor",
      "Description": "Automated stable hierarchy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "dolor",
      "Description": "Automated stable hierarchy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "sit",
      "Description": "Phased contextually-based definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 643
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "sit",
      "Description": "Phased contextually-based definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 643
        }
      }
    }
  ],
  "Description": "Profound homogeneous encoding",
  "UpdatedBy": {
    "AssociateId": 182,
    "Name": "Roob Inc and Sons",
    "PersonId": 49,
    "Rank": 635,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 670,
    "FullName": "Kathlyn Prosacco",
    "FormalName": "Barrows Group",
    "Deleted": true,
    "EjUserId": 260,
    "UserName": "Breitenberg Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 99
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 666,
    "Name": "Flatley, Cartwright and Carter",
    "PersonId": 612,
    "Rank": 908,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 522,
    "FullName": "Shad Stanton",
    "FormalName": "Borer, Stanton and Hodkiewicz",
    "Deleted": true,
    "EjUserId": 821,
    "UserName": "Lehner Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reintermediate dynamic supply-chains"
        },
        "FieldType": "System.Int32",
        "FieldLength": 97
      }
    }
  },
  "Associate": {
    "AssociateId": 544,
    "Name": "Dibbert-Bednar",
    "PersonId": 384,
    "Rank": 918,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 60,
    "FullName": "Geovanny Emard",
    "FormalName": "Labadie Inc and Sons",
    "Deleted": true,
    "EjUserId": 411,
    "UserName": "Auer-Heidenreich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 45
      }
    }
  },
  "Business": {
    "Id": 133,
    "Value": "eligendi",
    "Tooltip": "blanditiis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 392
      }
    }
  },
  "Category": {
    "Id": 323,
    "Value": "quas",
    "Tooltip": "totam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 271
      }
    }
  },
  "Country": {
    "CountryId": 130,
    "Name": "Osinski Inc and Sons",
    "CurrencyId": 799,
    "EnglishName": "Beahan Inc and Sons",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Virtual 6th generation forecast",
    "OrgNrText": "1030077",
    "InterAreaPrefix": "odio",
    "DialInPrefix": "magnam",
    "ZipPrefix": "adipisci",
    "DomainName": "O'Keefe-Sipes",
    "AddressLayoutId": 184,
    "DomesticAddressLayoutId": 586,
    "ForeignAddressLayoutId": 828,
    "Rank": 986,
    "Tooltip": "deserunt",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 86
      }
    }
  },
  "Persons": [
    {
      "Position": "et",
      "PersonId": 537,
      "Mrmrs": "illum",
      "Firstname": "Raymundo",
      "Lastname": "O'Connell",
      "MiddleName": "Dicki, Funk and Hickle",
      "Title": "facilis",
      "Description": "Assimilated value-added application",
      "Email": "cristopher_adams@morargrimes.co.uk",
      "FullName": "Ms. Raphael Kub",
      "DirectPhone": "(604)452-5853 x446",
      "FormalName": "Mayer-Schultz",
      "CountryId": 140,
      "ContactId": 183,
      "ContactName": "Morar, Leffler and Runte",
      "Retired": 730,
      "Rank": 81,
      "ActiveInterests": 810,
      "ContactDepartment": "",
      "ContactCountryId": 376,
      "ContactOrgNr": "638473",
      "FaxPhone": "(201)442-8886",
      "MobilePhone": "117.048.1618",
      "ContactPhone": "1-778-823-6283",
      "AssociateName": "Herman-Brekke",
      "AssociateId": 484,
      "UsePersonAddress": true,
      "ContactFax": "a",
      "Kanafname": "et",
      "Kanalname": "velit",
      "Post1": "magnam",
      "Post2": "animi",
      "Post3": "ipsa",
      "EmailName": "izaiah@jerde.us",
      "ContactFullName": "Mr. Eino Little",
      "ActiveErpLinks": 588,
      "TicketPriorityId": 923,
      "SupportLanguageId": 539,
      "SupportAssociateId": 182,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 768
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "omnis",
  "Xstop": true,
  "ActiveInterests": 770,
  "GroupId": 196,
  "ActiveStatusMonitorId": 366,
  "SupportAssociate": {
    "AssociateId": 312,
    "Name": "Brekke, Olson and Mraz",
    "PersonId": 565,
    "Rank": 320,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 782,
    "FullName": "Alene Brekke",
    "FormalName": "Bogisich LLC",
    "Deleted": true,
    "EjUserId": 661,
    "UserName": "Keeling-Hickle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 329
      }
    }
  },
  "TicketPriority": {
    "Id": 599,
    "Value": "ad",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 980
      }
    }
  },
  "CustomerLanguage": {
    "Id": 623,
    "Value": "voluptatum",
    "Tooltip": "voluptatibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 801
      }
    }
  },
  "Deleted": 971,
  "DbiAgentId": 127,
  "DbiLastSyncronized": "1996-10-03T16:48:29.0809296+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2005-03-28T16:48:29.0809296+02:00",
  "SupportPerson": {
    "Position": "maiores",
    "PersonId": 111,
    "Mrmrs": "non",
    "Firstname": "Tyrel",
    "Lastname": "Orn",
    "MiddleName": "Gottlieb-Greenholt",
    "Title": "provident",
    "Description": "Centralized stable array",
    "Email": "marcelle@christiansen.info",
    "FullName": "Mariam Brakus",
    "DirectPhone": "(124)238-8622 x51108",
    "FormalName": "Dietrich LLC",
    "CountryId": 19,
    "ContactId": 737,
    "ContactName": "Hickle-Pfannerstill",
    "Retired": 874,
    "Rank": 458,
    "ActiveInterests": 917,
    "ContactDepartment": "",
    "ContactCountryId": 407,
    "ContactOrgNr": "744961",
    "FaxPhone": "360.731.0704 x357",
    "MobilePhone": "1-470-386-0533 x755",
    "ContactPhone": "435.286.1402 x4014",
    "AssociateName": "Dickens, Bradtke and Schneider",
    "AssociateId": 858,
    "UsePersonAddress": true,
    "ContactFax": "inventore",
    "Kanafname": "delectus",
    "Kanalname": "nam",
    "Post1": "est",
    "Post2": "nobis",
    "Post3": "vero",
    "EmailName": "damon.morar@brakus.uk",
    "ContactFullName": "Quinten Stanton",
    "ActiveErpLinks": 910,
    "TicketPriorityId": 863,
    "SupportLanguageId": 503,
    "SupportAssociateId": 532,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 989
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 22097.834,
    "Wgs84Longitude": 7994.834,
    "LocalizedAddress": [
      [
        {
          "Name": "Koch, Wyman and Morissette",
          "Value": "ad",
          "Tooltip": "consequatur",
          "Label": "consequatur",
          "ValueLength": 257,
          "AddressType": "quos",
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
              "FieldLength": 187
            }
          }
        }
      ],
      [
        {
          "Name": "Witting, Altenwerth and Fritsch",
          "Value": "illo",
          "Tooltip": "neque",
          "Label": "odit",
          "ValueLength": 178,
          "AddressType": "consequatur",
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
              "FieldLength": 351
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "nisi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 438
      }
    }
  },
  "Source": 596,
  "ActiveErpLinks": 234,
  "BounceEmails": [
    "kay@greenfelderwilkinson.us",
    "violette.schmeler@jacobson.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Vella Willms",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "a"
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
      "FieldLength": 612
    }
  }
}
```