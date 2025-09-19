---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 458,
  "Name": "Leannon-Bartell",
  "Department": "",
  "OrgNr": "1048169",
  "Number1": "1582411",
  "Number2": "1211127",
  "UpdatedDate": "2008-07-07T03:41:53.2932434+02:00",
  "CreatedDate": "2002-12-13T03:41:53.2932434+01:00",
  "Emails": [
    {
      "Value": "architecto",
      "StrippedValue": "illo",
      "Description": "Balanced empowering matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "illo",
      "Description": "Balanced empowering matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 981,
      "Name": "Gulgowski LLC",
      "ToolTip": "Aut ex voluptas unde est reiciendis ullam dolores.",
      "Deleted": false,
      "Rank": 4,
      "Type": "voluptatem",
      "ColorBlock": 881,
      "IconHint": "natus",
      "Selected": false,
      "LastChanged": "2019-04-14T03:41:53.2932434+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "facilis",
      "Hidden": true,
      "FullName": "Ms. Wilson Mossie Goodwin II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolorem",
      "StrippedValue": "explicabo",
      "Description": "Profound upward-trending parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 206
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "explicabo",
      "Description": "Profound upward-trending parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 206
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eaque",
      "StrippedValue": "sequi",
      "Description": "Polarised clear-thinking monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "sequi",
      "Description": "Polarised clear-thinking monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "est",
      "Description": "Balanced systematic initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 893
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "est",
      "Description": "Balanced systematic initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 893
        }
      }
    }
  ],
  "Description": "Customizable fault-tolerant system engine",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nostrum",
      "PersonId": 325,
      "Mrmrs": "eum",
      "Firstname": "Rachel",
      "Lastname": "Romaguera",
      "MiddleName": "Reilly LLC",
      "Title": "dolor",
      "Description": "Exclusive cohesive circuit",
      "Email": "joelle_greenfelder@kautzerfeil.uk",
      "FullName": "Domenick Daugherty",
      "DirectPhone": "883-953-3352 x83886",
      "FormalName": "Jacobi-Goodwin",
      "CountryId": 768,
      "ContactId": 131,
      "ContactName": "Wyman LLC",
      "Retired": 929,
      "Rank": 454,
      "ActiveInterests": 487,
      "ContactDepartment": "",
      "ContactCountryId": 761,
      "ContactOrgNr": "1039829",
      "FaxPhone": "149-575-2059",
      "MobilePhone": "(660)931-6710 x872",
      "ContactPhone": "033-832-8655",
      "AssociateName": "Breitenberg-Weimann",
      "AssociateId": 147,
      "UsePersonAddress": false,
      "ContactFax": "quod",
      "Kanafname": "dignissimos",
      "Kanalname": "iure",
      "Post1": "doloremque",
      "Post2": "quas",
      "Post3": "non",
      "EmailName": "cecile.mayert@gerhold.biz",
      "ContactFullName": "Ms. Jaqueline Zemlak IV",
      "ActiveErpLinks": 722,
      "TicketPriorityId": 732,
      "SupportLanguageId": 406,
      "SupportAssociateId": 626,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1190494",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "repellendus",
  "Xstop": false,
  "ActiveInterests": 824,
  "GroupId": 290,
  "ActiveStatusMonitorId": 711,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 209,
  "DbiAgentId": 972,
  "DbiLastSyncronized": "2015-09-20T03:41:53.2932434+02:00",
  "DbiKey": "similique",
  "DbiLastModified": "2014-10-07T03:41:53.2932434+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 839,
  "ActiveErpLinks": 467,
  "BounceEmails": [
    "mafalda@wolff.com",
    "fidel@corkery.biz"
  ],
  "Domains": [
    "earum",
    "nostrum"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Eldon Tina Kunze DDS",
    "SuperOffice:2": "694137613"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "possimus"
  },
  "CustomFields": {
    "CustomFields1": "fugit",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 414
    }
  }
}
```