---
uid: help-no-mailing-google-analytics-tutorial
title: Veiledning - enkel sporing av Google Analytics e-post
description: Denne veiledningen vil forklare hvordan du kan spore resultater fra en utsendelse ved hjelp av SuperOffice og slå det opp i Google Analytics sammen med alle dine andre data.
keywords: Marketing, markedsføring, utsendelse, Google Analytics, sporing, sporingslenke, UTM, kampanje, nyhetsbrev
author: Alex Pelan
date: 06.25.2015
version: 8
topic: tutorial
language: no
translation_type: MT
audience: person
audience_tooltip: SuperOffice Marketing
---

# Veiledning - enkel sporing av Google Analytics e-post

<!-- markdownlint-disable-next-line MD036 -->
*Blogginnlegg av Alex Pelan*

E-postmarkedsføring har blitt en viktig del av bedrifters markedsføringsstrategier, men det er utallige måter å utføre digital markedsføring på i disse dager. E-postmarkedsføring er bare en del av det store bildet. Når man skal analysere resultatene av for eksempel en kampanje, er det nyttig å samle data fra alle markedsføringskanaler i ett system for å få det overordnede bildet.

Denne veiledningen vil forklare hvordan du kan spore resultater fra en utsendelse ved hjelp av SuperOffice og slå det opp i Google Analytics sammen med alle dine andre data.

## Hva vi skal gjøre

Vi skal sette opp en Google Analytics-konto. Opprette lenker og sporbare lenker i SuperOffice som vil poste resultater til Google Analytics. Deretter endelig vise disse resultatene i Google Analytics.

For å følge denne veiledningen trenger du en eksisterende nettside med et domenenavn.

## Sett opp en Google Analytics-konto

Gå til [analytics.google.com][1] og registrer deg for å få tilgang til Google Analytics. Når du oppretter en ny konto, gi den et passende kontonavn.

![Ny Google Analytics-konto -screenshot][img2]

Deretter må du sette opp nettstedet, slik:

![Google Analytics - setter opp nettstedet -screenshot][img3]

Nå kan du hente sporingskoden din. Kopier og lim inn dette i koden på hver side du vil spore. Plasser den rett før den avsluttende `</head >`-taggen.

![Google Analytics sporings-ID -screenshot][img4]

Når du har implementert koden, skriv inn URL-en til nettstedet ditt i nettleseren din. Gå nå tilbake til **Google Analytics** > **Rapportering** > **Sanntid** > **Oversikt**. Hvis du gjorde alt riktig, skal widgeten Akkurat nå vise 1 aktiv bruker.

![Google Analytics - oversikt -screenshot][img5]

## Opprett sporingslenker i SuperOffice

Først må du sette opp en ny utsendelse. I dette eksemplet har jeg laget et nyhetsbrev der jeg ønsker å spore hvor mange brukere som har klikket på Les mer-lenken. Selvfølgelig ønsker vi å se disse dataene i Google Analytics. Vi skal bare gå gjennom delen om å opprette lenken.

![SuperOffice sporingslenke -screenshot][img6]

Når du oppretter lenken i SuperOffice, ber den om en URL. For å kunne se at brukeren kommer fra nyhetsbrevet, må du legge til noen relevante parametere i URL-en. Disse er:

| Innstilling | UTM-parameter | Påkrevd | Beskrivelse |
|---|---|:-:|---|
| Kampanjekilde | utm_source | X | Identifiserer en søkemotor, nyhetsbrevnavn eller annen kilde. Eksempel: `utm_source=newsletter June 2015` |
| Kampanjemedium | utm_medium | X | Identifiserer et medium som e-post eller kostnad-per-klikk. Eksempel: `utm_medium=email` |
| Kampanjeinnhold | utm_content | | Brukes til A/B-testing og innholdsrettede annonser. Bruk utm_content for å differensiere annonser eller lenker som peker til samme URL. Eksempler: `utm_content=logolink`, `utm_content=textlink` |
| Kampanjenavn | utm_campaign | | Brukes til nøkkelordsanalyse. Identifiserer en spesifikk produktfremming eller strategisk kampanje. Eksempel: `utm_campaign=newsletters` |

Den endelige URL-en skal være noe som dette:

`http://www.somecorp.com/index.html?utm_source=newsletter%20june%202015&utm_medium=email&utm_content=textlink&utm__campaign=newsletters`

Husk at URL-er ikke håndterer mellomrom, så du må erstatte mellomrom med %20 i URL-en. Prøv [Google's URL builder][2] for å hjelpe deg med å generere disse URL-ene.

URL-en du opprettet eller genererte med URL-builderen limer du inn i URL-feltet for en lenke, som vist nedenfor:

![URL -screenshot][img7]

Eller du kan sette inn den samme URL-en i en sporbar lenke, slik:

![Sett inn URL -screenshot][img8]

Nå er vi klare til å sende nyhetsbrevet. Når du har sendt nyhetsbrevet, gå tilbake til Google Analytics.

![Google Analytics -screenshot][img9]

Du vil nå se trafikken generert av e-postnyhetsbrevet ditt. Som du ser på bildet, kan du se statistikk for kampanjen **Nyhetsbrev juni 2015**. Du vil også se hvilket medium disse brukerne kommer fra og antall klikk for hvert medium. Dette vil gjøre det mulig for oss å sammenligne hvilket medium som genererer flest klikk.

Begynn å utforske mulighetene!

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
