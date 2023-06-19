---
uid: help-sv-mailing-add-google-analytics
title: Så här lägger du till din Google Analytics-tagg i ett utskick
description: I den här guiden förklarar vi hur du spårar dina besökare.
author: Bergfrid Dias
so.date: 02.20.2023
keywords: Marknadsföring
so.topic: howto
language: sv
---

# Så här lägger du till din Google Analytics-tagg i ett utskick

Du kan spåra personer som besöker din webbplats eftersom de läst dina utskick genom att använda Google Analytics-funktionen i SuperOffice Marknadsföring. Google Analytics-spårningen måste konfigureras i det [första steget för varje utskick][1] du skapar.

## Krav

Om du vill använda [Google Analytics-funktionen][2] behöver du ett Google Analytics-konto som är kopplat till din webbplats.

[!include[Requirement](includes/req-marketing.md)]

## Steg

1. Börja med att öppna utskicket du vill spåra med Google Analytics eller skapa ett nytt utskick. Gå till det första steget i e-postguiden (Konfiguration). Rubriken **Spårning** finns i det nedre högra hörnet. Här kan du markera rutorna **Spåra alla länkar** och **Använd Google Analytics**. När du markerar Använd Google Analytics visas textfälten i Google Analytics.

    ![Markera rutan för Google Analytics och spåra alla länkar -screenshot][img1]

2. I fälten **Google Analytics-spårning** är "E-post" fördefinierat som medium. Det innebär att spårade utskick som skickas från SuperOffice CRM nu finns i Google Channel-rapporter under **E-post** istället för **Annat**.

3. För att identifiera ett specifikt utskick som källa måste fälten för Källa och Kampanj också fyllas i.

    * I fältet **Källa** kan du lägga till källan till din webbplatstrafik. Här kan du välja att använda de olika e-marknadsföringsprenumerationerna, som till exempel Månadsnyhetsbrev, Kampanjutskick etc.

    * I fältet **Kampanj** kan du ange namnet på den kampanj du genomför. Detta gör det lättare att spåra och rapportera resultatet av det utskick du har skickat ut. Här kan du ange kampanjnamn, till exempel julförsäljningskampanj eller höstförsäljningskampanj och så vidare.

4. När du har konfigurerat alla detaljer du vill använda för att spåra ditt utskick i Google Analytics kan du följa stegen i e-postguiden. Klicka på **Nästa** för att välja mall, lägga till innehåll, lägga till mottagare och skicka ditt utskick.

Alla länkar du lägger till i det tredje steget (Innehåll) spåras automatiskt eftersom du har aktiverat Google Analytics-funktionen. När dina mottagare klickar på länkarna till din webbplats kan du spåra deras besök på din webbplats i Google Analytics.

## Så här kontrollerar du resultatet av ditt utskick i Google Analytics

Du kan kontrollera resultatet av dina utskick genom att logga in på ditt Google Analytics-konto. Dina utskick ska vara synliga i Google Channel-rapporterna under E-post.

> [!NOTE]
> Ge Google Analytics lite tid att behandla din spårningsinformation. Det kan ta någonstans mellan 1–24 timmar innan din e-postkälla registreras i dina rapporter.

<!-- Referenced links -->
[1]: ../../mailing/learn/create/tutorial-email-mailing.yml
[2]: index.md#google

<!-- Referenced images -->
[img1]: media/google-analytics-tag.png
