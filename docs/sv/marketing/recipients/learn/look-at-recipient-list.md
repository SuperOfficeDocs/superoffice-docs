---
uid: help-sv-mailing-recipient-list
title: Jobba med mottagarlistan efter utskicket
description: Jobba med mottagarlistan efter utskicket
keywords: Marknadsföring, mottagare
author: SuperOffice RnD
so.date: 02.09.2024
so.version: 10
so.topic: howto
language: sv
so.audience: user
so.audience.tooltip: SuperOffice Marketing
---

# Titta på mottagarlistan efter utskicket

När ditt utskick är skickat är det alltid spännande att se hur bra det presterat. Det är också ett utmärkt tillfälle att kontrollera och förbättra kvaliteten på den information som registreras i din databas. Framför allt är antalet returnerade e-postmeddelanden en nyckelindikator. Lär dig hur du filtrerar mottagarlistan i den här guiden.

SuperOffice Marknadsföring samlar in data om statusen för varje skickat e-postmeddelande. På fliken Mottagare kan du se statusen för varje mottagare i utskicket. Du kan även filtrera listan och exportera resultaten till urval och projekt i SuperOffice CRM för vidare behandling.

![Du kan se status för utskicket i fältet Status -screenshot][img4]

## Steg

1. Klicka på utskicket på fliken **Utskick**.

2. I fönstret **Visa utskick** klickar du på fliken **Mottagare**.

    Listan visar de 100 första mottagarna. Klicka på ![ikon][img1] för att visa nästa 100.

3. [Filtrera listan](#filters) med kryssrutorna längst ned i listan.

    Som standard är alla filter aktiva för att visa alla mottagare. Du kan avmarkera en filterkryssruta om du vill inaktivera filtret. Flera filter kan kombineras.

4. Använd kryssrutorna i den vänstra kolumnen för att välja alla eller specifika mottagare.

5. Klicka på ![ikon][img2] menyknappen. Här har du följande alternativ:
    * Exportera de valda mottagarna till en Excel-, HTML- eller textfil.
    * [Lägg till de valda mottagarna till ett nytt eller befintligt urval eller projekt](#add-recipients-to-selections-or-projects).
    * Skicka om utskicket till de valda mottagarna.

6. Klicka på **Stäng** när du vill stänga skärmen **Visa utskick**.

Om statusen är **Redo att skicka** behöver du inte göra något. SuperOffice skickar ditt utskick till mottagarna. Status ändras till **Skickat** när det är klart.

## <a id="filters" />Filter

* **Skickat**: Aktivera detta filter om du vill visa alla mottagare som utskicket har skickats till.

* **Returnerat**: Aktivera detta filter om du vill visa alla mottagare som [utskicket returnerades för][3]. Det kan t.ex. bero på fel i e-postadresser, skräppostfilter, Internetproblem eller att mottagarnas inkorgar är fulla.

* **Läst av mottagare**: Aktivera detta filter om du vill visa alla mottagare som öppnat eller läst utskicket.

* **Redo att skicka**: Aktivera detta filter om du vill visa alla mottagare som utskicket ännu inte har skickats till.

* **Blockerad**: Aktivera filtret om du vill visa följande mottagare:

* Mottagare som inte vill bli kontaktad
* Duplicera mottagare
* [Mottagare utan en prenumeration][5]

**Mottagaren klagade**: Aktivera detta filter om du vill visa alla mottagare som rapporterat utskicket som [skräppost][4].

Om statusen är **Redo att skicka** behöver du inte göra något. SuperOffice skickar ditt utskick till mottagarna. Status ändras till **Skickat** när det är klart.

<!-- markdownlint-disable-next-line MD013 -->
## <a id="add-recipients-to-selections-or-projects" />Lägga till mottagare till urval eller projekt

Med hjälp av ![ikon][img2] menyknappen kan du lägga till mottagare och klickare i ett urval eller projekt.

> [!NOTE]
> Endast kontakter som redan är registrerade i SuperOffice-databasen läggs till i urvalet eller projektet. En kontaktikon ![ikon][img3] i kolumnen **Typ** anger att en kontakt är registrerad i SuperOffice-databasen. Mottagare som har importerats från externa listor registreras normalt inte.

### Lägga till klickare i ett nytt urval eller projekt

[!include[How to](../../learn/includes/howto-add-person-to-selection-new.md)]

### Lägg till klickare i ett befintligt urval eller projekt

[!include[How to](../../learn/includes/howto-add-person-to-selection-existing.md)]

## Relaterade ämnen

* [Jobba med spårade länkar efter utskicket][1]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/explore-clicks.md
[3]: manage-bounces.md
[4]: spam-complaints.md
[5]: manage-email-subscriptions.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/btn-menu.png
[img3]: ../../../../../common/icons/nav-contact.png
[img4]: ../../../../media/loc/en/marketing/recipients-tab-status.png
