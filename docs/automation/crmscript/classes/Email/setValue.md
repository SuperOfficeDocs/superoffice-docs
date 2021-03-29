---
title: crmscript_ref_Email_setValue_String_name_String_value
description: Email.setValue(String name, String value)
intellisense: Email.setValue
sortOrder: 284
keywords: setValue(String,String)
so.topic: reference
---

Sets the value of the given field in the email instance.



###The following fields are available:###


 - from: The from address.
 - to: The recipient.
 - cc: The carbon copy recipient.
 - bcc: The bcc recipient.
 - sms: A cellphone number to send sms to.
 - smsFrom: The from address when sending sms.
 - subject: The subject of the email.
 - body: The plain text body of the email.
 - bodyHtml: The HTML formated body of the email.
 - ticketId: The ticketId, only used with sms.



    From version 8.1 any other header value may also be added, eg. setValue("X-Foo", "42");
    

For multiple recipients, call setValue multiple times, once for each recipient.



###Parameters:###


 - name: The name of the field.
 - value: The value to set.


