---
uid: help-sv-mailing-recipient-list
title: Jobba med mottagarlistan efter utskicket
description: Jobba med mottagarlistan efter utskicket
keywords: Marknadsföring, mottagare
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Titta på mottagarlistan efter utskicket

När ditt utskick är skickat är det alltid spännande att se hur bra det presterat. Det är också ett utmärkt tillfälle att kontrollera och förbättra kvaliteten på den information som registreras i din databas. Framför allt är antalet returnerade e-postmeddelanden en nyckelindikator. Lär dig hur du filtrerar mottagarlistan i den här guiden.

SuperOffice Marknadsföring samlar in data om statusen för varje skickat e-postmeddelande. På fliken Mottagare kan du se statusen för varje mottagare i utskicket. Du kan även filtrera listan och exportera resultaten till urval och projekt i SuperOffice CRM för vidare behandling.

![Du kan se status för utskicket i fältet Status -screenshot][img4]

## Steg

1. Klicka på utskicket på fliken **Utskick**.

2. I fönstret **Visa utskick** klickar du på fliken **Mottagare**.

    Listan visar de 100 första mottagarna. Klicka på <i class="ph ph-arrow-right" aria-label="Arrow right"></i> för att visa nästa 100.

3. [Filtrera listan](#filters) med kryssrutorna längst ned i listan.

    Som standard är alla filter aktiva för att visa alla mottagare. Du kan avmarkera en filterkryssruta om du vill inaktivera filtret. Flera filter kan kombineras.

4. Använd kryssrutorna i den vänstra kolumnen för att välja alla eller specifika mottagare.

5. Klicka på **Åtgärder** menyknappen. Här har du följande alternativ:
    * Exportera de valda mottagarna till en Excel-, HTML- eller textfil.
    * [Lägg till de valda mottagarna till ett nytt eller befintligt urval eller projekt](#add-recipients).
    * Skicka om utskicket till de valda mottagarna.

6. Klicka på **Stäng** när du vill stänga skärmen **Visa utskick**.

Om statusen är **Redo att skicka** behöver du inte göra något. SuperOffice skickar ditt utskick till mottagarna. Status ändras till **Skickat** när det är klart.

## <a id="filters"></a>Filter

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

## <a id="add-recipients"></a>Lägga till mottagare till urval eller projekt

Med hjälp av **Åtgärder** menyknappen kan du lägga till mottagare och klickare i ett urval eller projekt.

> [!NOTE]
> Endast kontakter som redan är registrerade i SuperOffice-databasen läggs till i urvalet eller projektet. En kontaktikon (<i class="ph ph-user-circle" aria-hidden="true"></i>) i kolumnen **Typ** anger att en kontakt är registrerad i SuperOffice-databasen. Mottagare som har importerats från externa listor registreras normalt inte.

### Lägga till klickare i ett nytt urval eller projekt

1. Välj de relevanta kontakterna i listan.
2. Klicka på **Åtgärder** menyknappen.
3. Klicka på **Lägg till i nytt urval** eller **Lägg till i nytt projekt**.
4. Skriv namnet på det nya urvalet eller projektet.
5. Klicka på **OK**.

### Lägg till klickare i ett befintligt urval eller projekt

1. Välj de relevanta kontakterna i listan.
2. Klicka på **Åtgärder** menyknappen.
3. Klicka på **Lägg till i befintligt urval** eller **Lägg till i befintligt projekt**.
4. Börja skriva namnet på det urval eller projekt som du vill söka efter.
5. Klicka på urvalet eller projektet i listan.
6. Klicka på **OK**.

Öppna urvalet eller projektet och kontrollera att kontakterna lades till.

## Relaterat innehåll

* [Jobba med spårade länkar efter utskicket][1]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/explore-clicks.md
[3]: manage-bounces.md
[4]: spam-complaints.md
[5]: manage-email-subscriptions.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/recipients-tab-status.png
