---
uid: help-nl-quote-send
title: Een offerte verzenden
description: Leer hoe u offertes verzendt, goedkeurt en versies beheert in SuperOffice CRM.
keywords: offerte verzenden, offerte goedkeuren, verzonden offerte bewerken, verzenden, publiceren, goedkeuring, offerteversie, tabblad Bijlagen, offerte
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from:
  - /nl/quote/learn/approve
  - /nl/quote/learn/send
  - /nl/quote/learn/versions
---

# Een offerte verzenden

Nadat u producten hebt toegevoegd en een offertedocument hebt gemaakt, kunt u de offerte naar de klant verzenden. De offerte wordt gemarkeerd als **Verzonden** en is niet meer te bewerken.

## Offerte voorbereiden

1. Ga naar het sectietabblad **Offerte** van de verkoop en klik op **Openen** om de offerte te bewerken.

1. Controleer het volgende:

    * Alle verplichte productinformatie is ingevuld.
    * Het offertedocument is aangemaakt.
    * Relevante bijlagen zijn geselecteerd op het tabblad **Bijlagen** (indien vereist).
    * Het juiste alternatief is ingesteld als **favoriet alternatief**.
    * Er zijn geen [waarschuwingen of fouten][4].

> [!NOTE]
> U kunt een offerte niet verzenden als er waarschuwingen, fouten of goedkeuringsvereisten zijn. De knop **Verzenden** is dan uitgeschakeld.

## <a id="approve"></a>Moet de offerte worden goedgekeurd?

Sommige offertes moeten worden goedgekeurd voordat ze verzonden kunnen worden, bijvoorbeeld als de marge te laag is of de korting te hoog. De goedkeuringsregels worden per verkooptype ingesteld in Instellingen en onderhoud (**Lijsten** > **Verkoop - Type, fasen, offerte**).

* Als goedkeuring vereist is, krijgt de offerte de status **Goedkeuring noodzakelijk**
* In het dialoogvenster **Offerte bewerken** verschijnt een banner met waarschuwingsiconen

### Een offerte goedkeuren

1. Een gebruiker met goedkeuringsrechten opent de offerte.

1. Klik op **Goedkeuren** of **Afwijzen**.

1. De status wordt bijgewerkt naar **Goedgekeurd** (<i class="ph ph-check-square" aria-hidden="true"></i>) of **Afgewezen** (<i class="ph ph-x-square" aria-hidden="true"></i>).

## <a id="send"></a>Offerte verzenden

1. Klik in het dialoogvenster **Offerte bewerken** op **Verzenden**.

    Het dialoogvenster **Een offerte publiceren/verzenden** wordt weergegeven.

    ![Dialoogvenster offerte verzenden -screenshot][img1]

2. Pas in het veld **Geldig tot** de vervaldatum aan indien nodig (standaard is 30 dagen).

3. Kies het **offertesjabloon** en de **taal**.

4. Als er alternatieven zijn, kunt u **Alleen favoriet alternatief gebruiken** selecteren om alleen dat op te nemen.

5. In het gedeelte **Publiceren** kiest u hoe de offerte verzonden moet worden:

    * **Verzenden als e-mail en archiveren als PDF** (selecteer een e-mailsjabloon)
    * **Enkel archiveren als PDF** (zelf verzenden vereist)

6. (Optioneel) Selecteer **Vervolgactiviteit aanmaken**, voer een notitie in en kies een datum.

7. Klik op **Voorbeeld** om de offerte als PDF te bekijken.

8. Klik op **OK** om te verzenden en/of archiveren.

    Bij e-mailverzending opent het dialoogvenster **Nieuwe e-mail**.

### Na verzending

* De offerte krijgt de status **Verzonden**
* De huidige versie is vergrendeld
* De status bevat de vervaldatum (*Verzonden (Geldig tot - 03-05-2025)*)
* Het pictogram verandert van <i class="ph ph-pencil-simple" aria-label="Conceptpictogram"></i> naar een envelop (<i class="ph ph-envelope" aria-label="Verzondenpictogram"></i>)
* De PDF wordt gearchiveerd op het tabblad **Activiteiten**

    ![Sectietabblad offerte wanneer offerte is verzonden -screenshot][img2]

## <a id="versions"></a>Een verzonden offerte bewerken

Een verzonden offerte is alleen-lezen. U moet een nieuwe versie maken om deze te bewerken (bijvoorbeeld in antwoord op een verzoek van een klant).

1. Klik op **Openen** op het tabblad **Offerte**.
2. Klik in het dialoogvenster **Offerte bewerken** op **Bewerken**.
3. Er wordt een nieuwe versie gemaakt met de status **Concept**. De vorige versie wordt gearchiveerd (<i class="ph ph-folder-simple" aria-hidden="true"></i>).

Gebruik het keuzemenu **Versie** bovenaan om tussen versies te schakelen.

> [!TIP]
> Wijzigingen in de nieuwe versie hebben geen invloed op het origineel. U moet de nieuwe versie verzenden zodra deze klaar is.

## Gerelateerde inhoud

* [Een offertedocument maken][1]
* [Offertedocument vervangen][2]
* [Een order plaatsen][3]
* [Goedkeuringsregels configureren][5] in Instellingen en onderhoud

<!-- Referenced links -->
[1]: create-quote-document.md
[2]: create-quote-document.md#replace
[3]: place-order.md
[4]: create.md#warning
[5]: ../../admin/sale-type.md#quote-fields

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/send-quote-dialog.png
[img2]: ../../../../media/loc/en/sale/sent-quote.png
