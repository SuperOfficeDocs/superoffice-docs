---
uid: help-da-mailing-add-unsubscribe-link
title: Tilføje et afmeldingslink
description: "Når du sender en mail ud, er det nødvendigt at give modtagerne mulighed for at afmelde sig. Få mere at vide om, hvordan du kan føje et afmeldingslink til din udsendelse, i denne vejledning."
author: SuperOffice RnD
so.date: 02.16.2023
keywords: marketing
so.topic: howto
language: da
---

# Tilføje abonnement-links

Når du for eksempel udsender et nyhedsbrev, skal du give modtagerne mulighed for at framelde sig eller ændre indstillingerne for deres abonnement. Det kan gøres ved at tilføje et link, som modtagerne kan klikke på. Denne type links anbringes normalt i bunden af en meddelelse (i sidefoden).

Afmeldingslinket placeres normalt i bunden af en meddelelse. Hvis du bruger en af vores mailskabeloner, er linket allerede tilføjet.

Du bestemmer, hvor afmeldingslinket vises, hvilken formulering, der anvendes og hvad der sker, når man klikker på linket. For eksempel kan du ganske enkelt føre seeren til deres "afmeldings"-side, hvor de kan administrere deres præferencer, eller de kan automatisk fravælge alle dine udsendelser.

![Fra symbolet Indsæt/rediger link skal du klikke på Særlige links og tilføje dit afmeldingslink -screenshot][img4]

## I redigeringsværktøjet træk og slip

1. Gå til indholdet af meddelelsen, og klik på det afsnit, hvor du vil indsætte linket.
    eller
    Gå til afsnittet **Blokke**, og klik på og træk en sidefod til bunden af meddelelsen.

2. Indtast og vælg den tekst, som modtageren skal klikke på, f.eks. "Klik her for at afmelde dig" eller "Klik her for at administrere dine abonnementer".

3. Klik på knappen **Indsæt/rediger link**(![ikon][img3]) på værktøjslinjen.

4. Klik på **Særlige link**, og vælg en af følgende indstillinger:
    * **Administrer abonnementer**: Indsætter et link til en webside, hvor modtagerne kan vælge hvilke udsendelsestyper, de vil modtage. Linket er som standard gyldigt i 21 dage.
    * **Afmeld denne type udsendelse**: Indsætter et link til at framelde denne udsendelsestype. Modtageren vil stadig modtage udsendelser af andre typer. Udsendelsestypen vælges i trin 1: Opsætning.

5. Klik på **Gem**. Linket sættes ind i meddelelsen.

## I det gamle redigeringsværktøj

1. Gå til meddelelsens indhold, og [Rediger afsnit][1] for at åbne redigeringsvisningen.
    Klik eventuelt på ![ikon][img1] knappen **Tilføj afsnit** for at tilføje et afsnit nederst.
2. Vælg fanen **Brødtekst**.
3. Anbring musemarkøren dér, hvor du vil indsætte linket.
4. Klik på knappen ![ikon][img2]**Tilmeldingslink** på værktøjslinjen.
5. Hvis nødvendigt, kan du ændre teksten i feltet **Linketikette** i dialogboksen **Tilføj abonnementslink**til f.eks. "Klik her, hvis du ønsker at framelde dig mailudsendelser" eller "Klik her for at administrere dine abonnementer".
6. I feltet **Indsæt fra/tilmeldingslink** skal du vælge én blandt følgende valgmuligheder:
    * **Administrer abonnementer**: Indsætter et link til en webside, hvor modtagerne kan vælge hvilke udsendelsestyper, de vil modtage. Linket er som standard gyldigt i 21 dage.
    * **Afmeld denne type udsendelse**: Indsætter et link til at framelde denne udsendelsestype. Modtageren vil stadig modtage udsendelser af andre typer. Udsendelsestypen vælges i trin 1: Opsætning.
7. Klik på **OK**. Linket sættes ind i meddelelsen.

## Hvad sker der så nu?

Baseret på feedback fra modtagerne opdateres abonnementsindstillingerne på fanen **Interesser** på kontaktkortet i SuperOffice CRM..

> [!NOTE]
> Det betyder, at kunden ikke længere modtager denne type udsendelse fra SuperOffice Marketing, uanset hvilken modtagerliste der anvendes til udsendelsen. Det er ikke nødvendigvis det, du ønsker i forbindelse med fortsatte markedsføring. [Hvad er mine alternativer?][2]
>
> Du har dog mulighed for at tilsidesætte indstillingerne "intet samtykke / intet abonnement" fra **Indstillinger** i den nederste del af skærmen **Modtagere** (se trin 4: Modtagere).

## <a id="clear-interests" />Nulstille interesser i SuperOffice CRM

I SuperOffice CRM kan du registrere interesser (f.eks. "månedligt nyhedsbrev") for dine kontakter. Disse interesser kan bruges som grundlag for forskellige typer af udsendelser. I stedet for at bruge afmelding kan du nemt fjerne en bestemt interesse, f.eks. et månedligt nyhedsbrev, fra de kunder, der ikke ønsker at modtage det.

Det gør du ved at [oprette et link, der fjerner den relevante interesse][4] hos de modtagere, der klikker på linket. Den samme metode kan bruges til at registrere interesser.

<!-- Referenced links -->
[1]: ../../../learn/edit-paragraph.md
[2]: ../../../tracked-links/learn/examples.md
[4]: ../../../tracked-links/learn/define-link-actions.md#interests

<!-- Referenced images -->
[img3]: ../../../../../media/icons/marketing-and-forms/link.png
[img1]: ../../../../../media/icons/marketing-and-forms/new-para.jpg
[img2]: ../../../../../media/icons/marketing-and-forms/link.png
[img4]: media/insert-edit-link-unsubscribe-mailing.png
