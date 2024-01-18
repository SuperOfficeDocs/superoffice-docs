---
uid: help-nl-udef-add
title: Velden toevoegen
description: Velden toevoegen
author: Bergfrid Dias
so.date: 01.16.2024
keywords: udef, door gebruikers gedefinieerd, aangepast veld
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# Door gebruiker gedefinieerd veld toevoegen

Bekijk deze video om erachter te komen hoe u uw eigen extra velden kunt maken in SuperOffice CRM (videolengte - 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Stappen

1. [!include[Go to fields and select tab](../includes/goto-fields.md)]

1. Klik op de knop **Toevoegen** onder de lijst **Velden**.

1. Typ de gewenste naam in het veld **Naam**.

1. Selecteer in de keuzelijst **Type** het [type veld][6] dat u wilt toevoegen (bijvoorbeeld nummer, tekst of datum).

1. Voer in het veld **Standaardwaarde** de waarde in die standaard moet zijn ingevuld in dit veld.

1. Typ in het veld **Knopinfo** een korte beschrijving die wordt weergegeven als u de muisaanwijzer boven het veld houdt. Dit kan een beschrijving zijn met informatie voor de gebruikers die dit veld zullen gebruiken.

1. Het veld **Prog-ID** bevat een standaard-ID voor dit veld. De prog-ID kan door onze partners worden overschreven om een betere verbinding te realiseren voor de partnertoepassingen. In plaats van de wijziging van hun code kunnen ze ook een logischer naam of een specifieke ID voor door gebruiker gedefinieerde velden (UDEF) invoeren.

1. Schakel **Verplicht** in als u wilt dat dit een verplicht veld is.

    > [!NOTE]
    > dit geldt niet voor het veldtype **Selectievakje**.

1. Schakel **Label verbergen** in als u niet wilt dat de naam van het veld wordt weergegeven.

1. Schakel **Alleen lezen** in als u niet wilt dat gegevens in het veld kunnen worden ingevoerd of gewijzigd.

    > [!NOTE]
    > U kunt **alleen-lezen** niet inschakelen als u **Verplicht** hebt aangevinkt. U kunt slechts een van beide opties tegelijk inschakelen.

1. Schakel **Geïndexeerd** in als u wilt dat op dit veld kan worden gezocht.

1. Klik op **Opslaan** als u alle benodigde instellingen hebt opgegeven. Het dialoogvenster wordt gesloten en het nieuwe veld wordt weergegeven in de lijst **Velden** en in het raster.

    > [!TIP]
    > In de rechterbenedenhoek van het dialoogvenster **Velden** staat de **Naam sjabloonvariabele** gevolgd door een code (ID), die kan worden gebruikt om de informatie die u in dit veld invoert opnieuw te gebruiken, bijvoorbeeld als [sjabloonvariabelen][2] in documenten en e-mails.

1. [De positie van het veld aanpassen][3].

1. Klik op **Publiceren** als u de wijzigingen beschikbaar wilt maken voor SuperOffice CRM-gebruikers. Niet-gepubliceerde velden (![pictogram][img1]) en velden met niet-gepubliceerde wijzigingen ![pictogram][img2] worden in vette tekst weergeven in de lijst **Velden**.

## Wanneer is het verstandig om een index te maken?

Als u **Geïndexeerd** kiest, kunt u sneller op deze velden zoeken met **Zoeken**. Niet-geïndexeerde velden zijn ook doorzoekbaar, maar het zoeken duurt langer. U moet alleen velden indexeren die vaak worden gezocht en die veelgebruikte gegevens bevatten.

## Troubleshooting

### Ik kan geen nieuw veld maken

als u geen toestemming krijgt om een nieuw veld te maken, kan het zijn dat u reeds het [maximaal toegestane aantal velden][1] van dit type hebt bereikt. U moet in dat geval een bestaand veld verwijderen voordat u een nieuw veld kunt invoegen.

Vier van elk type veld (korte tekst, lange tekst, getal, decimaal) zijn doorzoekbaar. Als u bijvoorbeeld geen doorzoekbare velden markeert, kunt u slechts zes decimale velden opgeven.

## Verwante onderwerpen

* [Velden plaatsen][3]
* [Velden bewerken][4]
* [De tabvolgorde van velden bewerken][5]
* [Maximumaantal velden][1]
* [Schermontwerper][7]

<!-- Referenced links -->
[1]: limitations.md
[2]: ../../document/learn/template-variables.md
[3]: move.md
[4]: edit.md
[5]: change-tab-order.md
[6]: index.md#field-types
[7]: ../../ui/screen-designer/learn/index.md

<!-- Referenced links -->
[img1]: ../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../media/icons/admin/fields-unpublish-changed.png
