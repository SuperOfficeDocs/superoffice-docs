---
uid: help-da-request-relation-rules
title: Relationsregler
description: Lær, hvordan du konfigurerer relationsregler for at automatisere adfærd ved oprettelse og lukning af sager baseret på overordnet-underordnet-relationer i SuperOffice Service.
keywords: relationsregler, sagsrelation, overordnet-underordnet, relationsregel, automatisering, luk sag, fanen Relationsregler
author: digitaldiina
date: 04.08.2026
version: 11.12
content_type: howto
license: servicepremium
audience: settings
audience_tooltip: Settings and maintenance
language: da
index: true
---

# Relationsregler

Relationsregler definerer automatisk adfærd, der anvendes, når sager oprettes eller lukkes, baseret på overordnet-underordnet-relationer mellem bestemte sagstyper. De giver dig mulighed for at sikre konsistens i din supportproces — for eksempel ved at blokere en overordnet sag fra at blive lukket, indtil alle dens underordnede sager er løst, eller ved at opfordre agenter til at lukke relaterede sager samlet.

> [!NOTE]
> Regler udløser kun automatiske handlinger i brugergrænsefladen for sager. API- og CRMScript-handlinger påvirkes ikke.

## Hvad er en relationsregel?

En relationsregel består af:

* **Betingelse:** hvilke sagstyper reglen gælder for (kilde og mål).
* **Adfærd:** hvad der sker automatisk, når matchende sager oprettes eller lukkes.

## Hvor finder jeg relationsregler?

Gå til **Indstillinger og vedligeholdelse**, vælg **Sager** i navigatoren, og gå til fanen **Relationsregler**.

![Indstillinger og vedligeholdelse, Relationsregler -screenshot][img1]

[!include[Begrænset adgang](../../learn/includes/note-insufficient-rights.md)]

## Indstillinger

### Betingelse

| Felt | Beskrivelse |
|---|---|
| Fra (kilde) | En eller flere kildesagstyper. |
| Relation | Relationstypen (Overordnet eller Underordnet). |
| Til (mål) | En eller flere målsagstyper. |

Opsummeringslinjen nedenfor betingelsen bekræfter regelens fulde omfang på klart sprog. Der vises en advarsel, hvis betingelsen overlapper med en eksisterende regel.

### Adfærd: Ved oprettelse

| Mulighed | Beskrivelse |
|---|---|
| **Kræver angivelse af overordnet** | Forhindrer gemning af en ny sag, medmindre en overordnet sag er angivet. Gælder kun, hvis feltet **Overordnet** er tilføjet til sagsskærmbilledet i [Skærmdesigner][3]. |

### Adfærd: Ved lukning

| Mulighed | Beskrivelse |
|---|---|
| **Bloker for lukning af overordnet sag, indtil alle underordnede er lukket** | Blokerer den overordnede sag fra at blive lukket, mens der stadig er åbne underordnede sager. |
| **Tilbyd at lukke overordnet sag, når alle underordnede lukkes** | Når den sidste underordnede sag lukkes, opfordres agenten til også at lukke den overordnede sag. |
| **Tilbyd at lukke underordnede sager og sende besked, når overordnet lukkes** | Når den overordnede sag lukkes, opfordres agenten til at lukke alle åbne underordnede sager og tilføje et svarbrev til hver, som sendes til modtagerne. |

## Tilføj relationsregel

1. Gå til **Indstillinger og vedligeholdelse**, vælg **Sager** i navigatoren, og gå til fanen **Relationsregler**.

1. Klik på knappen **Tilføj**.

    ![Tilføj relationsregel -screenshot][img2]

1. Angiv et **Regelnavn** og eventuelt en **Beskrivelse**.

1. I sektionen **Betingelse** skal du vælge **Relation**-typen og derefter vælge en eller flere sagstyper i felterne **Fra (kilde)** og **Til (mål)**. Opsummeringslinjen nedenfor betingelsen bekræfter, hvad reglen gælder for.

    > [!NOTE]
    > Hvis betingelsen overlapper med en eksisterende regel, vises en konfliktadvarsel. Juster sagstyperne for at løse konflikten, inden du gemmer.

1. I sektionen **Adfærd** skal du markere de muligheder, du vil aktivere for **Ved oprettelse** og **Ved lukning**.

1. Klik på **Gem**.

## Rediger relationsregel

1. I fanen **Relationsregler** skal du klikke på reglen på listen til venstre.

1. Foretag dine ændringer.

1. Klik på **Gem**.

## Slet relationsregel

1. I fanen **Relationsregler** skal du vælge reglen på listen til venstre.

1. Klik på knappen **Slet** nederst på listen.

## Eksempel: Hændelsesstyring

Et stort serviceudfald genererer flere individuelle problemrapporter fra berørte kunder. Hver kunderapport registreres som en underordnet sag knyttet til en fælles hændelse som den overordnede sag.

* **Bloker for lukning af overordnet sag, indtil alle underordnede er lukket:** holder hændelsen åben, indtil alle problemrapporter er håndteret, og sikrer, at intet overses.

* **Tilbyd at lukke overordnet sag, når alle underordnede lukkes:** når den sidste problemrapport løses, opfordres agenten til at lukke hændelsen.

* **Tilbyd at lukke underordnede sager og sende besked, når overordnet lukkes:** når hændelsen er løst, kan agenten lukke alle resterende underordnede sager på én gang og sende et svar til hver berørt kunde om, at problemet er løst.

## Relateret indhold

* [Sagsrelationer][1]
* [Sagstyper][2]

<!-- Referenced links -->
[1]: ../learn/request-relations.md
[2]: type/index.md
[3]: ../../customization/screen-designer/admin/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/relation-rules.png
[img2]: ../../../media/loc/en/request/add-relation-rule.png
