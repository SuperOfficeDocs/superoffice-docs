---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

## Request Body: entity 

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

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 429,
  "Name": "Trantow Group",
  "Department": "",
  "OrgNr": "1123584",
  "Number1": "1376613",
  "Number2": "471257",
  "UpdatedDate": "2007-07-21T14:13:48.5226646+02:00",
  "CreatedDate": "2015-06-20T14:13:48.5226646+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "Persevering multimedia artificial intelligence"
    },
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "Persevering multimedia artificial intelligence"
    }
  ],
  "Interests": [
    {
      "Id": 849,
      "Name": "Rau, Vandervort and Beahan",
      "ToolTip": "Molestias qui.",
      "Deleted": true,
      "Rank": 418,
      "Type": "voluptatibus",
      "ColorBlock": 727,
      "IconHint": "tenetur",
      "Selected": true,
      "LastChanged": "2014-07-17T14:13:48.5226646+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "numquam",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Jaime Schneider"
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "vero",
      "Description": "Open-source well-modulated encryption"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "vero",
      "Description": "Open-source well-modulated encryption"
    }
  ],
  "Phones": [
    {
      "Value": "non",
      "StrippedValue": "voluptas",
      "Description": "Reverse-engineered clear-thinking Graphical User Interface"
    },
    {
      "Value": "non",
      "StrippedValue": "voluptas",
      "Description": "Reverse-engineered clear-thinking Graphical User Interface"
    }
  ],
  "Faxes": [
    {
      "Value": "eveniet",
      "StrippedValue": "officiis",
      "Description": "Right-sized non-volatile info-mediaries"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "officiis",
      "Description": "Right-sized non-volatile info-mediaries"
    }
  ],
  "Description": "Fundamental fresh-thinking success",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "maiores",
      "PersonId": 323,
      "Mrmrs": "ut",
      "Firstname": "Colten",
      "Lastname": "Zboncak",
      "MiddleName": "Wilkinson Inc and Sons",
      "Title": "fuga",
      "Description": "Front-line contextually-based toolset",
      "Email": "ambrose@spencer.name",
      "FullName": "Dr. Alexandre Evert Bahringer IV",
      "DirectPhone": "1-204-155-1133 x5535",
      "FormalName": "Johns Inc and Sons",
      "CountryId": 12,
      "ContactId": 972,
      "ContactName": "Crist-Hoppe",
      "Retired": 947,
      "Rank": 5,
      "ActiveInterests": 430,
      "ContactDepartment": "",
      "ContactCountryId": 689,
      "ContactOrgNr": "1356789",
      "FaxPhone": "1-813-390-1373",
      "MobilePhone": "576-985-3365 x8225",
      "ContactPhone": "(806)318-8116",
      "AssociateName": "Lubowitz Group",
      "AssociateId": 366,
      "UsePersonAddress": false,
      "ContactFax": "soluta",
      "Kanafname": "est",
      "Kanalname": "possimus",
      "Post1": "rerum",
      "Post2": "officia",
      "Post3": "sint",
      "EmailName": "orlando_boyer@klein.com",
      "ContactFullName": "Ransom Legros",
      "ActiveErpLinks": 505,
      "TicketPriorityId": 887,
      "SupportLanguageId": 8,
      "SupportAssociateId": 922,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1416620"
    }
  ],
  "NoMailing": true,
  "Kananame": "tenetur",
  "Xstop": false,
  "ActiveInterests": 935,
  "GroupId": 222,
  "ActiveStatusMonitorId": 694,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 316,
  "DbiAgentId": 13,
  "DbiLastSyncronized": "2005-10-20T14:13:48.5382858+02:00",
  "DbiKey": "temporibus",
  "DbiLastModified": "2001-07-28T14:13:48.5382858+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 345,
  "ActiveErpLinks": 87,
  "BounceEmails": [
    "kaleigh@labadie.biz",
    "amalia@franecki.us"
  ],
  "Domains": [
    "fuga",
    "sit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Robert Lind",
    "SuperOffice:2": "124651414"
  },
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "consequatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 85,
  "Name": "Bartoletti LLC",
  "Department": "",
  "OrgNr": "234912",
  "Number1": "1294928",
  "Number2": "1352129",
  "UpdatedDate": "2008-10-13T14:13:48.5382858+02:00",
  "CreatedDate": "2021-11-24T14:13:48.5382858+01:00",
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "veritatis",
      "Description": "Mandatory bottom-line neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "veritatis",
      "Description": "Mandatory bottom-line neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 381,
      "Name": "Champlin-Roob",
      "ToolTip": "Culpa harum reprehenderit ullam molestias fugiat qui rerum.",
      "Deleted": false,
      "Rank": 256,
      "Type": "molestiae",
      "ColorBlock": 210,
      "IconHint": "dolores",
      "Selected": false,
      "LastChanged": "2019-12-14T14:13:48.5382858+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugit",
      "StyleHint": "numquam",
      "Hidden": false,
      "FullName": "Cale Kozey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "unde",
      "Description": "Front-line mobile migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 411
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "unde",
      "Description": "Front-line mobile migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 411
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "in",
      "StrippedValue": "velit",
      "Description": "Synergistic zero defect synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 302
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "velit",
      "Description": "Synergistic zero defect synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 302
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nulla",
      "StrippedValue": "quia",
      "Description": "Reverse-engineered actuating support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "quia",
      "Description": "Reverse-engineered actuating support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    }
  ],
  "Description": "Expanded upward-trending database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "a",
      "PersonId": 720,
      "Mrmrs": "qui",
      "Firstname": "Jailyn",
      "Lastname": "Swift",
      "MiddleName": "Kerluke, Kautzer and Huels",
      "Title": "sed",
      "Description": "Total system-worthy interface",
      "Email": "cordell@hodkiewicz.co.uk",
      "FullName": "Prof. Addie Darion Mueller Sr.",
      "DirectPhone": "1-630-107-3450",
      "FormalName": "Weimann, Hudson and Towne",
      "CountryId": 2,
      "ContactId": 550,
      "ContactName": "Klocko LLC",
      "Retired": 515,
      "Rank": 259,
      "ActiveInterests": 459,
      "ContactDepartment": "",
      "ContactCountryId": 12,
      "ContactOrgNr": "473764",
      "FaxPhone": "1-313-960-3208 x2618",
      "MobilePhone": "693-869-1903 x424",
      "ContactPhone": "327-144-1059",
      "AssociateName": "Powlowski-Schowalter",
      "AssociateId": 928,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "dolor",
      "Kanalname": "quos",
      "Post1": "ipsum",
      "Post2": "sit",
      "Post3": "doloremque",
      "EmailName": "fermin@marks.uk",
      "ContactFullName": "May Lynch",
      "ActiveErpLinks": 631,
      "TicketPriorityId": 955,
      "SupportLanguageId": 138,
      "SupportAssociateId": 605,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1032763",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "laudantium",
  "Xstop": false,
  "ActiveInterests": 682,
  "GroupId": 548,
  "ActiveStatusMonitorId": 245,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 865,
  "DbiAgentId": 406,
  "DbiLastSyncronized": "1998-05-28T14:13:48.5539074+02:00",
  "DbiKey": "omnis",
  "DbiLastModified": "2018-09-10T14:13:48.5539074+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 332,
  "ActiveErpLinks": 993,
  "BounceEmails": [
    "greyson_mertz@vandervort.uk",
    "alec@lubowitz.com"
  ],
  "Domains": [
    "et",
    "necessitatibus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Elta Jenkins",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "quas",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 313
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```