---
uid: help-no-flow-view-statistics
title: View statistics for flow
description:
keywords: flyt, markedsføringsautomasjon, kampanje, suksesskriterie, segment
author: Bergfrid Dias
date: 05.24.2024
version: 10.3.5
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Analyser resultatene for flyt

SuperOffice samler statistikk og resultater for hver flyt du kjører.

## Trinn

For å se statistikk om flyten din, gå til **Flyter**-fanen og klikk på flyten i listen. Skjermen **Vis flyt** åpnes.

> [!TIP]
> Klikk på **Oppdater**-knappen for å oppdatere flytstatistikken.

## Faner med flytstatistikk

* **Oversikt:** Informasjon om flyten og noen nøkkeltall

  * **Trigger:** Flytens startpunkt som definerer NÅR en person foreslås som deltaker.
  * **Suksesskriterier:** Hva man ønsker å oppnå med denne automatiseringen.
  * **Registrert:** Totalt antall deltakerelagt til, alle statuser.
  * **Under arbeid:** Totalt antall deltakere med status = aktiv.
  * **Fullført:** Totalt antall deltakere med status = Fullført / Fullført med suksess.
  * **Suksessrate:** Prosentandel av alle deltakere med status Fullført med suksess.

  **Nøkkelinformasjon:** status (Stoppet/Kjører/Pause), eier, synlig for (assosiert/gruppe/alle), sist oppdatert, beskrivelse

* **Rapporter:** Viser diagrammer med statistikk for flyten, brukt for å overvåke ytelsen. Et skrivebeskyttet dashbord med forhåndsdefinerte fliser. Datasettet er begrenset til gjeldende flyt - ingen filtrering.

* **Deltakere:** Presenterer en [liste av alle deltakere][1] i flyten.

## Hva vil du sjekke?

### Sammenligne kampanjer/flyter

Gå til **Markedsføring** > **Flyter** og velg arkivmodus.

![Sammenlign kampanjer/flyter -screenshot][img3]

### Sjekke status for gjeldende flyt

I **Vis flyt**-skjermen er status synlig i toppteksten og på **Oversikt**-fanen.

![Vis status for gjeldende flyt -screenshot][img2]

### Sjekke status for alle flyter

Gå til **Markedsføring** > **Flyter** og velg arkivmodus ![ikon][img8].

![Vis status for alle flyter i arkivmodus -screenshot][img1]

### Sjekke ytelse og engasjement for meldinger

Gå til **Markedsføring** > **Flyter** > **Rapporter**.

![Vis flytdashboard -screenshot][img4]

### Rapportfliser

* Mottakere per e-post
* Åpningsrate per e-post
* Klikkfrekvens per e-post
* Deltakere per status
* Frafall av deltaker per årsak
* Registrering av deltakere over en periode
* E-poster med best ytelse (CTR)

### Hvilke lenker blir klikket og av hvem

Gå til **Markedsføring** > **Sporede lenker**. Se [Utforsk lenkeklikk][11].

<!-- Referenced links -->
[1]: participants.md
[11]: ../../tracked-links/learn/explore-clicks.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/view-status-all-flows.png
[img2]: ../../../../media/loc/en/marketing/check-flow-status.png
[img3]: ../../../../media/loc/en/marketing/compare-flow-success.png
[img4]: ../../../../media/loc/en/marketing/flow-dashboard.png
[img8]: ../../../../../common/icons/view-list.png
