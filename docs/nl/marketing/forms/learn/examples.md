---
uid: help-nl-forms-examples
title: Formulieren maken (voorbeelden)
description: Formulieren maken (voorbeelden)
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formulieren
so.topic: concept
language: nl
---

# Formulieren maken (voorbeelden)

Laten we eens kijken naar twee aangepaste formulieren die relevant kunnen zijn voor uw bedrijf:

* [Aanmelden nieuwsbrief](#newsletter-sign-up): Laat uw klanten zich aanmelden voor een of meer van uw nieuwsbrieven.
* [Neem contact met mij op](#contact-me): Gebruik een "neem contact met mij op"-formulier om een ander communicatiekanaal te openen met uw klanten of prospects. Gebruik dit formulier om ondersteuningsaanvragen of leads te genereren voor uw verkoopteam.

De voorbeelden dekken niet elk veld en elke optie, maar u kunt uitgebreide instructies vinden in [Een nieuw formulier maken][1].

## Wat is dubbele opt-in?

Met dubbele opt-in moeten de klanten hun e-mailadres verifiëren door op de link in een bevestigingsmail te klikken naast het indienen van het formulier.

Deze optie voegt een extra beveiligingslaag toe aan het formulier. Als u deze optie activeert, moet de persoon die het formulier verzendt, ook zijn/haar e-mailadres bevestigen. Dit gebeurt door een e-mail te verzenden naar de persoon wanneer het formulier wordt verzonden. De e-mail bevat een koppeling waarop moet worden geklikt om te bevestigen dat het e-mailadres correct is.
de koppeling is standaard 30 minuten geldig.

## <a id="newsletter-sign-up" />Aanmelden nieuwsbrief

Via dit formulier kunnen uw klanten zich aanmelden voor een of meer nieuwsbrieven. Het aanmeldingsproces omvat ook dubbele opt-in om foutieve of nepabonnementen te elimineren.

1. Open SuperOffice CRM en maak een statische selectie van bedrijven/personen genaamd "Nieuwsbriefabonnees (formulier)". We zullen deze selectie later in deze handleiding gebruiken.

1. Open SuperOffice Marketing en ga naar tabblad **Formulieren**.

1. Selecteer **Formulier** onder **Nieuw maken** aan de rechterkant van het scherm. Het scherm **Formulier bewerken** wordt geopend.

1. Geef "Aanmelden nieuwsbrief" op in het veld **Naam formulier**.

1. Vul de relevante opties/velden in de categorie **Eigenschappen** in. Activeer GEEN opties onder **Formulier automatisch deactiveren**.

1. Klik op **Nu toepassen** om het formulier op te slaan en door te gaan met bewerken.

1. Klik in de categorie **Velden** op ![pictogram][img1] en voeg de volgende velden toe:

    * Voor-en achternaam (verwijder het veld **Persoon - naam**)
    * **Persoon - e-mail** (maak dit veld verplicht)
    * Persoon - abonnement
        * Selecteer een of meer nieuwsbrieven die beschikbaar moeten zijn
        * Stel het veld in op **Verplicht**.
        * Wijzig de naam van het veld in "Uw abonnementen selecteren".

1. Selecteer het veld **OK**, wijzig de naam in "Verzenden" en bewerk lettertype/achtergrondkleur en positie.

1. Bewerk desgewenst de namen van de andere velden. **Tip**: Verwijder "Persoon -".

1. Klik ![pictogram][img2] boven aan een veld en sleep het naar de gewenste positie in het formulier. De velden moeten een logische volgorde hebben.

1. Klik op **Nu toepassen** om het formulier op te slaan en door te gaan met bewerken.

1. Bewerk in de categorie **Stijl** de opmaak, kleuren, grootte en lettertypen van het formulier. Overweeg om uw webontwerpcollega's erbij te betrekken.

1. Klik op **Nu toepassen** om het formulier op te slaan en door te gaan met bewerken.

1. Selecteer in de categorie **Dubbele opt-in** **Dubbele opt-in inschakelen**.

1. Voer in het tabblad **Bericht** de tekst in die moet worden weergegeven nadat het formulier is ingediend. Dit bericht dient de klant te informeren dat hij/zij een e-mailbevestiging zal ontvangen. Klik op **Werkbalk weergeven/verbergen** ![pictogram][img3] om opmaaktopties voor de tekst weer te geven.

    <details><summary>Voorbeeld</summary>

    We verzenden nu een e-mail naar het adres dat u in ons formulier hebt geregistreerd.

    Klik op de koppeling in de e-mail om uw e-mailadres te bevestigen en uw abonnement(en) te activeren.

    Met vriendelijke groet,

    SuperShop
    </details>

1. Maak in het tabblad **E-mail** de bevestigings-e-mail die wordt verzonden naar personen die het formulier verzenden.

    <details><summary>Voorbeeld</summary>

    Hallo en bedankt voor uw interesse in onze nieuwsbrieven

    Klik op de koppeling hieronder om uw e-mailadres te bevestigen en uw abonnement te starten.

    Klik hier om uw e-mailadres te bevestigen

    Met vriendelijke groet,

    Het SuperShop-team
    </details>

1. Klik op **Werkbalk weergeven/verbergen** ![pictogram][img3] en vervolgens op **Bevestigingskoppeling invoegen** ![pictogram][img4]. De bevestigingskoppeling wordt in de hoofdtekst ingevoegd.

1. Klik op de bevestigingskoppeling, selecteer **Koppeling bewerken** (![pictogram][img5]) en wijzig de koppelingstekst in "Klik hier om uw e-mailadres te bevestigen". de koppeling is standaard 30 minuten geldig.

1. Klik op **Nu toepassen** om het formulier op te slaan en door te gaan met bewerken.

1. In de categorie **Pagina Bedankt** kunt u de klant omleiden naar een webpagina of een bericht weergeven (zoals "Hartelijk dank voor uw abonnement"). Dit wordt weergegeven nadat de klant zijn e-mailadres controleert.

1. Klik op **Nu toepassen** om het formulier op te slaan en door te gaan met bewerken.

1. Voer in de categorie **Pagina voor inactief formulier** een URL of een bericht in. Dit is relevant als een klant het formulier opent nadat het is ingesteld op inactief.

1. Klik op **Nu toepassen** om het formulier op te slaan en door te gaan met bewerken.

1. In de categorie **Acties** moet u de acties instellen die moeten worden uitgevoerd wanneer het formulier wordt verwerkt:

    * Selecteer **Verzoek maken** niet. De abonnementen worden automatisch geactiveerd, zodat het supportteam geen actie hoeft te ondernemen.

    * Selecteer **Handmatig als indiener onbekend is. Automatisch als indiener bekend is**: Als het e-mailadres dat is verzonden in het formulier, overeenkomt met een e-mailadres in SuperOffice, wordt de formulierverzending automatisch verwerkt. Anders wordt deze handmatig verwerkt.

    * **Persoon toevoegen aan selectie**: Selecteer de selectie die u in stap 1 hebt gemaakt. Gebruik deze selectie om personen bij te houden die via dit formulier zijn toegevoegd.

    * **Interesses toevoegen aan persoon**: Selecteer de interesse genaamd **Nieuwsbrief**. Deze interesse wordt toegevoegd aan personen die dit formulier verzenden.

    * **E-mailantwoord**: Selecteer een formulierantwoord om te verzenden naar personen wanneer hun formulier is verwerkt. Deze e-mail kan de klant bijvoorbeeld informeren over het privacybeleid van uw bedrijf en kan ook een koppeling bevatten om abonnementen te beheren. [Een formulierantwoord maken][2].

1. Klik op **Opslaan**. Het formulier wordt opgeslagen en het scherm **Formulier bewerken** wordt gesloten.

1. Stel het formulier in als **Actief** ![pictogram][img6] in de koptekst.

1. Ga naar het tabblad **Publiceren**.

1. Kopieer de directe koppeling en/of JavaScript in een nieuwsbrief, website of Customer Centre om het formulier te publiceren voor uw klanten of prospects.

1. Open de koppeling naar het formulier, vul het formulier in en controleer of alles werkt zoals verwacht.

## <a id="contact-me" />Neem contact met mij op

Zet een "neem contact met mij op"-formulier op de webpagina's van uw bedrijf om een gemakkelijk communicatiekanaal te bieden voor bestaande of potentiële klanten.

In dit voorbeeld laten we zien hoe u een kort formulier kunt maken voor klanten die in contact willen komen met een supportmedewerker. De formulierverzending zal leiden tot een nieuwe aanvraag voor uw supportafdeling.

1. Open SuperOffice Marketing en ga naar tabblad **Formulieren**.

1. Selecteer **Formulier** onder **Nieuw maken** aan de rechterkant van het scherm. Het scherm **Formulier bewerken** wordt geopend.

1. Geef "Contact met mij opnemen (support)" op in het veld **Formuliernaam**.

1. Vul de relevante opties/velden in de categorie **Eigenschappen** in. Activeer GEEN opties onder **Formulier automatisch deactiveren**.

1. Klik in de categorie **Velden** op ![pictogram][img1] en voeg de volgende velden toe:

    * Voor- en achternaam. Verwijder het veld **Persoon - naam**.
    * **Elementen weergeven** &gt; **Tekstblok**: Geef de tekst in vet op in "Hoe kunnen we contact met u opnemen?".
    * **Persoon - mobiel**: Voer een voorbeeld in van een correct opgemaakt telefoonnummer voor uw land (inclusief de landcode) in het veld **Tijdelijke aanduiding** (bijvoorbeeld: +47 999 88 777).
    * **Persoon - E-mail**
    * **Formulierelementen** &gt; **Tekstgebied**: Wijzig de naam van het veld in "Opmerking (optioneel)" en schrijf "Hoe kunnen we u vandaag helpen?" in het veld **Tijdelijke aanduiding**.

1. Selecteer het veld **OK**, wijzig de naam in "Verzenden" en bewerk lettertype/achtergrondkleur en positie.

1. Bewerk desgewenst de namen van de andere velden. **Tip**: Verwijder "Persoon -".

1. Klik ![pictogram][img2] boven aan een veld en sleep het naar de gewenste positie in het formulier. De velden moeten een logische volgorde hebben.

1. Klik op **Nu toepassen** om het formulier op te slaan en door te gaan met bewerken.

1. Bewerk in de categorie **Stijl** de opmaak, kleuren, grootte en lettertypen van het formulier. Overweeg om uw webontwerpcollega's erbij te betrekken.

1. Klik op **Nu toepassen** om het formulier op te slaan en door te gaan met bewerken.

1. Optioneel: Als u dubbele opt-in wilt inschakelen, moet u ook het veld **E-mail** instellen op **Verplicht**.

1. In de categorie **Pagina Bedankt** kunt u de klant omleiden naar een webpagina of een bericht weergeven (zoals "Fijn dat u contact met ons hebt opgenomen. U hoort zo snel mogelijk van ons."). Dit wordt weergegeven nadat de klant het formulier verzendt.

1. Voer in de categorie **Pagina voor inactief formulier** een URL of een bericht in. Dit is relevant als een klant het formulier opent nadat het is gemarkeerd als inactief.

1. In de categorie **Acties** moet u de acties instellen die moeten worden uitgevoerd wanneer het formulier wordt verwerkt:

    * Selecteer **Verzoek maken** en doe het volgende:
        1. Voer een beschrijvende titel in voor de verzoeken die vanuit dit formulier worden gegenereerd.
        2. Selecteer de relevante verzoekcategorie, bijvoorbeeld "Support" of een subcategorie genaamd "Formulierverzendingen".
        3. Stel de verzoekprioriteit in op **Gemiddeld**.

    * Selecteer **Handmatig als indiener onbekend is. Automatisch als indiener bekend is**: Als het e-mailadres dat is verzonden in het formulier, overeenkomt met een e-mailadres in SuperOffice, wordt de formulierverzending automatisch verwerkt. Anders wordt deze handmatig verwerkt.

    * **E-mailantwoord**: Selecteer een formulierantwoord om te verzenden naar personen wanneer hun formulier is verwerkt. Deze e-mail kan de klant bijvoorbeeld informeren over het privacybeleid van uw bedrijf en kan ook een koppeling bevatten om abonnementen te beheren. [Een formulierantwoord maken][2].

1. Klik op **Opslaan**. Het formulier wordt opgeslagen en het scherm **Formulier bewerken** wordt gesloten.

1. Stel het formulier in als **Actief** ![pictogram][img6] in de koptekst.

1. Ga naar het tabblad **Publiceren**.

1. Kopieer de directe koppeling en/of JavaScript in een nieuwsbrief, website of Customer Centre om het formulier te publiceren voor uw klanten of prospects.

1. Open de koppeling naar het formulier, vul het formulier in en controleer of alles werkt zoals verwacht.

## Wat gebeurt er nu?

* [Formulierverzendingen][3]
* [Formulierverzendingen traceren en statistieken weergeven][4]
* [Formulierverzendingen verwerken][5]

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[3]: submissions/index.md
[4]: submissions/track.md
[5]: submissions/process.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/marketing-and-forms/add-field.png
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img3]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img4]: ../../../../../common/icons/new-window-icon.png
[img5]: ../../../../../common/icons/edit-black.png
[img6]: ../../../../media/icons/marketing-and-forms/form-active.png
