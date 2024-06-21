---
uid: help-no-sync-configure-field-allocation
title: Konfigurere felttilordning
description: Konfigurere felttilordning
author: Bergfrid Dias
date: 03.29.2023
keywords: tilbud, sync, connector, ERP, kartlegging
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Konfigurere felttilordning

Når du skal synkronisere data mellom SuperOffice og ERP-systemer, må du angi hvilke SuperOffice-felt og ERP-felt som hører sammen.

> [!NOTE]
> Når du skal redigere en ERP-tilkobling, må du først deaktivere den.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Merk ERP-koblingen, og klikk på knappen **Tilordninger** nederst. I dialogboksen **Tilordninger** vises fanene for de tilgjengelige aktørene i ERP-systemet.

1. Velg fanen for den aktøren du vil konfigurere felttilordninger for.

1. Velg **Synkroniser ERP [actor] med SuperOffice [entity]**.

1. I listen nedenfor må du velge synkroniseringsretning og hvilket SuperOffice-felt hvert ERP-felt skal tilordnes (synkroniseres med). I tillegg kan du velge om feltene skal vises i søk og i fanen **ERP**.
    Listen består av følgende kolonner:

    * **Vis i søk**: Merk av her hvis dette feltet skal vises i søkeresultatene.
    * **ERP-felt**: Her vises navnet på feltet i ERP-systemet.
    * **Retning**: Her velger du retningen(e) for synkroniseringen. Se tabell med ikoner nedenfor.

    * **SuperOffice-felt**: Her velger du hvilket SuperOffice-felt du vil synkronisere. Enkelte felt (for eksempel kunde- og personnummer) kan ikke synkroniseres, og listen vil da være tom.
    * **Vis i ERP-fane**: Merk av her hvis du vil at dette feltet skal vises i fanen **ERP** i SuperOffice CRM (bildet Firma, Person og Prosjekt).

        > [!NOTE]
        > Hvis du har valgt å synkronisere dette feltet med et SuperOffice-felt, har det ingen hensikt å vise feltet i **ERP**-fanen.

1. Gjenta trinn 4 til 6 for å konfigurere felttilordninger for andre aktører.

1. Klikk på **Ferdig** for å fullføre. Under listen **ERP-tilkoblinger** vises alle feltene som synkroniseres for de ulike aktørene.

1. Merk av for **Aktiv** for ERP-koblingen du har redigert.

## Hva betyr ikonene?

| Ikon | Forklaring |
|---|---|
| ![ikon][img1] | Ingen synkronisering (SuperOffice-felt er valgt). Hvis feltet er obligatorisk, MÅ du velge en retning. |
| ![ikon][img2] | Synkronisering begge veier. |
| ![ikon][img3] | Synkronisering fra SuperOffice til ERP-systemet. |
| ![ikon][img4] | Synkronisering fra ERP-systemet til SuperOffice. |
| ![ikon][img5] | Ingen synkronisering (SuperOffice-felt er IKKE valgt), eller feltet kan ikke synkroniseres (f.eks. kundenavn). Dette kan skyldes at feltene kun er lesbare. Hold musepekeren over ikonet for å vise detaljer. |

> [!NOTE]
> Pilene er deaktivert helt til du har valgt et SuperOffice-felt.

## Feilsøking

Hvis du definerte feil innstillinger for felttilordningene, får du en feilmelding som beskriver hva som er feil. Det kan for eksempel gjelde et obligatorisk felt som mangler synkroniseringsretning. Du må rette opp feilen før du kan aktivere ERP-koblingen.

## Hvordan kartlegge/allokere listeelementer

Hvis du har tilordnet noen lister (for eksempel kategori), må du også [tilordne de enkelte elementene i hver liste][1].

<!-- Referenced links -->
[1]: sync-configure-list-mapping.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/sync-none.png
[img2]: ../../../../../media/icons/admin/sync-2-way.png
[img3]: ../../../../../media/icons/admin/sync-to-erp.png
[img4]: ../../../../../media/icons/admin/sync-to-so.png
[img5]: ../../../../../media/icons/admin/sync-deactivated.png
