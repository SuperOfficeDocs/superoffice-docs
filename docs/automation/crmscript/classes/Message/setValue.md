---
title: Void setValue(String colName, String value)
path: /EJScript/Classes/Message/Member functions/Void setValue(String colName, String value)
intellisense: 1
classref: 1
sortOrder: 558
keywords: setValue(String,String)
---

Sets the value of column colName to the given value



###Parameters:###


 - String column name of the value
 - String value that should be stored in the column




###Possible columns:###


 - id: Integer, The primary key (auto-incremented)
 - ticketId: Integer, The ticket this message is a child of.
 - createdAt: DateTime, When the message was posted.
 - createdBy: Integer, The id of the user who posted the message. The value 1 (system user) for externally posted messages.
 - type: String, The type of the message (plaintext/html).
 - author: String, A string representing the author of the message. Could be a user's name, or a persons email address.
 - slevel: String, The securitylevel of the message (1 is internal, 2 is external).
 - message\_id: String, The X-Message-Id header value from the email. Used for threading, i.e. connecting messages to existing tickets.
 - timeSpent: Integer, The time spent (minutes) for this message.
 - timeCharge: Integer, The amount of time (minutes) which should be invoiced for this message.
 - body: String, The textbody for the message.
 - bodyHtml: String, The html body for the message (if any).
 - emailHeader: String, The email header is saved in this field as raw text


