---
uid: help-nl-udef-add
title: Door gebruiker gedefinieerd veld toevoegen
description: Door gebruiker gedefinieerd veld toevoegen
keywords: udef, door gebruikers gedefinieerd, aangepast veld
author: Bergfrid Dias
so.date: 01.30.2024
so.version: 10
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

1. [!include[Ga naar Velden](includes/goto-fields.md)]

1. Klik op de knop **Toevoegen** onder de lijst **Velden**.

1. Voer een **Naam** in en selecteer een [**Type**][2] (bijvoorbeeld nummer, tekst of datum).

1. Stel eventueel andere [veld eigenschappen](#properties) in, zoals of het veld verplicht is of geïndexeerd moet worden.

1. Als u klaar bent, klik op **Opslaan**. Het dialoogvenster sluit en het nieuwe veld wordt weergegeven in de lijst **Velden** en in het raster.

1. [Optioneel, pas de positie van het veld aan][3]. Dit vereist een licentie voor Development Tools!

1. Ga door met het toevoegen van velden. Klik op **Publiceren** als u klaar bent om het veld beschikbaar te maken voor SuperOffice-gebruikers. Niet-gepubliceerde velden ![pictogram][img1] en velden met niet-gepubliceerde wijzigingen ![pictogram][img2] worden vet weergegeven in de lijst **Velden**.

## <a id="properties" />Veld eigenschappen

| Eigenschap | Beschrijving |
|---|---|
| Standaardwaarde | De waarde die standaard in dit veld moet worden ingevuld. |
| Knopinfo | Een korte beschrijving die verschijnt wanneer je met de muis over het veld beweegt. Bijvoorbeeld, gebruiksinformatie. |
| Prog-ID | Een standaard-ID voor dit veld. Het formaat is **tekst:getal**. Behoud het tekstgedeelte voor letters a-z of hun hoofdletterequivalenten. Kan worden overschreven door SuperOffice-partners. |
| Verplicht | Maakt het verplicht om dit veld in te vullen. Geldt niet voor het *Selectievakje*-veldtype. |
| Label verbergen | Als geselecteerd, wordt de naam van het veld niet weergegeven. |
| Alleen lezen | Als geselecteerd, is het niet mogelijk om het veld te wijzigen. |
| Geïndexeerd | Als geselecteerd, wordt dit veld doorzoekbaar en versnelt het **Zoeken**. Niet-geïndexeerde velden zijn ook doorzoekbaar, maar het zoeken duurt langer. U moet alleen velden indexeren die vaak worden gezocht en die veelgebruikte gegevens bevatten. |

> [!NOTE]
> U kunt **Alleen lezen** niet aanvinken als u **Verplicht** hebt aangevinkt. Deze opties sluiten elkaar uit.

## Waar worden de velden die ik maak, weergegeven?

* [Het tabblad Meer (Bedrijf)][16]
* [Het tabblad Meer (Contactpersoon)][17]
* [Het tabblad Meer (Project)][13]
* [Het tabblad Meer (Vervolgactiviteit)][14]
* [Het tabblad Meer (Document)][15]
* [Het tabblad Meer (Verkoop)][19]

> [!TIP]
> In de rechterbenedenhoek van het dialoogvenster **Velden** staat de **Naam sjabloonvariabele** gevolgd door een code (ID), die kan worden gebruikt om de informatie die u in dit veld invoert opnieuw te gebruiken, bijvoorbeeld als [sjabloonvariabelen][12] in documenten en e-mails.

## Troubleshooting

### Ik kan geen nieuw veld maken

als u geen toestemming krijgt om een nieuw veld te maken, kan het zijn dat u reeds het [maximaal toegestane aantal velden][1] van dit type hebt bereikt. U moet in dat geval een bestaand veld verwijderen voordat u een nieuw veld kunt invoegen.

Vier van elk type veld (korte tekst, lange tekst, getal, decimaal) zijn doorzoekbaar. Als u bijvoorbeeld geen doorzoekbare velden markeert, kunt u slechts zes decimale velden opgeven.

## Verwante onderwerpen

* [Velden plaatsen][3]
* [Velden bewerken][4]
* [Schermontwerper][11]

<!-- Referenced links -->
[1]: ../learn/udef.md#limit
[2]: ../learn/udef.md#field-types
[3]: edit-udef-layout.md
[4]: edit-udef.md
[11]: ../../ui/screen-designer/learn/index.md
[12]: ../../document/learn/template-variables.md
[13]: ../../project/learn/index.md#more-tab
[14]: ../../diary/learn/follow-ups.md#more-tab
[15]: ../../document/learn/screen/index.md
[16]: ../../company/learn/create.md#more-tab
[17]: ../../contact/learn/create.md#more-tab
[19]: ../../sale/learn/index.md

<!-- Referenced links -->
[img1]: ../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../media/icons/admin/fields-unpublish-changed.png
