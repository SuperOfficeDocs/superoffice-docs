---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 343,
  "Name": "Leffler Inc and Sons",
  "Department": "",
  "OrgNr": "600102",
  "Number1": "388539",
  "Number2": "1409782",
  "UpdatedDate": "2014-10-06T14:23:46.1574569+02:00",
  "CreatedDate": "2005-10-20T14:23:46.1574569+02:00",
  "Emails": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "eum",
      "Description": "Networked homogeneous hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 837
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "eum",
      "Description": "Networked homogeneous hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 837
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 388,
      "Name": "Lindgren, Toy and Collins",
      "ToolTip": "Dolor rerum eum beatae.",
      "Deleted": false,
      "Rank": 449,
      "Type": "explicabo",
      "ColorBlock": 631,
      "IconHint": "illo",
      "Selected": true,
      "LastChanged": "2024-02-25T14:23:46.1574569+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reprehenderit",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Ila Murphy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 938
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "enim",
      "Description": "Synchronised bifurcated internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "enim",
      "Description": "Synchronised bifurcated internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "magnam",
      "StrippedValue": "asperiores",
      "Description": "Polarised object-oriented benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "asperiores",
      "Description": "Polarised object-oriented benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "ut",
      "Description": "Progressive heuristic analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "ut",
      "Description": "Progressive heuristic analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    }
  ],
  "Description": "Synergized composite attitude",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "fugit",
      "PersonId": 320,
      "Mrmrs": "iusto",
      "Firstname": "Lance",
      "Lastname": "Balistreri",
      "MiddleName": "Willms Group",
      "Title": "nesciunt",
      "Description": "Multi-lateral needs-based application",
      "Email": "daniela_boehm@cummingsbarton.ca",
      "FullName": "Brody Fay",
      "DirectPhone": "969.197.7669 x9390",
      "FormalName": "Stiedemann-Hodkiewicz",
      "CountryId": 882,
      "ContactId": 777,
      "ContactName": "Zieme Group",
      "Retired": 92,
      "Rank": 681,
      "ActiveInterests": 283,
      "ContactDepartment": "",
      "ContactCountryId": 993,
      "ContactOrgNr": "651532",
      "FaxPhone": "1-423-011-3627",
      "MobilePhone": "1-621-535-3283",
      "ContactPhone": "(334)156-0255 x9357",
      "AssociateName": "Eichmann-Stracke",
      "AssociateId": 524,
      "UsePersonAddress": false,
      "ContactFax": "quaerat",
      "Kanafname": "dolores",
      "Kanalname": "at",
      "Post1": "non",
      "Post2": "id",
      "Post3": "illum",
      "EmailName": "lenora_vandervort@trantow.biz",
      "ContactFullName": "Miss Raul Angus Reichel",
      "ActiveErpLinks": 765,
      "TicketPriorityId": 717,
      "SupportLanguageId": 562,
      "SupportAssociateId": 924,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 463
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "velit",
  "Xstop": false,
  "ActiveInterests": 821,
  "GroupId": 159,
  "ActiveStatusMonitorId": 967,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 380,
  "DbiAgentId": 706,
  "DbiLastSyncronized": "2004-12-13T14:23:46.1574569+01:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "1997-05-06T14:23:46.1574569+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 676,
  "ActiveErpLinks": 89,
  "BounceEmails": [
    "agustin.fisher@hintz.ca",
    "kirstin.okeefe@erdman.biz"
  ],
  "Domains": [
    "non",
    "sit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Antwan Osinski"
  },
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "ducimus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 978
    }
  }
}
```