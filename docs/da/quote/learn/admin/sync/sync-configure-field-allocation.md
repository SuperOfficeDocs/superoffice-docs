---
uid: help-da-sync-configure-field-allocation
title: Konfiguration af felttildeling
description: Konfiguration af felttildeling
author: Bergfrid Dias
date: 03.29.2023
keywords: tilbud, sync, henvisning, ERP, felttildeling
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Konfiguration af felttildeling

Når du skal synkronisere data mellem SuperOffice og ERP-systemer, skal du angive, hvilke SuperOffice-felter og ERP-felter, som hører sammen.

> [!NOTE]
> Når du skal redigere et ERP-link, skal du deaktivere den først.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Marker ERP-linket, og klik på knappen **Tilknytninger** nederst. I dialogboksen **Tilknytninger** vises fanerne for de tilgængelige aktører i ERP-systemet.

1. Vælg fanen for den aktør, du vil konfigurere tilknytninger til.

1. Marker **Synkroniser ERP \[actor\] med SuperOffice \[entity\]**.

1. På listen nedenfor skal du vælge synkroniseringsretning og hvilket SuperOffice-felt, hvert ERP-felt skal tilknyttes (dvs. synkroniseres med). Derudover kan du vælge, om felterne skal vises i søgning og på fanen **ERP**.
    Listen består af følgende kolonner:

    * **Vis i søgning**: Marker dette, hvis dette feltet skal vises i søgeresultatet.
    * **ERP-felt**: Her vises navnet på feltet i ERP-systemet.
    * **Retning**: Her vælger du retningen/retningerne for synkroniseringen. Se tabel over ikoner nedenfor.

    * **SuperOffice-felt**: her vælger du, hvilket SuperOffice-felt du vil synkronisere. Nogle felter (f. eks. kunde-og person-id'er) kan ikke synkroniseres, og listen vil derefter være tom.
    * **Vis i fanen ERP**: marker dette, hvis du ønsker, at dette felt skal vises på fanen **ERP** i SuperOffice CRM (skærmbilledet Firma, Kontakt og Projekt).

        > [!NOTE]
        > Hvis du har valgt at synkronisere dette felt med et SuperOffice-felt, giver det ingen mening at vise feltet på fanen **ERP**.

1. Gentag trin 4 til 6 for at konfigurere felttilknytninger for andre aktører.

1. Klik på **Udfør** for at fuldføre. Under listen **ERP-links** vises alle felterne, der synkroniseres for de forskellige aktører.

1. Marker **Aktiv** for det ERP-link, du har redigeret.

## Hvad betyder ikonerne?

| Ikon | Forklaring |
|---|---|
| ![ikon][img1] | Ingen synkronisering (SuperOffice-felt er valgt). Hvis feltet er obligatorisk, SKAL du vælge en retning. |
| ![ikon][img2] | Synkronisering begge veje. |
| ![ikon][img3] | Synkronisering fra SuperOffice til ERP-systemet. |
| ![ikon][img4] | Synkronisering fra ERP-systemet til SuperOffice. |
| ![ikon][img5] | Ingen synkronisering (SuperOffice-felt er IKKE valgt), eller feltet kan ikke synkroniseres (f.eks. kundenavn). Dette kan skyldes, at felterne er skrivebeskyttede. Hold musemarkøren over ikonet for at få vist detaljer. |

> [!NOTE]
> Pilene er deaktiveret, indtil du har valgt et SuperOffice-felt.

## Fejlfinding

Hvis du har angivet forkerte indstillinger, får du en fejlmeddelelse, der beskriver, hvad der er galt. Det kan for eksempel dreje sig om et obligatorisk felt, der mangler synkroniseringsretning. Du skal korrigere fejlen, før du kan aktivere ERP-linket.

## Sådan tilknyttes/allokeres listeelementer

Hvis du har tilknyttet lister (f.eks. kategori), skal du også [tilknytte de enkelte elementer på hver liste][1].

<!-- Referenced links -->
[1]: sync-configure-list-mapping.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/sync-none.png
[img2]: ../../../../../media/icons/admin/sync-2-way.png
[img3]: ../../../../../media/icons/admin/sync-to-erp.png
[img4]: ../../../../../media/icons/admin/sync-to-so.png
[img5]: ../../../../../media/icons/admin/sync-deactivated.png
