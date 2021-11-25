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
| Domains | array | Web domains for this contact, ordered in array by rank |
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
  "ContactId": 507
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 629,
  "Name": "Spencer-Hegmann",
  "Department": "envisioneer synergistic relationships",
  "OrgNr": "1378891",
  "Number1": "893072",
  "Number2": "1040034",
  "UpdatedDate": "1998-12-16T18:28:48.4906261+01:00",
  "CreatedDate": "2016-12-18T18:28:48.4906261+01:00",
  "Emails": [
    {
      "Value": "nesciunt",
      "StrippedValue": "sit",
      "Description": "Re-engineered zero defect hierarchy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "sit",
      "Description": "Re-engineered zero defect hierarchy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 70,
      "Name": "Wolf, Hegmann and Howe",
      "ToolTip": "Est qui.",
      "Deleted": true,
      "Rank": 207,
      "Type": "perferendis",
      "ColorBlock": 144,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2002-06-27T18:28:48.4916264+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "voluptate",
      "Hidden": false,
      "FullName": "Grayce Carter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 640
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fugit",
      "StrippedValue": "aperiam",
      "Description": "Realigned multimedia model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 444
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "aperiam",
      "Description": "Realigned multimedia model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 444
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "aut",
      "Description": "Virtual bifurcated intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "repurpose bricks-and-clicks paradigms"
          },
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "aut",
      "Description": "Virtual bifurcated intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "repurpose bricks-and-clicks paradigms"
          },
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "modi",
      "StrippedValue": "in",
      "Description": "Enhanced stable archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    },
    {
      "Value": "modi",
      "StrippedValue": "in",
      "Description": "Enhanced stable archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "Description": "Devolved zero administration hardware",
  "UpdatedBy": {
    "AssociateId": 413,
    "Name": "Kautzer, Kuphal and Runolfsdottir",
    "PersonId": 765,
    "Rank": 998,
    "Tooltip": "quos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 429,
    "FullName": "Abigayle Ward",
    "FormalName": "Walter Inc and Sons",
    "Deleted": true,
    "EjUserId": 3,
    "UserName": "Langosh-Jones",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 84
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 353,
    "Name": "Marvin Group",
    "PersonId": 883,
    "Rank": 801,
    "Tooltip": "fugit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 153,
    "FullName": "Darrick Goyette",
    "FormalName": "Kuphal Inc and Sons",
    "Deleted": false,
    "EjUserId": 344,
    "UserName": "Fritsch Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "revolutionize innovative web-readiness"
        },
        "FieldType": "System.Int32",
        "FieldLength": 444
      }
    }
  },
  "Associate": {
    "AssociateId": 921,
    "Name": "Witting, Crist and Leannon",
    "PersonId": 683,
    "Rank": 414,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 415,
    "FullName": "Rahsaan Toy",
    "FormalName": "Bogan LLC",
    "Deleted": true,
    "EjUserId": 786,
    "UserName": "Barton, Hudson and Predovic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate end-to-end channels"
        },
        "FieldType": "System.Int32",
        "FieldLength": 749
      }
    }
  },
  "Business": {
    "Id": 783,
    "Value": "et",
    "Tooltip": "adipisci",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 715
      }
    }
  },
  "Category": {
    "Id": 603,
    "Value": "minus",
    "Tooltip": "ratione",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 942
      }
    }
  },
  "Country": {
    "CountryId": 946,
    "Name": "Davis Inc and Sons",
    "CurrencyId": 243,
    "EnglishName": "Jakubowski-Ledner",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Face to face dynamic algorithm",
    "OrgNrText": "1224085",
    "InterAreaPrefix": "libero",
    "DialInPrefix": "quibusdam",
    "ZipPrefix": "repellat",
    "DomainName": "Powlowski LLC",
    "AddressLayoutId": 907,
    "DomesticAddressLayoutId": 521,
    "ForeignAddressLayoutId": 362,
    "Rank": 185,
    "Tooltip": "corporis",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 285
      }
    }
  },
  "Persons": [
    {
      "Position": "dolore",
      "PersonId": 61,
      "Mrmrs": "est",
      "Firstname": "Lessie",
      "Lastname": "Crist",
      "MiddleName": "Orn LLC",
      "Title": "explicabo",
      "Description": "Universal client-driven moratorium",
      "Email": "salma@hilpertleannon.us",
      "FullName": "Jackie Collins MD",
      "DirectPhone": "(060)665-3418 x5108",
      "FormalName": "Runte, Balistreri and Beahan",
      "CountryId": 41,
      "ContactId": 426,
      "ContactName": "Anderson-Christiansen",
      "Retired": 239,
      "Rank": 912,
      "ActiveInterests": 201,
      "ContactDepartment": "",
      "ContactCountryId": 84,
      "ContactOrgNr": "990685",
      "FaxPhone": "880.441.8626 x3064",
      "MobilePhone": "(236)513-0220 x4774",
      "ContactPhone": "350-162-0335",
      "AssociateName": "Heathcote Group",
      "AssociateId": 757,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "ut",
      "Kanalname": "molestiae",
      "Post1": "suscipit",
      "Post2": "eum",
      "Post3": "libero",
      "EmailName": "johan_hegmann@cummerata.us",
      "ContactFullName": "Zola Lang",
      "ActiveErpLinks": 772,
      "TicketPriorityId": 393,
      "SupportLanguageId": 227,
      "SupportAssociateId": 42,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 65
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "modi",
  "Xstop": true,
  "ActiveInterests": 114,
  "GroupId": 87,
  "ActiveStatusMonitorId": 609,
  "SupportAssociate": {
    "AssociateId": 615,
    "Name": "Wehner Inc and Sons",
    "PersonId": 206,
    "Rank": 803,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 881,
    "FullName": "Cornelius Batz",
    "FormalName": "Raynor LLC",
    "Deleted": true,
    "EjUserId": 963,
    "UserName": "Altenwerth, Sporer and Price",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "envisioneer out-of-the-box e-services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 188
      }
    }
  },
  "TicketPriority": {
    "Id": 548,
    "Value": "dolorem",
    "Tooltip": "laudantium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 572
      }
    }
  },
  "CustomerLanguage": {
    "Id": 796,
    "Value": "voluptates",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 69
      }
    }
  },
  "Deleted": 886,
  "DbiAgentId": 618,
  "DbiLastSyncronized": "2020-06-25T18:28:48.4946258+02:00",
  "DbiKey": "consequuntur",
  "DbiLastModified": "2016-08-20T18:28:48.4946258+02:00",
  "SupportPerson": {
    "Position": "voluptas",
    "PersonId": 915,
    "Mrmrs": "nulla",
    "Firstname": "Valentina",
    "Lastname": "Koelpin",
    "MiddleName": "Hilpert-Kautzer",
    "Title": "blanditiis",
    "Description": "Phased value-added local area network",
    "Email": "willy.nikolaus@ebert.co.uk",
    "FullName": "Misty Ebert",
    "DirectPhone": "(637)142-5165 x245",
    "FormalName": "Farrell LLC",
    "CountryId": 347,
    "ContactId": 212,
    "ContactName": "Gottlieb, Swift and Kuhn",
    "Retired": 259,
    "Rank": 635,
    "ActiveInterests": 11,
    "ContactDepartment": "",
    "ContactCountryId": 960,
    "ContactOrgNr": "1959257",
    "FaxPhone": "(165)470-4211 x8678",
    "MobilePhone": "(407)856-4085 x1121",
    "ContactPhone": "351.045.8141",
    "AssociateName": "Bechtelar Inc and Sons",
    "AssociateId": 545,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "sapiente",
    "Kanalname": "aliquid",
    "Post1": "alias",
    "Post2": "ut",
    "Post3": "soluta",
    "EmailName": "santa_strosin@dach.info",
    "ContactFullName": "Keara Stroman",
    "ActiveErpLinks": 511,
    "TicketPriorityId": 61,
    "SupportLanguageId": 591,
    "SupportAssociateId": 873,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 673
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 16723.024,
    "Wgs84Longitude": 14886.5,
    "LocalizedAddress": [
      [
        {
          "Name": "Kulas-Maggio",
          "Value": "ad",
          "Tooltip": "vel",
          "Label": "est",
          "ValueLength": 795,
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
              "FieldLength": 780
            }
          }
        }
      ],
      [
        {
          "Name": "Wiza, Reichert and Wyman",
          "Value": "placeat",
          "Tooltip": "et",
          "Label": "deleniti",
          "ValueLength": 830,
          "AddressType": "necessitatibus",
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
              "FieldLength": 45
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "voluptatibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 677
      }
    }
  },
  "Source": 766,
  "ActiveErpLinks": 835,
  "BounceEmails": [
    "breana.mclaughlin@kuhicrodriguez.info",
    "nicholas_welch@corwin.us"
  ],
  "Domains": [
    "ducimus",
    "minus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Sienna Heller",
    "SuperOffice:2": "Beulah Hackett"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "necessitatibus",
    "CustomFields2": "quo"
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
      "FieldLength": 431
    }
  }
}
```