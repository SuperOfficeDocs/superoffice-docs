---
uid: help-da-sale-add-type
title: Tilføjelse af salgstype
description: Tilføjelse af salgstype
author: SuperOffice RnD
date: 06.29.2022
keywords: salgstype
topic: howto
language: da
---

# Tilføjelse af salgstype

[!include[Must be admin](../../../learn/includes/req-admin.md)]

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

> [!NOTE]
> Et tilbud tilhører et salg, og alle salg har en salgstype. I hver salgstype kan du definere mange af egenskaberne for et tilbud, f.eks. vedhæftede filer, indstillinger for godkendelse, brug af alternativer og skabeloner.

[!include[Edit list item](includes/edit-list-item.md)] når forekomsterne er salgstyper:

1. Indtast det ønskede navn for forekomsten i feltet **Navn**.

    [!include[Mandatory](includes/note-mandatory-field.md)]

2. Vælg den ønskede kategori for salgstypen på listen **Salgstypekategori**.

    > [!TIP]
    > Du kan oprette nye indstillinger ud over de foruddefinerede indstillinger ved at [tilføje forekomster][2] til listen **Salg – Kategori (til salgstype)** i Indstillinger og vedligeholdelse.

3. I **Estimeret tid for denne salgsproces**skal du angive en varighed for salgstypen (antal uger, dage eller måneder). Når du opretter et nyt salg af denne salgstype, indstilles salgsdatoen i forhold til det tidspunkt, du angiver her (dags dato + estimeret tid).

4. Angiv en beskrivelse af salgstypen nederst i dialogboksen.

5. Angiv oplysninger under fanerne **Trin**, **Tilbudsbilag**, **Tilbudsstandarder** og **Tilbudsgodkendelse**. Dette er beskrevet nedenfor.

    > [!NOTE]
    > Bemærk: Fanerne **Tilbudsbilag**, **Tilbudsstandarder** og **Tilbudsgodkendelse** er kun relevante, hvis du har licens til Håndtering af salgstilbud.

6. [!include[Save or cancel](includes/save-or-cancel.md)]

## Fanen Trin

På fanen **Trin** gør du følgende:

1. På listen **Trin anvendt til denne salgstype** skal du markere de trin, du vil medtage for salgstypen. Dette trin er valgfrit, men hvis du vil knytte salgstypen til en salgsguide, skal du markere mindst to trin.

    [Sådan oprettes en fase][3].

2. Marker **Denne salgstype er knyttet til en guide** , hvis du ønsker, at alt salg af denne salgstype skal følge en [salgsguide][5].

3. Hvis du ønsker det, skal du markere **Foreslå at flytte salget til næste trin automatisk**.

    Når alle opfølgninger og dokumenter for en fase er afsluttet, bliver du spurgt, om du vil gå til næste fase.

4. Markér **Denne salgstype har interessenter**, hvis du vil tillade tilknytning af [interessenter][4] til salg af denne salgstype.

## Fanen Tilbudsbilag

På fanen **Tilbudsbilag** kan du tilføje dokumenter, der skal sendes til kunden sammen med et tilbud. For eksempel produktspecifikationer, brochurer og så videre.

> [!NOTE]
> Dokumenterne skal først tilføjes som dokumentskabeloner i SuperOffice.

### Tilføjelse af tilbudsbilag

1. Klik på **Tilføj**.
2. På skærmbilledet Søg skal du [søge efter de dokumenter, du vil tilføje][1].
3. Vælg et eller flere dokumenter, og klik på **OK**. Dokumenterne vises under fanen **Tilbudsbilag**.
4. Vælg de dokumenter, du vil medtage i kolonnen **Medtag**.

Når du opretter et tilbud med denne salgstype, føjes de valgte dokumenter til tilbuddet som vedhæftede filer. De vil dog ikke blive tilføjet under fanen **Aktiviteter** i salget.

## Tilbudsstandarder

Indstillinger for tilbud med denne salgstype:

* **Tillad at alternativer føjes til tilbud**: Markér dette, hvis brugerne skal kunne tilføje flere alternativer til et tilbud.
* **Standarddage et tilbud er gyldigt**: Indtast det antal dage, et tilbud forbliver gyldigt. Denne værdi kan ændres, når tilbuddet sendes.
* **Skabelon til tilbudsformat**: Markér den skabelon, du vil bruge til tilbuddet.
* **Skabelon til ordrebekræftelse**: Markér den skabelon, du vil bruge til bekræftelsen.

## Godkendelse af tilbud

Her kan du vælge, om tilbuddet skal godkendes, hvis den samlede rabat er over en bestemt tærskel eller den samlede indtjening er under en bestemt tærskel:

* Ingen godkendelse påkrævet. Ingen grænser. Tilbuddet kræver ikke godkendelse.
* **Den samlede rabat er over grænsen**. Angiv en procentværdi.
* **Den samlede indtjening er under grænsen**. Angiv en procentværdi.

## Relateret inhold

* [Tilbudsskabeloner][6]

<!-- Referenced links -->
[2]: adding-items.md
[3]: ../../../sale/learn/screen/sale-stage.md
[4]: ../../../sale/learn/stakeholders/index.md
[5]: ../../../sale/learn/screen/sales-guide-admin.md
[1]: ../../../search-options/learn/search-criteria.md
[6]: ../../../document/templates/learn/quote-templates.md

<!-- Referenced images -->
