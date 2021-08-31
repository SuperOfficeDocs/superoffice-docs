---
title: GetContactEntity
id: v1ContactAgent_GetContactEntity
---

# GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=190
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 867,
  "Name": "Walsh Group",
  "Department": "",
  "OrgNr": "1482609",
  "Number1": "1469287",
  "Number2": "1463377",
  "UpdatedDate": "2004-03-09T14:58:03.5833111+01:00",
  "CreatedDate": "2000-04-14T14:58:03.5833111+02:00",
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "quis",
      "Description": "Optimized non-volatile model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 87
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "quis",
      "Description": "Optimized non-volatile model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 87
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 576,
      "Name": "Feeney, Lynch and Howell",
      "ToolTip": "Quod temporibus molestiae rerum.",
      "Deleted": true,
      "Rank": 988,
      "Type": "suscipit",
      "ColorBlock": 471,
      "IconHint": "earum",
      "Selected": false,
      "LastChanged": "1996-12-13T14:58:03.5843106+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "unde",
      "StyleHint": "error",
      "Hidden": true,
      "FullName": "Dr. Jean Kuhic",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "occaecati",
      "Description": "Open-source clear-thinking encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 714
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "occaecati",
      "Description": "Open-source clear-thinking encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 714
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "laudantium",
      "StrippedValue": "reiciendis",
      "Description": "User-friendly analyzing attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 721
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "reiciendis",
      "Description": "User-friendly analyzing attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 721
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aliquam",
      "StrippedValue": "dolor",
      "Description": "Operative local standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 626
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "dolor",
      "Description": "Operative local standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 626
        }
      }
    }
  ],
  "Description": "Customizable modular complexity",
  "UpdatedBy": {
    "AssociateId": 100,
    "Name": "Blanda, Sanford and Jacobson",
    "PersonId": 471,
    "Rank": 839,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 989,
    "FullName": "Romaine Lemke",
    "FormalName": "Cole-Macejkovic",
    "Deleted": true,
    "EjUserId": 929,
    "UserName": "Gusikowski-Wuckert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 734
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 574,
    "Name": "Collins Inc and Sons",
    "PersonId": 274,
    "Rank": 318,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 131,
    "FullName": "Dr. Krystal Little",
    "FormalName": "O'Reilly, O'Conner and Miller",
    "Deleted": false,
    "EjUserId": 951,
    "UserName": "Hane, Smitham and Jakubowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 985
      }
    }
  },
  "Associate": {
    "AssociateId": 898,
    "Name": "Pollich Inc and Sons",
    "PersonId": 152,
    "Rank": 673,
    "Tooltip": "fugiat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 559,
    "FullName": "Marcos Sanford",
    "FormalName": "Parisian Inc and Sons",
    "Deleted": true,
    "EjUserId": 641,
    "UserName": "Hoeger, Rowe and Nicolas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 679
      }
    }
  },
  "Business": {
    "Id": 6,
    "Value": "dolorem",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "revolutionize visionary mindshare"
        },
        "FieldType": "System.Int32",
        "FieldLength": 718
      }
    }
  },
  "Category": {
    "Id": 774,
    "Value": "est",
    "Tooltip": "non",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 175
      }
    }
  },
  "Country": {
    "CountryId": 669,
    "Name": "Lueilwitz-Halvorson",
    "CurrencyId": 464,
    "EnglishName": "Spencer, Ernser and Gerlach",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Seamless 4th generation framework",
    "OrgNrText": "1139430",
    "InterAreaPrefix": "nam",
    "DialInPrefix": "est",
    "ZipPrefix": "in",
    "DomainName": "Dare, West and Stamm",
    "AddressLayoutId": 374,
    "DomesticAddressLayoutId": 868,
    "ForeignAddressLayoutId": 776,
    "Rank": 732,
    "Tooltip": "impedit",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 339
      }
    }
  },
  "Persons": [
    {
      "Position": "est",
      "PersonId": 414,
      "Mrmrs": "magnam",
      "Firstname": "Derick",
      "Lastname": "Mills",
      "MiddleName": "West-Jacobi",
      "Title": "ullam",
      "Description": "Ergonomic zero tolerance functionalities",
      "Email": "jaylon_little@kuhn.biz",
      "FullName": "Laurie Trantow",
      "DirectPhone": "1-444-548-2005",
      "FormalName": "Ernser Inc and Sons",
      "CountryId": 348,
      "ContactId": 553,
      "ContactName": "Kihn Inc and Sons",
      "Retired": 568,
      "Rank": 531,
      "ActiveInterests": 734,
      "ContactDepartment": "",
      "ContactCountryId": 788,
      "ContactOrgNr": "1465861",
      "FaxPhone": "(278)848-3100",
      "MobilePhone": "772.882.2342",
      "ContactPhone": "(862)803-3167 x72641",
      "AssociateName": "Champlin Inc and Sons",
      "AssociateId": 867,
      "UsePersonAddress": true,
      "ContactFax": "deleniti",
      "Kanafname": "harum",
      "Kanalname": "ut",
      "Post1": "temporibus",
      "Post2": "praesentium",
      "Post3": "sed",
      "EmailName": "guiseppe@dooley.info",
      "ContactFullName": "Obie Tromp",
      "ActiveErpLinks": 308,
      "TicketPriorityId": 594,
      "SupportLanguageId": 936,
      "SupportAssociateId": 547,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 177
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "facilis",
  "Xstop": true,
  "ActiveInterests": 620,
  "GroupId": 464,
  "ActiveStatusMonitorId": 93,
  "SupportAssociate": {
    "AssociateId": 631,
    "Name": "Schimmel, Rogahn and McKenzie",
    "PersonId": 196,
    "Rank": 306,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 284,
    "FullName": "Velda Larkin",
    "FormalName": "Hintz-Strosin",
    "Deleted": true,
    "EjUserId": 359,
    "UserName": "Armstrong Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 997
      }
    }
  },
  "TicketPriority": {
    "Id": 821,
    "Value": "enim",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 8
      }
    }
  },
  "CustomerLanguage": {
    "Id": 870,
    "Value": "dolore",
    "Tooltip": "nihil",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 351
      }
    }
  },
  "Deleted": 364,
  "DbiAgentId": 849,
  "DbiLastSyncronized": "1998-09-11T14:58:03.5873108+02:00",
  "DbiKey": "fuga",
  "DbiLastModified": "2001-03-20T14:58:03.5873108+01:00",
  "SupportPerson": {
    "Position": "facilis",
    "PersonId": 262,
    "Mrmrs": "architecto",
    "Firstname": "Toby",
    "Lastname": "Abbott",
    "MiddleName": "Macejkovic LLC",
    "Title": "ipsa",
    "Description": "Customer-focused background collaboration",
    "Email": "brown@lang.ca",
    "FullName": "Mack D'Amore PhD",
    "DirectPhone": "323-115-4734 x100",
    "FormalName": "Stracke, Paucek and McClure",
    "CountryId": 333,
    "ContactId": 961,
    "ContactName": "Connelly Inc and Sons",
    "Retired": 867,
    "Rank": 708,
    "ActiveInterests": 995,
    "ContactDepartment": "iterate magnetic platforms",
    "ContactCountryId": 416,
    "ContactOrgNr": "727292",
    "FaxPhone": "458-231-3537",
    "MobilePhone": "873.748.5216 x21351",
    "ContactPhone": "605-880-7517",
    "AssociateName": "Conroy-Carter",
    "AssociateId": 558,
    "UsePersonAddress": true,
    "ContactFax": "sit",
    "Kanafname": "porro",
    "Kanalname": "impedit",
    "Post1": "asperiores",
    "Post2": "voluptas",
    "Post3": "et",
    "EmailName": "claire@morarmedhurst.us",
    "ContactFullName": "Marilie Larkin MD",
    "ActiveErpLinks": 885,
    "TicketPriorityId": 57,
    "SupportLanguageId": 959,
    "SupportAssociateId": 26,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 482
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 15873.71,
    "Wgs84Longitude": 6305.608,
    "LocalizedAddress": [
      [
        {
          "Name": "Hand-Kulas",
          "Value": "totam",
          "Tooltip": "reiciendis",
          "Label": "facilis",
          "ValueLength": 97,
          "AddressType": "dolor",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "envisioneer 24/365 models"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 928
            }
          }
        }
      ],
      [
        {
          "Name": "Waters, Brakus and Kihn",
          "Value": "possimus",
          "Tooltip": "et",
          "Label": "et",
          "ValueLength": 731,
          "AddressType": "dicta",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "visualize turn-key platforms"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 35
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "minima",
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
  "Source": 449,
  "ActiveErpLinks": 930,
  "BounceEmails": [
    "leta@goldnersanford.uk",
    "green@cronaschuster.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "similique",
    "CustomFields2": "voluptas"
  },
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
      "FieldLength": 451
    }
  }
}
```