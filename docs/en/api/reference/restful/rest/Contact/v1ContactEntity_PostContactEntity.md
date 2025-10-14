---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
content_type: reference
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.
NsApiSlow threshold: 2000 ms.






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
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntityWithLinks

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
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 599,
  "Name": "Davis Group",
  "Department": "",
  "OrgNr": "1575415",
  "Number1": "1491094",
  "Number2": "757644",
  "UpdatedDate": "1998-12-12T03:40:55.4443154+01:00",
  "CreatedDate": "2019-08-31T03:40:55.4443154+02:00",
  "Emails": [
    {
      "Value": "corporis",
      "StrippedValue": "nostrum",
      "Description": "Adaptive non-volatile secured line"
    },
    {
      "Value": "corporis",
      "StrippedValue": "nostrum",
      "Description": "Adaptive non-volatile secured line"
    }
  ],
  "Interests": [
    {
      "Id": 9,
      "Name": "Feest, Dooley and Johnson",
      "ToolTip": "Magni omnis id est distinctio quod praesentium ipsam.",
      "Deleted": true,
      "Rank": 143,
      "Type": "ipsum",
      "ColorBlock": 580,
      "IconHint": "occaecati",
      "Selected": false,
      "LastChanged": "2022-08-08T03:40:55.4443154+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quae",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Kendall Schamberger"
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "magnam",
      "Description": "Front-line assymetric interface"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "magnam",
      "Description": "Front-line assymetric interface"
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "accusantium",
      "Description": "User-friendly content-based interface"
    },
    {
      "Value": "quia",
      "StrippedValue": "accusantium",
      "Description": "User-friendly content-based interface"
    }
  ],
  "Faxes": [
    {
      "Value": "illum",
      "StrippedValue": "debitis",
      "Description": "Synergized methodical extranet"
    },
    {
      "Value": "illum",
      "StrippedValue": "debitis",
      "Description": "Synergized methodical extranet"
    }
  ],
  "Description": "Cross-group national task-force",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "saepe",
      "PersonId": 132,
      "Mrmrs": "ut",
      "Firstname": "Vickie",
      "Lastname": "Crist",
      "MiddleName": "Fisher-Nader",
      "Title": "occaecati",
      "Description": "Right-sized executive time-frame",
      "Email": "flossie_zulauf@schuppeheathcote.com",
      "FullName": "Pamela Wolf",
      "DirectPhone": "1-777-082-8748",
      "FormalName": "Schimmel Group",
      "CountryId": 533,
      "ContactId": 172,
      "ContactName": "Hills-White",
      "Retired": 431,
      "Rank": 504,
      "ActiveInterests": 750,
      "ContactDepartment": "",
      "ContactCountryId": 124,
      "ContactOrgNr": "1545481",
      "FaxPhone": "1-632-157-5201",
      "MobilePhone": "514-155-9350 x4640",
      "ContactPhone": "1-561-268-1414",
      "AssociateName": "Veum Inc and Sons",
      "AssociateId": 564,
      "UsePersonAddress": false,
      "ContactFax": "consequuntur",
      "Kanafname": "at",
      "Kanalname": "pariatur",
      "Post1": "aperiam",
      "Post2": "voluptatibus",
      "Post3": "nobis",
      "EmailName": "jamil.klein@baumbach.uk",
      "ContactFullName": "Else Russel",
      "ActiveErpLinks": 289,
      "TicketPriorityId": 863,
      "SupportLanguageId": 707,
      "SupportAssociateId": 731,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1054267"
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": true,
  "ActiveInterests": 152,
  "GroupId": 414,
  "ActiveStatusMonitorId": 850,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 229,
  "DbiAgentId": 93,
  "DbiLastSyncronized": "2021-12-30T03:40:55.4443154+01:00",
  "DbiKey": "aut",
  "DbiLastModified": "2013-11-24T03:40:55.4443154+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 388,
  "ActiveErpLinks": 410,
  "BounceEmails": [
    "itzel@watersflatley.co.uk",
    "ruthe_marquardt@tillmanleffler.info"
  ],
  "Domains": [
    "saepe",
    "ut"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Keeley Langworth DVM",
    "SuperOffice:2": "1260118134"
  },
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "voluptas"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 17,
  "Name": "Lehner LLC",
  "Department": "",
  "OrgNr": "1286470",
  "Number1": "829982",
  "Number2": "1548568",
  "UpdatedDate": "2015-04-24T03:40:55.4599408+02:00",
  "CreatedDate": "2009-08-26T03:40:55.4599408+02:00",
  "Emails": [
    {
      "Value": "odit",
      "StrippedValue": "facere",
      "Description": "Open-architected bifurcated encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 584
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "facere",
      "Description": "Open-architected bifurcated encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 584
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 489,
      "Name": "Goyette Inc and Sons",
      "ToolTip": "Nemo fugiat doloremque neque.",
      "Deleted": true,
      "Rank": 328,
      "Type": "impedit",
      "ColorBlock": 433,
      "IconHint": "consequuntur",
      "Selected": true,
      "LastChanged": "2007-08-20T03:40:55.4599408+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "vitae",
      "Hidden": true,
      "FullName": "Ezequiel Pfannerstill",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 445
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "pariatur",
      "StrippedValue": "voluptatem",
      "Description": "Multi-channelled 4th generation firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 926
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "voluptatem",
      "Description": "Multi-channelled 4th generation firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 926
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "ab",
      "Description": "Secured global matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ab",
      "Description": "Secured global matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "reiciendis",
      "StrippedValue": "ratione",
      "Description": "Face to face disintermediate function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "ratione",
      "Description": "Face to face disintermediate function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    }
  ],
  "Description": "Face to face heuristic hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nulla",
      "PersonId": 368,
      "Mrmrs": "quidem",
      "Firstname": "Carley",
      "Lastname": "Veum",
      "MiddleName": "Prohaska Inc and Sons",
      "Title": "eos",
      "Description": "Fully-configurable attitude-oriented customer loyalty",
      "Email": "yasmin.orn@boscoanderson.info",
      "FullName": "Barney Ritchie",
      "DirectPhone": "(286)144-6096 x43983",
      "FormalName": "Feeney, Wunsch and Quigley",
      "CountryId": 301,
      "ContactId": 885,
      "ContactName": "Mueller LLC",
      "Retired": 401,
      "Rank": 882,
      "ActiveInterests": 18,
      "ContactDepartment": "",
      "ContactCountryId": 641,
      "ContactOrgNr": "1097988",
      "FaxPhone": "(672)806-7292 x4725",
      "MobilePhone": "1-663-862-6954 x00233",
      "ContactPhone": "1-408-965-1630 x718",
      "AssociateName": "Jacobs Group",
      "AssociateId": 996,
      "UsePersonAddress": true,
      "ContactFax": "consequatur",
      "Kanafname": "quibusdam",
      "Kanalname": "consequatur",
      "Post1": "qui",
      "Post2": "accusantium",
      "Post3": "non",
      "EmailName": "lon.lockman@hermannbarrows.com",
      "ContactFullName": "Ms. Marlee Walker DVM",
      "ActiveErpLinks": 566,
      "TicketPriorityId": 316,
      "SupportLanguageId": 350,
      "SupportAssociateId": 313,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1161351",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 396
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "sint",
  "Xstop": false,
  "ActiveInterests": 938,
  "GroupId": 420,
  "ActiveStatusMonitorId": 441,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 354,
  "DbiAgentId": 112,
  "DbiLastSyncronized": "2023-07-14T03:40:55.4599408+02:00",
  "DbiKey": "totam",
  "DbiLastModified": "2004-12-13T03:40:55.4599408+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 593,
  "ActiveErpLinks": 714,
  "BounceEmails": [
    "ethyl@littlecollins.uk",
    "darwin@okeefeerdman.info"
  ],
  "Domains": [
    "et",
    "cum"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Jan Jenkins",
    "SuperOffice:2": "Miss Stan Kling Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 98
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```