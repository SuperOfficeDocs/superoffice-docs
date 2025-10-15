---
uid: help-en-ai-copilot
title: SuperOffice Copilot
description: SuperOffice AI Services - Copilot
keywords: AI, ChatGPT, OpenAI, Bing, Copilot
author: digitaldiina, Filip Norman
date: 10.15.2025
version: 11.5
content_type: concept
license: aiplatform
pilot: yes
category: automation
topic: ai
deployment: online
platform: web
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: /en/ai/copilot/index
---

# SuperOffice Copilot

The SuperOffice Copilot smoothly integrates a ChatGPT-like user experience with SuperOffice, providing a powerful AI tool within the CRM context. Our aim is to seamlessly embed generative AI within SuperOffice CRM, eliminating the need for external app access while enhancing your workflow directly within the platform.

You can save time and get insights using the different ready-made questions (prompts) in the Company, Contact, Diary, Sale, Project, Request, and Selection screen.

> [!NOTE]
> This feature is available through our [AI lab program][9]. SuperOffice AI is cloud only.

## Privacy and GDPR

SuperOffice Copilot does not know anything about your customer data and will provide you answers with the help of a large-language-model (LLM) such as Bing from Microsoft or ChatGPT from OpenAI.

## Getting started

The SuperOffice Copilot is available in all screens with the [side panel][1]. By default, the side panel shows a preview of the selected record.

1. Go to a company, contact, diary, sale, project, request, or selection.

1. Click <i class="ph ph-caret-down" aria-label="Chevron"></i> next to the side panel's name and select **SuperOffice Copilot**.

    ![Enable SuperOffice Copilot -screenshot][img2]

1. Select one of the pre-defined prompts or ask any type of question to get answers from the AI technology.

    ![SuperOffice Copilot on a sale -screenshot][img3]

1. After the AI has generated a response, you have the following options:

    * Select the plus or minus icon to get more or less text.
    * Copy the result to the clipboard.
    * Ask another question.
    * Clear the chat.

    ![SuperOffice Copilot on a sale -screenshot][img4]

## Context and language

SuperOffice Copilot uses the language of your SuperOffice application. For example, if you have selected *Deutsch* in **Local settings**, the AI will answer you in German.

The context is always the currently viewed item. For example, when viewing the company "SuperOffice AS", the AI tells you about SuperOffice. If you go to "Visma", AI tells you about that company instead. If you switch to **Project**, the chat is reset and you can select project-related prompts. And so on.

## Available prompts

Prompts are subject to change without prior notice during the pilot!

### Company

* **Company details:** AI tells you about the current company.
* **Competitors:** AI presents general information about competitors and competitive analysis.
* **Business:** AI tells you about the business the company is engaged in.

### Contact

* **Company details:** AI tells you about the current company.
* **Contact details:** AI tells you about the current contact.
* **Write pitch:** AI writes a pitch targeted at the contact.

### Diary

* **Today:** AI lists all your scheduled diary entries for the current date.

### Sale

* **Company details:** AI tells you about the company of the current sale.
* **Competitors:** AI presents general information about competitors and competitive analysis.
* **Business:** AI tells you about the business the company is engaged in.
* **Proposal:** AI drafts a proposal for the sale's opportunity.

### Project

* **Project planning:** AI creates a project plan for the current project.
* **Ideas:** AI gives you some ideas of things to consider for the current project based on its title and description.

### Requests

* **Summarize:** AI analyzes the request and request messages, extracts key information, and presents a brief, coherent summary.

  * If a request contains 3 or more messages, you can select **Summarize** from the **Show all** dropdown menu in the **Messages** tab of the Request screen.
  * If the request has more than 5 messages, a separate **Summarize** button will also appear next to the **Add comment** button.

### Selection

* To come

## Related content

* [Other AI services][2]
* [Trust center | GDPR & SuperOffice Products][8]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: index.md
[8]: https://www.superoffice.com/trust-center/gdpr-and-crm/
[9]: https://community.superoffice.com/en/product-releases/pilot-programs/current-pilot-programs/ai-lab/

<!-- Referenced image -->
[img2]: ../../../media/loc/en/ai/copilot-in-sidepanel-list.png
[img3]: ../../../media/loc/en/ai/copilot-on-sale.png
[img4]: ../../../media/loc/en/ai/copilot-about-superoffice.png
