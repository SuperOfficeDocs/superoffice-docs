---
uid: help-no-request-category-create
title: Opprett sakskategori
description: Opprett sakskategori
author: Hanne Gunnarsson
date: 02.05.2025
version: 10.5.1
keywords: legg til sakskategori, opprett sakskategori, ny sakskategori, sakskategori, fanen Kategorier, sak, kategori
topic: howto
license: serviceessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Opprett sakskategori

1. I **Innstillinger og vedlikehold**, klikk på **Saker** i navigatoren og velg fanen **Kategorier**.

1. Klikk på **Legg til**.

1. Angi et beskrivende navn i feltet **Kategorinavn** over fanene.

1. I fanen **Egenskaper**, angi følgende informasjon:

    * **Intern eller ekstern**: Hvis du merker av for **Intern**, vil ikke kategorien være synlig i SuperOffice Kundesenter.

    * **Eksternt navn**: Her angir du det kategorinavnet som vises overfor kunden. Dette feltet må fylles ut, med mindre kategorien er intern.

    * **Underkategori av**: Hvis dette skal være en underkategori for en annen kategori, velger du ønsket overordnet kategori.

    * **Kategorisjef**: Velg hvem som skal være ansvarlig for sakene i denne kategorien. I fanen **Fordelingsmetode** kan du angi at saker skal tildeles kategorisjefen hvis ingen andre medlemmer av kategorien er tilgjengelige. Vanligvis bør en avdelingssjef ha rollen som kategorisjef.

        * **Vis kategori i statusbilde**: Hvis det er merket av her, vises denne kategorien under **Status** på **dashbordet**.
        * **Kun tilgjengelig for medlemmer**: Hvis det er merket av her, er kategorien bare tilgjengelig for medlemmer av kategorien.
        * **Send varsling til medlemmer om ny sak**: Hvis det er merket av her, får alle medlemmer av kategorien varsling om nye saker i denne kategorien.

    * **Send varsling om ny sak til e-postadresse**: Skriv inn en e-postadresse.

    * **Overta ved svar**: Hvis det er merket av her, blir brukeren som svarer på en sak i denne kategorien, satt som eier av saken.

    * **Standardstatus for ny sak**: Her velger du hvilken status som skal være standard i bildet **Sak**. Denne innstillingen overstyrer [brukerpreferanser][1], med mindre du velger **Brukerdefinert**.

    * **Standardstatus for ny melding**: Her velger du standardstatusen som skal vises i en ny melding. Denne innstillingen overstyrer [brukerpreferanser][1], med mindre du velger **Brukerdefinert**.

    * **Slå sammen utgående e-postmeldinger for denne kategorien med svarmal**: Velg hvilken svarmal som skal brukes i meldinger som sendes ut til kunder og andre personer, for saker som tilhører denne kategorien. Dette kan være en svarmal som er spesifikt opprettet for denne kategorien, for å gi alle svar fra en kategori (som støtte eller regnskap) et enhetlig utseende.

        * Merk av for **Gjelder for underkategorier** hvis du vil at den valgte svarmalen også skal brukes på eventuelle underkategorier. Dette forutsetter imidlertid at malen ikke blir overstyrt av innstillingene som er angitt i underkategoriene.

1. I fanen **Medlemmer** angir du hvem som skal være medlemmer av kategorien. Velg en bruker i listen **Bruker** nederst, og klikk på **Legg til**.

    > [!TIP]
    > Hvis **Vektet fordeling** er valgt som fordelingsmetode for sakene i denne kategorien, kan du bruke vekttallet for hver enkelt bruker til å bestemme fordelingen av nye saker. Brukerne med høyest vekttall vil bli tildelt flest saker. Du kan ikke bruke vektet fordeling for kategorimedlemmer fra brukergrupper.

1. I fanen **Fordelingsmetode** angir du følgende informasjon:

    * Velg en fordelingstype:

        * **Jevn** Fordeler sakene likt blant medlemmene av kategorien.
        * **Vektet**: Fordeler sakene basert på vekttallene som er angitt for medlemmene av kategorien.

            Eksempel: Hvis person A har vekt 1, person B har vekt 2 og person C har vekt 5, så vil hver av disse personene i løpet av 8 saker få tildelt like mange saker som vekttallet deres tilsier.

        * **Til saksbehandleren med færrest aktive saker**: Fordeler nye saker til det kategorimedlemmet som har færrest aktive saker.
        * **Ikke fordel**: Fordeler ikke saker til bestemte brukere, men legger som standard alle saker i en kø. Under **Saker** > **Ufordelte saker** (standard) eller i køsystemet **Hent neste sak i køen**.

    * **Fordel bare til innloggede brukere**: Fordeler saker bare til brukere som er logget inn i SuperOffice Service.

    * **Fordel til kategorisjef hvis ingen er tilgjengelige**: Fordeler saker til kategorisjefen hvis ingen andre brukere er tilgjengelige.

    * **Fordel sak på nytt ved ny melding om saksbehandler ikke tilgjengelig**: Fordeler saker på nytt når det kommer en ny melding i en sak, og brukeren ikke er tilgjengelig.

    * **Fordel til vår servicekontakt hvis tilgjengelig**: Hvis gjeldende firma eller person har en saksbehandler angitt som **Vår kontakt**, og hvis denne brukeren er tilgjengelig, tildeles saken til denne brukeren. Hvis **Vår kontakt** ikke er angitt, eller brukeren ikke er tilgjengelig, fordeles saken etter de vanlige fordelingsreglene.

    * **Fordelingskarantene**: Angi antall minutter du ønsker å overstyre fordelingen og tilordne alle saker fra samme kunde til én bruker. Når kunder sender to saker rett etter hverandre til samme adresse, vil sakene havne hos samme saksbehandler. Hvis du angir -1, deaktiveres denne funksjonaliteten, og alle saker vil bli fordelt i henhold til de vanlige fordelingsreglene.

1. Klikk på **Lagre**. Kategorien opprettes.

## Relatert innhold

* [Slik setter du opp Hent neste sak i køen][3]

<!-- Referenced links -->
[1]: ../../../admin/preferences/learn/index.md
[3]: ../next-in-queue.md

<!-- Referenced images -->
