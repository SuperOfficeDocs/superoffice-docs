---
uid: help-no-quote-alternatives
title: Legg til alternativer i et tilbud
description: Lær hvordan du oppretter og administrerer alternativer i tilbud i SuperOffice CRM for å tilby flere forslag til kunden.
keywords: tilbud, tilbudsalternativ
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from: /no/quote/learn/add-alternative
---

# Legge til alternativer i et tilbud

Bruk alternativer for å tilby forskjellige kombinasjoner av produkter, mengder eller priser i ett og samme tilbud. Hvert alternativ vises som en egen fane i dialogboksen **Rediger tilbud**.

Du kan lage et nytt alternativ fra bunnen av eller kopiere et eksisterende.

> [!NOTE]
> [Alternativer må være aktivert][3] for salgstypen i Innstillinger og vedlikehold. Hvis fanen **+** ikke vises, må du velge en annen salgstype eller aktivere funksjonen. Du kan også ta med bare ett alternativ i tilbudet.

## Opprette eller kopiere et alternativ

1. Gå til detaljkortet **Tilbud** i salget og klikk på **Åpne** for å redigere tilbudet.

    Tilbudet må ha status **Utkast**. Hvis det allerede er sendt, må du [opprette en ny versjon][1].

1. Klikk på fanen **+** til høyre for de eksisterende alternativene.

1. Velg ett av følgende:

    * **Opprett nytt alternativ:** Starter fra bunnen av
    * **Kopier alternativ;** Kopierer et eksisterende alternativ, inkludert produkter

1. Skriv inn navnet på det nye alternativet i feltet **Navn**. Dette blir fanenavnet.

1. Klikk på **Legg til**. Det nye alternativet vises som en egen fane.

1. [Legg til produkter i det nye alternativet][2].

1. Valgfritt: Klikk på <i class="ph ph-star" aria-label="Star icon"></i> **Favorittalternativ** nederst for å angi dette som nytt favorittalternativ.

    Estimert salgsbeløp i salget ("forecast") hentes fra totalbeløpet for favorittalternativet.

## Endre navn på eller slette et alternativ

1. Velg fanen til alternativet du vil endre.

1. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> nederst til venstre for å åpne oppgavemenyen.

1. Velg ett av følgende:

    * **Endre navn på alternativ**: Skriv inn et nytt navn og trykk **Enter**
    * **Slett \[alternativnavn\]**: Bekreft slettingen i dialogboksen

> [!NOTE]
> Ikonet <i class="ph ph-trash" aria-hidden="true"></i> under produktlisten sletter bare valgte **produktlinjer**, ikke hele alternativer.

<!-- Referenced links -->
[1]: send.md#versions
[2]: create.md#add-products
[3]: ../../admin/sale-type.md#quote-fields
