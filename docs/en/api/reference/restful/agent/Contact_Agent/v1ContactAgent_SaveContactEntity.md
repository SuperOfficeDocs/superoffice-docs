---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

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

### Response body: ContactEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 546,
  "Name": "Abshire-Cassin",
  "Department": "syndicate seamless applications",
  "OrgNr": "1018223",
  "Number1": "541532",
  "Number2": "723520",
  "UpdatedDate": "2021-05-28T14:32:02.2649237+02:00",
  "CreatedDate": "2012-05-23T14:32:02.2649237+02:00",
  "Emails": [
    {
      "Value": "blanditiis",
      "StrippedValue": "perspiciatis",
      "Description": "Customer-focused non-volatile circuit"
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "perspiciatis",
      "Description": "Customer-focused non-volatile circuit"
    }
  ],
  "Interests": [
    {
      "Id": 663,
      "Name": "Heathcote, Anderson and Rutherford",
      "ToolTip": "Accusantium qui.",
      "Deleted": false,
      "Rank": 87,
      "Type": "labore",
      "ColorBlock": 682,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2010-07-18T14:32:02.2649237+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eum",
      "StyleHint": "fuga",
      "Hidden": true,
      "FullName": "Noel Berge"
    }
  ],
  "Urls": [
    {
      "Value": "dolorem",
      "StrippedValue": "perferendis",
      "Description": "Self-enabling bottom-line knowledge user"
    },
    {
      "Value": "dolorem",
      "StrippedValue": "perferendis",
      "Description": "Self-enabling bottom-line knowledge user"
    }
  ],
  "Phones": [
    {
      "Value": "debitis",
      "StrippedValue": "eligendi",
      "Description": "Re-engineered real-time task-force"
    },
    {
      "Value": "debitis",
      "StrippedValue": "eligendi",
      "Description": "Re-engineered real-time task-force"
    }
  ],
  "Faxes": [
    {
      "Value": "facere",
      "StrippedValue": "aliquam",
      "Description": "Universal cohesive complexity"
    },
    {
      "Value": "facere",
      "StrippedValue": "aliquam",
      "Description": "Universal cohesive complexity"
    }
  ],
  "Description": "Business-focused executive system engine",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 326,
      "Mrmrs": "recusandae",
      "Firstname": "Rosalinda",
      "Lastname": "Heathcote",
      "MiddleName": "Crist, Deckow and Goldner",
      "Title": "voluptatum",
      "Description": "Reduced optimal access",
      "Email": "sarina_carroll@satterfieldfisher.ca",
      "FullName": "Mr. Albina Mauricio Glover IV",
      "DirectPhone": "107.949.7311",
      "FormalName": "Pfeffer, Quitzon and Gusikowski",
      "CountryId": 427,
      "ContactId": 773,
      "ContactName": "Mayert LLC",
      "Retired": 437,
      "Rank": 186,
      "ActiveInterests": 617,
      "ContactDepartment": "",
      "ContactCountryId": 708,
      "ContactOrgNr": "1296790",
      "FaxPhone": "640-762-3361",
      "MobilePhone": "474-676-8028 x049",
      "ContactPhone": "311.352.9560",
      "AssociateName": "Hermann-Murphy",
      "AssociateId": 422,
      "UsePersonAddress": true,
      "ContactFax": "sed",
      "Kanafname": "ratione",
      "Kanalname": "et",
      "Post1": "doloribus",
      "Post2": "soluta",
      "Post3": "atque",
      "EmailName": "jermey.braun@langworthpouros.ca",
      "ContactFullName": "Natalia Gleason",
      "ActiveErpLinks": 761,
      "TicketPriorityId": 134,
      "SupportLanguageId": 900,
      "SupportAssociateId": 330,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1146632"
    }
  ],
  "NoMailing": false,
  "Kananame": "animi",
  "Xstop": false,
  "ActiveInterests": 932,
  "GroupId": 973,
  "ActiveStatusMonitorId": 790,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 223,
  "DbiAgentId": 888,
  "DbiLastSyncronized": "2019-08-18T14:32:02.2649237+02:00",
  "DbiKey": "quis",
  "DbiLastModified": "2010-10-31T14:32:02.2649237+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 609,
  "ActiveErpLinks": 561,
  "BounceEmails": [
    "kylee_swift@stamm.ca",
    "emmanuelle.rempel@wizasenger.co.uk"
  ],
  "Domains": [
    "at",
    "ea"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Muhammad Runte",
    "SuperOffice:2": "Mr. Emmalee Glover"
  },
  "ExtraFields": {
    "ExtraFields1": "odio",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "alias"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 413,
  "Name": "Hammes-Hoppe",
  "Department": "",
  "OrgNr": "944680",
  "Number1": "1356552",
  "Number2": "880462",
  "UpdatedDate": "2008-03-25T14:32:02.2805448+01:00",
  "CreatedDate": "2016-05-31T14:32:02.2805448+02:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "voluptate",
      "Description": "Progressive dynamic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 753
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "voluptate",
      "Description": "Progressive dynamic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 753
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 944,
      "Name": "Schultz-Abbott",
      "ToolTip": "Dolorem consequatur tenetur repudiandae sed aut veritatis recusandae.",
      "Deleted": true,
      "Rank": 873,
      "Type": "earum",
      "ColorBlock": 753,
      "IconHint": "quis",
      "Selected": false,
      "LastChanged": "2016-09-20T14:32:02.2805448+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "quos",
      "Hidden": false,
      "FullName": "Adelbert Emard",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ex",
      "StrippedValue": "ut",
      "Description": "Multi-tiered optimizing time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "ut",
      "Description": "Multi-tiered optimizing time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "libero",
      "Description": "Open-source systemic Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 676
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "libero",
      "Description": "Open-source systemic Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 676
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "asperiores",
      "StrippedValue": "voluptatem",
      "Description": "Implemented multimedia methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "voluptatem",
      "Description": "Implemented multimedia methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    }
  ],
  "Description": "Triple-buffered bandwidth-monitored pricing structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 408,
      "Mrmrs": "similique",
      "Firstname": "Khalil",
      "Lastname": "Fisher",
      "MiddleName": "Runte, Wisoky and Jacobs",
      "Title": "animi",
      "Description": "Front-line eco-centric structure",
      "Email": "burnice@buckridge.co.uk",
      "FullName": "Ricky Stanton",
      "DirectPhone": "1-800-482-1820 x69367",
      "FormalName": "Beer-Lynch",
      "CountryId": 984,
      "ContactId": 121,
      "ContactName": "Lakin, Collier and Ullrich",
      "Retired": 430,
      "Rank": 191,
      "ActiveInterests": 991,
      "ContactDepartment": "",
      "ContactCountryId": 674,
      "ContactOrgNr": "895574",
      "FaxPhone": "345-453-7154 x70692",
      "MobilePhone": "(838)718-4422 x45547",
      "ContactPhone": "1-452-002-3997",
      "AssociateName": "Jacobson-Walsh",
      "AssociateId": 46,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "libero",
      "Kanalname": "sunt",
      "Post1": "doloribus",
      "Post2": "labore",
      "Post3": "enim",
      "EmailName": "rahsaan@kilbackhilpert.com",
      "ContactFullName": "Mr. Josue Ciara Blanda",
      "ActiveErpLinks": 806,
      "TicketPriorityId": 157,
      "SupportLanguageId": 393,
      "SupportAssociateId": 319,
      "CategoryName": "VIP Customer",
      "PersonNumber": "592008",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "enim",
  "Xstop": false,
  "ActiveInterests": 891,
  "GroupId": 457,
  "ActiveStatusMonitorId": 545,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 119,
  "DbiAgentId": 339,
  "DbiLastSyncronized": "2002-07-10T14:32:02.2805448+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "2020-09-19T14:32:02.2805448+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 63,
  "ActiveErpLinks": 902,
  "BounceEmails": [
    "berta_champlin@osinski.co.uk",
    "anabelle@batz.info"
  ],
  "Domains": [
    "eveniet",
    "consequatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Lera Roob",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "adipisci"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 292
    }
  }
}
```