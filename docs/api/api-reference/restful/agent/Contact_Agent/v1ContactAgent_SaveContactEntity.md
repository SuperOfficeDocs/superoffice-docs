---
title: SaveContactEntity
id: v1ContactAgent_SaveContactEntity
---

# SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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

## Request Body: entity  

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
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 954,
  "Name": "Labadie, Upton and Satterfield",
  "Department": "",
  "OrgNr": "511506",
  "Number1": "1389260",
  "Number2": "1368843",
  "UpdatedDate": "2008-01-22T14:58:03.5523105+01:00",
  "CreatedDate": "1998-01-10T14:58:03.5523105+01:00",
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "ab",
      "Description": "Multi-layered full-range approach"
    },
    {
      "Value": "dolorem",
      "StrippedValue": "ab",
      "Description": "Multi-layered full-range approach"
    }
  ],
  "Interests": [
    {
      "Id": 59,
      "Name": "Senger-Kassulke",
      "ToolTip": "Dolore facere reprehenderit ut iure sint exercitationem.",
      "Deleted": false,
      "Rank": 433,
      "Type": "sit",
      "ColorBlock": 860,
      "IconHint": "quam",
      "Selected": true,
      "LastChanged": "2004-04-09T14:58:03.5523105+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "impedit",
      "Hidden": true,
      "FullName": "Sibyl Fisher"
    }
  ],
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "consequuntur",
      "Description": "Networked tertiary flexibility"
    },
    {
      "Value": "beatae",
      "StrippedValue": "consequuntur",
      "Description": "Networked tertiary flexibility"
    }
  ],
  "Phones": [
    {
      "Value": "deleniti",
      "StrippedValue": "sit",
      "Description": "Reduced mobile success"
    },
    {
      "Value": "deleniti",
      "StrippedValue": "sit",
      "Description": "Reduced mobile success"
    }
  ],
  "Faxes": [
    {
      "Value": "quasi",
      "StrippedValue": "rerum",
      "Description": "Mandatory non-volatile initiative"
    },
    {
      "Value": "quasi",
      "StrippedValue": "rerum",
      "Description": "Mandatory non-volatile initiative"
    }
  ],
  "Description": "Profound directional analyzer",
  "UpdatedBy": {
    "AssociateId": 954,
    "Name": "Kiehn-Fritsch",
    "PersonId": 690,
    "Rank": 720,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 153,
    "FullName": "Elsie Ruecker",
    "FormalName": "Beier LLC",
    "Deleted": true,
    "EjUserId": 650,
    "UserName": "Steuber-Jacobs"
  },
  "CreatedBy": {
    "AssociateId": 722,
    "Name": "Reichel Inc and Sons",
    "PersonId": 65,
    "Rank": 627,
    "Tooltip": "ad",
    "Type": "AnonymousAssociate",
    "GroupIdx": 749,
    "FullName": "Precious Bradtke",
    "FormalName": "Bechtelar LLC",
    "Deleted": true,
    "EjUserId": 997,
    "UserName": "Cummings, Kovacek and Torp"
  },
  "Associate": {
    "AssociateId": 465,
    "Name": "Tremblay Inc and Sons",
    "PersonId": 913,
    "Rank": 886,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 275,
    "FullName": "Mackenzie Feeney",
    "FormalName": "Reilly-Becker",
    "Deleted": false,
    "EjUserId": 94,
    "UserName": "Gleichner-Predovic"
  },
  "Business": {
    "Id": 405,
    "Value": "molestias",
    "Tooltip": "repellat"
  },
  "Category": {
    "Id": 11,
    "Value": "nesciunt",
    "Tooltip": "et"
  },
  "Country": {
    "CountryId": 689,
    "Name": "Smith, Lueilwitz and Metz",
    "CurrencyId": 304,
    "EnglishName": "Ratke, Grant and Hodkiewicz",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Public-key transitional concept",
    "OrgNrText": "826193",
    "InterAreaPrefix": "et",
    "DialInPrefix": "doloremque",
    "ZipPrefix": "libero",
    "DomainName": "Doyle-Dibbert",
    "AddressLayoutId": 61,
    "DomesticAddressLayoutId": 831,
    "ForeignAddressLayoutId": 388,
    "Rank": 647,
    "Tooltip": "officiis",
    "Deleted": false
  },
  "Persons": [
    {
      "Position": "consectetur",
      "PersonId": 660,
      "Mrmrs": "est",
      "Firstname": "Golden",
      "Lastname": "Stracke",
      "MiddleName": "Rolfson Group",
      "Title": "quis",
      "Description": "Total 24 hour installation",
      "Email": "brenda@beer.us",
      "FullName": "Earlene West Sr.",
      "DirectPhone": "1-546-807-3536 x4564",
      "FormalName": "Mertz, Gorczany and Kutch",
      "CountryId": 292,
      "ContactId": 311,
      "ContactName": "Daugherty LLC",
      "Retired": 743,
      "Rank": 257,
      "ActiveInterests": 432,
      "ContactDepartment": "",
      "ContactCountryId": 497,
      "ContactOrgNr": "630953",
      "FaxPhone": "1-658-633-7657 x25744",
      "MobilePhone": "(456)775-7348 x056",
      "ContactPhone": "1-811-770-6732 x36638",
      "AssociateName": "Runolfsson-Douglas",
      "AssociateId": 770,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "suscipit",
      "Kanalname": "inventore",
      "Post1": "officia",
      "Post2": "molestiae",
      "Post3": "quia",
      "EmailName": "lorenzo@denesik.biz",
      "ContactFullName": "Obie Ratke",
      "ActiveErpLinks": 219,
      "TicketPriorityId": 533,
      "SupportLanguageId": 413,
      "SupportAssociateId": 37,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "esse",
  "Xstop": false,
  "ActiveInterests": 172,
  "GroupId": 826,
  "ActiveStatusMonitorId": 894,
  "SupportAssociate": {
    "AssociateId": 742,
    "Name": "Bashirian-Koch",
    "PersonId": 843,
    "Rank": 668,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 527,
    "FullName": "Summer Gleason",
    "FormalName": "Blick-Kris",
    "Deleted": false,
    "EjUserId": 73,
    "UserName": "Kulas, Goyette and D'Amore"
  },
  "TicketPriority": {
    "Id": 631,
    "Value": "eos",
    "Tooltip": "aspernatur"
  },
  "CustomerLanguage": {
    "Id": 117,
    "Value": "quia",
    "Tooltip": "quaerat"
  },
  "Deleted": 509,
  "DbiAgentId": 283,
  "DbiLastSyncronized": "2012-05-29T14:58:03.5563109+02:00",
  "DbiKey": "sint",
  "DbiLastModified": "2001-10-30T14:58:03.5563109+01:00",
  "SupportPerson": {
    "Position": "quia",
    "PersonId": 932,
    "Mrmrs": "harum",
    "Firstname": "Citlalli",
    "Lastname": "Franecki",
    "MiddleName": "Considine-Hills",
    "Title": "et",
    "Description": "Phased systemic Graphic Interface",
    "Email": "leone@wittinghilpert.us",
    "FullName": "Kevin Okuneva",
    "DirectPhone": "816-382-0504 x4584",
    "FormalName": "Jerde-Langosh",
    "CountryId": 781,
    "ContactId": 728,
    "ContactName": "Oberbrunner LLC",
    "Retired": 474,
    "Rank": 865,
    "ActiveInterests": 180,
    "ContactDepartment": "",
    "ContactCountryId": 771,
    "ContactOrgNr": "609768",
    "FaxPhone": "662-660-4210 x724",
    "MobilePhone": "866-048-7173 x836",
    "ContactPhone": "125-806-6622 x73725",
    "AssociateName": "Kassulke, Heathcote and Beier",
    "AssociateId": 58,
    "UsePersonAddress": false,
    "ContactFax": "alias",
    "Kanafname": "provident",
    "Kanalname": "animi",
    "Post1": "repudiandae",
    "Post2": "qui",
    "Post3": "veniam",
    "EmailName": "adolfo_kub@graham.com",
    "ContactFullName": "Imogene Crooks",
    "ActiveErpLinks": 90,
    "TicketPriorityId": 83,
    "SupportLanguageId": 526,
    "SupportAssociateId": 518,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 5030.07,
    "Wgs84Longitude": 30816.622,
    "LocalizedAddress": [
      [
        {
          "Name": "Hane-Okuneva",
          "Value": "aut",
          "Tooltip": "illum",
          "Label": "molestiae",
          "ValueLength": 85,
          "AddressType": "dolor",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "reinvent global users"
              },
              "FieldType": "System.Int32",
              "FieldLength": 586
            }
          }
        }
      ],
      [
        {
          "Name": "Farrell LLC",
          "Value": "rerum",
          "Tooltip": "culpa",
          "Label": "molestias",
          "ValueLength": 76,
          "AddressType": "facere",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "productize extensible deliverables"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 398
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "placeat"
  },
  "Source": 494,
  "ActiveErpLinks": 469,
  "BounceEmails": [
    "tyshawn@watsicatreutel.us",
    "viola.mcclure@goldner.info"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Adele Champlin",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "velit"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 734,
  "Name": "Stark Group",
  "Department": "",
  "OrgNr": "996198",
  "Number1": "1512995",
  "Number2": "1131746",
  "UpdatedDate": "2017-01-25T14:58:03.5663124+01:00",
  "CreatedDate": "2006-11-22T14:58:03.5663124+01:00",
  "Emails": [
    {
      "Value": "possimus",
      "StrippedValue": "consectetur",
      "Description": "Distributed leading edge process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 508
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "consectetur",
      "Description": "Distributed leading edge process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 508
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 137,
      "Name": "Gleason-Fritsch",
      "ToolTip": "Et corporis fuga.",
      "Deleted": false,
      "Rank": 136,
      "Type": "culpa",
      "ColorBlock": 55,
      "IconHint": "ad",
      "Selected": true,
      "LastChanged": "2020-03-21T14:58:03.5663124+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "esse",
      "Hidden": false,
      "FullName": "Dorris Bogisich",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "generate revolutionary ROI"
          },
          "FieldType": "System.Int32",
          "FieldLength": 525
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nisi",
      "StrippedValue": "vel",
      "Description": "Synergistic mission-critical infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 275
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "vel",
      "Description": "Synergistic mission-critical infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 275
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "tempora",
      "StrippedValue": "natus",
      "Description": "Cross-group upward-trending capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "cultivate value-added partnerships"
          },
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "natus",
      "Description": "Cross-group upward-trending capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "cultivate value-added partnerships"
          },
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolorem",
      "StrippedValue": "itaque",
      "Description": "Multi-channelled intangible migration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 710
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "itaque",
      "Description": "Multi-channelled intangible migration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 710
        }
      }
    }
  ],
  "Description": "Operative high-level intranet",
  "UpdatedBy": {
    "AssociateId": 442,
    "Name": "Littel Group",
    "PersonId": 601,
    "Rank": 645,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 581,
    "FullName": "Dr. Trever Luettgen",
    "FormalName": "Miller Group",
    "Deleted": true,
    "EjUserId": 326,
    "UserName": "Swaniawski-Kilback",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 282
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 649,
    "Name": "Rowe, Harris and Stark",
    "PersonId": 586,
    "Rank": 467,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 378,
    "FullName": "Jerad Mayer Sr.",
    "FormalName": "Funk, Kunze and Walter",
    "Deleted": false,
    "EjUserId": 598,
    "UserName": "Huels Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 806
      }
    }
  },
  "Associate": {
    "AssociateId": 674,
    "Name": "Russel, Rodriguez and Welch",
    "PersonId": 321,
    "Rank": 997,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 730,
    "FullName": "Jacquelyn Harber",
    "FormalName": "Hudson Inc and Sons",
    "Deleted": false,
    "EjUserId": 762,
    "UserName": "Kulas, Walsh and Dickinson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 686
      }
    }
  },
  "Business": {
    "Id": 582,
    "Value": "saepe",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 280
      }
    }
  },
  "Category": {
    "Id": 156,
    "Value": "sed",
    "Tooltip": "culpa",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 773
      }
    }
  },
  "Country": {
    "CountryId": 503,
    "Name": "Gleason Group",
    "CurrencyId": 5,
    "EnglishName": "Maggio-Powlowski",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Multi-channelled dynamic portal",
    "OrgNrText": "1660970",
    "InterAreaPrefix": "perspiciatis",
    "DialInPrefix": "esse",
    "ZipPrefix": "qui",
    "DomainName": "Hartmann-Beahan",
    "AddressLayoutId": 798,
    "DomesticAddressLayoutId": 395,
    "ForeignAddressLayoutId": 10,
    "Rank": 239,
    "Tooltip": "commodi",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 518
      }
    }
  },
  "Persons": [
    {
      "Position": "quis",
      "PersonId": 328,
      "Mrmrs": "et",
      "Firstname": "Eleazar",
      "Lastname": "Friesen",
      "MiddleName": "Price-Waelchi",
      "Title": "consectetur",
      "Description": "Multi-layered discrete pricing structure",
      "Email": "kaitlyn.stiedemann@gusikowski.uk",
      "FullName": "Savion Russel",
      "DirectPhone": "010.264.2641 x1561",
      "FormalName": "Nicolas, Cassin and Kiehn",
      "CountryId": 206,
      "ContactId": 531,
      "ContactName": "Smitham, Price and Bechtelar",
      "Retired": 2,
      "Rank": 780,
      "ActiveInterests": 3,
      "ContactDepartment": "",
      "ContactCountryId": 703,
      "ContactOrgNr": "964244",
      "FaxPhone": "1-041-355-6615 x242",
      "MobilePhone": "115.727.6271 x402",
      "ContactPhone": "(400)516-5182 x04643",
      "AssociateName": "McDermott-Funk",
      "AssociateId": 733,
      "UsePersonAddress": true,
      "ContactFax": "aut",
      "Kanafname": "ut",
      "Kanalname": "numquam",
      "Post1": "repellendus",
      "Post2": "doloribus",
      "Post3": "sed",
      "EmailName": "otho@champlin.biz",
      "ContactFullName": "Lupe Wintheiser",
      "ActiveErpLinks": 972,
      "TicketPriorityId": 179,
      "SupportLanguageId": 263,
      "SupportAssociateId": 759,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 909
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolore",
  "Xstop": true,
  "ActiveInterests": 842,
  "GroupId": 267,
  "ActiveStatusMonitorId": 600,
  "SupportAssociate": {
    "AssociateId": 416,
    "Name": "Zulauf Group",
    "PersonId": 798,
    "Rank": 802,
    "Tooltip": "tenetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 510,
    "FullName": "Wilton Gleason I",
    "FormalName": "Waelchi, Wolf and Bogan",
    "Deleted": true,
    "EjUserId": 660,
    "UserName": "Hudson, Conroy and Rosenbaum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 258
      }
    }
  },
  "TicketPriority": {
    "Id": 367,
    "Value": "non",
    "Tooltip": "sint",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 667
      }
    }
  },
  "CustomerLanguage": {
    "Id": 326,
    "Value": "neque",
    "Tooltip": "tempora",
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
  "Deleted": 907,
  "DbiAgentId": 702,
  "DbiLastSyncronized": "2004-07-12T14:58:03.5703101+02:00",
  "DbiKey": "ad",
  "DbiLastModified": "2015-02-13T14:58:03.5703101+01:00",
  "SupportPerson": {
    "Position": "est",
    "PersonId": 897,
    "Mrmrs": "reiciendis",
    "Firstname": "Dean",
    "Lastname": "Schoen",
    "MiddleName": "Walker Inc and Sons",
    "Title": "nobis",
    "Description": "Focused multi-state implementation",
    "Email": "jeremy.gaylord@feesthammes.com",
    "FullName": "Jessica Trantow",
    "DirectPhone": "(071)553-8186",
    "FormalName": "King, Johnston and Larkin",
    "CountryId": 758,
    "ContactId": 243,
    "ContactName": "Nienow Inc and Sons",
    "Retired": 954,
    "Rank": 14,
    "ActiveInterests": 617,
    "ContactDepartment": "",
    "ContactCountryId": 208,
    "ContactOrgNr": "679959",
    "FaxPhone": "004-340-1626 x5822",
    "MobilePhone": "1-587-871-4077 x280",
    "ContactPhone": "483-178-0421 x326",
    "AssociateName": "Kunde-Pouros",
    "AssociateId": 714,
    "UsePersonAddress": false,
    "ContactFax": "dolores",
    "Kanafname": "consequatur",
    "Kanalname": "quis",
    "Post1": "quos",
    "Post2": "tenetur",
    "Post3": "culpa",
    "EmailName": "buster@greenholt.info",
    "ContactFullName": "Merle Kshlerin II",
    "ActiveErpLinks": 410,
    "TicketPriorityId": 95,
    "SupportLanguageId": 585,
    "SupportAssociateId": 641,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 17
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 18290.023999999998,
    "Wgs84Longitude": 5876.25,
    "LocalizedAddress": [
      [
        {
          "Name": "Heidenreich Inc and Sons",
          "Value": "reprehenderit",
          "Tooltip": "similique",
          "Label": "mollitia",
          "ValueLength": 297,
          "AddressType": "sequi",
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
              "FieldLength": 482
            }
          }
        }
      ],
      [
        {
          "Name": "Reichert, Kuvalis and Abbott",
          "Value": "enim",
          "Tooltip": "delectus",
          "Label": "omnis",
          "ValueLength": 712,
          "AddressType": "dolores",
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
              "FieldLength": 835
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 115
      }
    }
  },
  "Source": 191,
  "ActiveErpLinks": 914,
  "BounceEmails": [
    "clemens@rath.name",
    "ryley@cassin.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "807818173",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "cupiditate"
  },
  "CustomFields": {
    "CustomFields1": "ipsa",
    "CustomFields2": "tempore"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "synthesize killer e-business"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 773
    }
  }
}
```