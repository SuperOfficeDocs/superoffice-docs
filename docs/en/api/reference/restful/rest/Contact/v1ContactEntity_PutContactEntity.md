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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 72,
  "Name": "Ebert, Crona and DuBuque",
  "Department": "target seamless mindshare",
  "OrgNr": "998078",
  "Number1": "594388",
  "Number2": "835477",
  "UpdatedDate": "2022-03-24T12:19:53.2274553+01:00",
  "CreatedDate": "1999-10-24T12:19:53.2274553+02:00",
  "Emails": [
    {
      "Value": "temporibus",
      "StrippedValue": "eos",
      "Description": "Synergistic web-enabled workforce"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "eos",
      "Description": "Synergistic web-enabled workforce"
    }
  ],
  "Interests": [
    {
      "Id": 843,
      "Name": "Pollich Group",
      "ToolTip": "Mollitia ea adipisci.",
      "Deleted": false,
      "Rank": 449,
      "Type": "ab",
      "ColorBlock": 781,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "1999-04-21T12:19:53.2274553+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "sint",
      "Hidden": true,
      "FullName": "Dino Kunde"
    }
  ],
  "Urls": [
    {
      "Value": "consequuntur",
      "StrippedValue": "molestiae",
      "Description": "Re-contextualized logistical concept"
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "molestiae",
      "Description": "Re-contextualized logistical concept"
    }
  ],
  "Phones": [
    {
      "Value": "corporis",
      "StrippedValue": "a",
      "Description": "Visionary value-added software"
    },
    {
      "Value": "corporis",
      "StrippedValue": "a",
      "Description": "Visionary value-added software"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "repellat",
      "Description": "Face to face holistic workforce"
    },
    {
      "Value": "et",
      "StrippedValue": "repellat",
      "Description": "Face to face holistic workforce"
    }
  ],
  "Description": "Polarised attitude-oriented encryption",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 591,
      "Mrmrs": "omnis",
      "Firstname": "Kim",
      "Lastname": "Daugherty",
      "MiddleName": "Pacocha-VonRueden",
      "Title": "consequatur",
      "Description": "Optimized exuding firmware",
      "Email": "georgiana@zemlak.biz",
      "FullName": "Bulah Dare",
      "DirectPhone": "159-817-9166 x26725",
      "FormalName": "Murphy, Rowe and Schinner",
      "CountryId": 771,
      "ContactId": 566,
      "ContactName": "Wyman-Pollich",
      "Retired": 468,
      "Rank": 822,
      "ActiveInterests": 853,
      "ContactDepartment": "",
      "ContactCountryId": 37,
      "ContactOrgNr": "1734279",
      "FaxPhone": "1-419-343-2817 x835",
      "MobilePhone": "313.808.2372",
      "ContactPhone": "484.041.8930",
      "AssociateName": "Pfeffer, West and Strosin",
      "AssociateId": 601,
      "UsePersonAddress": false,
      "ContactFax": "illum",
      "Kanafname": "mollitia",
      "Kanalname": "pariatur",
      "Post1": "laudantium",
      "Post2": "ducimus",
      "Post3": "porro",
      "EmailName": "kobe@hagenes.com",
      "ContactFullName": "Dr. Ebba Corwin",
      "ActiveErpLinks": 316,
      "TicketPriorityId": 625,
      "SupportLanguageId": 834,
      "SupportAssociateId": 479,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 146,
  "GroupId": 342,
  "ActiveStatusMonitorId": 302,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 682,
  "DbiAgentId": 676,
  "DbiLastSyncronized": "2015-11-02T12:19:53.2274553+01:00",
  "DbiKey": "illum",
  "DbiLastModified": "2012-08-03T12:19:53.2274553+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 725,
  "ActiveErpLinks": 677,
  "BounceEmails": [
    "jena@kohlereichmann.name",
    "stone@conroy.com"
  ],
  "Domains": [
    "soluta",
    "exercitationem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Gabriella Zemlak",
    "SuperOffice:2": "Willy Shannon Wolf Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "hic",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "odio"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 228,
  "Name": "Connelly Inc and Sons",
  "Department": "",
  "OrgNr": "1053568",
  "Number1": "1008752",
  "Number2": "534159",
  "UpdatedDate": "2022-03-03T12:19:53.2430797+01:00",
  "CreatedDate": "2012-01-29T12:19:53.2430797+01:00",
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "nobis",
      "Description": "Visionary foreground encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "nobis",
      "Description": "Visionary foreground encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 710,
      "Name": "Feest, Gusikowski and Hessel",
      "ToolTip": "Adipisci ducimus non cumque vel.",
      "Deleted": false,
      "Rank": 2,
      "Type": "incidunt",
      "ColorBlock": 316,
      "IconHint": "ea",
      "Selected": true,
      "LastChanged": "2000-11-24T12:19:53.2430797+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "aliquam",
      "Hidden": false,
      "FullName": "Miss Aimee Stoltenberg IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "laudantium",
      "Description": "Open-architected upward-trending capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "laudantium",
      "Description": "Open-architected upward-trending capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "natus",
      "StrippedValue": "quia",
      "Description": "Future-proofed mission-critical service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "quia",
      "Description": "Future-proofed mission-critical service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Object-based bi-directional Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Object-based bi-directional Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    }
  ],
  "Description": "Operative cohesive moderator",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "iure",
      "PersonId": 377,
      "Mrmrs": "deserunt",
      "Firstname": "Demetrius",
      "Lastname": "Hagenes",
      "MiddleName": "Wisozk-Kautzer",
      "Title": "reiciendis",
      "Description": "Customizable attitude-oriented adapter",
      "Email": "fiona.murphy@lang.name",
      "FullName": "Mr. Jadon America Graham",
      "DirectPhone": "1-467-947-0278",
      "FormalName": "Davis, Osinski and Lakin",
      "CountryId": 482,
      "ContactId": 606,
      "ContactName": "Runte, Mohr and Quitzon",
      "Retired": 433,
      "Rank": 229,
      "ActiveInterests": 648,
      "ContactDepartment": "synergize end-to-end mindshare",
      "ContactCountryId": 224,
      "ContactOrgNr": "150653",
      "FaxPhone": "313.732.1341",
      "MobilePhone": "349-218-3956 x939",
      "ContactPhone": "(744)233-3412 x42083",
      "AssociateName": "O'Hara, O'Reilly and Moen",
      "AssociateId": 631,
      "UsePersonAddress": false,
      "ContactFax": "expedita",
      "Kanafname": "quibusdam",
      "Kanalname": "maiores",
      "Post1": "vel",
      "Post2": "autem",
      "Post3": "animi",
      "EmailName": "eli@smithbogisich.info",
      "ContactFullName": "Lacy Treutel",
      "ActiveErpLinks": 867,
      "TicketPriorityId": 582,
      "SupportLanguageId": 617,
      "SupportAssociateId": 259,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 403,
  "GroupId": 47,
  "ActiveStatusMonitorId": 639,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 476,
  "DbiAgentId": 219,
  "DbiLastSyncronized": "2008-12-24T12:19:53.2430797+01:00",
  "DbiKey": "sequi",
  "DbiLastModified": "2008-02-10T12:19:53.2430797+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 724,
  "ActiveErpLinks": 190,
  "BounceEmails": [
    "cloyd@ebertkovacek.info",
    "tyler_ohara@homenick.uk"
  ],
  "Domains": [
    "rerum",
    "explicabo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Rosina Freda Batz",
    "SuperOffice:2": "Cara Graham"
  },
  "ExtraFields": {
    "ExtraFields1": "doloribus",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 612
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```