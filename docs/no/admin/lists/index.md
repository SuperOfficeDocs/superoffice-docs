---
uid: help-no-lists
title: Lister
description: Slik redigerer du lister
keywords: liste
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: 
  - /no/admin/lists/learn/index
  - /no/admin/lists/learn/items
  - /no/admin/lists/learn/duplicates
language: no
---

# Lister

SuperOffice CRM har mange standardlister, for eksempel kundekategorier, aktivitetstyper, salgstyper og mange flere. Hvis du vil endre standardlistene slik at de passer til bedriftens sjargong og prosesser, forklarer denne guiden hvordan du redigerer lister.

Avhengig av hvilken bransje firmaet din har virksomhet i, kan du skreddersy alle lister i systemet for å gjenspeile forretningsprosessene og behovet. Du kan opprette nye forekomster, deaktivere unødvendige forekomster og redigere eksisterende. Enkelte forekomster vises som standard i alle listene i SuperOffice CRM.

## Lister-bilde

**Lister**-bildet består av beskrivelser og definisjoner av listene som forekommer i SuperOffice CRM. Her kan du blant annet tilpasse forhåndsdefinerte lister som er standard i SuperOffice CRM.

> [!TIP]
> Du kan raskt åpne en liste ved å klikke på **Lister** i navigatoren og begynne å skrive i søkefeltet. Søkeresultatene blir oppdatert mens du skriver.

Du kan også legge til egne, brukerdefinerte lister som skal vises i **Mer**-faner i SuperOffice CRM. Hva som skal vises i disse **Mer**-fanene, angir du i [Felt][10]-bildet.

**Lister**-bildet er inndelt i følgende deler:

* Øverst i bildet kan du klikke på listeboksen for å velge blant alle tilgjengelige lister i SuperOffice, både forhåndsdefinerte og [brukerdefinerte lister][5].
* Fanen **Forekomster** inneholder tilgjengelige [forekomster](#items) på den valgte listen.
* Fanen **Brukergrupper** viser forekomster [filtrert etter brukergruppe][7].
* Fanen **Overskrifter** viser [forekomster per overskrift][1].
* I listen **Synlig for brukergruppe** kan du se gruppene som forekomsten du har valgt i **Forekomster**-listen, er synlige for. Du kan for eksempel velge å ha ulike oppfølgingstyper tilgjengelig for brukergruppene Salg, Brukerstøtte og Regnskap.
* **Overskrifter**-listen viser hvilke [overskrifter][1] de enkelte forekomstene vises under. Hvis en liste er veldig lang (inneholder veldig mange forekomster), kan du bruke overskrifter til å gruppere forekomstene på en logisk måte. Forekomstene i listen **Dokument - mal** er for eksempel gruppert i overskriftene **Brev**, **Faks**, **E-post** og så videre.

Øverst til høyre finner du valgboksen **Bruk gruppering og brukergruppefiltrering for denne listen**, der du angir om listen skal kunne grupperes og filtreres. Dette alternativet er deaktivert for lister der dette ikke er aktuelt.

Nederst i **Lister**-bildet finner du valgboksen **Vis slettede forekomster og overskrifter**, som gjør det mulig å [oppheve sletting][9] av forekomster og overskrifter.

## <a id="items"></a>Forekomster

I motsetning til lister, kan du endre, legge til og slette forekomster både i forhåndsdefinerte og brukerdefinerte lister.

### Duplikater

Du kan ikke registrere to forekomster med samme navn i én liste. Det samme gjelder overskrifter. Hvis du forsøker å registrere noe med nøyaktig samme navn som en eksisterende forekomst eller overskrift, får du melding om at dette ikke er tillatt. Dette gjelder uansett om du bruker store eller små bokstaver.

> [!NOTE]
> Vær oppmerksom på at du heller ikke kan legge til en ny forekomst eller overskrift som har samme navn som en [slettet forekomst eller overskrift][9].

## Organisere lister

SuperOffice CRM inneholder mange standardlister og enda flere forekomster. Når du legger til dine egne (brukerdefinerte) lister og forekomster, er det lurt å organisere listene. Du kan organisere lister på to hovedmåter i SuperOffice CRM:

* **Gruppering:** Bruk [overskrifter][1] i lister for å kategorisere forekomstene i to nivåer. Eksempel: Listen **Generelt - Ressurs** kan grupperes under to overskrifter: *Utstyr* og *Rom*.

* **Brukergruppefiltrering:** Sørg for at forekomstene bare er synlige for brukergruppene som faktisk bruker dem. Eksempel: Listen **Dokument - Mal** kan [filtreres][7] slik at tilbudsmaler ikke er synlige for brukergrupper som aldri sender tilbud.

> [!NOTE]
> Brukergrupper og overskrifter vises ikke for lister der disse elementene ikke er aktuelle.

I Innstillinger og vedlikehold kan du for de fleste forhåndsdefinerte lister og alle brukerdefinerte lister angi at de skal være grupperte.

## Relatert innhold

* [Spesialiserte lister][4]
* [Legge til brukerdefinerte lister][5]
* [Legge til en forekomst][6]
* [Redigere eller slette en forekomst][8]

<!-- Referenced links -->
[1]: headings.md
[4]: specialized-lists.md
[5]: user-defined-lists.md
[6]: add-items.md
[7]: user-group-filtering.md
[8]: update-items.md
[9]: restore.md
[10]: ../../custom-objects/admin/edit-udef-layout.md

<!-- Referenced images -->
