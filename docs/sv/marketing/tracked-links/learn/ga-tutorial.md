---
uid: help-sv-mailing-google-analytics-tutorial
title: Guide - enkel spårning av Google Analytics e-post
description: Denna guide kommer att förklara hur du kan spåra resultat från en utskick med hjälp av SuperOffice och slå upp det i Google Analytics tillsammans med alla dina andra data.
keywords: Marketing, marknadsföring, utskikt, Google Analytics, spårning, spårningslänk, UTM, kampanj, nyhetsbrev
author: Alex Pelan
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
translation_type: MT
---

# Guide - enkel spårning av Google Analytics e-post

<!-- markdownlint-disable-next-line MD036 -->
*Blogginlägg av Alex Pelan*

E-postmarknadsföring har blivit en viktig del av företagens marknadsföringsstrategier, men det finns otaliga sätt att utföra digital marknadsföring på dessa dagar. E-postmarknadsföring är bara en del av den stora bilden. När man ska analysera resultaten av till exempel en kampanj, är det användbart att samla data från alla marknadsföringskanaler i ett system för att få den övergripande bilden.

Denna guide kommer att förklara hur du kan spåra resultat från en utskick med hjälp av SuperOffice och slå upp det i Google Analytics tillsammans med alla dina andra data.

## Vad vi ska göra

Vi kommer att skapa ett Google Analytics-konto. Skapa länkar och spårade länkar i SuperOffice som kommer att posta resultat till Google Analytics. Sedan slutligen visa dessa resultat i Google Analytics.

För att följa denna guide behöver du en befintlig webbplats med ett domännamn.

## Skapa ett Google Analytics-konto

Gå till [analytics.google.com][1] och registrera dig för att få tillgång till Google Analytics. När du skapar ett nytt konto, ge det ett lämpligt kontonamn.

![Ny Google Analytics-konto -screenshot][img2]

Nästa steg är att du behöver ställa in webbplatsen, så här:

![Google Analytics - inställning av din webbplats -screenshot][img3]

Nu kan du hämta din spårningskod. Kopiera och klistra in detta i koden på varje sida du vill spåra. Placera den precis före den avslutande `</head >`-taggen.

![Google Analytics spårnings-ID -screenshot][img4]

När du har implementerat koden, skriv in URL:en till din webbplats i din webbläsare. Gå nu tillbaka till **Google Analytics** > **Rapportering** > **Real-Time** > **Overview**. Om du gjorde allt korrekt, bör widgeten Just nu visa 1 aktiv användare.

![Google Analytics - översikt -screenshot][img5]

## Skapa spårbara länkar i SuperOffice

Först behöver du ställa in en ny utskick. I det här exemplet har jag skapat ett nyhetsbrev där jag vill spåra hur många användare som har klickat på Läs mer-länken. Självklart vill vi se dessa data i Google Analytics. Vi kommer bara att gå igenom delen om att skapa länken.

![SuperOffice spårningslänk -screenshot][img6]

När du skapar länken i SuperOffice ber vi om en URL. För att kunna se att användaren kommer från nyhetsbrevet behöver du lägga till några relevanta parametrar i URL:en. Dessa är:

| Inställning | UTM-parameter | Krävs | Beskrivning |
|---|---|:-:|---|
| Kampanjkälla | utm_source | X | Identifierar en sökmotor, nyhetsbrevnamn eller annan källa. Exempel: `utm_source=newsletter June 2015` |
| Kampanjemedium | utm_medium | X | Identifierar ett medium som e-post eller kostnad-per-klick. Exempel: `utm_medium=email` |
| Kampanjeinnehåll | utm_content | | Används för A/B-testning och innehållsinriktade annonser. Använd utm_content för att differentiera annonser eller länkar som pekar på samma URL. Exempel: `utm_content=logolink`, `utm_content=textlink` |
| Kampanjnamn | utm_campaign | | Används för sökordsanalys. Identifierar en specifik produktfrämjande eller strategisk kampanj. Exempel: `utm_campaign=newsletters` |

Den slutliga URL:en ska vara något som detta:

`http://www.somecorp.com/index.html?utm_source=newsletter%20june%202015&utm_medium=email&utm_content=textlink&utm__campaign=newsletters`

Kom ihåg att URL:er inte hanterar mellanslag, så du behöver ersätta mellanslag med %20 i URL:en. Prova [Google's URL builder][2] för att hjälpa dig att generera dessa URL:er.

URL:en du skapade eller genererade med URL-builderen klistrar du in i URL-fältet för en länk, som visas nedan:

![URL -screenshot][img7]

Eller du kan infoga samma URL i en spårningslänk, så här:

![Infoga URL -screenshot][img8]

Nu är vi redo att skicka nyhetsbrevet. När du har skickat nyhetsbrevet, gå tillbaka till Google Analytics.

![Google Analytics -screenshot][img9]

Du kommer nu att se trafiken som genereras av ditt e-postnyhetsbrev. Som du ser på bilden kan du se statistik för kampanjen **Nyhetsbrev juni 2015**. Du kommer också att se vilket medium dessa användare kommer från och antalet klick för varje medium. Detta kommer att göra det möjligt för oss att jämföra vilket medium som genererar flest klick.

Börja utforska möjligheterna!

<!-- Referenced links -->
[1]: http://analytics.google.com
[2]: https://support.google.com/analytics/answer/1033867

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/marketing/new-account.png
[img3]: ../../../../media/loc/en/marketing/setting-up-property.png
[img4]: ../../../../media/loc/en/marketing/tracking-id.png
[img5]: ../../../../media/loc/en/marketing/overview-right-now.png
[img6]: ../../../../media/loc/en/marketing/so-trackable-links.png
[img7]: ../../../../media/loc/en/marketing/generated-link.png
[img8]: ../../../../media/loc/en/marketing/insert-url.png
[img9]: ../../../../media/loc/en/marketing/google-analytics.png
