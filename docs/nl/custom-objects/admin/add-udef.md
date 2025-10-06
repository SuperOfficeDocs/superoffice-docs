---
uid: help-nl-udef-add
title: Door gebruiker gedefinieerd veld toevoegen
description: Door gebruiker gedefinieerd veld toevoegen
keywords: udef, door gebruikers gedefinieerd, aangepast veld
author: Bergfrid Dias
date: 09.06.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/custom-objects/learn/udef/add
index: true
---

# Door gebruiker gedefinieerd veld toevoegen

Bekijk deze video om erachter te komen hoe u uw eigen extra velden kunt maken in SuperOffice CRM (videolengte - 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Stappen

1. [!include[Ga naar Velden](includes/goto-fields.md)]

1. Klik op de knop **Toevoegen** onder de lijst **Velden**.

1. Voer een **Naam** in en selecteer een [**Type**][2] (bijvoorbeeld nummer, tekst of datum).

    Gebruik een [taalprefix](#language) om de naam in meerdere talen op te geven zoals dit: `US:"Language";NO:"Språk"`

    ![UDEF-veldnaam in meerdere talen -screenshot][img3]

1. Stel eventueel andere [veld eigenschappen](#properties) in, zoals of het veld verplicht is of geïndexeerd moet worden.

1. Als u klaar bent, klik op **Opslaan**. Het dialoogvenster sluit en het nieuwe veld wordt weergegeven in de lijst **Velden** en in het raster.

1. [Optioneel, pas de positie van het veld aan][3]. Dit vereist een licentie voor Development Tools!

1. Ga door met het toevoegen van velden. Klik op **Publiceren** als u klaar bent om het veld beschikbaar te maken voor SuperOffice-gebruikers. Niet-gepubliceerde velden  en velden met niet-gepubliceerde wijzigingen worden vet weergegeven in de lijst **Velden**.

## <a id="properties"></a>Veld eigenschappen

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

## <a id="language"></a>Taalcodes

[!include[Taalcodes](../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Waar worden de velden die ik maak, weergegeven?

De door u gemaakte aangepaste velden verschijnen in het [Meer-tabblad][5] voor Bedrijven, Personen, Verkopen en Projecten, evenals in de Vervolgactiviteit- en Documentdialogen.

In de rechterbenedenhoek van het dialoogvenster **Velden** staat de **Naam sjabloonvariabele** gevolgd door een code (ID), die kan worden gebruikt om de informatie die u in dit veld invoert opnieuw te gebruiken, bijvoorbeeld als [sjabloonvariabelen][12] in documenten en e-mails.

## Troubleshooting

### Ik kan geen nieuw veld maken

als u geen toestemming krijgt om een nieuw veld te maken, kan het zijn dat u reeds het [maximaal toegestane aantal velden][1] van dit type hebt bereikt. U moet in dat geval een bestaand veld verwijderen voordat u een nieuw veld kunt invoegen.

Vier van elk type veld (korte tekst, lange tekst, getal, decimaal) zijn doorzoekbaar. Als u bijvoorbeeld geen doorzoekbare velden markeert, kunt u slechts zes decimale velden opgeven.

## Gerelateerde inhoud

* [Velden plaatsen][3]
* [Velden bewerken][4]
* [Schermontwerper][11]

<!-- Referenced links -->
[1]: ../learn/udef.md#limit
[2]: ../learn/udef.md#field-types
[3]: edit-udef-layout.md
[4]: edit-udef.md
[5]: ../learn/more-tab.md
[11]: ../../customization/screen-designer/admin/index.md
[12]: ../../document/templates/learn/template-variables.md

<!-- Referenced links -->
[img3]: ../../../media/loc/en/custom-objects/add-udef-multi-languages.png
