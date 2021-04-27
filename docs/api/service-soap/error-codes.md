---
title: services_soap_error_codes
description: Services SOAP interface error codes
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# Error codes

The methods can return various error codes. Here is a list of all with a description (the same description as you would get with `getErrorMessage()`):

| Name | Value | Description |
|:-:|---|---|
| 0 | SoapErrorNoError | No Error |
| 1 | SoapErrorIncorrectLoginCustomer | Customer could not be logged in: User name or password was incorrect. |
| 2 | SoapErrorIncorrectLoginUser | User could not be logged in: User name or password was incorrect. |
| 3 | SoapErrorUnknownCustomer | Customer could not be identified by the customer's user name. |
| 4 | SoapErrorInsufficientRights | The user does not have sufficient rights to perform this operation. |
| 5 | SoapErrorInvalidSessionKey | The session key provided has either expired or is corrupted. |
| 6 | SoapErrorOperationIllegal | The operation is not permitted on this system. |
| 7 | SoapErrorCustomError | Custom error, no error message available. |
| 8 | SoapErrorInvalidCategory | The specified category is invalid. |
| 9 | SoapErrorInvalidPriority | The specified priority is invalid. |
| 10 | SoapErrorInvalidSLevel | The specified security level is invalid. |
| 11 | SoapErrorInvalidDomain | The domain should be either 'company', 'customer', or 'ticket' |
| 12 | SoapErrorInvalidExtraField | The extra field specified is invalid or does not exist. |
| 13 | SoapErrorUnknownTicket | The ticket could not be found, or you do not have access to it. |
| 14 | SoapErrorUserNameExists | You can not create this user because the user name is already in use |
| 15 | SoapErrorEmptyPassword | The password you supplied was empty |
| 16 | SoapErrorUnknownAttachment | The attachment specified is invalid or does not exist. |
| 17 | SoapErrorInvalidField | The field you specified is illegal, or unknown. |
| 18 | SoapErrorUnknownMessage | The message you requested is not accessible or non-existing |
| 19 | SoapErrorNoLicense | The system is licensed for the requested functionality/module |
| 20 | SoapErrorInvalidFaqCategory | The category you requested is inaccessible or unknown. |
| 21 | SoapErrorInvalidFaqEntry | The FAQ entry you requested is inaccessible or unknown. |
| 22 | SoapErrorFaqScoreOutOfRange | The score must have a value ranging from 0 to 10. |
| 23 | SoapErrorUnknownLanguage | The language specified does not exist. |
| 24 | SoapErrorAttachmentInUse | The attachment you tried to remove was in use. |
| 25 | SoapErrorInvalidFaqGroup | The FAQ group specified does not exist. |
| 26 | SoapErrorNotificationViolation | The notifications for this user are being read by someone else. Another Agent? |
| 27 | SoapErrorFileNotFound | The file was not found on the server |
| 28 | SoapErrorIllegalCriterias | The criteria you specified are illegal. |
| 29 | SoapErrorInvalidOwner | The owner you specified is invalid or non-existing |
| 30 | SoapErrorUnknownCompany | The company you specified was not found |
| 31 | SoapErrorUnknownCustomerId | The customer you specified was not found |
| 32 | SoapErrorUnknownTicketStatus | The specified ticket status is illegal. |
| 33 | SoapErrorUnknownExtraTable | The specified extra table does not exist |
| 34 | SoapErrorUnknownUserId | The specified user does not exist |
| 35 | SoapErrorUserNotFound | The user was not found |
