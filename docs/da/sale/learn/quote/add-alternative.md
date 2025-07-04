---
uid: help-da-quote-alternatives
title: Tilføj alternativer i et tilbud
description: Lær, hvordan du opretter og administrerer tilbudsalternativer i SuperOffice CRM for at tilbyde flere forslag til kunden.
keywords: tilbud, tilbudsalternativ
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from: /da/quote/learn/add-alternative
---

# Tilføj alternativer i et tilbud

Brug alternativer til at tilbyde forskellige kombinationer af produkter, antal eller priser i det samme tilbud. Hvert alternativ vises som en separat fane i dialogboksen **Rediger tilbud**.

Du kan oprette et alternativ fra bunden eller kopiere et eksisterende.

> [!NOTE]
> [Alternativer skal være aktiveret][3] for salgstypen i Indstillinger og vedligeholdelse. Hvis fanen **+** ikke vises, skal du vælge en anden salgstype eller aktivere alternativfunktionen. Du kan også nøjes med kun at medtage ét alternativ i tilbuddet.

## Opret eller kopier et alternativ

1. Gå til detaljkortet **Tilbud** og klik på **Åbn** for at redigere tilbuddet.

    Tilbuddet skal have status **Udkast**. Hvis det allerede er sendt, skal du [oprette en ny version][1].

1. Klik på fanen **+** til højre for de eksisterende alternativer.

1. Vælg en af følgende muligheder:

    * **Opret nyt alternativ:** Starter med et tomt alternativ
    * **Kopiér alternativ:** Kopierer et eksisterende alternativ med dets produkter

1. Indtast et navn i feltet **Navn**. Dette bliver fanenavnet.

1. Klik på **Tilføj**. Det nye alternativ vises som en ny fane.

1. [Tilføj produkter til det nye alternativ][2].

1. Valgfrit: Klik på <i class="ph ph-star" aria-label="Star icon"></i> **Foretrukket alternativ** nederst for at markere dette alternativ som det foretrukne.

    Anslåede salgsbeløb for salget (prognose) fås fra det samlede beløb for favoritalternativet.

## Omdøb eller slet et alternativ

1. Vælg fanen for det alternativ, du vil ændre.

1. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> nederst til venstre for at åbne opgavemenuen.

1. Vælg en af følgende muligheder:

    * **Omdøb alternativ**: Indtast et nyt navn, og tryk på **Enter**
    * **Slet \[alternativnavn\]**: Bekræft sletningen i dialogboksen

> [!NOTE]
> Ikonet <i class="ph ph-trash" aria-hidden="true"></i> under produktlisten sletter kun valgte **produktlinjer**, ikke hele alternativer.

<!-- Referenced links -->
[1]: send.md#versions
[2]: create.md#add-products
[3]: ../../admin/sale-type.md#quote-fields
