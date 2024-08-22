---
uid: help-no-bulk-update
title: Masseredigering
description: Masseredigering
author: SuperOffice RnD
date: 06.29.2022
keywords: masseredigering
topic: howto
language: no
---

# Oppdatere flere poster (masseredigering)

Med masseredigering kan du endre verdier på tvers av flere oppføringer av samme type. Du kan utføre masseredigeringen på alle eller utvalgte oppføringer i detaljkort (arkiver), utvalg og **Finn**-skjermbildet. Denne oppgaven kan også brukes til å slette flere oppføringer.

1. Åpne utvalget, detaljkortet (arkiv) eller søkeresultatene (**Finn**-skjermbildet) som inneholder oppføringene du vil oppdatere.

2. Utvalg: Klikk på **Oppgave**-knappen og velg **Masseredigering**.
    eller
    Velg oppføringene du vil oppdatere, høyreklikk på disse og velg **Masseredigering...**.
    Dialogboksen **Masseredigering** åpnes. Nederst i denne dialogboksen kan du se typen oppføring og hvor mange oppføringer som skal oppdateres. Eksempel: Antall personer i kø for masseredigering: 7.

    > [!NOTE]
    > Hvis utvalget inneholder både firma og personer, vil det være to faner: **Firma** og **Person**.

3. Velg et felt som skal oppdateres, i kolonnen **Felt**. Du kan også skrive inn navnet i feltet. Mens du skriver inn hver bokstav, viser listen nedenfor alle treff som er relevante for de valgte oppføringene.

4. Velg en handling i kolonnen **Handling**. Hvilke handlinger som er tilgjengelige, avhenger av felttypen du valgte i forrige trinn. Eksempler:

    * **Velg**: Merk av i eller fjern merking av avmerkingsboks.
    * **Bytt**: Fjern merking i en avmerket avmerkingsboks og omvendt.
    * **Søk og erstatt**: [Finn en tekst og erstatt den](#search-and-replace).
    * **Regex**: Oppdatere et felt ved hjelp av [regulære uttrykk](#regex).
    * **Angi**: Bruk en ny verdi i feltet.
    * **Tøm**: Fjern alle verdier fra feltet.
    * Handlinger for lister: Velg eller fjern enkelte eller flere verdier for listefelt.
    * Handlinger for aktivitetskoblinger: Legg til, slett eller erstatt aktivitetskoblinger eller fjern alle aktivitetskoblinger.

5. Hvis du vil legge til flere felt som skal oppdateres, klikker du på **Legg til** og gjentar trinn 3 og 4.

6. Pass på at du velger (![icon][img1]) feltene du vil oppdatere og fjern valget (![icon][img2]) feltene du IKKE ønsker å oppdatere.

7. Klikk på **Oppdater**. Dialogboksen **Bekreft** åpnes og viser en oversikt over oppdateringene.

    > [!NOTE]
    > Når en oppdatering er installert, kan den ikke angres.

8. Klikk på **Ja** for å implementere endringene i de valgte oppføringene.

    > [!NOTE]
    > Det er mulig å stoppe oppdateringen så snart du har startet den. Elementer som ennå ikke er blitt oppdatert, vil ikke bli det.

9. Klikk på **LOGG** for å vise endringsloggen. Hvis noen oppføringer ikke ble oppdatert, er årsaken oppført i kolonnen **Årsak**.

10. Klikk på **Lukk**.

## <a id="search-and-replace"></a>Søk og erstatt

Med handlingen **Søk og erstatt** kan du finne en bestemt tekst i et felt og erstatte den.

1. Velg **Søk og erstatt** i kolonnen **Handling**.
2. Skriv inn teksten som skal erstattes, i **Finn**-feltet.
3. Skriv inn erstatningsteksten i feltet **Erstatt med**.
4. Valgfritt: Klikk på **Alternativer** og velg innstillingen for om du vil bruke store eller små bokstaver og søke etter hele eller deler av ord.

## <a id="regex"></a>Regulære uttrykk

Handlingstypen **Regex** lar deg bruke vanlige uttrykk til å oppdatere et felt.

1. Velg **Regex** i **Handling**-kolonnen.
2. Skriv inn uttrykket i feltet **Uttrykk**.
3. Skriv inn erstatningsteksten i feltet **Erstatt med**.
4. Valgfritt: Klikk på **Alternativer** og velg innstillinger for det vanlige uttrykket.

## Eksempler

## Oppdatere firmakategorier

Du ønsker å kategorisere kundene etter salgsbeløp. Opprett firmakategorier kalt "Kunde A", "Kunde B" og "Kunde C" i SuperOffice CRM. For "Kunde A" kan du opprette et utvalg av firmaer som hadde salgsbeløp på over 50 000 EUR i fjor. Bruk **Masseredigering** til å oppdatere kategorien for disse kundene til "Kunde A". Gjenta denne prosessen for de andre firmaene.

## Oppdatere postnummer og poststed for firmaer

Postnummer og poststeder i Norge er endret. Bruk **Masseredigering** til å oppdatere adressene.

## Oppdater person

Du oppdager at kontaktfeltet **Posisjon** sjelden brukes. For å komme i gang med oppgaven med å fylle ut dette feltet for alle personer, ønsker du å finne alle personene som har direktør i tittelen. Opprett et utvalg av alle personer som inneholder ordet "direktør" i **Tittel**-feltet. Bruk **Masseredigering** til å angi feltet **Stilling** til **Ledelse**.

## Oppdatere prosjekt

Du ønsker å rydde opp i alle de "gamle" prosjektene som ikke er satt til å fullføres. Opprett et utvalg av alle de gamle prosjektene dine, for eksempel alle prosjekter som går mer enn 2 år tilbake i tid, og som ikke har vært oppdatert det siste året. Bruk **Masseredigering** til å angi statusen **Fullført** for disse prosjektene til **Ja**.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-selected.png
[img2]: ../../../media/icons/btn-unselected.png
