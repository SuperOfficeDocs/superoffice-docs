---
uid: help-da-mailing-google-analytics-tutorial
title: Vejledning - simpel Google Analytics e-mail sporing
description: Denne vejledning vil forklare, hvordan du kan spore resultater fra en udsendelse ved hjælp af SuperOffice og slå det op i Google Analytics sammen med alle dine andre data.
keywords: Marketing, udsendelse, Google Analytics, sporing, sporingslinks, UTM, kampagne, nyhedsbrev
author: Alex Pelan
date: 06.25.2015
version: 8
topic: tutorial
language: da
translation_type: MT
audience: person
audience_tooltip: SuperOffice Marketing
---

# Vejledning - simpel Google Analytics e-mail sporing

<!-- markdownlint-disable-next-line MD036 -->
*Blogindlæg af Alex Pelan*

E-mail marketing er blevet en vigtig del af virksomheders marketingstrategier, men der er utallige måder at udføre digital marketing på i disse dage. E-mail marketing er kun en del af det store billede. Når man skal analysere resultaterne af for eksempel en kampagne, er det nyttigt at samle data fra alle marketingkanaler i ét system for at få det overordnede billede.

Denne vejledning vil forklare, hvordan du kan spore resultater fra en udsendelse ved hjælp af SuperOffice og slå det op i Google Analytics sammen med alle dine andre data.

## Hvad vi skal gøre

Vi skal oprette en Google Analytics-konto. Oprette links og sporede links i SuperOffice, der vil sende resultater til Google Analytics. Derefter endelig vise disse resultater i Google Analytics.

For at følge denne vejledning skal du have et eksisterende websted med et domænenavn.

## Opret en Google Analytics-konto

Gå til [analytics.google.com][1] og tilmeld dig for at få adgang til Google Analytics. Når du opretter en ny konto, skal du give den et passende kontonavn.

![Nyt Google Analytics-konto -screenshot][img2]

Dernæst skal du oprette webstedet, sådan her:

![Google Analytics - opsætning af dit websted -screenshot][img3]

Nu kan du hente din sporingskode. Kopier og indsæt dette i koden på hver side, du vil spore. Placer det lige før den afsluttende `</head >`-tag.

![Google Analytics sporings-ID -screenshot][img4]

Når du har implementeret koden, skal du indtaste URL'en til dit websted i din browser. Gå nu tilbage til **Google Analytics** > **Rapportering** > **Real-Time** > **Overview**. Hvis du gjorde alt korrekt, skal widgeten Right now vise 1 aktiv bruger.

![Google Analytics - oversigt -screenshot][img5]

## Opret sporingslinks i SuperOffice

Først skal du oprette en ny udsendelse. I dette eksempel har jeg oprettet et nyhedsbrev, hvor jeg gerne vil spore, hvor mange brugere der har klikket på Læs mere-linket. Selvfølgelig vil vi gerne se disse data i Google Analytics. Vi vil kun gennemgå delen om at oprette linket.

![SuperOffice sporingslink -screenshot][img6]

Når du opretter linket i SuperOffice, beder vi om en URL. For at kunne se, at brugeren kommer fra nyhedsbrevet, skal du tilføje nogle relevante parametre til URL'en. Disse er:

| Indstilling | UTM-parameter | Krævet | Beskrivelse |
|---|---|:-:|---|
| Kampagnekilde | utm_source | X | Identificerer en søgemaskine, nyhedsbrevnavn eller anden kilde. Eksempel: `utm_source=newsletter June 2015` |
| Kampagnemedium | utm_medium | X | Identificerer et medium som e-mail eller cost-per-click. Eksempel: `utm_medium=email` |
| Kampagneindhold | utm_content | | Bruges til A/B-test og indholdsrettede annoncer. Brug utm_content til at differentiere annoncer eller links, der peger på samme URL. Eksempler: `utm_content=logolink`, `utm_content=textlink` |
| Kampagnenavn | utm_campaign | | Bruges til nøgleordsanalyse. Identificerer en specifik produktfremme eller strategisk kampagne. Eksempel: `utm_campaign=newsletters` |

Den endelige URL skal være noget som dette:

`http://www.somecorp.com/index.html?utm_source=newsletter%20june%202015&utm_medium=email&utm_content=textlink&utm__campaign=newsletters`

Husk, at URL'er ikke håndterer mellemrum, så du skal erstatte mellemrum med %20 i URL'en. Prøv [Google's URL builder][2] for at hjælpe dig med at generere disse URL'er.

URL'en, du oprettede eller genererede med URL-builderen, indsætter du i URL-feltet for et link, som vist nedenfor:

![URL -screenshot][img7]

Eller du kan indsætte den samme URL i et sporingslink, sådan her:

![Indsæt URL -screenshot][img8]

Nu er vi klar til at sende nyhedsbrevet. Når du har sendt nyhedsbrevet, skal du gå tilbage til Google Analytics.

![Google Analytics -screenshot][img9]

Du vil nu se trafikken genereret af dit e-mail-nyhedsbrev. Som du ser på billedet, kan du se statistik for kampagnen **Nyhedsbrev juni 2015**. Du vil også se, hvilket medium disse brugere kommer fra, og antallet af klik for hvert medium. Dette vil gøre det muligt for os at sammenligne, hvilket medium der genererer flest klik.

Begynd at udforske mulighederne!

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
