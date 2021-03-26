---
title: POST Contact
id: v1ContactEntity_PostContactEntity
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity

Calls the Contact agent service SaveContactEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

## Request Body: newEntity  

The ContactEntity to be saved. 

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


## Response: object

The Contact Service. The service implements all services working with the Contact object



ContactEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 938,
  "Name": "Jacobi LLC",
  "Department": "reintermediate 24/365 e-commerce",
  "OrgNr": "447127",
  "Number1": "1540478",
  "Number2": "1496241",
  "UpdatedDate": "1995-08-20T09:40:58.8743757+02:00",
  "CreatedDate": "1999-02-13T09:40:58.8743757+01:00",
  "Emails": [
    {
      "Value": "pariatur",
      "StrippedValue": "earum",
      "Description": "Cross-platform intangible forecast"
    },
    {
      "Value": "pariatur",
      "StrippedValue": "earum",
      "Description": "Cross-platform intangible forecast"
    }
  ],
  "Interests": [
    {
      "Id": 805,
      "Name": "Littel Inc and Sons",
      "ToolTip": "Ea eos molestiae occaecati et ratione optio.",
      "Deleted": true,
      "Rank": 76,
      "Type": "et",
      "ColorBlock": 628,
      "IconHint": "tempore",
      "Selected": false,
      "LastChanged": "1996-10-24T09:40:58.8743757+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "numquam",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Kristina Greenfelder"
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "ea",
      "Description": "Reverse-engineered methodical framework"
    },
    {
      "Value": "aut",
      "StrippedValue": "ea",
      "Description": "Reverse-engineered methodical framework"
    }
  ],
  "Phones": [
    {
      "Value": "nihil",
      "StrippedValue": "incidunt",
      "Description": "Expanded fault-tolerant encryption"
    },
    {
      "Value": "nihil",
      "StrippedValue": "incidunt",
      "Description": "Expanded fault-tolerant encryption"
    }
  ],
  "Faxes": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "accusamus",
      "Description": "Re-engineered bottom-line analyzer"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "accusamus",
      "Description": "Re-engineered bottom-line analyzer"
    }
  ],
  "Description": "Synergistic object-oriented hub",
  "UpdatedBy": {
    "AssociateId": 889,
    "Name": "Terry-Abernathy",
    "PersonId": 58,
    "Rank": 130,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 635,
    "FullName": "Domingo Haag",
    "FormalName": "Haley LLC",
    "Deleted": false,
    "EjUserId": 252,
    "UserName": "Rippin LLC"
  },
  "CreatedBy": {
    "AssociateId": 376,
    "Name": "Mosciski-Roberts",
    "PersonId": 97,
    "Rank": 846,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 245,
    "FullName": "Della Hoppe IV",
    "FormalName": "Reichel LLC",
    "Deleted": true,
    "EjUserId": 298,
    "UserName": "Hackett-Yundt"
  },
  "Associate": {
    "AssociateId": 759,
    "Name": "Doyle, Bogan and Wintheiser",
    "PersonId": 557,
    "Rank": 257,
    "Tooltip": "quibusdam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 988,
    "FullName": "Ms. Veda Gaylord",
    "FormalName": "Willms Inc and Sons",
    "Deleted": false,
    "EjUserId": 170,
    "UserName": "Howell, Heathcote and Bahringer"
  },
  "Business": {
    "Id": 923,
    "Value": "sit",
    "Tooltip": "sint"
  },
  "Category": {
    "Id": 758,
    "Value": "sed",
    "Tooltip": "iure"
  },
  "Country": {
    "CountryId": 746,
    "Name": "Leuschke, Altenwerth and Thiel",
    "CurrencyId": 626,
    "EnglishName": "Cummerata-Kihn",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Multi-tiered demand-driven framework",
    "OrgNrText": "348876",
    "InterAreaPrefix": "odit",
    "DialInPrefix": "aut",
    "ZipPrefix": "qui",
    "DomainName": "Hilll LLC",
    "AddressLayoutId": 184,
    "DomesticAddressLayoutId": 167,
    "ForeignAddressLayoutId": 191,
    "Rank": 539,
    "Tooltip": "facere",
    "Deleted": true
  },
  "Persons": [
    {
      "Position": "accusamus",
      "PersonId": 879,
      "Mrmrs": "quia",
      "Firstname": "Isaac",
      "Lastname": "Reichert",
      "MiddleName": "Jakubowski, Bednar and Osinski",
      "Title": "earum",
      "Description": "Synergistic radical intranet",
      "Email": "margret.jaskolski@trantow.name",
      "FullName": "Garth Hegmann II",
      "DirectPhone": "608-336-3471 x03557",
      "FormalName": "Kling-Jones",
      "CountryId": 603,
      "ContactId": 424,
      "ContactName": "Johns-Stoltenberg",
      "Retired": 210,
      "Rank": 345,
      "ActiveInterests": 820,
      "ContactDepartment": "",
      "ContactCountryId": 694,
      "ContactOrgNr": "1766717",
      "FaxPhone": "030-686-2413 x08420",
      "MobilePhone": "224-786-8222 x7057",
      "ContactPhone": "(582)804-8871 x7405",
      "AssociateName": "Hammes-Wehner",
      "AssociateId": 321,
      "UsePersonAddress": true,
      "ContactFax": "in",
      "Kanafname": "explicabo",
      "Kanalname": "ex",
      "Post1": "aut",
      "Post2": "maxime",
      "Post3": "velit",
      "EmailName": "eladio_kessler@feil.com",
      "ContactFullName": "Gavin Reynolds",
      "ActiveErpLinks": 602,
      "TicketPriorityId": 66,
      "SupportLanguageId": 286,
      "SupportAssociateId": 880,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": false,
  "ActiveInterests": 752,
  "GroupId": 411,
  "ActiveStatusMonitorId": 267,
  "SupportAssociate": {
    "AssociateId": 302,
    "Name": "Ullrich LLC",
    "PersonId": 567,
    "Rank": 588,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 905,
    "FullName": "Tremaine Cummings",
    "FormalName": "Cassin-Nader",
    "Deleted": true,
    "EjUserId": 590,
    "UserName": "Anderson Inc and Sons"
  },
  "TicketPriority": {
    "Id": 24,
    "Value": "quos",
    "Tooltip": "quasi"
  },
  "CustomerLanguage": {
    "Id": 556,
    "Value": "cumque",
    "Tooltip": "eaque"
  },
  "Deleted": 450,
  "DbiAgentId": 543,
  "DbiLastSyncronized": "2020-07-03T09:40:58.8773758+02:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "1994-03-12T09:40:58.8773758+01:00",
  "SupportPerson": {
    "Position": "repellendus",
    "PersonId": 419,
    "Mrmrs": "rerum",
    "Firstname": "Conor",
    "Lastname": "Shields",
    "MiddleName": "Christiansen-Buckridge",
    "Title": "sed",
    "Description": "Configurable secondary data-warehouse",
    "Email": "grant@gorczany.uk",
    "FullName": "Jermey Bartoletti",
    "DirectPhone": "627.431.0852",
    "FormalName": "Treutel, Kerluke and Frami",
    "CountryId": 819,
    "ContactId": 803,
    "ContactName": "Pfannerstill, Wilkinson and Bergnaum",
    "Retired": 687,
    "Rank": 592,
    "ActiveInterests": 24,
    "ContactDepartment": "",
    "ContactCountryId": 15,
    "ContactOrgNr": "1095164",
    "FaxPhone": "(551)231-1780",
    "MobilePhone": "1-845-444-4874 x7484",
    "ContactPhone": "612.042.1830 x04420",
    "AssociateName": "Smitham, Schneider and Wilderman",
    "AssociateId": 983,
    "UsePersonAddress": false,
    "ContactFax": "consequuntur",
    "Kanafname": "voluptatem",
    "Kanalname": "sit",
    "Post1": "et",
    "Post2": "ipsa",
    "Post3": "placeat",
    "EmailName": "jonathon@maggio.ca",
    "ContactFullName": "Ottilie Lind",
    "ActiveErpLinks": 246,
    "TicketPriorityId": 391,
    "SupportLanguageId": 492,
    "SupportAssociateId": 943,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 783.5,
    "Wgs84Longitude": 22633.748,
    "LocalizedAddress": [
      [
        {
          "Name": "Langworth, Wolff and Reinger",
          "Value": "natus",
          "Tooltip": "id",
          "Label": "quo",
          "ValueLength": 772,
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
              "FieldType": "System.String",
              "FieldLength": 769
            }
          }
        }
      ],
      [
        {
          "Name": "Reilly Inc and Sons",
          "Value": "delectus",
          "Tooltip": "totam",
          "Label": "ab",
          "ValueLength": 840,
          "AddressType": "voluptatibus",
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
              "FieldLength": 779
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "quia"
  },
  "Source": 191,
  "ActiveErpLinks": 42,
  "BounceEmails": [
    "adalberto_brakus@jerderau.com",
    "floyd_daniel@zulauf.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1071921572",
    "SuperOffice:2": "698464879"
  },
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "consectetur"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 253,
  "Name": "Graham, Abshire and Mertz",
  "Department": "facilitate holistic e-services",
  "OrgNr": "893218",
  "Number1": "1051512",
  "Number2": "714417",
  "UpdatedDate": "1995-08-24T09:40:58.923481+02:00",
  "CreatedDate": "2000-10-20T09:40:58.923481+02:00",
  "Emails": [
    {
      "Value": "aperiam",
      "StrippedValue": "iusto",
      "Description": "Versatile value-added adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "iusto",
      "Description": "Versatile value-added adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 87,
      "Name": "Homenick-Reilly",
      "ToolTip": "Itaque commodi et ipsum veritatis id.",
      "Deleted": false,
      "Rank": 403,
      "Type": "ea",
      "ColorBlock": 398,
      "IconHint": "fugiat",
      "Selected": true,
      "LastChanged": "2019-03-16T09:40:58.923481+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officiis",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Yasmine Graham",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "maxime",
      "StrippedValue": "illum",
      "Description": "Expanded intangible hierarchy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 765
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "illum",
      "Description": "Expanded intangible hierarchy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 765
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ad",
      "StrippedValue": "in",
      "Description": "Face to face mission-critical knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 784
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "in",
      "Description": "Face to face mission-critical knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 784
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "quibusdam",
      "Description": "Progressive scalable throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 644
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "quibusdam",
      "Description": "Progressive scalable throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 644
        }
      }
    }
  ],
  "Description": "Automated empowering monitoring",
  "UpdatedBy": {
    "AssociateId": 254,
    "Name": "Collins-Trantow",
    "PersonId": 387,
    "Rank": 168,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 508,
    "FullName": "Lexie Kub",
    "FormalName": "Padberg, Greenholt and O'Connell",
    "Deleted": false,
    "EjUserId": 928,
    "UserName": "Upton-Parker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 639
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 24,
    "Name": "Hilpert-Stanton",
    "PersonId": 42,
    "Rank": 235,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 67,
    "FullName": "Micaela Hickle",
    "FormalName": "Hyatt-O'Hara",
    "Deleted": true,
    "EjUserId": 826,
    "UserName": "Beer-Hand",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 266
      }
    }
  },
  "Associate": {
    "AssociateId": 977,
    "Name": "Stark Group",
    "PersonId": 571,
    "Rank": 60,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 145,
    "FullName": "Randall Gerlach",
    "FormalName": "Blanda-Leannon",
    "Deleted": false,
    "EjUserId": 672,
    "UserName": "Terry-Weber",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 257
      }
    }
  },
  "Business": {
    "Id": 583,
    "Value": "aut",
    "Tooltip": "ipsam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 587
      }
    }
  },
  "Category": {
    "Id": 67,
    "Value": "et",
    "Tooltip": "laudantium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 621
      }
    }
  },
  "Country": {
    "CountryId": 458,
    "Name": "Spencer-Spencer",
    "CurrencyId": 361,
    "EnglishName": "Lesch-Mayer",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Organized regional analyzer",
    "OrgNrText": "1003394",
    "InterAreaPrefix": "voluptas",
    "DialInPrefix": "maiores",
    "ZipPrefix": "cumque",
    "DomainName": "Keeling LLC",
    "AddressLayoutId": 565,
    "DomesticAddressLayoutId": 370,
    "ForeignAddressLayoutId": 678,
    "Rank": 402,
    "Tooltip": "ad",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 268
      }
    }
  },
  "Persons": [
    {
      "Position": "accusamus",
      "PersonId": 463,
      "Mrmrs": "quod",
      "Firstname": "Elinore",
      "Lastname": "Lueilwitz",
      "MiddleName": "Rice Inc and Sons",
      "Title": "reprehenderit",
      "Description": "Exclusive fault-tolerant flexibility",
      "Email": "jesus@moenbaumbach.uk",
      "FullName": "Aubrey Berge IV",
      "DirectPhone": "842.731.8088",
      "FormalName": "Block Inc and Sons",
      "CountryId": 101,
      "ContactId": 145,
      "ContactName": "Predovic, Crooks and Considine",
      "Retired": 979,
      "Rank": 421,
      "ActiveInterests": 11,
      "ContactDepartment": "",
      "ContactCountryId": 797,
      "ContactOrgNr": "985134",
      "FaxPhone": "074.738.5308 x87241",
      "MobilePhone": "313.248.3488",
      "ContactPhone": "(687)455-1714 x181",
      "AssociateName": "Rosenbaum, Bayer and Abshire",
      "AssociateId": 788,
      "UsePersonAddress": true,
      "ContactFax": "quas",
      "Kanafname": "laborum",
      "Kanalname": "et",
      "Post1": "quas",
      "Post2": "consectetur",
      "Post3": "consequatur",
      "EmailName": "jaylon.sipes@gleichnerledner.us",
      "ContactFullName": "Alivia Nolan DVM",
      "ActiveErpLinks": 900,
      "TicketPriorityId": 274,
      "SupportLanguageId": 280,
      "SupportAssociateId": 287,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 412
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "alias",
  "Xstop": false,
  "ActiveInterests": 521,
  "GroupId": 338,
  "ActiveStatusMonitorId": 609,
  "SupportAssociate": {
    "AssociateId": 852,
    "Name": "Cole, Prohaska and Nienow",
    "PersonId": 781,
    "Rank": 493,
    "Tooltip": "quam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 837,
    "FullName": "Ophelia Kreiger",
    "FormalName": "Casper-Swift",
    "Deleted": false,
    "EjUserId": 245,
    "UserName": "White, Harvey and Littel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 24
      }
    }
  },
  "TicketPriority": {
    "Id": 307,
    "Value": "deleniti",
    "Tooltip": "ipsam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 599
      }
    }
  },
  "CustomerLanguage": {
    "Id": 72,
    "Value": "consequatur",
    "Tooltip": "voluptate",
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
  "Deleted": 382,
  "DbiAgentId": 81,
  "DbiLastSyncronized": "1995-09-23T09:40:58.9273714+02:00",
  "DbiKey": "deleniti",
  "DbiLastModified": "2017-09-22T09:40:58.9273714+02:00",
  "SupportPerson": {
    "Position": "ad",
    "PersonId": 624,
    "Mrmrs": "excepturi",
    "Firstname": "Cleveland",
    "Lastname": "Dibbert",
    "MiddleName": "Gutmann, Roob and Dibbert",
    "Title": "itaque",
    "Description": "Enterprise-wide incremental extranet",
    "Email": "princess@becker.co.uk",
    "FullName": "Vida Krajcik",
    "DirectPhone": "1-132-006-3203 x01373",
    "FormalName": "Kihn, Erdman and White",
    "CountryId": 923,
    "ContactId": 366,
    "ContactName": "Bergstrom Group",
    "Retired": 131,
    "Rank": 405,
    "ActiveInterests": 427,
    "ContactDepartment": "",
    "ContactCountryId": 273,
    "ContactOrgNr": "551534",
    "FaxPhone": "(028)505-1258 x4705",
    "MobilePhone": "111-500-5502 x285",
    "ContactPhone": "1-607-121-1865",
    "AssociateName": "Bogan, Parisian and Hartmann",
    "AssociateId": 463,
    "UsePersonAddress": false,
    "ContactFax": "vero",
    "Kanafname": "tenetur",
    "Kanalname": "molestiae",
    "Post1": "rerum",
    "Post2": "nobis",
    "Post3": "nam",
    "EmailName": "elsa_prosacco@walshsenger.info",
    "ContactFullName": "Nova Schneider",
    "ActiveErpLinks": 514,
    "TicketPriorityId": 299,
    "SupportLanguageId": 257,
    "SupportAssociateId": 390,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 333
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 6910.4699999999993,
    "Wgs84Longitude": 3829.748,
    "LocalizedAddress": [
      [
        {
          "Name": "Breitenberg LLC",
          "Value": "eligendi",
          "Tooltip": "suscipit",
          "Label": "nesciunt",
          "ValueLength": 888,
          "AddressType": "facilis",
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
              "FieldLength": 601
            }
          }
        }
      ],
      [
        {
          "Name": "Lang, Morar and Bartoletti",
          "Value": "ab",
          "Tooltip": "expedita",
          "Label": "eaque",
          "ValueLength": 614,
          "AddressType": "incidunt",
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
              "FieldLength": 329
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "autem",
    "TableRight": {},
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
  },
  "Source": 880,
  "ActiveErpLinks": 187,
  "BounceEmails": [
    "rahsaan.walker@rippinjacobi.ca",
    "joelle.pfannerstill@kuhnbatz.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Madisyn Gleason",
    "SuperOffice:2": "2031796402"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "impedit"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "generate synergistic infrastructures"
      },
      "FieldType": "System.Int32",
      "FieldLength": 93
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```