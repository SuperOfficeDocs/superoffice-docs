---
uid: help-no-other-applications
title: Legg til eksterne applikasjoner
description: Legge til eksterne applikasjoner på listen Applikasjon
keywords: eksterne applikasjoner, listen GUI - Applikasjon
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: customization
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /no/admin/lists/learn/applications
  - /no/admin/lists/learn/adding-external-applications-to-application-list
language: no
---

# Legg til eksterne applikasjoner

Du kan ha snarveier til eksterne applikasjoner i SuperOffice CRM, slik at du kan åpne dem direkte fra SuperOffice CRM for Windows. Du definerer hvilke URL-adresser som skal være tilgjengelige for brukerne i **Lister**-bildet i Innstillinger og vedlikehold.

> [!NOTE]
> Filer eller applikasjoner som må kjøres lokalt (for eksempel .exe filer), er ikke tilgjengelige i SuperOffice CRM for Web.

## Steps

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **GUI - Applikasjon** fra rullegardinmenyen.

1. Klikk på **Legg til**-knappen under Forekomster-listen.

1. Skriv inn ønsket navn på forekomsten i feltet **Navn**. Dette navnet kommer til å vises der du legger til applikasjonen i SuperOffice CRM (se trinn 7 om listeboksen **Vis**). *(Obligatorisk)*

1. Under **Legg til som** velger du hva applikasjonen skal legges til som:

    * **Knapp**: applikasjonsikonet vises i Navigator. Brukeren kan da åpne applikasjonen direkte ved å klikke på ikonet i navigatoren.
    * **Menyvalg**: Brukeren får tilgang til applikasjonen ved å klikke på **Verktøy**-knappen (<i class="ph ph-wrench" aria-hidden="true"></i>) i navigatoren og/eller velge **Andre applikasjoner** på hovedmenyen (<i class="ph ph-list" aria-hidden="true"></i>).
    * **Arrangement**: Applikasjonen kjøres når SuperOffice CRM startes eller avsluttes, eller ved lokal oppdatering (Travel). Se trinn 8. Du kan for eksempel kjøre et synkroniseringsprogram for en PDA når SuperOffice CRM lukkes.
    * **Oppgave**: Velg et alternativ i denne listeboksen for å gjøre applikasjonen tilgjengelig fra fanen **Oppgave** i Valg-bildet eller **Oppgave**-knappene.

        <details><summary>Finn ut mer om de ulike alternativene.</summary>

        Navnene i parentes angir detaljkortet der applikasjonen er tilgjengelig.

        Eksempler:

        * **Salgsutvalg (Salg)**: Når du har åpnet et salgsutvalg i Utvalg-bildet og detaljkortet **Salg** er aktivt, vises applikasjonen som en oppgave i fanen **Oppgave**.
        * **Salgsutvalg (firmaer)**: Når du har åpnet et salgsutvalg i Utvalg-bildet og detaljkortet **Firmaer** er aktivt, vises applikasjonen som en oppgave i fanen **Oppgave**.
        * **Salgsutvalg (ekstern)**: Hvis din installasjon av SuperOffice CRM er tilknyttet en tredjepartsapplikasjon, kan det hende at det vises flere detaljkort for de ulike utvalgene. Du kan da velge for eksempel **Salgsutvalg (ekstern)** for å vise applikasjonen som en oppgave i fanen **Oppgave** når du har åpnet et salgsutvalg i Utvalg-bildet og detaljkortet for tredjepartsapplikasjonen er aktivt.

        Andre alternativer:

        * **Knapperad**: Applikasjonen vises som et alternativ på knapperaden. Brukerne må konfigurere knapperaden i SuperOffice CRM og velge å vise applikasjonen.

        * **Dialogboksen for oppfølginger**: Applikasjonen vises som et valg under **Oppgave**-knappen i dialogboksen for oppfølginger.

        * **Dialogboksen Dokument**: Applikasjonen vises som et alternativ under **Oppgave**-knappen i den valgte dialogboksen. Det samme alternativet er tilgjengelig for bildene Person, Tilbud og Produkt.

        </details>

    > [!NOTE]
    > Det er valgene du gjør under **Legg til som**, som avgjør hvilke alternativer som skal være tilgjengelige i resten av dialogboksen.

1. Under **Tilgjengelig på**, velger du hvor applikasjonen er tilgjengelig. Du kan velge flere av disse alternativene samtidig.

    * **Sentral database**: Når du jobber på den sentrale databasen.
    * **Satellitt**: Når du jobber på en satellitt.
    * **Travel**: Når du bruker en lokal database ved hjelp av Travel-funksjonen.

1. Angi ønsket applikasjon i feltet **Filnavn**.

1. I feltet **Parametere** kan du angi eventuelle oppstartsparametere for applikasjonen.

1. I feltet **Arbeidsmappe** kan du angi mappen du at skal være gjeldende mappe når applikasjonen startes. Skriv inn banen manuelt. Vanligvis lar du dette feltet stå tomt.

1. I listeboksen **Vis** velger du ønsket alternativ. Denne listeboksen vises bare hvis du valgte **Menyvalg** under **Legg til som**.

    * **Verktøykassemenyen**: Brukeren får tilgang til applikasjonen ved å klikke på **Verktøy**-knappen i navigatoren eller velge **Andre applikasjoner** på hovedmenyen i SuperOffice CRM.
    * **Vis-menyen**: Brukeren får tilgang til applikasjonen via valget **Andre applikasjoner** på **Vis**-menyen i SuperOffice CRM.

1. I listeboksen **Kjør når** velger du når applikasjonen skal kjøres. Denne listeboksen vises bare hvis du valgte **Hendelse** under **Legg til som**.

    * **SuperOffice CRM starter**: Applikasjonen kjører når SuperOffice CRM starter.
    * **SuperOffice CRM avsluttes**: Applikasjonen kjører når SuperOffice CRM lukkes.
    * **Lokal oppdatering**: Applikasjonen startes ved bruk av Travel.

1. Merk av for **Vent på at applikasjonen blir ferdig** hvis du vil at SuperOffice CRM ikke skal lukkes før du avslutter den eksterne applikasjonen. Hvis du ikke merker av her, kan du lukke SuperOffice CRM uten å lukke den eksterne applikasjonen. Denne listeboksen vises bare hvis du valgte **Hendelse** under **Legg til som**.

1. Under **Oppstartmodus** velger du hva slags vindu applikasjonen skal startes i - maksimert, minimert eller gjenopprettet.

1. I feltet **Ikon** kan du velge hvilket ikon som skal vises for applikasjonen i navigatoren i SuperOffice CRM (se trinn 7 om listeboksen **Vis**). Denne listeboksen vises bare hvis du valgte **Knapp** under **Legg til som**.

    * **Fra biblioteket**: Velg ett av de tilgjengelige ikonene på listen.
    * **Bruk programikonet**: Bruk standardikonet for valgte applikasjon.

1. Legg eventuelt inn en beskrivelse av forekomsten i feltet **Beskrivelse**.

1. Klikk på **Lagre**. Forekomsten blir nå lagt til i listen **Forekomster**. Gjenta prosedyren hvis du vil legge til flere forekomster.

> [!NOTE]
> Brukerne må logge på SuperOffice CRM på nytt før applikasjonen vises.

## Etter lagring

Når du har lagt til forekomster, kan du angi detaljer for hver forekomst. Du kan blant annet angi følgende:

* Hvilke brukergrupper [elementet er synlig for][2].
* Hvilken [overskrift][1] det skal vises under.

Forekomstene vises i den rekkefølgen de blir lagt inn. Hvis du vil endre rekkefølgen, velger du et element og flytter det opp eller ned ved hjelp av pilknappene til venstre for listen (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).

<!-- Referenced links -->
[1]: ../../admin/lists/headings.md
[2]: ../../admin/lists/user-group-filtering.md
