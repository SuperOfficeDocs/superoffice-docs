---
uid: help-en-document-replytemplates
title: document replyTemplates
description: document replyTemplates
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Work with reply templates

A reply template can for instance be a specific layout to implement on replies, or a ready-made text that can be pasted into a message you are writing to a customer. It can also include an attachment, which will then be added to the message. Before you send the reply to the customer, you can edit the text and add or remove attachments. In other words, a reply template provides the basis for a customised response to a customer. Using reply templates saves time, and they can be tailored to the precise situation.

<!-- Fix reuse ID=a1 -->

* If you select a reply template, it is pasted in as ordinary text that you can edit before sending the reply. The benefit of using reply templates is that they can be tailored to the precise situation.
* If you select an FAQ entry, a link to the FAQ entry in the customer centre is pasted in. This means you cannot edit the FAQ entry before sending your reply to the customer. The benefit of using FAQ entries is that you let the customer know that there are FAQs available that may be of use in the future.

<!-- Fix reuse ID=a2 -->

To give each department in your company a custom layout for their correspondence, you can create reply templates with different layouts. Each reply template can be linked to a category representing a department. All outgoing replies from the categories (departments) will be merged with the department specific design.

Apart from the layout/formatting of the reply template, it must contain the following template variables to be able to merge with the reply:

\[\[IF:message.bodyHtml!=""\]\]

\[\[message.bodyHtml\]\]

\[\[ELSE\]\]

\[\[message.body\]\]

\[\[ENDIF\]\]

  
See also <a href="https://community.superoffice.com/en/Technical/Blog/reply-templates-on-categories-in-service-what-is-that/" target="_blank">Reply templates on Categories in Service... what is that?</a>

## What would you like to do now?

[View reply templates](document.replyTemplates.viewReplyTemplate.md)

[Create reply templates](document.replyTemplates.newReplyTemplate.md)

[Create new language version of reply template](document.replyTemplates.newlangversion.md)

[Create reply template with automatic FAQ reply](document.replyTemplates.autoFAQ.md)

[Edit reply templates](document.replyTemplates.editReplyTemplateCustomerLang.md)

[Copy reply templates](document.replyTemplates.viewReplyTemplate.md#CopyReplyTemplate)

[Delete reply templates](document.replyTemplates.delReplyTemplate.md)

[Search for reply templates](document.replyTemplates.findReplyTemplates.md)

[Administrate folders of reply templates](document.replyTemplates.editReplyTemplateFolder.md)

[Add reply templates to messages](document.replyTemplates.addReplyTemplatesToMessages.md)
