---
uid: help-sv-mail-link-archive
title: Arkivera e-postmeddelanden till SuperOffice
description: Arkivera e-postmeddelanden till SuperOffice
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail Link
content_type: howto
language: sv
---

# Arkivera ett e-postmeddelande

När du klickar på knappen **Arkivera e-post** i verktygsfältet i e-postklienten visas en meny med arkiveringsalternativ.

> [!NOTE]
> Den här knappen visas också i e-postfönstret när du öppnar ett e-postmeddelande som du har mottagit.

**Alternativ:**

* [Arkivera e-postmeddelanden under företag/kontakter][2]
* [Arkivera e-postmeddelanden som aktiviteter][1]
* [Arkivering av bilagor][3]
* [Arkivera e-postmeddelanden som ärenden][4]

För alla olika arkiveringsalternativ kan du välja alternativet **Varna mig när ett e-postmeddelande är större än (i KB)** i [fönstret **Allmänna inställningar**][5] i dialogrutan **Alternativ för SuperOffice CRM**. Om du försöker arkivera ett e-postmeddelande med en bifogad fil som är större än den angivna maxstorleken visas en dialogruta som informerar dig om detta och frågar om du ändå vill arkivera det.

## Skillnader mellan Outlook, Notes och SuperOffice CRM

Du kan skapa e-postmeddelanden på flera olika sätt, både [från Outlook][6] och [från SuperOffice CRM][8]. Om dialogrutan **Dokument** visas behandlas e-postmeddelandet som ett SuperOffice-dokument och arkiveras. Om dialogrutan **Dokument** inte visas arkiveras e-postmeddelandet enligt inställningarna i dialogrutan **Alternativ för SuperOffice CRM**.

Dialogrutan **Dokument** öppnas automatiskt om du

* klickar på knappen **Skriv** i SuperOffice CRM

* klickar på nedåtpilen till höger om knappen **Nytt e-postmeddelande** i verktygsfältet i Microsoft Outlook och väljer någon av mallarna på undermenyn **SuperOffice-meddelande**.

Dialogrutan **Dokument** öppnas inte automatiskt om du

* klickar på knappen **Nytt e-postmeddelande** i e-postklienten. E-postmeddelandena arkiveras dock om alternativet **Arkivera e-postmeddelanden som standard när: skapats från e-postklient** i dialogrutan **Alternativ för SuperOffice CRM** är markerat.

* klickar på knappen **E-post** i SuperOffice CRM. E-postmeddelandena arkiveras dock om alternativet **Arkivera e-postmeddelanden som standard när: skapats från SuperOffice CRM** i dialogrutan **Alternativ för SuperOffice CRM** är markerat.

* När du skapar ett e-postmeddelande med knappen **E-post** i SuperOffice CRM kan du använda en fördefinierad e-postmall som standard om alternativet **Använd e-postmall från SuperOffice** i dialogrutan **Alternativ för SuperOffice CRM** är markerat.

> [!NOTE]
> Detta gäller också om du klickar på en e-postadress i SuperOffice CRM, skickar ett e-postmeddelande från detaljkortet **Kontakter** eller svarar på/vidarebefordrar ett e-postmeddelande från detaljkortet **Aktiviteter**.

## E-postmeddelandet har redan arkiverats i SuperOffice CRM

När ett e-postmeddelande arkiveras av en användare taggas det med ett unikt ID i SuperOffice CRM. Det innebär att nästa gång någon försöker arkivera samma e-postmeddelande visas en varning som informerar personen om detta. På så sätt kan dubbletter undvikas i databasen.

Om du öppnar ett e-postmeddelande som redan har arkiverats blir knappen **Arkivera e-post** ![ikon][img1] grön med en vit markering. Om du håller muspekaren över knappen visas en inforuta som anger när och av vem e-postmeddelandet arkiverades. Detta förutsätter att du har valt alternativet **Utför dubblettkontroll när ett e-postmeddelande öppnas** i dialogrutan **Alternativ för SuperOffice CRM**.

## Relaterat innehåll

* [Arkiveringsalternativ][9]
* [Allmänna inställningar][5]

<!-- Referenced links -->
[1]: archive-as-activity.md
[2]: archive-on-contact.md
[3]: archive-attachment.md
[4]: archive-as-request.md
[5]: settings/general.md
[9]: settings/default.md
[6]: create-in-outlook.md
[8]: create-in-superoffice.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/mail-link/already-archived.png
