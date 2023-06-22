---
uid: help-nl-sync-configure-field-allocation
title: Veldtoewijzing configureren
description: Veldtoewijzing configureren
author: Bergfrid Dias
so.date: 03.29.2023
keywords: offerte, synchroniseren, connector, ERP, toewijzen
so.topic: howto
so.user: admin
language: nl
---

# Veldtoewijzing configureren

Wanneer u gegevens synchroniseert tussen SuperOffice en ERP-systemen, moet u opgeven welk SuperOffice-veld en welk ERP-veld bij elkaar hoort.

> [!NOTE]
> Voordat u een ERP-verbinding bewerkt, moet u deze eerst deactiveren.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Selecteer de ERP-verbinding en klik op de knop **Toewijzingen** onderaan. Het dialoogvenster **Toewijzingen** geeft de tabbladen weer voor de beschikbare actoren in het ERP-systeem.

1. Selecteer het tabblad voor de actor waarvoor u toewijzingen wilt configureren.

1. Vink **Sync ERP \[actor\] met SuperOffice\[entity\]aan**.

1. In de lijst hieronder selecteert u de synchronisatierichting en aan welk SuperOffice-veld elk ERP-veld moet worden toegewezen (moet worden meegesynchroniseerd). U kunt ook kiezen of de velden moeten worden weergegeven en doorzocht op het tabblad **ERP**.
    De lijst bestaat uit de volgende kolommen:

    * **Weergeven in zoekopdracht**: Zet hier een vinkje als dit veld weergegeven moet worden in de zoekresultaten.
    * **ERP-veld**: Geeft de naam weer van het veld in het ERP-systeem.
    * **Richting**: Hier selecteert u de richting(en) voor de synchronisatie. Zie de tabel met pictogrammen hieronder.

    * **SuperOffice-veld**: hier kiest u welk SuperOffice-veld u wilt synchroniseren. Sommige velden (zoals klant- en persoon-ID's) kunnen niet worden gesynchroniseerd; de lijst zal dan leeg zijn.
    * **Weergeven in ERP-tabblad**: dit aanvinken als u wilt dat dit veld wordt weergegeven op het tabblad **ERP** in SuperOffice CRM (Bedrijf, Persoon en Scherm Project).

        > [!NOTE]
        > Als u ervoor hebt gekozen dit veld te synchroniseren met een SuperOffice-veld, is het niet zinvol het veld weer te geven in het tabblad **ERP**.

1. Herhaal de stappen 4 tot en met 6 om veldtoewijzingen te configureren voor andere actors.

1. Klik op **Gereed** om te voltooien. Onder de lijst **ERP-verbindingen** worden alle velden weergegeven die worden gesynchroniseerd voor de verschillende actors.

1. Schakel **Actief** in voor de ERP-verbinding die u hebt bewerkt.

## Betekenis van de pictogrammen

| Pictogram | Uitleg |
|---|---|
| ![pictogram][img1] | Geen synchronisatie (SuperOffice-veld is geselecteerd). Als het veld verplicht is, MOET u een richting kiezen. |
| ![pictogram][img2] | Beide kanten op synchroniseren. |
| ![pictogram][img3] | Synchroniseren van SuperOffice naar het ERP-systeem. |
| ![pictogram][img4] | Synchroniseren van het ERP-systeem naar SuperOffice. |
| ![pictogram][img5] | Geen synchronisatie (SuperOffice-veld is NIET geselecteerd) of het veld kan niet worden gesynchroniseerd (bijvoorbeeld klantnaam). De oorzaak kan ook liggen in alleen-lezen velden. Houd uw muisaanwijzer boven het pictogram om details te bekijken. |

> [!NOTE]
> De pijlen blijven uitgeschakeld totdat u een SuperOffice-veld selecteert.

## Troubleshooting

Als u onjuiste instellingen hebt gedefinieerd voor de veldtoewijzingen, ontvangt u een beschrijvend foutbericht. Dit zou bijvoorbeeld van toepassing zijn op een verplicht veld zonder een synchronisatierichting. U moet de fout corrigeren voordat u de ERP-verbinding kunt activeren.

## Lijstitems toewijzen

Als u lijsten hebt toegewezen (bijvoorbeeld categorie), moet u ook [de afzonderlijke items in elke lijst toewijzen][1].

<!-- Referenced links -->
[1]: sync-configure-list-mapping.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/sync-none.bmp
[img2]: ../../../../../media/icons/admin/sync-2-way.bmp
[img3]: ../../../../../media/icons/admin/sync-to-erp.bmp
[img4]: ../../../../../media/icons/admin/sync-to-so.bmp
[img5]: ../../../../../media/icons/admin/sync-deactivated.bmp
