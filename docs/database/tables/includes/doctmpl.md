<!-- markdownlint-disable-file MD041 -->
### Values needed to access the DocTmpl tables

This table must contain special values that would be difficult to guess correctly. These are listed below with a description of how to use them.

  | Record Type | ID | Comment |
 |---|---|---|
 | Unknown | 0 | The document type is unknown/undecided |
 | Appointment | 1 | (not used for document templates) |
 | Document | 2 | Generic text document (for instance, a letter) |
 | Email | 3 | Email message |
 | Fax | 4 | Facsimile |
 | Phone | 5 | (not used for document templates) |
 | To Do | 6 | (not used for document templates) |
 | Mail merge draft document | 7 | Template for mail merge operations |
 | Mail merge final document | 8 | Result of a mail merge operation |
 | Saved report | 9 | Saved result of running a report (output from Reporter) |

 | Direction Type | ID | Comment |
 |---|---|---|
 | Unknown | 0 | The direction of documents from this template is unknown/undecided |
 | Incoming | 1 | Document template for incoming documents |
 | Outgoing | 2 | Document template is used for outgoing documents |
 | SaintAll | 3 | 'All' choice for Saint. This is NOT an acceptable value for a task definition, but is used by the Saint system for indexing all directions |

Is this document template some kind of quote document, and if so what

 | QuoteDocType | ID | Comment |
 |---|---|---|
 | None | 0 | This document template is in no way related to Quote Management |
 | MailBody | 1 | This is a template for the offer mail body |
 | MainDocument | 2 | This is a template for the main offer document, document instances will be referred through Quote.DocumentId |
 | QuoteLines | 3 | This is a template for the AsposeWords merge process, generating the offer line details |
 | ConfirmationMailBody | 4 | This is a template for the mail body of the order confirmation |
 | ConfirmationLines | 5 | This is a template for the lines document that is an attachment to the confirmation mail |
