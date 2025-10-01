---
uid: help-sv-send-privacy-confirmation-email
title: Skicka e-postbekräftelse om personskydd
description: Skicka e-postbekräftelse om personskydd
keywords: e-postbekräftelse, personskydd, integritetsbekräftelse
author: SuperOffice Product and Engineering
date: 02.21.2023
version: 10.3
content_type: howto
category: privacy
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Skicka e-postbekräftelse om personskydd

I den nya GDPR-världen, har individer "rätt att informeras". Det innebär att de har rätt att få veta, antingen i förväg eller inom 30 dagar efter att deras personuppgifter har samlats in. GDPR föreskriver att individer har rätt att bli informerade (a) om att en organisation avser att lagra deras personuppgifter och (b) vad organisationen avser att använda deras uppgifter till.

## Inhämta deras samtycke i förväg via formulär

Genom att använda integrerade formulär som finns tillgängliga i din CRM-lösning kan du hämta in en persons samtycke, samtidigt som de fyller i ett webbformulär och ger dig sina personuppgifter. Detta samtycke dokumenteras automatiskt i SuperOffice CRM med hjälp av funktionerna för samtyckeshantering.

Den här videon visar hur du skapar ett grundläggande webbformulär och lägger till det på din webbsida:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/18m6Dx1t9wI]

(videolängd - 7:49)

## Skicka automatiska e-postbekräftelser

SuperOffice CRM låter dig automatiskt skicka en integritetsbekräftelse via e-post till personer som har registrerats i din databas. E-postmeddelandet skickas automatiskt till en kontakt när de först registreras i SuperOffice, utan att du behöver göra något.

Detta är inte bara ett artigt sätt att följa upp din första kontakt med en kund på, utan det ger också din kontakt ett enkelt sätt att meddela dig om de har några frågor eller invändningar mot att du lagrar deras information.

Du kan konfigurera systemet så att det även innehåller en länk som leder till en personlig prenumerationssida. Med den här länken kan dina kontakter välja vilken typ av kommunikation de vill ta emot.

## Så här skickar du e-postbekräftelse om personskydd igen

Från Kontakt-fönstret kan du skicka eller skicka om en e-postbekräftelse om personskydd till en kontakt.

[!include[Go to Contact screen](../../../learn/includes/goto-contact.md)]

1. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> och välj **Skicka e-postbekräftelse om personskydd**.

    ![Skicka en e-postbekräftelse för att informera kontakterna om att deras information lagras i din CRM-databas -screenshot][img2]

1. I dialogrutan som öppnas fyller du i följande fält:
    * **Skicka till**: Använd standardpostadressen eller annan adress.
    * **Använd mall**: Välj en e-postmall.
    * **Språk**: Använd standardspråket eller välj ett annat språk.
    * **Ämne**: Redigera eventuellt standardrubriken på e-postmeddelandet.

1. Klicka på **Skicka**.

E-postbekräftelsen skickas till kontakten. E-postmeddelandet arkiveras på detaljkortet **Aktiviteter**.

## Vad innehåller e-postmeddelandet?

E-postbekräftelsen om personskydd informerar vanligtvis om följande:

* Deras information har lagrats i SuperOffice
* Vilken typ av information som har lagrats
* Vad informationen används till (syfte)
* Att de när som helst dra tillbaka sitt samtycke
* Att informationen är säker och inte delas

E-postmeddelandet kan också innehålla en länk till ett kundcenter där kontakten kan administrera abonnemang och samtycke. Länken är giltig i 21 dagar som standard.

## Relaterat innehåll

* [Redigera bekräftelsen om personskydd i Inställningar och underhåll][1]

<!-- Referenced links -->
[1]: ../admin/edit-privacy-confirmation-email.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/security/confirmation-email.png
