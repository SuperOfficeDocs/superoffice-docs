---
uid: help-no-sale-configuration
title: Administrere salgstyper, faser og guider
description: Lær hvordan du administrerer salgsprosesser i SuperOffice CRM med salgstyper, faser og guider. Konfigurer disse verktøyene i Innstillinger og vedlikehold for å standardisere oppfølging, oppgaver og dokumentasjon.
keywords: salgsguide, salgsfase, salgstype, arbeidsflyt, salg
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
index: true
---

# Administrere salgstyper, faser og guider

SuperOffice CRM gir administratorer verktøy for å standardisere salgsprosesser ved hjelp av **salgstyper**, **faser** og **guider**. Disse funksjonene sikrer enhetlig oppfølging av salg, oppgavestyring og dokumenthåndtering i teamet ditt.

Bruk skjermbildene **Arbeidsflyt** og **Lister** i **Innstillinger og vedlikehold** for å konfigurere og administrere disse komponentene.

## Nøkkelbegreper og plasseringer

| Begrep | Definisjon | Plassering i Innstillinger og vedlikehold |
|---|---|---|
| Salgstype | Kategoriserer salg (for eksempel "Ny kunde" eller "Fornyelse") og kobler dem til faser og guider. | **Lister** > **Salg – Type, Faser, Tilbud** |
| Salgsfase | Sporer fasen et salg befinner seg i (for eksempel "Tilbud" eller "Kontraktsignering"). Defineres per salgstype. | **Lister** > **Salg – Fase** |
| Salgsguide | Et arbeidsflytverktøy som kobler faser til spesifikke oppfølginger og dokumenter. | **Arbeidsflyt** > **Salgsguide** |
| Valuta | En listeforekomst som definerer tilgjengelige valutaer for salgsbeløp, inkludert valutakurs og enhet. | **Lister** > **Generelt – Valuta** |
| Basisvaluta | Standardvalutaen som brukes til beregninger og valutakurser i hele systemet. | **Preferanser** > **Globale preferanser** > **System** > **Ledende valuta** |

## Tilpasse salgslistene dine

SuperOffice CRM er utviklet for å støtte salgstypene som er vanlige for de fleste firmaer, men det er likevel noen firmaer som kanskje vil lage sine egne.

Avhengig av hvilken type virksomhet firmaet ditt har, kan du skreddersy systemet ved å lage salgslistene du trenger.

Ta en titt på disse listene for å se om du vil endre dem:

* Salg - Kilde
* Salg - Fase
* Salg - Typekategori
* Salg - Type, Faser, Tilbud

## Hva vil du gjøre?

* [Legge til en salgsfase][3]: Definer og administrer salgsfaser som "Første møte" eller "Avslutning".
* [Legge til en salgstype][4]: Opprett kategorier som "Prospekt" og tilknytt relevante faser.
* [Opprette en ny salgsguide][1]: Utform arbeidsflyter med oppfølginger og dokumenter for salgstyper.
* [Redigere eller deaktivere en salgsguide][2]: Oppdater arbeidsflyter eller deaktiver guider for bestemte salgstyper.
* [Administrer valuta][5]: Legg til valutaer eller endre basisvalutaen som brukes i salg.

Disse verktøyene gir administratorer muligheten til å skreddersy salgsprosessene for å sikre effektivitet og enhetlighet i hele organisasjonen.

<!-- Refererte lenker -->
[1]: create-sales-guide.md
[2]: edit-sales-guide.md
[3]: sale-stage.md
[4]: sale-type.md
[5]: add-currency.md
