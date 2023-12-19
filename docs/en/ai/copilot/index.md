---
title: SuperOffice AI Services - ChatGPT sidebar
description: SuperOffice AI Services - ChatGPT sidebar
author: Bergfrid Dias, Filip Norman
so.date: 12.14.2023
so.version: 10.2.11
so.pilot: yes
keywords: AI, ChatGPT, OpenAI, Bing
so.topic: concept
so.envir: cloud
so.client: online
---

# ChatGPT sidebar

The ChatGPT sidebar smoothly integrates the ChatGPT user experience into SuperOffice, providing a powerful AI tool within the CRM context. Our aim is to seamlessly embed ChatGPT within SuperOffice CRM, eliminating the need for external app access while enhancing your workflow directly within the platform.

You can save time and get insights using the different ready-made questions (prompts) in the Company, Contact, Diary, Sale, Project, Request, and Selection screen.

> [!NOTE]
> This feature requires a separate licence for SuperOffice AI Platform and is available in pilot only, by invite. SuperOffice AI is cloud only.

## Privacy and GDPR

The AI does not know anything about your customer data and will provide you answers with the help of a large-language-model (LLM) such as Bing from Microsoft or ChatGPT from OpenAI.

## Getting started

The ChatGPT sidebar is available in all screens with the [side panel][1]. By default, the side panel shows a preview of the selected record.

1. Go to a company, contact, diary, sale, project, request, and selection.
1. Click the arrow ![icon][img1] next to the side panel's name and select **Chat GPT**.

    ![Enable ChatGPT sidebar -screenshot][img2]

1. Select one of the pre-defined prompts or ask any type of question to get answers from the AI technology.

    ![Enable ChatGPT sidebar on a sale-screenshot][img3]

1. After Hugo's response, you request more text, less text, or copy the result to the clipboard. To clear the chat, press F5.

    ![Enable ChatGPT sidebar on a sale-screenshot][img4]

## Context and language

The AI uses the language of your SuperOffice application. For example, if you have selected *Deutsch* in **Local settings**, the AI will answer you in German.

The context is always the currently viewed item. For example, when viewing the company "SuperOffice AS", Hugo will tell you about SuperOffice. If you go to "Visma", Hugo will tell you about that company instead. If you switch to **Project**, the chat is reset and Hugo presents project-related prompts. And so on.

## Available prompts

Prompts are subject to change without prior notice during the pilot!

### Company

* **Company details:** Hugo tells you about the current company.
* **Competitors:** Hugo presents general information about competitors and competitive analysis.
* **Business:** Hugo tells you about the business the company is engaged in.

### Contact

* **Company details:** Hugo tells you about the current company.
* **Contact details:** Hugo tells you about the current contact.
* **Write pitch:** Hugo writes a pitch targeted at the contact.

### Diary

* **Today:** Hugo summarizes a few news articles about what's happening today.
* **Lunch tomorrow:** Hugo makes a lunch appointment for tomorrow. Provide time and place when asked. (Does NOT update your diary.)

### Sale

* **Company details:** Hugo tells you about the company of the current sale.
* **Competitors:** Hugo presents general information about competitors and competitive analysis.
* **Business:** Hugo tells you about the business the company is engaged in.
* **Proposal:** Hugo drafts a proposal for the sale's opportunity.

### Project

* **Project planning:** Hugo creates a project plan for the current project.
* **Ideas:** Hugo gives you some ideas of things to consider for the current project based on it's title and description.

### Requests

* To come

### Selection

* To come

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md

<!-- Referenced image -->
[img1]: ../../../../common/icons/dropdown-icon.png
[img2]: ../../../media/loc/en/ai/chatgpt-in-sidepanel-list.png
[img3]: ../../../media/loc/en/ai/chatgpt-on-sale.png
[img4]: ../../../media/loc/en/ai/chatgpt-about-superoffice.png
