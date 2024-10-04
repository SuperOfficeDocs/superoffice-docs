---
uid: help-da-screen-designer-edit-layout
title: Rediger layout af et kort
description: I denne vejledning lærer du, hvordan du redigerer et layout.
keywords: Skærmdesigner, layout, udseende, felt, kortlayout, hovedkort
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Rediger layout af et kort

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Når du har [oprettet et nyt layout][6], er det tid til at tilpasse det. Tilpas layoutet for hovedkortene og arkiverne, så det passer til din organisations informationsbehov.

## Overvejelser

Før du tilpasser et layout, skal du afgøre, hvem de tiltænkte brugere er.

* Hvad har de brug for lige ved hånden?
* Har de brug for alle standardfelter og faner, eller skal du fjerne noget?
* Har de brug for ekstra faner?
* Hvad er felternes logiske rækkefølge?

> [!NOTE]
> Du kan redigere **standardlayoutet**, men du kan ikke redigere standardindstillingerne for kontrol, og du kan ikke tildele layoutet til en brugergruppe eller type.

Se denne video, og find ud af, hvordan du bruger skærmdesigneren til at konfigurere dine skærmbilleder i SuperOffice CRM, eller følg trin-for-trin-guiden nedenunder (videolængde - 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## <a id="edit"></a>Rediger kortlayout

1. Åbn Skærmdesigneren.
2. Vælg øverst en skærm eller dialog, som du vil tilpasse.
3. Vælg et layout i listen til venstre.
4. Klik på **Rediger layout** under forhåndsvisningen.
5. I skærmbilledet **Rediger kortlayout**, gennemgå fanerne på skærmen.

    * [Tilføj, rediger, flyt eller fjern et felt][1]
    * [Tilføj kobling eller knap][2]
    * [Organiser oplysninger i logiske grupper][4]
    * [Tilføj, fjern eller gendan en fane][3]
    * [Ændre antallet af kolonner i en fane][5]<a id="columns"></a>

![Fjern, tilføj og flyt de forskellige felter i layoutet -screenshot][img3]

## <a id="save"></a>Gem, udgiv eller afbryd

Efter redigering af et layout skal du klikke på en af følgende knapper:

| Knap | Beskrivelse |
|---|---|
| Gem udkast | Gemmer en upubliceret version af layoutet, som du kan genoptage redigeringen senere eller bede nogen om at gennemgå. |
| Gem + Udgiv | Anvender layoutet på de valgte brugergrupper **eller** salgs-/projekt-/sags-/opfølgningstype. |
| Afbryd | Annullerer alle ændringer. |

## <a id="undo-changes"></a>Fortryd ændringer

Hvis du har brug for at vende tilbage til en tidligere version af skærmen, kan du få adgang til følgende muligheder fra knappen **Opgave**:

* **Nulstil til fabriksindstillinger**: Denne mulighed annullerer alle ændringer og nulstiller layoutet til den standardversion, der leveres af SuperOffice.

* **Gendan faner**: Denne mulighed gendanner alle tidligere fjernede faner.

* **Slet kladde**: Denne mulighed annullerer alle ikke-gemte ændringer og nulstiller layoutet til den sidst udgivne version.

## <a id="delete"></a>Slet layout

Når et brugergruppe-baseret layout slettes, ser brugerne i den gruppe standardlayoutet (systemlayoutet).

For at slette et layout:

1. Vælg layoutet i listen **Layout**.
1. Klik på **Slet**.

## Relateret indhold

* [Arbejde med detaljekort (arkiver)][7]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: add-button.md
[3]: working-with-tabs.md
[4]: working-with-tabs.md#label
[5]: working-with-tabs.md#columns
[6]: add-layout.md
[7]: working-with-archives.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/ui/edit-the-screen-layout-of-companies-and-contacts.png
