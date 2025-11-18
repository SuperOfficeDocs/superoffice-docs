---
uid: help-sv-utm-setup
title: Ställ in UTM-spårning
description: Lär dig hur du aktiverar och använder UTM-spårning i SuperOffice Marketing för att registrera leadkällor.
keywords: aktivera UTM, konverteringsspårning, leadkälla
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Ställ in UTM-spårning

UTM-spårning gör det möjligt för SuperOffice att registrera källan, mediet och kampanjen som genererade ett lead. Den här inställningen säkerställer att varje formulärinlämning kan spåras tillbaka till den marknadsaktivitet som drev den.

Du måste göra en **engångsinställning** (av en administratör eller webbutvecklare) och sedan utföra några **återkommande steg** för varje kampanj.

## Stegöversikt

| Steg | Vem | Frekvens | Syfte |
|---|---|---|---|
| **1. Aktivera överföring av UTM-data** | Administratör | En gång | Gör det möjligt för formulär att registrera UTM-data och spara dem i CRM-fält. |
| **2. Lägg till UTM-spårningsskriptet på din webbplats** | Webbutvecklare | En gång | Aktiverar bestående UTM-spårning över sidor och sessioner. |
| **3. Skapa kampanjslänkar med UTM-parametrar** | Marknadsförare | För varje kampanj | Identifierar var trafiken kommer ifrån. |
| **4. Använd länken i kampanjer** | Marknadsförare | För varje kampanj | Använd de taggade länkarna i annonser, e-post och sociala medier. |
| **5. Publicera formuläret korrekt** | Marknadsförare | För varje kampanj | Säkerställ att formuläret publiceras på ett sätt som registrerar UTM-data. |
| **6. Testa och verifiera inställningen** | Marknadsförare | Efter första inställning och före varje kampanj | Kontrollera att spårning och datainsamling fungerar korrekt. |
| **7. Analysera och visualisera resultat** | Marknadsförare | Efter varje kampanj | Mät kampanjresultat i dashboards och rapporter. |

## <a id="enable"></a>1. Aktivera överföring av UTM-data

**Vem:** Administratör

**När:** En gång

Att aktivera överföring av UTM-data gör att SuperOffice kan samla in information om varifrån besökare kommer när de skickar in ett formulär.

Datan blir tillgänglig på både **kontaktkortet** och **formulärinlämningen**.

1. Gå till **Inställningar och underhåll** > **Marketing**.
1. Aktivera **Överför UTM-data vid formulärinlämningar**.

   ![Inställningssidan för Marketing i SuperOffice Inställningar och underhåll som visar alternativet att aktivera överföring av UTM-data. -screenshot][img1]

## <a id="script"></a>2. Lägg till UTM-spårningsskriptet på din webbplats

**Vem:** Webbutvecklare eller webbansvarig

**När:** En gång

Skriptet möjliggör bestående spårning. Det lyssnar efter UTM-parametrar i URL:en och sparar dem tillfälligt i webbläsaren så att även om en besökare navigerar mellan flera sidor innan formuläret skickas in, registreras first touch-data.

1. Kopiera skriptet nedan.
1. Klistra in det i din webbplatskod direkt efter `<head>`-taggen.
1. Publicera den uppdaterade sidan.

```html
<!-- SuperOffice UTM tag -->
<script src="https://sod2.superoffice.com/CustXXXXX/cs/javascript/utm.js"></script>
```

> [!TIP]
> Utan skriptet fångas UTM-data endast för direkta formulärlänkar, inte för besökare som navigerar mellan sidor.

## <a id="build-url"></a>3. Skapa kampanjslänkar med UTM-parametrar

**Vem:** Marknadsförare

**När:** För varje kampanj

UTM-parametrar identifierar var dina besökare kommer ifrån och hur de interagerar med dina kampanjer.

Du kan lägga till parametrarna manuellt eller använda ett UTM-byggarverktyg.

```text
https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=webinar_sept
```

Använd [SuperOffice UTM-byggare för formulärsidor][1] eller [Googles Campaign URL Builder][4] för att skapa konsekventa kampanjslänkar och minska manuella fel.

**Standardparametrar:**
utm_source, utm_medium, utm_campaign, utm_term, utm_content

För beskrivningar och namnkonventioner, se [UTM-parametrar][2].

## <a id="tag"></a>4. Använd länken i kampanjer

**Vem:** Marknadsförare

**När:** För varje kampanj

Använd länken där du marknadsför kampanjen, till exempel:

* Knappar i blogginlägg
* Nyhetsbrev
* Facebook-annonser
* Google Ads
* LinkedIn-inlägg

## <a id="publish"></a>5. Publicera formuläret korrekt

**Vem:** Marknadsförare

**När:** För varje kampanj

SuperOffice kan registrera UTM-data oavsett om formuläret är **inbäddat** på din webbplats eller **hostat** av SuperOffice.

| Metod | Beskrivning | Registrerar first touch? |
|---|---|---|
| **Inbäddat formulär** | Lägg till spårningsskriptet på din webbplats och använd en landningssida med UTM-taggad URL. | <i class="ph ph-check-circle" aria-hidden="true"></i> Ja |
| **SuperOffice-hostat formulär (direktlänk)** | Lägg till UTM-parametrar i SuperOffice-formulärets URL. | <i class="ph ph-warning-circle" aria-hidden="true"></i> Nej |

> [!TIP]
> Länka inte direkt från din webbplats till ett SuperOffice-hostat formulär, eftersom UTM-taggar kan gå förlorade mellan sidor.

## <a id="test"></a>6. Testa och verifiera inställningen

**Vem:** Marknadsförare

**När:** Efter första inställning och före varje ny kampanj

1. Klicka på en av dina kampanjslänkar.
1. Fyll i och skicka formuläret.
1. Öppna det nya kontaktkortet i SuperOffice.
1. Kontrollera att fälten **källa**, **medium** och/eller **kampanj** innehåller data.

Om data saknas, kontrollera att:

* Spårningsskriptet är korrekt installerat.
* UTM-parametrarna är korrekt stavade och formaterade.
* Webbläsarens cookies inte är blockerade eller raderade mellan besök.

## <a id="analyze"></a>7. Analysera och visualisera resultat

**Vem:** Marknadsförare

**När:** Efter varje kampanj

När data har registrerats kan du mäta resultat i dashboards och rapporter.

* Visa nya leads efter **first touch-källa** (vilken kanal som genererade trafik).
* Visa nya leads efter **kampanj** (vilken kampanj som genererade konverteringar).
* Skapa en **dashboard-panel** som visar nya leads efter källa, medium eller kampanj för innevarande år.

Läs mer om dashboards i [Marknadsföringspaneler och rapporter][5].

[2]: ../learn/parameters.md
[1]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: ../../../dashboard/learn/show-leads.md

[img1]: ../../../../media/loc/en/marketing/conversion-tracking.png
