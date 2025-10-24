---
uid: help-no-our-companies-manage
title: Vedlikeholde Våre firmaer
description: Slik legger du til og fjerner firmaer i fanen Våre firmaer
keywords: bruker, våre firmaer
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
platform: web
index: true
redirect_from: 
  - /no/admin/user-management/learn/move-user
  - /no/admin/user-management/learn/our-companies
language: no
---

# Vedlikeholde Våre firmaer

Du kan administrere "Våre firmaer" og flytte brukere mellom dem i Bruker-bildet under Innstillinger og vedlikehold.

## Legge til firma i fanen Våre firmaer

Forutsetninger: For at et firma skal kunne legges til i fanen **Våre firmaer**, må det først være registrert som firma i SuperOffice.

1. Velg fanen **Våre firmaer**.

1. Klikk på **Legg til**-knappen under firmalisten.

1. Finn-skjermen åpnes. Hvis det allerede finnes søkekriterier, men du ikke ønsker å bruke akkurat disse, kan du klikke på **Deaktiver alle**-knappen for å deaktivere dem eller fjerne avmerkingen i avmerkingsboksen for de aktuelle kriteriene.

1. Søk etter et firma. Se detaljer under.

1. Når du har valgt ønsket firma og klikket på **OK**, vises firmaet i listen.

## Slette firma i fanen Våre firmaer

1. Kontroller at kriteriene ovenfor er oppfylt.

    * Det kan ikke være registrert noen medarbeidere på firmaet. Antall medarbeidere vises i kolonnen **Medarbeidere** på firmalisten. Hvis du vil slette et firma, må du først [slette de registrerte medarbeiderne][2].
    * Firmaet kan ikke være en aktiv satellitt. Undersøk om firmaet er oppført i kolonnen **Aktiv satellitt** i firmalisten.

1. Velg fanen **Våre firmaer**.

1. Merk ønsket firma på listen.

1. Klikk på **Slett**-knappen under firmalisten. Firmaet fjernes fra listen.

> [!NOTE]
> Du kan ikke slette firmaet som er registrert som databaseeier. Hvis du velger en databaseeier, er **Slett**-knappen deaktivert.

## <a id="move"></a>Flytte bruker fra ett firma til et annet

Du kan flytte en bruker fra ett firma til et annet hvis organisasjonen består av flere firmaer som er registrert i fanen Våre firmaer. Hvis brukere blir registrert under feil firma, eller hvis de har byttet stilling/jobb i organisasjonen, kan de flyttes, inkludert aktivitetene og salgene deres.

1. Velg fanen **Medarbeidere** og merk ønsket bruker i oversikten.

1. Klikk på **Oppgave** og velg **Flytt bruker**.

1. Gå til **Flytt til** i dialogboksen, og velg firmaet du vil flytte personen til.

1. Velg ett av følgende under **Handling på alle eksisterende aktiviteter og salg**:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    > [!NOTE]
    > For å se resultatene før du bekrefter handlingen, klikk på <i class="ph ph-info" aria-hidden="true"></i>.

1. Klikk på **Flytt**. Brukeren flyttes til det bestemte firmaet.

## Hvordan søker jeg etter et firma?

1. I listeboksen til høyre for feltet du vil søke i, velger du om du vil søke etter firmaer som **Begynner med**, **Inneholder** eller **Er lik** søkekriteriene du angir.

2. Du kan angi flere forskjellige søkekriterier, for eksempel navn, kode, telefonnummer eller e-postadresse. Angir du flere søkekriterier, søkes det etter firmaer som oppfyller alle kriteriene samtidig.

3. Når du har angitt ønskede kriterier, klikker du på **Finn**-knappen.

4. Når søket er ferdig, kan ett av følgende skje:

    * **Ett treff**: Firmaet som samsvarer med søkekriteriene, vises i listen.

    * **To eller flere treff**: Finn-skjermen viser en liste over treff. Her kan du merke ønsket firma og klikke på **OK** for å vise det aktuelle firmaet i listen.

    * **Ingen treff**: Du får en melding om at det ikke finnes noen oppføringer som samsvarer med søkekriteriene. Klikk på **OK**, og søk på nytt med andre søkekriterier.

### <a id="criteria"></a>Søkekriteriene

Feltene nedenfor tilsvarer feltene på firmakortet.

* Navn: Skriv inn hele eller begynnelsen av firmanavnet.
* Nummer: Skriv inn hele eller begynnelsen av firmanavnet.
* Kode: Skriv inn hele eller deler av koden.
* Org.nr.: Skriv inn hele eller deler av organisasjonsnummeret.
* Fornavn: Skriv inn hele eller deler av fornavnet til en person hos firmaet.
* Etternavn: Skriv inn hele eller deler av etternavnet til en person hos firmaet.
* Telefon: Skriv inn hele eller deler av et telefonnummer til firmaet.
* E-post: Skriv inn hele eller deler av en e-postadresse til firmaet.
* Tilfredsstill også: Her kan du angi ytterligere [søkekriterier][1].

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: update-user.md#delete

<!-- Referenced images -->
