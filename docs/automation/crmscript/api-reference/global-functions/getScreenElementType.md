---
title: Integer getScreenElementType(Integer index)
description: Integer getScreenElementType(Integer index)
intellisense: Void.getScreenElementType
langref: 1
keywords: getScreenElementType(Integer)
so.topic: reference
---

# Integer getScreenElementType(Integer index)

This function can only be called from a screen definition, it will fail if called from a regular script.

It returns the type of the screen element with the given index in the current screen definition.

The index can be retrieved with `getHtmlElementIndex(elementName)`.

* **index:** The index of the element
* **Returns:** An integer defining the type of the element

## Types

### Simple elements

* TypeAnchorLine = 1,
* TypeInfoFields = 2,
* TypeGrid = 3,
* TypeHR = 4,
* TypeBR = 5,
* TypeSubHeader = 6,
* TypeParserCode = 7,
* TypeMessages = 8,
* TypeEjScript = 9,
* TypeHtmlGrid = 10,
* TypePlanner = 11,
* TypeStaticGrid = 12,
* TypeDrillDown = 13,
* TypeGenericGrid = 14,
* TypeInfoFields2 = 15,
* TypeExtraTableEntriesGrid = 16,
* TypeDirectedAcyclicGraph = 17,

### Form elements

* TypeText = 101,
* TypeTextarea = 102,
* TypeSelectCategory = 103,
* TypeSelectCustomer = 104,
* TypeSelectCompany = 105,
* TypeSelectDate = 106,
* TypeSelectDateTime = 107,
* TypeSelectTime = 108,
* TypeButtonRow = 109,
* TypeCheckbox = 110,
* TypeEditor = 111,
* TypeInvoice = 112,
* TypeSelectUser = 113,
* TypeSelectExtraField = 114,
* TypeSelect = 115,
* TypeSendTo = 116,
* TypeSelectReplyTemplate = 117,
* TypeSelectTimeSpan = 118,
* TypeSelectRelation = 119,
* TypeSelectPriority = 120,
* TypeCc = 121,
* TypeAttachment = 122,
* TypeSelectSlevel = 123,
* TypeCustomers = 124,
* TypeSelectFaq = 125,
* TypeSelectDictionaryLang = 126,
* TypeButton = 127,
* TypeSelectMultipleRelations = 128,
* TypeTreeExplorer = 129,
* TypePinEdit = 130,
* TypeContactRecipients = 131,
* TypeTicketStatus = 132,
* TypeSelectMessage = 133,
* TypeCategoryMembership = 134,
* TypeAddressBook = 135,
* TypeRelatedDropdowns = 136,
* TypeSelectTicketStatus = 137,
* TypeSelectTable = 138,
* TypeFckEdit = 139,
* TypeWhere = 140,
* TypeSelectInsertText = 141,
* TypeRadioButtons = 142,

### Groups

* TypeFieldset = 201,
* TypeLayoutTable = 202,
* TypePanes = 203,
* TypePane = 204,
* TypeVerticalTable = 205,

### Group end marker

* TypeGroupEnd = 301
