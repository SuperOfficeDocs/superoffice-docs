---
uid: help-no-list-headings
title: Listeoverskrifter
description: Bruk overskrifter for å gruppere elementer i lange lister i Innstillinger og vedlikehold.
keywords: overskrift, organisere liste
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: reference
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /no/admin/lists/learn/organize/index
  - /no/admin/lists/learn/organize/headings
  - /no/admin/lists/learn/organize/adding-headings
  - /no/admin/lists/learn/organize/headings-editing-and-deleting
  - /no/admin/lists/learn/organize/grouping-items-under-headings
language: no
---

# Listeoverskrifter

Listeforekomster kan vises på to nivåer. Det øverste nivået kalles forekomstens **overskrift**. En overskrift inneholder grupper av forekomster som kan vises under det valgte elementet i SuperOffice CRM. De samme forekomstene kan vises under flere overskrifter.

Listen **Overskrifter** (nede til høyre i **Lister**-bildet) viser hvilke overskrifter de enkelte forekomstene vises under. Du kan også gå til fanen **Overskrifter** for å se hvilke forekomster som vises under en bestemt overskrift.

## Når bør du bruke overskrifter i lister?

Hvis en liste er veldig lang (inneholder mange elementer), kan du bruke overskrifter til å gruppere forekomstene på en logisk måte. Forekomstene i listen **Dokumentmaler** er for eksempel gruppert under overskriftene **Brev**, **Faks**, **E-post** og så videre.

## Arbeide med overskrifter i lister

Åpne **Lister**-bildet og velg ønsket liste fra nedtrekksmenyen øverst til venstre.

> [!NOTE]
> Overskrifter er kun tilgjengelig for lister hvor **Bruk gruppering og brukergruppefiltrering for denne listen** er aktivert (avkrysningsboks øverst til høyre).
>
> Grupperingsfunksjonen er ikke tilgjengelig for enkelte forhåndsdefinerte lister (for eksempel **Generelt – Brukergruppe**). Hvis en liste ikke kan grupperes, er denne avmerkingsboksen deaktivert.

Du kan knytte overskrifter til listeforekomster på to måter:

* **Fra fanen Forekomster**: Velg en forekomst og tildel én eller flere overskrifter fra **Overskrifter**-panelet.
* **Fra fanen Overskrifter**: Velg en overskrift og angi hvilke forekomster som skal vises under den.

Du kan også legge til, redigere eller slette overskrifter ved behov.

## <a id="add"></a>Legge til overskrift

Før du kan knytte en overskrift til en forekomst, må du legge til de overskriftene du trenger.

1. Gå til fanen **Overskrifter**.

1. Klikk på **Legg til** under listen **Overskrifter**.

1. Skriv inn ønsket navn for overskriften *(obligatorisk)* og en beskrivelse *(valgfritt)*.

    * Feltet **Beskrivelse** kan brukes til å forklare hensikten med overskriften, og kan vises som verktøytips i grensesnittet.

1. [!include[Save or cancel](includes/save-or-cancel.md)]

Overskriften legges til i listen **Overskrifter**. Gjenta prosedyren for å legge til flere overskrifter.

Etterpå kan du [velge hvilke overskrifter forekomstene skal vises under](#group).

## <a id="group"></a>Gruppere forekomster under overskrifter

Hvis du vil bruke to nivåer i en liste, må du tildele overskrifter til hver enkelt forekomst i listen **Forekomster**. Alternativt kan du bruke fanen **Overskrifter** for å spesifisere hvilke forekomster som hører til en bestemt overskrift.

> [!NOTE]
> Listen må inneholde et visst minimum antall forekomster for at gruppering skal aktiveres. Dette antallet defineres i [Preferanser][3].

### Velg overskrifter for en forekomst

Eventuelle overskrifter som allerede er definert for den valgte listen, vises i panelet **Overskrifter** nederst til høyre. Hvis dette feltet er tomt, må du [legge til overskrifter først](#add).

1. Velg ønsket forekomst i listen **Forekomster**.

1. Kryss av ved ønsket overskrift i **Overskrifter**-listen. Da vil forekomsten vises under denne overskriften. En hake (<i class="ph ph-check" aria-hidden="true"></i>) vises.
    Endringene lagres automatisk.

> [!TIP]
> Du kan tilordne flere overskrifter til én forekomst.

### Velg forekomster for en overskrift

1. Gå til fanen **Overskrifter**.

1. Velg en overskrift i listen.

1. I listen **Forekomster under denne overskriften** klikker du av for hver forekomst som skal vises under den valgte overskriften.

1. Gjenta for hver overskrift du vil tilordne forekomster til.

    Endringene lagres automatisk.

## <a id="update"></a>Redigere overskrifter

Du redigerer en overskrift ved å dobbeltklikke på ønsket overskrift i listen **Overskrifter** og endre informasjonen.

## Slette overskrifter

Du sletter overskrifter ved å merke ønsket overskrift og klikke på **Slett**.

> [!NOTE]
> Å slette en overskrift fjerner **ikke** forekomstene som er tilknyttet. Du kan [gjenopprette slettede overskrifter][2].

<!-- Refererte lenker -->
[2]: restore.md
[3]: ../preferences/index.md
