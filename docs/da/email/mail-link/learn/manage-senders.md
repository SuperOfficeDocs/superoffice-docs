---
uid: help-da-mail-link-senders
title: Administrer afsendere
description: Administrer afsendere
author: SuperOffice RnD
date: 12.11.2024
keywords: Mail Link
topic: howto, sender
language: da
---

# Administrer afsendere

Når du arkiverer en e-mail eller en vedhæftet fil, udfører SuperOffice CRM en søgning for at se, om afsenderen stemmer overens med nogle af de registrerede firmaer eller personer.

## Sådan søges efter afsenderen af en e-mail

Du kan bruge **knappen Søg efter afsender** til at søge efter afsenderens præcise e-mailadresse i din [foretrukne SuperOffice-klient][4].

1. Vælg den e-mail i e-mail-klientindbakken (du kan kun vælge en), hvis afsender du gerne vil søge efter i SuperOffice.

2. Klik på knappen **Søg på afsender**.

3. Det næste, der sker, afhænger af, om afsenderen findes i SuperOffice:
    * Hvis e-mailadressen findes på et firma/en person, åbnes firma-/personkortet i SuperOffice.
    * Hvis e-mailadressen er registreret ved mere en et firma eller en person, vises en dialogboks med en liste med alternativerne, hvor du kan vælge en af dem.
    * Hvis afsenderens e-mailadresse ikke er registreret i SuperOffice, kan du tilføje den.
    * Kun for SuperOffice CRM: Hvis afsenderen af den valgte e-mail er markeret som fratrådt, åbnes firmaet/personen, med afsenderen vises ikke i SuperOffice CRM, medmindre du har valgt at vise tidligere medarbejdere.

## Håndtering af e-mails fra afsendere med flere lister

Hvis afsenderen er oplistet mere end en gang i SuperOffice CRM, vises en dialogboks, som informerer dig om dette og giver mulighed for at vælge den korrekte post.

## Håndter en e-mail fra en afsender, der ikke er angivet i SuperOffice

Hvis afsenderen slet ikke er oplistet i SuperOffice CRM, får du mulighed for at tilføje dennes e-mailadresse til SuperOffice CRM.

1. Gør ét af følgende:
    * [Arkivere e-mailen på firmaer/personer][1]
    * [Arkivere e-mailen som aktivitet][2]
    * [Arkiver vedhæftede filer][3]

2. Hvis afsenderen af e-mailen eller den vedhæftede fil ikke er på listen i SuperOffice CRM, vises der en advarsel i toppen af dialogboksen til arkivering af e-mailen, når du prøver at arkivere: "Afsenderens e-mailadresse er ikke registreret. Klik her for at opdatere SuperOffice med denne adresse". Klik på advarslen.

3. I dialogboksen **Arkiver e-mailadresse** vælger du en af følgende alternativknapper:
    * **Opret ny person**: Klik på denne valgmulighed, hvis du vil [tilføje e-mailadressen til en ny person](#new-contact).
    * **Tilføj e-mailadresse på eksisterende person**: Klik på denne valgmulighed, hvis du vil [tilføje e-mailadressen til en eksisterende person](#existing-contact).

4. Klik på **OK**. Personen og dennes e-mailadresse vises på fanebladet **Personer** på det angivne firmakort.

> [!NOTE]
> Hvis du forsøger at arkivere mere end en e-mail ad gangen, bliver du adspurgt ved hver eneste afsender, der ikke er på listen i SuperOffice CRM.

## <a id="new-contact"></a>Tilføj en e-mailadresse til en ny person

1. Åbn dialogboksen **Arkiver e-mailadresse**.

2. Klik på valgmuligheden **Opret ny person**.

3. I feltet **Firma** skal du vælge det firma, som den nye person skal gemmes i. Du kan søge efter et firma ved at indtaste navnet på firmaet og derefter vælge mellem de forekomster, som vises.

4. Indtast de obligatoriske oplysninger om personen, f.eks. navn, e-mailadresse og telefonnummer.

5. Klik på **OK**. Personen og dennes e-mailadresse vises på fanebladet **Personer** på det angivne firmakort.

## <a id="existing-contact"></a>Tilføj e-mailadresse på eksisterende person

1. Åbn dialogboksen **Arkiver e-mailadresse**.

2. Klik på valgmuligheden **Tilføj e-mailadresse på eksisterende person**.

3. I feltet **Firma** vælger du det firma, som du gerne vil registrere e-mailadressen under. Du kan søge efter et firma ved at indtaste navnet på firmaet og derefter vælge mellem de forekomster, som vises.

4. I feltet **Person** vælger du mellem de personer, der er registreret for det aktive firma.

5. Marker afkrydsningsfeltet **Gør dette til den primære e-mailadresse for denne person**, hvis personen har mere end en e-mailadresse, og hvis du gerne vil have, at denne anvendes som personens standardadresse.

6. Klik på **OK**. Personen og dennes e-mailadresse vises på fanebladet **Personer** på det angivne firmakort.

## Undlade af tilføje en e-mailadresse til SuperOffice

Det er muligt at arkivere en e-mail/vedhæftet fil eller søge efter en afsender uden at tilføje e-mailadressen til SuperOffice CRM.

Hvis du ikke ønsker at tilføje e-mailadressen til SuperOffice CRM, skal du blot undlade at klikke på advarslen i dialogboksen **Gem e-mail**.

<!-- Referenced links -->

[1]: archive-on-contact.md
[2]: archive-as-activity.md
[3]: archive-attachment.md
[4]: settings/superoffice-account.md

<!-- Referenced images -->
