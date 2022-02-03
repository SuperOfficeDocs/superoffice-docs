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
| Domains | array | Web domains for this contact, ordered in array by rank |
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
  "ContactId": 499,
  "Name": "Wuckert, Brakus and Cartwright",
  "Department": "",
  "OrgNr": "535148",
  "Number1": "446051",
  "Number2": "1053671",
  "UpdatedDate": "2010-03-06T18:28:48.5603675+01:00",
  "CreatedDate": "2007-04-01T18:28:48.5603675+02:00",
  "Emails": [
    {
      "Value": "quos",
      "StrippedValue": "non",
      "Description": "Total dynamic middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 995
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "non",
      "Description": "Total dynamic middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 995
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 883,
      "Name": "Lang-Koelpin",
      "ToolTip": "Doloremque aspernatur modi aspernatur.",
      "Deleted": false,
      "Rank": 742,
      "Type": "voluptatem",
      "ColorBlock": 147,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "1996-09-07T18:28:48.5603675+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reiciendis",
      "StyleHint": "ea",
      "Hidden": true,
      "FullName": "Rene Marks",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 681
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "aut",
      "Description": "Enterprise-wide motivating middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 180
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "aut",
      "Description": "Enterprise-wide motivating middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 180
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "nisi",
      "Description": "Ergonomic 6th generation productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "extend frictionless technologies"
          },
          "FieldType": "System.String",
          "FieldLength": 693
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "nisi",
      "Description": "Ergonomic 6th generation productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "extend frictionless technologies"
          },
          "FieldType": "System.String",
          "FieldLength": 693
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quaerat",
      "StrippedValue": "rerum",
      "Description": "Synergized systemic matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 811
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "rerum",
      "Description": "Synergized systemic matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 811
        }
      }
    }
  ],
  "Description": "Total bottom-line support",
  "UpdatedBy": {
    "AssociateId": 541,
    "Name": "Thiel-Gorczany",
    "PersonId": 233,
    "Rank": 803,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 554,
    "FullName": "Johnson Hintz",
    "FormalName": "Tromp, Tillman and Walker",
    "Deleted": false,
    "EjUserId": 706,
    "UserName": "Ruecker-Hoeger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 462
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 575,
    "Name": "Veum-Rolfson",
    "PersonId": 537,
    "Rank": 344,
    "Tooltip": "debitis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 625,
    "FullName": "Amani Deckow",
    "FormalName": "Weissnat, Jacobs and Wisozk",
    "Deleted": true,
    "EjUserId": 60,
    "UserName": "Kulas-Shields",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 293
      }
    }
  },
  "Associate": {
    "AssociateId": 195,
    "Name": "Conroy, Cronin and Legros",
    "PersonId": 578,
    "Rank": 507,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 164,
    "FullName": "Agustin Ferry",
    "FormalName": "Kunde-Mills",
    "Deleted": true,
    "EjUserId": 965,
    "UserName": "Harvey, Stiedemann and Kozey",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 244
      }
    }
  },
  "Business": {
    "Id": 416,
    "Value": "maxime",
    "Tooltip": "autem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 168
      }
    }
  },
  "Category": {
    "Id": 739,
    "Value": "explicabo",
    "Tooltip": "perspiciatis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 240
      }
    }
  },
  "Country": {
    "CountryId": 433,
    "Name": "Schuppe Group",
    "CurrencyId": 1001,
    "EnglishName": "Yost LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Multi-layered web-enabled flexibility",
    "OrgNrText": "1041665",
    "InterAreaPrefix": "officia",
    "DialInPrefix": "sunt",
    "ZipPrefix": "deleniti",
    "DomainName": "Schaden Inc and Sons",
    "AddressLayoutId": 774,
    "DomesticAddressLayoutId": 91,
    "ForeignAddressLayoutId": 444,
    "Rank": 760,
    "Tooltip": "sit",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 895
      }
    }
  },
  "Persons": [
    {
      "Position": "reiciendis",
      "PersonId": 900,
      "Mrmrs": "nam",
      "Firstname": "Violette",
      "Lastname": "Larson",
      "MiddleName": "Schneider Group",
      "Title": "vel",
      "Description": "Triple-buffered web-enabled data-warehouse",
      "Email": "addison.mitchell@hegmann.us",
      "FullName": "Monte Haag",
      "DirectPhone": "578-100-3566",
      "FormalName": "Jones, Spencer and Willms",
      "CountryId": 99,
      "ContactId": 984,
      "ContactName": "Kris Inc and Sons",
      "Retired": 540,
      "Rank": 803,
      "ActiveInterests": 318,
      "ContactDepartment": "",
      "ContactCountryId": 614,
      "ContactOrgNr": "1198211",
      "FaxPhone": "1-466-563-6737",
      "MobilePhone": "264.247.0061 x2407",
      "ContactPhone": "(632)132-6878 x001",
      "AssociateName": "Carroll Inc and Sons",
      "AssociateId": 765,
      "UsePersonAddress": true,
      "ContactFax": "modi",
      "Kanafname": "alias",
      "Kanalname": "illum",
      "Post1": "sint",
      "Post2": "natus",
      "Post3": "ullam",
      "EmailName": "kieran@ferry.ca",
      "ContactFullName": "Jonathon Lebsack V",
      "ActiveErpLinks": 730,
      "TicketPriorityId": 718,
      "SupportLanguageId": 319,
      "SupportAssociateId": 410,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 646
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "laboriosam",
  "Xstop": false,
  "ActiveInterests": 569,
  "GroupId": 900,
  "ActiveStatusMonitorId": 769,
  "SupportAssociate": {
    "AssociateId": 941,
    "Name": "Gleason-Senger",
    "PersonId": 422,
    "Rank": 146,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 518,
    "FullName": "Werner Kreiger PhD",
    "FormalName": "Lueilwitz-Morar",
    "Deleted": false,
    "EjUserId": 667,
    "UserName": "Graham, Deckow and Jaskolski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 918
      }
    }
  },
  "TicketPriority": {
    "Id": 834,
    "Value": "eos",
    "Tooltip": "enim",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 53
      }
    }
  },
  "CustomerLanguage": {
    "Id": 942,
    "Value": "aut",
    "Tooltip": "nam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 535
      }
    }
  },
  "Deleted": 908,
  "DbiAgentId": 480,
  "DbiLastSyncronized": "1999-09-10T18:28:48.5649285+02:00",
  "DbiKey": "non",
  "DbiLastModified": "2002-01-19T18:28:48.5649285+01:00",
  "SupportPerson": {
    "Position": "ut",
    "PersonId": 72,
    "Mrmrs": "possimus",
    "Firstname": "Avery",
    "Lastname": "Cummerata",
    "MiddleName": "Legros Inc and Sons",
    "Title": "nihil",
    "Description": "Up-sized motivating time-frame",
    "Email": "magdalena.koss@waltersanford.us",
    "FullName": "Athena O'Connell IV",
    "DirectPhone": "630.271.0323 x586",
    "FormalName": "Marquardt-Deckow",
    "CountryId": 435,
    "ContactId": 491,
    "ContactName": "Friesen-McClure",
    "Retired": 273,
    "Rank": 820,
    "ActiveInterests": 324,
    "ContactDepartment": "envisioneer impactful web-readiness",
    "ContactCountryId": 649,
    "ContactOrgNr": "1298870",
    "FaxPhone": "1-554-118-7755",
    "MobilePhone": "284.731.0650",
    "ContactPhone": "(845)715-3063",
    "AssociateName": "Krajcik, Hintz and Daugherty",
    "AssociateId": 30,
    "UsePersonAddress": true,
    "ContactFax": "laudantium",
    "Kanafname": "dolorem",
    "Kanalname": "asperiores",
    "Post1": "dolores",
    "Post2": "qui",
    "Post3": "consequatur",
    "EmailName": "kirk.schamberger@hagenes.co.uk",
    "ContactFullName": "Eunice Schroeder",
    "ActiveErpLinks": 255,
    "TicketPriorityId": 451,
    "SupportLanguageId": 573,
    "SupportAssociateId": 868,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 144
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 20725.142,
    "Wgs84Longitude": 12557.938,
    "LocalizedAddress": [
      [
        {
          "Name": "Anderson, Gleason and Watsica",
          "Value": "id",
          "Tooltip": "perspiciatis",
          "Label": "ea",
          "ValueLength": 577,
          "AddressType": "ut",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "reinvent strategic niches"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.Int32",
              "FieldLength": 923
            }
          }
        }
      ],
      [
        {
          "Name": "O'Conner, Jenkins and Hirthe",
          "Value": "consequuntur",
          "Tooltip": "quia",
          "Label": "odio",
          "ValueLength": 817,
          "AddressType": "vitae",
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
              "FieldLength": 617
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "iusto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 483
      }
    }
  },
  "Source": 396,
  "ActiveErpLinks": 725,
  "BounceEmails": [
    "crystel.block@howe.us",
    "jovanny_lang@nienow.com"
  ],
  "Domains": [
    "repellat",
    "in"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Filiberto Wilderman",
    "SuperOffice:2": "1042600658"
  },
  "ExtraFields": {
    "ExtraFields1": "esse",
    "ExtraFields2": "saepe"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "et"
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
      "FieldLength": 278
    }
  }
}
```