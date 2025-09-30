---
uid: help-sv-mailing-send-test
title: Testa utskick genom att skicka ett testmejl
description: I den här guiden förklarar vi hur du skickar ett testutskick.
keywords: Marknadsföring
author: SuperOffice Product and Engineering
date: 09.26.2025
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
language: sv
---

# Skicka ett testmejl för e-postutskick och formulärsvar

När du har skapat en slagkraftig ämnesrad, lagt till din text, lagt in länkar och bilder i din e-postmall kan du göra några tester för att kontrollera att utskicket fungerar korrekt och att layouten ser OK ut. I steget **Innehåll** kan du skicka ett testmeddelande via e-post. Detta är inte relevant för dokument och SMS.

Skapa ett litet urval som består av dig och några av dina kollegor. Du kan skicka det utskick du förberett till dig själv och dina kollegor för att få feedback och godkännande innan du skickar det till din målgrupp.

![Testa ditt utskick innan du skickar det till allmänheten -screenshot][img2]

## Steg

1. Gå till steget **Innehåll**.
2. Klicka på knappen **Skicka test** i nedre vänstra hörnet.
3. Ange en e-postadress. Du kan lägga till flera e-postadresser genom att använda ; som avgränsare.
4. Klicka på **OK**. Meddelandet skickas till de angivna e-postadresserna.

## Vad bör jag testa?

När du testar ett utskick är det viktigt att du kontrollerar följande:

* Att mallvariablerna har ersatts med kunddata. Till exempel ser du "Hej John" och inte "Hej **\[\[customer.firstname\]\]**".
* Att länkarna fungerar och pekar på rätt sidor.
* Att eventuella klick på länkarna registreras i SuperOffice Marknadsföring.
* Att meddelanden som öppnas registreras i SuperOffice Marknadsföring.
* Att bilderna visas som de ska.
* Att meddelandets layout ser bra ut.
* Att meddelandet är uppdaterat (datum, årtal, namn, versionsnummer osv.) och inte innehåller stavfel.
* Att utskicket är [läsbart på en smarttelefon eller pekdator][1].

## Nollställa räknare efter testning

När du har skickat ett testutskick måste du nollställa räknarna för länkarna i meddelandet. Annars kommer listan att inkludera de klick på länkarna som du och andra personer gjorde under testet.

1. Gå till fliken **Spårade länkar**
2. Klicka på menyknappen bredvid den aktuella länken och välj **Nollställ**. Kolumnen **Klick** sätts då på **0**. Informationen om vilka kunder som klickat på länken tas också bort.

<!-- Referenced links -->
[1]: ../../../learn/best-practices.md#mobile

<!-- Referenced images -->
[img2]: ../../../../../media/loc/en/marketing/test-mailing.png
