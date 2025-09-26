---
uid: help-nl-mailing-google-analytics-tutorial
title: Handleiding - eenvoudige Google Analytics e-mailtracking
description: Deze handleiding zal uitleggen hoe je resultaten van een mailing kunt volgen met SuperOffice en deze kunt opzoeken in Google Analytics samen met al je andere gegevens.
keywords: Marketing, mailing, Google Analytics, e-mailtracking, gevolgde links, tracking-ID, UTM, campagne, nieuwsbrief
author: Alex Pelan
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
translation_type: MT
---

# Handleiding - eenvoudige Google Analytics e-mailtracking

<!-- markdownlint-disable-next-line MD036 -->
*Blogpost door Alex Pelan*

E-mailmarketing is een belangrijk onderdeel geworden van de marketingstrategieën van bedrijven, maar er zijn talloze manieren om tegenwoordig digitale marketing uit te voeren. E-mailmarketing is slechts een deel van het grote geheel. Wanneer men bijvoorbeeld de resultaten van een campagne wil analyseren, is het nuttig om gegevens van alle marketingkanalen in één systeem te verzamelen om het totaalbeeld te krijgen.

Deze handleiding zal uitleggen hoe je resultaten van een mailing kunt volgen met SuperOffice en deze kunt opzoeken in Google Analytics samen met al je andere gegevens.

## Wat we gaan doen

We gaan een Google Analytics-account opzetten. Links en gevolgde links in SuperOffice maken die resultaten naar Google Analytics zullen posten. Vervolgens tonen we deze resultaten in Google Analytics.

Om deze gids te volgen, heb je een bestaande website met een domeinnaam nodig.

## Stel een Google Analytics-account in

Ga naar [analytics.google.com][1] en meld je aan om toegang te krijgen tot Google Analytics. Wanneer je een nieuw account aanmaakt, geef het dan een passende accountnaam.

![Nieuwe Google Analytics-account -screenshot][img2]

Vervolgens moet je de eigenschap (website) instellen, zoals dit:

![Google Analytics - het instellen van uw eigendom -screenshot][img3]

Nu kun je je trackingcode ophalen. Kopieer en plak dit in de code van elke pagina die je wilt volgen. Plaats het net voor de afsluitende `</head >`-tag.

![Google Analytics tracking-ID -screenshot][img4]

Nadat je de code hebt geïmplementeerd, voer je de URL van je website in je browser in. Ga nu terug naar **Google Analytics** > **Rapportage** > **Realtime** > **Overzicht**. Als je alles correct hebt gedaan, zou de widget Nu moeten 1 actieve gebruiker weergeven.

![Google Analytics - overzicht -screenshot][img5]

## Maak traceerbare links in SuperOffice

Eerst moet je een nieuwe mailing instellen. In dit voorbeeld heb ik een nieuwsbrief gemaakt waarbij ik wil bijhouden hoeveel gebruikers op de link Meer lezen hebben geklikt. Natuurlijk willen we deze gegevens in Google Analytics zien. We zullen alleen het deel van het maken van de link doornemen.

![SuperOffice trackinglink -screenshot][img6]

Bij het maken van de link in SuperOffice vragen we om een URL. Om te kunnen zien dat de gebruiker van de nieuwsbrief komt, moet je enkele relevante parameters aan de URL toevoegen. Deze zijn:

| Instelling | UTM-parameter | Vereist | Beschrijving |
|---|---|:-:|---|
| Campagnebron | utm_source | X | Identificeert een zoekmachine, nieuwsbriefnaam of andere bron. Voorbeeld: `utm_source=newsletter June 2015` |
| Campagnemedium | utm_medium | X | Identificeert een medium zoals e-mail of kosten-per-klik. Voorbeeld: `utm_medium=email` |
| Campagne-inhoud | utm_content | | Wordt gebruikt voor A/B-testen en inhoudsgerichte advertenties. Gebruik utm_content om advertenties of links te onderscheiden die naar dezelfde URL wijzen. Voorbeelden: `utm_content=logolink`, `utm_content=textlink` |
| Campagnenaam | utm_campaign | | Wordt gebruikt voor trefwoordanalyse. Identificeert een specifieke productpromotie of strategische campagne. Voorbeeld: `utm_campaign=newsletters` |

De uiteindelijke URL zou er zo uit moeten zien:

`http://www.somecorp.com/index.html?utm_source=newsletter%20june%202015&utm_medium=email&utm_content=textlink&utm__campaign=newsletters`

Onthoud dat URL's geen spaties verwerken, dus je moet spaties in de URL vervangen door %20. Probeer [Google's URL-builder][2] om je te helpen deze URL's te genereren.

De URL die je hebt gemaakt of gegenereerd met de URL-builder plak je in het URL-veld voor een link, zoals hieronder getoond:

![URL -screenshot][img7]

Of je kunt dezelfde URL invoegen in een gevolgde link, zoals dit:

![URL invoegen -screenshot][img8]

Nu zijn we klaar om de nieuwsbrief te verzenden. Nadat je de nieuwsbrief hebt verzonden, ga je terug naar Google Analytics.

![Google Analytics -screenshot][img9]

Je zult nu het verkeer zien dat door je e-mailnieuwsbrief is gegenereerd. Zoals je op de afbeelding kunt zien, kun je statistieken zien voor de campagne **Nieuwsbrief juni 2015**. Je zult ook zien van welk medium deze gebruikers komen en het aantal klikken voor elk medium. Dit stelt ons in staat om te vergelijken welk medium de meeste klikken genereert.

Begin met het verkennen van de mogelijkheden!

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
