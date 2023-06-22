---
uid: help-nl-form-prefilled
title: Vooraf ingevulde velden in formulieren gebruiken
description: Vooraf ingevulde velden in formulieren gebruiken
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formulieren
so.topic: howto
language: nl
---

# Vooraf ingevulde velden in formulieren gebruiken

Om uw klanten de tijd en moeite te besparen van het invullen van hun naam, e-mailadres, telefoonnummer, enzovoort, in formulieren, kunt u veld-ID's en sjabloonvariabelen toevoegen aan de formulierkoppelingen/URL's. Wanneer de klant een formulier opent, worden bestaande klantgegevens ingevuld met SuperOffice-gegevens.

1. [Een nieuw formulier maken][1].

2. Voor elk veld dat u vooraf wilt invullen: Klik op **Geavanceerde opties** ![pictogram][img1] om het veld **ID** weer te geven, waarin u een ID kunt toevoegen voor het veld. Dit is een unieke ID voor dit veld en zal niet wijzigen, zelfs niet als de naam/het label van het veld of de talen wijzigen. Op deze manier kunt u ervoor zorgen dat koppelingen naar dit veld niet worden verbroken na publicatie van het formulier.

3. [Formulieren publiceren][2].

4. Selecteer **Weergeven met vooraf ingevulde velden** om veld-ID's toe te voegen aan de koppeling/JavaScript.
    Het moet er ongeveer zo uitzien:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

5. Kopieer de koppeling of JavaScript naar een teksteditor of iets dergelijks.

6. Voer de relevante [sjabloonvariabelen][3] in tussen de twee vierkante haakjes NA het gelijkheidsteken:
    ```text
    ...formId=F-FH2K4Vru&field-name-1=\[\[customer.name\]\]&field-mail=\[\[customer.email\]\]
    ```

7. Kopieer de volledige koppeling of JavaScript en publiceer deze.

<!-- Referenced links -->
[1]: create.md
[2]: publish.md
[3]: ../../../request/reply-templates/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/cog-wheel.png
