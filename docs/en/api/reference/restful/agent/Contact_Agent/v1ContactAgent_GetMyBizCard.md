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
  "ContactId": 550,
  "Name": "Hudson Inc and Sons",
  "Department": "",
  "OrgNr": "735218",
  "Number1": "519815",
  "Number2": "397141",
  "UpdatedDate": "2019-04-07T13:28:22.288659+02:00",
  "CreatedDate": "2020-02-19T13:28:22.288659+01:00",
  "Emails": [
    {
      "Value": "fuga",
      "StrippedValue": "consectetur",
      "Description": "Proactive object-oriented leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "consectetur",
      "Description": "Proactive object-oriented leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 123,
      "Name": "Bechtelar, Moore and Lueilwitz",
      "ToolTip": "Nostrum neque cum vitae.",
      "Deleted": true,
      "Rank": 520,
      "Type": "expedita",
      "ColorBlock": 465,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2013-05-18T13:28:22.288659+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tenetur",
      "StyleHint": "cum",
      "Hidden": false,
      "FullName": "Miss Scottie Jenkins V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 432
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "nam",
      "Description": "Fundamental dynamic Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "nam",
      "Description": "Fundamental dynamic Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "possimus",
      "StrippedValue": "ad",
      "Description": "Managed local core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "ad",
      "Description": "Managed local core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "aliquam",
      "Description": "Grass-roots non-volatile product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 794
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "aliquam",
      "Description": "Grass-roots non-volatile product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 794
        }
      }
    }
  ],
  "Description": "Ameliorated holistic architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 255,
      "Mrmrs": "quia",
      "Firstname": "Leanne",
      "Lastname": "Tillman",
      "MiddleName": "Baumbach, Gleichner and Conroy",
      "Title": "quaerat",
      "Description": "Exclusive methodical framework",
      "Email": "beulah_prosacco@abernathy.info",
      "FullName": "Audrey Denesik",
      "DirectPhone": "109.051.6462 x249",
      "FormalName": "Cummerata, Schuster and Fahey",
      "CountryId": 293,
      "ContactId": 81,
      "ContactName": "Baumbach, Kiehn and Streich",
      "Retired": 106,
      "Rank": 574,
      "ActiveInterests": 328,
      "ContactDepartment": "",
      "ContactCountryId": 729,
      "ContactOrgNr": "1501172",
      "FaxPhone": "410-105-0289",
      "MobilePhone": "177-712-5236 x284",
      "ContactPhone": "864.573.1159 x50121",
      "AssociateName": "Boyle-Bartoletti",
      "AssociateId": 759,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "quia",
      "Kanalname": "est",
      "Post1": "nemo",
      "Post2": "blanditiis",
      "Post3": "facilis",
      "EmailName": "kianna_jones@dare.com",
      "ContactFullName": "Josh Norma Hickle MD",
      "ActiveErpLinks": 64,
      "TicketPriorityId": 938,
      "SupportLanguageId": 336,
      "SupportAssociateId": 337,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 530
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "facilis",
  "Xstop": false,
  "ActiveInterests": 313,
  "GroupId": 444,
  "ActiveStatusMonitorId": 927,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 837,
  "DbiAgentId": 925,
  "DbiLastSyncronized": "2022-07-04T13:28:22.288659+02:00",
  "DbiKey": "enim",
  "DbiLastModified": "2004-10-17T13:28:22.288659+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 804,
  "ActiveErpLinks": 235,
  "BounceEmails": [
    "osborne@murphy.us",
    "earline.batz@jacobihaag.us"
  ],
  "Domains": [
    "accusamus",
    "modi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1051112681",
    "SuperOffice:2": "Sabryna Hane"
  },
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "pariatur",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 215
    }
  }
}
```