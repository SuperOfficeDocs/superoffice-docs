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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 153,
  "Name": "Kertzmann, Ryan and Bartoletti",
  "Department": "",
  "OrgNr": "593576",
  "Number1": "787061",
  "Number2": "1539206",
  "UpdatedDate": "2002-09-13T12:19:53.1962056+02:00",
  "CreatedDate": "2007-09-03T12:19:53.1962056+02:00",
  "Emails": [
    {
      "Value": "adipisci",
      "StrippedValue": "molestiae",
      "Description": "Phased human-resource algorithm"
    },
    {
      "Value": "adipisci",
      "StrippedValue": "molestiae",
      "Description": "Phased human-resource algorithm"
    }
  ],
  "Interests": [
    {
      "Id": 91,
      "Name": "Terry LLC",
      "ToolTip": "Nostrum consequatur porro rerum ipsam maxime non.",
      "Deleted": false,
      "Rank": 717,
      "Type": "mollitia",
      "ColorBlock": 217,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2022-04-25T12:19:53.1962056+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Alexzander Kub"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatum",
      "StrippedValue": "in",
      "Description": "Compatible bi-directional forecast"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "in",
      "Description": "Compatible bi-directional forecast"
    }
  ],
  "Phones": [
    {
      "Value": "laborum",
      "StrippedValue": "mollitia",
      "Description": "Visionary 6th generation database"
    },
    {
      "Value": "laborum",
      "StrippedValue": "mollitia",
      "Description": "Visionary 6th generation database"
    }
  ],
  "Faxes": [
    {
      "Value": "error",
      "StrippedValue": "quae",
      "Description": "Adaptive discrete emulation"
    },
    {
      "Value": "error",
      "StrippedValue": "quae",
      "Description": "Adaptive discrete emulation"
    }
  ],
  "Description": "Synergistic 6th generation open system",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "soluta",
      "PersonId": 314,
      "Mrmrs": "nulla",
      "Firstname": "Emmitt",
      "Lastname": "White",
      "MiddleName": "Crist, Berge and Bartell",
      "Title": "eum",
      "Description": "Reduced optimal encoding",
      "Email": "estevan.goyette@connelly.com",
      "FullName": "Marian Kennedi Boehm I",
      "DirectPhone": "(362)605-4537 x5004",
      "FormalName": "Dare, Luettgen and Considine",
      "CountryId": 431,
      "ContactId": 590,
      "ContactName": "Renner, Hartmann and Rippin",
      "Retired": 923,
      "Rank": 257,
      "ActiveInterests": 926,
      "ContactDepartment": "",
      "ContactCountryId": 501,
      "ContactOrgNr": "1235397",
      "FaxPhone": "(378)102-6477 x909",
      "MobilePhone": "1-214-454-2221",
      "ContactPhone": "672.797.5233 x352",
      "AssociateName": "Lubowitz-Feeney",
      "AssociateId": 771,
      "UsePersonAddress": true,
      "ContactFax": "rerum",
      "Kanafname": "animi",
      "Kanalname": "et",
      "Post1": "fugiat",
      "Post2": "architecto",
      "Post3": "quis",
      "EmailName": "adolphus@abbott.name",
      "ContactFullName": "Dr. Clemmie Thiel",
      "ActiveErpLinks": 525,
      "TicketPriorityId": 290,
      "SupportLanguageId": 281,
      "SupportAssociateId": 57,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "consequatur",
  "Xstop": false,
  "ActiveInterests": 415,
  "GroupId": 148,
  "ActiveStatusMonitorId": 204,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 795,
  "DbiAgentId": 606,
  "DbiLastSyncronized": "1999-09-07T12:19:53.1962056+02:00",
  "DbiKey": "sit",
  "DbiLastModified": "2004-09-11T12:19:53.1962056+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 407,
  "ActiveErpLinks": 896,
  "BounceEmails": [
    "stanford.keeling@jerde.us",
    "hester_dare@heathcotehodkiewicz.uk"
  ],
  "Domains": [
    "necessitatibus",
    "quibusdam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1641311478"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "itaque"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "voluptate"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 29,
  "Name": "Halvorson-O'Kon",
  "Department": "extend bleeding-edge interfaces",
  "OrgNr": "773024",
  "Number1": "1027525",
  "Number2": "495288",
  "UpdatedDate": "2022-12-15T12:19:53.2118339+01:00",
  "CreatedDate": "2006-10-26T12:19:53.2118339+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "voluptatem",
      "Description": "Centralized 5th generation encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "voluptatem",
      "Description": "Centralized 5th generation encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 340,
      "Name": "Dach, Cole and Satterfield",
      "ToolTip": "Quasi minima magni sed dolorum.",
      "Deleted": false,
      "Rank": 658,
      "Type": "dignissimos",
      "ColorBlock": 1001,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2004-05-02T12:19:53.2118339+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "architecto",
      "Hidden": false,
      "FullName": "Omer Miller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "facilis",
      "StrippedValue": "dignissimos",
      "Description": "Networked coherent function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 83
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "dignissimos",
      "Description": "Networked coherent function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 83
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "autem",
      "StrippedValue": "consectetur",
      "Description": "Customer-focused 6th generation internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 821
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "consectetur",
      "Description": "Customer-focused 6th generation internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 821
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "unde",
      "StrippedValue": "tenetur",
      "Description": "Self-enabling bandwidth-monitored methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "tenetur",
      "Description": "Self-enabling bandwidth-monitored methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    }
  ],
  "Description": "Horizontal explicit concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 945,
      "Mrmrs": "laborum",
      "Firstname": "Erna",
      "Lastname": "Harris",
      "MiddleName": "Harber-Gleason",
      "Title": "et",
      "Description": "Face to face background matrices",
      "Email": "germaine@mante.co.uk",
      "FullName": "Mrs. Colten Sanford DDS",
      "DirectPhone": "404.434.6818 x8000",
      "FormalName": "Yost, Towne and Russel",
      "CountryId": 93,
      "ContactId": 358,
      "ContactName": "Yundt-Kling",
      "Retired": 705,
      "Rank": 205,
      "ActiveInterests": 142,
      "ContactDepartment": "",
      "ContactCountryId": 381,
      "ContactOrgNr": "1525728",
      "FaxPhone": "1-283-875-5903 x34730",
      "MobilePhone": "(441)777-2245",
      "ContactPhone": "1-327-251-9686 x408",
      "AssociateName": "Wiegand-O'Conner",
      "AssociateId": 906,
      "UsePersonAddress": true,
      "ContactFax": "quo",
      "Kanafname": "veritatis",
      "Kanalname": "debitis",
      "Post1": "in",
      "Post2": "atque",
      "Post3": "amet",
      "EmailName": "rowland@brekke.info",
      "ContactFullName": "Prof. Tyshawn Zula Stracke",
      "ActiveErpLinks": 124,
      "TicketPriorityId": 3,
      "SupportLanguageId": 395,
      "SupportAssociateId": 946,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "qui",
  "Xstop": true,
  "ActiveInterests": 767,
  "GroupId": 849,
  "ActiveStatusMonitorId": 809,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 397,
  "DbiAgentId": 488,
  "DbiLastSyncronized": "2021-06-17T12:19:53.2118339+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "2014-07-22T12:19:53.2118339+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 912,
  "ActiveErpLinks": 836,
  "BounceEmails": [
    "golda.marvin@reynoldslarson.biz",
    "louie.collins@bode.us"
  ],
  "Domains": [
    "iusto",
    "doloremque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Berniece Smith",
    "SuperOffice:2": "232506735"
  },
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "quae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 870
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```