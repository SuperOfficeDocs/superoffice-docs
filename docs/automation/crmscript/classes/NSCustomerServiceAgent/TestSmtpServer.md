---
title: crmscript_ref_NSCustomerServiceAgent_TestSmtpServer_String_p_0_String_p_1_Bool_p_2
description: NSCustomerServiceAgent.TestSmtpServer(String p_0, String p_1, Bool p_2)
intellisense: NSCustomerServiceAgent.TestSmtpServer
sortOrder: 2237
keywords: TestSmtpServer(String,String,Bool)
so.topic: reference
---


This method will do a test of a SMTP account, by sending an email to a special @superoffice.com account



* **smtpUri:** An URI containing information to connect to the SMTP server, eg. smtps://myuser:mypassword@smtp.myserver.com:465. Note that username and password must be url encoded
* **from:** The from-address used in the test
* **useStoredPassword:** Use database persisted password
* **Returns:** Contains the result of the test


