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
| Domains | array | Web domains for this contact, ordered in array by rank |
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
| Domains | array | Web domains for this contact, ordered in array by rank |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 68,
  "Name": "Kerluke LLC",
  "Department": "",
  "OrgNr": "1818905",
  "Number1": "1261413",
  "Number2": "1037922",
  "UpdatedDate": "1994-09-22T18:25:50.2426193+02:00",
  "CreatedDate": "2017-10-05T18:25:50.2426193+02:00",
  "Emails": [
    {
      "Value": "aperiam",
      "StrippedValue": "deleniti",
      "Description": "Compatible methodical methodology"
    },
    {
      "Value": "aperiam",
      "StrippedValue": "deleniti",
      "Description": "Compatible methodical methodology"
    }
  ],
  "Interests": [
    {
      "Id": 644,
      "Name": "Ankunding LLC",
      "ToolTip": "Vel omnis.",
      "Deleted": true,
      "Rank": 484,
      "Type": "fugiat",
      "ColorBlock": 388,
      "IconHint": "consequuntur",
      "Selected": true,
      "LastChanged": "2003-02-22T18:25:50.2426193+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "quis",
      "Hidden": false,
      "FullName": "Aliza Medhurst"
    }
  ],
  "Urls": [
    {
      "Value": "ratione",
      "StrippedValue": "quasi",
      "Description": "Optional zero administration neural-net"
    },
    {
      "Value": "ratione",
      "StrippedValue": "quasi",
      "Description": "Optional zero administration neural-net"
    }
  ],
  "Phones": [
    {
      "Value": "dolores",
      "StrippedValue": "perferendis",
      "Description": "Advanced dynamic alliance"
    },
    {
      "Value": "dolores",
      "StrippedValue": "perferendis",
      "Description": "Advanced dynamic alliance"
    }
  ],
  "Faxes": [
    {
      "Value": "quam",
      "StrippedValue": "eveniet",
      "Description": "Triple-buffered foreground extranet"
    },
    {
      "Value": "quam",
      "StrippedValue": "eveniet",
      "Description": "Triple-buffered foreground extranet"
    }
  ],
  "Description": "Object-based actuating adapter",
  "UpdatedBy": {
    "AssociateId": 638,
    "Name": "Pfannerstill-Hessel",
    "PersonId": 851,
    "Rank": 229,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 420,
    "FullName": "Valentina Goodwin",
    "FormalName": "Kris, Kuvalis and Schiller",
    "Deleted": false,
    "EjUserId": 893,
    "UserName": "Buckridge Inc and Sons"
  },
  "CreatedBy": {
    "AssociateId": 379,
    "Name": "Schmitt Group",
    "PersonId": 257,
    "Rank": 788,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 530,
    "FullName": "Ms. Horace Durgan",
    "FormalName": "Hamill LLC",
    "Deleted": true,
    "EjUserId": 749,
    "UserName": "Ankunding Group"
  },
  "Associate": {
    "AssociateId": 691,
    "Name": "Considine-Jones",
    "PersonId": 418,
    "Rank": 402,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 803,
    "FullName": "Freddie Wiza",
    "FormalName": "Luettgen, Barrows and Witting",
    "Deleted": true,
    "EjUserId": 112,
    "UserName": "Collins-Simonis"
  },
  "Business": {
    "Id": 868,
    "Value": "quaerat",
    "Tooltip": "numquam"
  },
  "Category": {
    "Id": 472,
    "Value": "fuga",
    "Tooltip": "voluptatem"
  },
  "Country": {
    "CountryId": 260,
    "Name": "Halvorson-Kerluke",
    "CurrencyId": 678,
    "EnglishName": "Hills, Jenkins and Bartoletti",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Optimized uniform emulation",
    "OrgNrText": "673784",
    "InterAreaPrefix": "laborum",
    "DialInPrefix": "iure",
    "ZipPrefix": "laborum",
    "DomainName": "O'Connell, Romaguera and Stokes",
    "AddressLayoutId": 500,
    "DomesticAddressLayoutId": 386,
    "ForeignAddressLayoutId": 168,
    "Rank": 143,
    "Tooltip": "eos",
    "Deleted": false
  },
  "Persons": [
    {
      "Position": "quis",
      "PersonId": 887,
      "Mrmrs": "atque",
      "Firstname": "Forest",
      "Lastname": "Carter",
      "MiddleName": "Connelly-Runolfsson",
      "Title": "sit",
      "Description": "Persistent uniform leverage",
      "Email": "clare@miller.info",
      "FullName": "Stephen Bayer",
      "DirectPhone": "648-252-2888 x8686",
      "FormalName": "Nitzsche Inc and Sons",
      "CountryId": 155,
      "ContactId": 846,
      "ContactName": "Haley Inc and Sons",
      "Retired": 946,
      "Rank": 917,
      "ActiveInterests": 230,
      "ContactDepartment": "",
      "ContactCountryId": 101,
      "ContactOrgNr": "1015187",
      "FaxPhone": "537-468-1044 x43585",
      "MobilePhone": "223-061-0625 x400",
      "ContactPhone": "(154)125-7483 x4862",
      "AssociateName": "Thompson, Larkin and Wilderman",
      "AssociateId": 326,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "commodi",
      "Kanalname": "atque",
      "Post1": "beatae",
      "Post2": "quia",
      "Post3": "sequi",
      "EmailName": "patience.sipes@langworth.ca",
      "ContactFullName": "Eli Zieme",
      "ActiveErpLinks": 605,
      "TicketPriorityId": 747,
      "SupportLanguageId": 501,
      "SupportAssociateId": 751,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "inventore",
  "Xstop": false,
  "ActiveInterests": 701,
  "GroupId": 272,
  "ActiveStatusMonitorId": 941,
  "SupportAssociate": {
    "AssociateId": 326,
    "Name": "Breitenberg-Balistreri",
    "PersonId": 783,
    "Rank": 277,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 962,
    "FullName": "Wyatt Torphy",
    "FormalName": "Wolff, Veum and Abbott",
    "Deleted": true,
    "EjUserId": 343,
    "UserName": "Wyman LLC"
  },
  "TicketPriority": {
    "Id": 245,
    "Value": "ex",
    "Tooltip": "culpa"
  },
  "CustomerLanguage": {
    "Id": 127,
    "Value": "sed",
    "Tooltip": "blanditiis"
  },
  "Deleted": 725,
  "DbiAgentId": 851,
  "DbiLastSyncronized": "2019-08-12T18:25:50.2476268+02:00",
  "DbiKey": "eos",
  "DbiLastModified": "2008-07-07T18:25:50.2476268+02:00",
  "SupportPerson": {
    "Position": "impedit",
    "PersonId": 755,
    "Mrmrs": "voluptatum",
    "Firstname": "Alfreda",
    "Lastname": "Grimes",
    "MiddleName": "Moore, Stanton and Wiza",
    "Title": "inventore",
    "Description": "Fundamental executive algorithm",
    "Email": "reanna.hegmann@schmeler.uk",
    "FullName": "Breanne Stehr",
    "DirectPhone": "(074)042-5440",
    "FormalName": "Koelpin LLC",
    "CountryId": 372,
    "ContactId": 733,
    "ContactName": "Green Inc and Sons",
    "Retired": 497,
    "Rank": 98,
    "ActiveInterests": 693,
    "ContactDepartment": "",
    "ContactCountryId": 268,
    "ContactOrgNr": "791457",
    "FaxPhone": "100-068-3450 x34406",
    "MobilePhone": "1-478-703-8415 x565",
    "ContactPhone": "1-424-615-3322",
    "AssociateName": "Bradtke Group",
    "AssociateId": 698,
    "UsePersonAddress": false,
    "ContactFax": "sint",
    "Kanafname": "quis",
    "Kanalname": "esse",
    "Post1": "voluptas",
    "Post2": "quod",
    "Post3": "ab",
    "EmailName": "russell.glover@walsh.com",
    "ContactFullName": "Rosella Walker",
    "ActiveErpLinks": 106,
    "TicketPriorityId": 144,
    "SupportLanguageId": 36,
    "SupportAssociateId": 527,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 20311.453999999998,
    "Wgs84Longitude": 27037.018,
    "LocalizedAddress": [
      [
        {
          "Name": "Nader, Gleason and Schmeler",
          "Value": "consequuntur",
          "Tooltip": "iure",
          "Label": "qui",
          "ValueLength": 70,
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
              "FieldLength": 133
            }
          }
        }
      ],
      [
        {
          "Name": "Harvey Inc and Sons",
          "Value": "non",
          "Tooltip": "molestiae",
          "Label": "sint",
          "ValueLength": 268,
          "AddressType": "vel",
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
              "FieldLength": 784
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "occaecati"
  },
  "Source": 4,
  "ActiveErpLinks": 77,
  "BounceEmails": [
    "jermey@jewess.name",
    "kaci.kilback@morissetteledner.info"
  ],
  "Domains": [
    "illo",
    "velit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1454284047",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "quasi"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 285,
  "Name": "Wyman, Lebsack and Bergstrom",
  "Department": "",
  "OrgNr": "663390",
  "Number1": "1030108",
  "Number2": "1011282",
  "UpdatedDate": "1998-06-18T18:25:50.2566268+02:00",
  "CreatedDate": "1998-04-15T18:25:50.2566268+02:00",
  "Emails": [
    {
      "Value": "veniam",
      "StrippedValue": "asperiores",
      "Description": "Digitized neutral contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 666
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "asperiores",
      "Description": "Digitized neutral contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 666
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 952,
      "Name": "Wisozk Inc and Sons",
      "ToolTip": "Veniam quis fugiat voluptas.",
      "Deleted": true,
      "Rank": 315,
      "Type": "magni",
      "ColorBlock": 242,
      "IconHint": "sapiente",
      "Selected": true,
      "LastChanged": "1996-04-13T18:25:50.2566268+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "architecto",
      "StyleHint": "tempore",
      "Hidden": true,
      "FullName": "Arturo Roberts",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 185
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "eos",
      "Description": "Cross-group local instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "eos",
      "Description": "Cross-group local instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "perferendis",
      "StrippedValue": "aperiam",
      "Description": "Digitized exuding pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 923
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "aperiam",
      "Description": "Digitized exuding pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 923
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "praesentium",
      "StrippedValue": "minima",
      "Description": "Advanced explicit workforce",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "minima",
      "Description": "Advanced explicit workforce",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    }
  ],
  "Description": "Programmable solution-oriented product",
  "UpdatedBy": {
    "AssociateId": 652,
    "Name": "Cassin LLC",
    "PersonId": 454,
    "Rank": 229,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 99,
    "FullName": "Mark Maggio",
    "FormalName": "Hermiston, Gorczany and Schumm",
    "Deleted": false,
    "EjUserId": 285,
    "UserName": "Monahan-Zboncak",
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
  "CreatedBy": {
    "AssociateId": 108,
    "Name": "Roberts-Conn",
    "PersonId": 145,
    "Rank": 354,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 116,
    "FullName": "Mae Graham",
    "FormalName": "Feil, Koelpin and Welch",
    "Deleted": true,
    "EjUserId": 619,
    "UserName": "Schneider-Botsford",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 115
      }
    }
  },
  "Associate": {
    "AssociateId": 378,
    "Name": "Cruickshank LLC",
    "PersonId": 732,
    "Rank": 290,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 190,
    "FullName": "Garth Wilkinson",
    "FormalName": "Treutel Inc and Sons",
    "Deleted": true,
    "EjUserId": 245,
    "UserName": "Cronin-Prosacco",
    "TableRight": {},
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
  },
  "Business": {
    "Id": 319,
    "Value": "non",
    "Tooltip": "perferendis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 32
      }
    }
  },
  "Category": {
    "Id": 977,
    "Value": "aspernatur",
    "Tooltip": "eum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 552
      }
    }
  },
  "Country": {
    "CountryId": 51,
    "Name": "Mante, Gleichner and Hagenes",
    "CurrencyId": 440,
    "EnglishName": "Reichert-Crist",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Function-based grid-enabled groupware",
    "OrgNrText": "818314",
    "InterAreaPrefix": "et",
    "DialInPrefix": "quasi",
    "ZipPrefix": "aut",
    "DomainName": "Bosco Group",
    "AddressLayoutId": 840,
    "DomesticAddressLayoutId": 925,
    "ForeignAddressLayoutId": 333,
    "Rank": 431,
    "Tooltip": "dolores",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 62
      }
    }
  },
  "Persons": [
    {
      "Position": "voluptate",
      "PersonId": 478,
      "Mrmrs": "voluptates",
      "Firstname": "Omari",
      "Lastname": "Smith",
      "MiddleName": "Weimann LLC",
      "Title": "dolorum",
      "Description": "Down-sized fresh-thinking architecture",
      "Email": "walton@anderson.uk",
      "FullName": "Otha Rempel",
      "DirectPhone": "1-802-220-0667",
      "FormalName": "Conn-Hettinger",
      "CountryId": 162,
      "ContactId": 945,
      "ContactName": "Schuppe Inc and Sons",
      "Retired": 520,
      "Rank": 744,
      "ActiveInterests": 304,
      "ContactDepartment": "implement leading-edge communities",
      "ContactCountryId": 889,
      "ContactOrgNr": "462207",
      "FaxPhone": "1-525-668-6405 x3084",
      "MobilePhone": "415.007.5728 x078",
      "ContactPhone": "838.580.5835",
      "AssociateName": "Davis LLC",
      "AssociateId": 757,
      "UsePersonAddress": false,
      "ContactFax": "expedita",
      "Kanafname": "et",
      "Kanalname": "facilis",
      "Post1": "minima",
      "Post2": "aliquid",
      "Post3": "asperiores",
      "EmailName": "franco@ondricka.us",
      "ContactFullName": "Mrs. Israel Kunze",
      "ActiveErpLinks": 991,
      "TicketPriorityId": 420,
      "SupportLanguageId": 4,
      "SupportAssociateId": 504,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 890
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "exercitationem",
  "Xstop": true,
  "ActiveInterests": 334,
  "GroupId": 682,
  "ActiveStatusMonitorId": 245,
  "SupportAssociate": {
    "AssociateId": 561,
    "Name": "Stroman-Cole",
    "PersonId": 42,
    "Rank": 239,
    "Tooltip": "explicabo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 615,
    "FullName": "Zechariah Cronin",
    "FormalName": "Ernser-Pagac",
    "Deleted": true,
    "EjUserId": 647,
    "UserName": "Hills Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "disintermediate frictionless paradigms"
        },
        "FieldType": "System.Int32",
        "FieldLength": 596
      }
    }
  },
  "TicketPriority": {
    "Id": 129,
    "Value": "adipisci",
    "Tooltip": "voluptatibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 211
      }
    }
  },
  "CustomerLanguage": {
    "Id": 103,
    "Value": "quaerat",
    "Tooltip": "voluptas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 956
      }
    }
  },
  "Deleted": 720,
  "DbiAgentId": 480,
  "DbiLastSyncronized": "2020-08-01T18:25:50.2606246+02:00",
  "DbiKey": "sit",
  "DbiLastModified": "2007-07-24T18:25:50.2616185+02:00",
  "SupportPerson": {
    "Position": "enim",
    "PersonId": 47,
    "Mrmrs": "iure",
    "Firstname": "Jason",
    "Lastname": "Schmidt",
    "MiddleName": "Ryan, Kuhn and Wintheiser",
    "Title": "quam",
    "Description": "Diverse 24/7 flexibility",
    "Email": "gavin@darefeest.name",
    "FullName": "Savanah Lubowitz",
    "DirectPhone": "(233)848-1626",
    "FormalName": "Boehm, Kling and Reynolds",
    "CountryId": 301,
    "ContactId": 425,
    "ContactName": "Jaskolski-Hessel",
    "Retired": 918,
    "Rank": 471,
    "ActiveInterests": 898,
    "ContactDepartment": "",
    "ContactCountryId": 387,
    "ContactOrgNr": "947517",
    "FaxPhone": "1-722-715-1135 x7807",
    "MobilePhone": "1-834-186-7730 x4573",
    "ContactPhone": "867-123-8754 x247",
    "AssociateName": "Predovic, Koch and Harvey",
    "AssociateId": 97,
    "UsePersonAddress": false,
    "ContactFax": "animi",
    "Kanafname": "nesciunt",
    "Kanalname": "voluptatibus",
    "Post1": "voluptatum",
    "Post2": "dolor",
    "Post3": "recusandae",
    "EmailName": "pearl@prohaska.info",
    "ContactFullName": "Freddie Wolf",
    "ActiveErpLinks": 510,
    "TicketPriorityId": 944,
    "SupportLanguageId": 609,
    "SupportAssociateId": 598,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 714
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 18788.329999999998,
    "Wgs84Longitude": 5475.098,
    "LocalizedAddress": [
      [
        {
          "Name": "Beier-Kilback",
          "Value": "fugit",
          "Tooltip": "quia",
          "Label": "suscipit",
          "ValueLength": 908,
          "AddressType": "ab",
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
              "FieldLength": 73
            }
          }
        }
      ],
      [
        {
          "Name": "Howell-Legros",
          "Value": "ex",
          "Tooltip": "explicabo",
          "Label": "omnis",
          "ValueLength": 156,
          "AddressType": "sapiente",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "leverage interactive niches"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.Int32",
              "FieldLength": 588
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 874
      }
    }
  },
  "Source": 458,
  "ActiveErpLinks": 1000,
  "BounceEmails": [
    "lionel@cassinwisoky.co.uk",
    "luella@prosacco.com"
  ],
  "Domains": [
    "ut",
    "quis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2033664164",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "atque"
  },
  "CustomFields": {
    "CustomFields1": "dignissimos",
    "CustomFields2": "iure"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "expedite customized convergence"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 469
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```