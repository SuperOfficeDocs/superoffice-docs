---
uid: help-no-flow-run-pause-end
title: Kjør, pause og avslutt flyt
description: Hvordan kjøre, pause, gjenoppta, avslutte og slette en SuperOffice-markedsføringsautomatiseringsflyt.
keywords: flyt, markedsføring, automatisering, kjøre flyt, kjørende, pause flyt, gjenoppta flyt, avslutte flyt, slette flyt, flytstatus
author: Bergfrid Dias
date: 02.17.2025
version: 10.5.2
topic: howto
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: no
---

# Kjør, pause og avslutt flyt

## <a id="status"></a>Flytstatus

* **Stoppet:** Representerer en ikke-startet ny flyt (eller en avsluttet flyt). Triggere er ikke aktive.

* **Kjørende:** Ingen endringer er tillatt mens flyten pågår. Automatiske triggere er aktive, og deltakere legges til i flyten.

* **Pauset:** Triggere forblir aktive. Deltakere legges til i flyten, men venter før første trinn. Eksisterende deltakere forblir på gjeldende trinn når flyten er satt på pause. Denne statusen brukes når man gjør endringer eller forbedringer i en flyt.

![Markedsføringsflyter med forskjellig status og statistikk -screenshot][img1]

## Start flyt for første gang

For å starte en ny flyt:

1. Gå til **Markedsføring** > **Flyter**.
1. Velg flyten du ønsker å starte.
1. I toppteksten, veksle skyveknappen til **PÅ**. Status endres til **Kjørende**.

Dette aktiverer flytens triggere. Nye deltakere legges til i flytens deltakerliste basert på disse triggerne. Flytdeltakere vil gå gjennom flyten, handlinger vil bli utført til de møter flytens suksesskriterium, når avslut-trinnet, eller trekker seg ut.

## Pause flyt

For å midlertidig stoppe en kjørende flyt:

1. Åpne flyten du ønsker å pause.
1. I toppteksten, veksle skyveknappen til **AV**. Status endres til **Pauset**.

* Denne handlingen fryser gjeldende status for alle deltakere, som forblir på deres gjeldende trinn.
* **Triggere forblir aktive**, og deltakerlisten fortsetter å vokse. Nye deltakere melder seg på, men plasseres i en kø.
* **Rediger**-knappen er tilgjengelig, slik at flytadministratorer kan gjøre oppdateringer i flyten (med visse begrensninger).

## Gjenoppta flyt (pause > kjørende)

For å starte en pauseflyt igjen, veksle skyveknappen til **PÅ** på **Vis flyt**-skjermen.

* Alle deltakere vil fortsette fra trinnet de var på da flyten ble satt på pause.
* Deltakere som meldte seg på og var i kø under pausen vil bevege seg til det første trinnet.
* Eventuelle endringer gjort i flyten vil gjelde for en deltaker hvis de ennå ikke har kommet forbi det relevante trinnet.

## Avslutt flyt

For å avslutte flyten:

1. Åpne flyten.
1. Velg **Oppgave** > **Avslutt flyt**.

* Flytens status endres til **Stoppet**.
* Alle triggere for denne flyten deaktiveres, og påmelding avsluttes. Ingen nye deltakere vil bli lagt til i flyten.
* Aktive deltakere får status = *Dropout*. De vil ikke fullføre flyten.

> [!CAUTION]
> Denne oppgaven bør bare brukes for flyter som ikke lenger er relevante. Å avslutte en flyt er ikke ment for å gjøre mindre justeringer - bruk pause i stedet. **Deltakere med status Dropout vil ikke fortsette flyten hvis du bestemmer deg for å kjøre den igjen.**

Hvis flyten startes igjen etter å ha avsluttet den, går bare nye deltakere gjennom flyten, gamle deltakere beholder statusen Dropout.

## <a id="delete"></a>Slett flyt

1. Sett flyten på pause. Flytens status endres til **Pauset**.
1. Avslutt flyten. Status endres til **Stoppet**.
1. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Oppgavemeny"></i> og velg **Slett flyt**.
1. Bekreft handlingen.

Denne muligheten er tilgjengelig både i **Vis flyt**-skjermen og i oversikten over alle flyter.

## Feilsøking

### Kan ikke kjøre flyt

Alle påkrevde innstillinger må være gyldige før flyten kan kjøres. For eksempel kan ikke en flyt med et e-posttrinn kjøres hvis e-postinnstillinger som avsenderadresse eller svaradresse mangler. Se etter advarselikonet - verktøytipset beskriver problemet.

### Kan ikke slette flyt

Du kan ikke slette en kjørende flyt. Først må du sette flyten på pause. Deretter må du avslutte flyten, slik at statusen endres til **Stoppet**. Til slutt klikker du på <i class="ph ph-dots-three-circle-vertical" aria-label="Oppgavemeny"></i> og velger **Slett flyt**.

## Relatert innhold

* [Oppdater flyt][1]

<!-- Referenced links -->
[1]: update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-status.png
