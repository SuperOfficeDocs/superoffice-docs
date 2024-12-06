---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 374,
  "Name": "Vandervort-Upton",
  "Department": "",
  "OrgNr": "1149500",
  "Number1": "822641",
  "Number2": "1585925",
  "UpdatedDate": "2018-02-12T10:18:00.2855716+01:00",
  "CreatedDate": "2012-12-11T10:18:00.2855716+01:00",
  "Emails": [
    {
      "Value": "doloribus",
      "StrippedValue": "ullam",
      "Description": "Enterprise-wide zero defect firmware"
    },
    {
      "Value": "doloribus",
      "StrippedValue": "ullam",
      "Description": "Enterprise-wide zero defect firmware"
    }
  ],
  "Interests": [
    {
      "Id": 41,
      "Name": "Schaefer Group",
      "ToolTip": "Quasi harum autem ex voluptatem.",
      "Deleted": false,
      "Rank": 804,
      "Type": "doloribus",
      "ColorBlock": 426,
      "IconHint": "in",
      "Selected": true,
      "LastChanged": "2024-03-10T10:18:00.2855716+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Oswaldo Eichmann"
    }
  ],
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "enim",
      "Description": "Fundamental responsive task-force"
    },
    {
      "Value": "in",
      "StrippedValue": "enim",
      "Description": "Fundamental responsive task-force"
    }
  ],
  "Phones": [
    {
      "Value": "repellendus",
      "StrippedValue": "occaecati",
      "Description": "Intuitive uniform implementation"
    },
    {
      "Value": "repellendus",
      "StrippedValue": "occaecati",
      "Description": "Intuitive uniform implementation"
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "consequatur",
      "Description": "Enterprise-wide bottom-line success"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "consequatur",
      "Description": "Enterprise-wide bottom-line success"
    }
  ],
  "Description": "Versatile disintermediate algorithm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "in",
      "PersonId": 55,
      "Mrmrs": "libero",
      "Firstname": "Iva",
      "Lastname": "Schamberger",
      "MiddleName": "Sauer Inc and Sons",
      "Title": "nam",
      "Description": "Advanced eco-centric analyzer",
      "Email": "meta@altenwerth.us",
      "FullName": "Cesar Nienow",
      "DirectPhone": "817-824-5575 x36652",
      "FormalName": "Schinner LLC",
      "CountryId": 207,
      "ContactId": 641,
      "ContactName": "Bernhard Group",
      "Retired": 806,
      "Rank": 152,
      "ActiveInterests": 808,
      "ContactDepartment": "",
      "ContactCountryId": 282,
      "ContactOrgNr": "746969",
      "FaxPhone": "584.642.3364 x2569",
      "MobilePhone": "295-074-5059",
      "ContactPhone": "(558)992-1942",
      "AssociateName": "Heaney LLC",
      "AssociateId": 353,
      "UsePersonAddress": true,
      "ContactFax": "tenetur",
      "Kanafname": "ut",
      "Kanalname": "repudiandae",
      "Post1": "alias",
      "Post2": "qui",
      "Post3": "ut",
      "EmailName": "mason@jewess.info",
      "ContactFullName": "Macey Schuppe",
      "ActiveErpLinks": 502,
      "TicketPriorityId": 608,
      "SupportLanguageId": 593,
      "SupportAssociateId": 857,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "temporibus",
  "Xstop": false,
  "ActiveInterests": 902,
  "GroupId": 293,
  "ActiveStatusMonitorId": 757,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 273,
  "DbiAgentId": 803,
  "DbiLastSyncronized": "2014-04-13T10:18:00.2855716+02:00",
  "DbiKey": "quo",
  "DbiLastModified": "2017-02-28T10:18:00.2855716+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 760,
  "ActiveErpLinks": 731,
  "BounceEmails": [
    "isadore.senger@rohanreichert.ca",
    "susana_rosenbaum@bergstrom.uk"
  ],
  "Domains": [
    "atque",
    "accusamus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1896836995",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "sapiente"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "molestiae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 230,
  "Name": "Bergnaum LLC",
  "Department": "",
  "OrgNr": "670712",
  "Number1": "1741715",
  "Number2": "1327512",
  "UpdatedDate": "2019-05-01T10:18:00.3011917+02:00",
  "CreatedDate": "2000-04-11T10:18:00.3011917+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "odit",
      "Description": "User-friendly demand-driven conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "odit",
      "Description": "User-friendly demand-driven conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 113,
      "Name": "Walker, Rogahn and Mosciski",
      "ToolTip": "Debitis a optio vitae voluptas fugiat.",
      "Deleted": false,
      "Rank": 493,
      "Type": "laboriosam",
      "ColorBlock": 849,
      "IconHint": "maxime",
      "Selected": false,
      "LastChanged": "2004-10-13T10:18:00.3011917+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "recusandae",
      "StyleHint": "inventore",
      "Hidden": false,
      "FullName": "Luciano Schultz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 702
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fugit",
      "StrippedValue": "consequatur",
      "Description": "Seamless reciprocal ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "consequatur",
      "Description": "Seamless reciprocal ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "perferendis",
      "StrippedValue": "similique",
      "Description": "Visionary holistic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "similique",
      "Description": "Visionary holistic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quo",
      "StrippedValue": "dignissimos",
      "Description": "Right-sized full-range intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 434
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "dignissimos",
      "Description": "Right-sized full-range intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 434
        }
      }
    }
  ],
  "Description": "Synergistic radical website",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptates",
      "PersonId": 814,
      "Mrmrs": "repellat",
      "Firstname": "Earnest",
      "Lastname": "Legros",
      "MiddleName": "Marquardt-Hessel",
      "Title": "dolor",
      "Description": "Visionary didactic conglomeration",
      "Email": "flavie@wizaledner.co.uk",
      "FullName": "Blair Roberts",
      "DirectPhone": "(960)069-4800",
      "FormalName": "Klein LLC",
      "CountryId": 575,
      "ContactId": 330,
      "ContactName": "Kovacek, Mante and Treutel",
      "Retired": 246,
      "Rank": 109,
      "ActiveInterests": 746,
      "ContactDepartment": "",
      "ContactCountryId": 518,
      "ContactOrgNr": "246066",
      "FaxPhone": "220.888.3186",
      "MobilePhone": "1-878-093-7594",
      "ContactPhone": "579.562.5806 x1533",
      "AssociateName": "Feil Inc and Sons",
      "AssociateId": 92,
      "UsePersonAddress": true,
      "ContactFax": "sunt",
      "Kanafname": "in",
      "Kanalname": "consequatur",
      "Post1": "impedit",
      "Post2": "alias",
      "Post3": "sed",
      "EmailName": "korbin_grady@sanford.uk",
      "ContactFullName": "Susanna Pacocha",
      "ActiveErpLinks": 486,
      "TicketPriorityId": 954,
      "SupportLanguageId": 858,
      "SupportAssociateId": 157,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aliquid",
  "Xstop": true,
  "ActiveInterests": 260,
  "GroupId": 429,
  "ActiveStatusMonitorId": 99,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 41,
  "DbiAgentId": 581,
  "DbiLastSyncronized": "2020-06-05T10:18:00.3011917+02:00",
  "DbiKey": "architecto",
  "DbiLastModified": "2003-11-03T10:18:00.3011917+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 5,
  "ActiveErpLinks": 77,
  "BounceEmails": [
    "micheal.ullrich@vonruedenmohr.name",
    "alicia@hermanabshire.us"
  ],
  "Domains": [
    "sed",
    "at"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Donny Braun",
    "SuperOffice:2": "101693429"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "similique"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 577
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```